using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Objects;
using System.Text;
using System.Configuration;
using PicControllerMain.ParamsEntity;
using Rock.Data.DataAccess;

namespace PicControllerMain
{
    public class DataController
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["PicStoreEntities1"].ToString();
        private PicStoreEntities1 _picStormContent;
        public DataController()
        {
            _picStormContent = new PicStoreEntities1();
        }

        #region 自定义字段操作
        /// <summary>
        /// 获取字段类型列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CustomFieldType> GetCustomFieldTypeList()
        {
            var list = _picStormContent.CustomFieldType.Where<CustomFieldType>(d => 1 == 1).ToList();
            return list;
        }

        /// <summary>
        /// 新建自定义字段
        /// </summary>
        /// <param name="tableID"></param>
        /// <param name="fieldName"></param>
        /// <param name="fieldType"></param>
        /// <returns></returns>
        public int SaveCustomField(int tableID, string fieldName, int fieldType, bool isPrint, List<string> itemList = null)
        {
            //检查是否此tableID下的此名字的字段已存在
            if (_picStormContent.CustomField.Where(d => d.CustomFieldName == fieldName && d.TableIndex == tableID).ToArray().Length > 0)
            {
                return 0;
            }
            CustomField cf = new CustomField()
            {
                CustomFieldName = fieldName,
                TableIndex = tableID,
                CustomFieldTypeID = fieldType,
                EnteredDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                IsAlive = true,
                CustomFieldDefaultValue = string.Empty,
                IsPrint = isPrint
            };
            _picStormContent.CustomField.Add(cf);
            if (_picStormContent.SaveChanges() == 1)
            {
                if (itemList != null)
                {
                    foreach (var item in itemList)
                    {
                        CustomFieldDataList cflist = new CustomFieldDataList();
                        cflist.CustomFieldItemName = item;
                        cflist.CustomFieldID = cf.CustomFieldID;
                        _picStormContent.CustomFieldDataList.Add(cflist);
                    }
                    _picStormContent.SaveChanges();
                }
            }

            return cf.CustomFieldID;
        }

        /// <summary>
        /// 根据分类获取已创建的自定义字段
        /// </summary>
        /// <param name="type">字段所属分类0:所有，1：Customer客户表，2：Order订单表</param>
        /// <returns></returns>
        public IEnumerable<CustomField> GetCustomFieldList(int type = 0)
        {
            List<CustomField> list;
            if (type != 0)
            {
                list = _picStormContent.CustomField.Where<CustomField>(d => d.TableIndex == type).ToList();
            }
            else
            {
                list = _picStormContent.CustomField.Where<CustomField>(d => 1 == 1).ToList();
            }
            return list;
        }

        /// <summary>
        /// 获取允许打印的自定义字段集合
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CustomField> GetPrintCustomFieldList()
        {
            List<CustomField> list = _picStormContent.CustomField.Where<CustomField>(d => d.IsPrint == true).ToList();
            return list;
        }
        #endregion

        #region 订单操作

        public Order FindOrder(int id)
        {
            return _picStormContent.Order.Find(id);
        }

        /// <summary>
        /// 获取订单集合
        /// </summary>
        /// <param name="pEntity">查询参数对象</param>o
        /// <returns></returns>
        public IQueryable LoadOrderList(OrderSearchParams pEntity)
        {
            var list = from o in _picStormContent.Order
                       join c in _picStormContent.Customer on o.CustomerID equals c.CustomerID
                       select new
                       {
                           o.OrderID,
                           c.CustomerName,
                           c.CustomerPhone,
                           o.EnteredDate,
                           o.Status,
                           o.FinishDate
                       };
            if (!string.IsNullOrEmpty(pEntity.ParamsCustomerName))
            {
                list = list.Where(d => d.CustomerName.Contains(pEntity.ParamsCustomerName));
            }
            if (!string.IsNullOrEmpty(pEntity.ParamsPhone))
            {
                list = list.Where(d => d.CustomerPhone.Contains(pEntity.ParamsPhone));
            }
            if (!string.IsNullOrEmpty(pEntity.ParamsOrderStatus))
            {
                list = list.Where(d => d.Status.Equals(pEntity.ParamsOrderStatus, StringComparison.CurrentCultureIgnoreCase));
            }
            return list;

        }

        /// <summary>
        /// 订单创建页面查询客户信息集合
        /// </summary>
        /// <param name="pEntity"></param>
        /// <returns></returns>
        public List<Customer> LoadCustomerList(OrderCustomerSearchParams pEntity)
        {
            var list = _picStormContent.Customer.Where(d => d.CustomerName.Contains(pEntity.ParamsString)
            || d.CustomerPhone.Contains(pEntity.ParamsString)
            || d.Address.Contains(pEntity.ParamsString)
            || d.WeiXin.Contains(pEntity.ParamsString)
            || d.QQ.Contains(pEntity.ParamsString)
            || d.Email.Contains(pEntity.ParamsString)).ToList();
            return list;
        }

        /// <summary>
        /// 保存订单信息
        /// </summary>
        /// <param name="entity">订单实体</param>
        /// <returns></returns>
        public int SaveOrder(Order entity)
        {
            entity.EnteredDate = DateTime.Now;
            entity.UpdateDate = DateTime.Now;
            _picStormContent.Order.Add(entity);
            _picStormContent.SaveChanges();
            return entity.OrderID;
        }

        public void UpdateOrder(Order entity)
        {
            Order order = new Order();
            order = _picStormContent.Order.FirstOrDefault(d => d.OrderID == entity.OrderID);
            order.TotalAmount = entity.TotalAmount;
            order.AdvanceAmount = entity.AdvanceAmount;
            order.CustomerID = entity.CustomerID;
            order.Status = entity.Status;
            order.Comment = entity.Comment;
            order.UpdateDate = DateTime.Now;
            order.FinishDate = entity.FinishDate;
            _picStormContent.SaveChanges();
        }
        #endregion

        #region 客户操作

        /// <summary>
        /// 获取客户集合
        /// </summary>
        /// <param name="pEntity"></param>
        /// <returns></returns>
        public IQueryable LoadCustomerList(CustomerSearchParams pEntity)
        {
            var list = from c in _picStormContent.Customer
                       select new
                       {
                           c.CustomerID,
                           c.CustomerName,
                           c.CustomerPhone,
                           c.Address,
                           c.EnteredDate
                       };
            if (!string.IsNullOrEmpty(pEntity.ParamsCustomerName))
            {
                list = list.Where(d => d.CustomerName.Contains(pEntity.ParamsCustomerName));
            }
            if (!string.IsNullOrEmpty(pEntity.ParamsPhone))
            {
                list = list.Where(d => d.CustomerPhone.Contains(pEntity.ParamsPhone));
            }
            if (!string.IsNullOrEmpty(pEntity.ParamsAddress))
            {
                list = list.Where(d => d.Address.Contains(pEntity.ParamsAddress));
            }
            return list;
        }

        /// <summary>
        /// 查找客户信息
        /// </summary>
        /// <param name="id">客户主键ID</param>
        /// <returns></returns>
        public Customer FindCustomer(int id)
        {
            return _picStormContent.Customer.Find(id);
        }

        public void UpdateCustomer(Customer entity)
        {
            Customer en = new Customer();
            en = _picStormContent.Customer.FirstOrDefault(d => d.CustomerID == entity.CustomerID);
            en.CustomerName = entity.CustomerName;
            en.CustomerPhone = entity.CustomerPhone;
            en.WeiXin = entity.WeiXin;
            en.QQ = entity.QQ;
            en.Email = entity.Email;
            en.Address = entity.Address;
            en.UpdateDate = DateTime.Now;
            _picStormContent.SaveChanges();
        }

        public int SaveCustomer(Customer entity)
        {
            entity.EnteredDate = DateTime.Now;
            entity.UpdateDate = DateTime.Now;
            _picStormContent.Customer.Add(entity);
            _picStormContent.SaveChanges();
            return entity.CustomerID;
        }
        #endregion

        #region 自定义字段相关
        /// <summary>
        /// 根据CF主键ID获取其列表数据集合
        /// </summary>
        /// <param name="cfID"></param>
        /// <returns></returns>
        public IEnumerable<CustomFieldDataList> GetCustomFieldDataListList(int cfID)
        {
            IEnumerable<CustomFieldDataList> list = _picStormContent.CustomFieldDataList.Where<CustomFieldDataList>(d => d.CustomFieldID == cfID);
            return list;
        }

        /// <summary>
        /// 执行更新或添加自定义字段的用户录入值
        /// </summary>
        /// <param name="ItemList"></param>
        public void UpdateCustomFieldData(List<CustomFieldsColumnsList> ItemList)
        {
            foreach (var item in ItemList)
            {
                string sql = @"IF EXISTS(SELECT * FROM CustomFieldData WHERE CustomFieldID = @customFieldID AND TableID = @tableID)
                                BEGIN
	                                UPDATE CustomFieldData SET CustomFieldValue = @fieldValue, UpdateDate = GETDATE() WHERE CustomFieldID = @customFieldID AND TableID = @tableID
                                END
                                ELSE
                                BEGIN
	                                INSERT INTO CustomFieldData(CustomFieldValue,EnteredDate,UpdateDate,CustomFieldID,TableID)
	                                VALUES(@fieldValue,GETDATE(),GETDATE(), @customFieldID, @tableID)
                                END";
                SqlParameter[] par = new SqlParameter[] {
                    new SqlParameter("@customFieldID",item.CustomFieldID),
                    new SqlParameter("@tableID", item.TableID),
                    new SqlParameter("@fieldValue", item.FieldValue)
                    };
                _picStormContent.Database.ExecuteSqlCommand(sql, par);
            }
        }

        /// <summary>
        /// 获取自定义字段用户输入的值集合
        /// </summary>
        /// <param name="tableID"></param>
        /// <returns></returns>
        public List<CustomFieldData> GetCustomFieldValue(int tableID)
        {
            return _picStormContent.CustomFieldData.Where<CustomFieldData>(d => d.TableID == tableID).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public List<CustomFieldData> GetPrintCustomFieldValue(int orderID, int customerID)
        {
            using (MSSqlContext dbContext = new MSSqlContext(ConnectionString))
            {
                List<CustomFieldData> list;
                string sql = @"select *from CustomFieldData where TableID=@orderID and CustomFieldID in(
                                select CustomFieldID from CustomField where TableIndex = 2
                                )
                                union all
                                select* from CustomFieldData where TableID = @customerID and CustomFieldID in(
                                  select CustomFieldID from CustomField where TableIndex = 1
                                )";
                list = dbContext.FindByFilter<CustomFieldData>(sql, new { orderID = orderID, customerID = customerID }).ToList();
                return list;
            }
        }
        /// <summary>
        /// 根据主键ID获取某条记录
        /// </summary>
        /// <param name="cfdlID"></param>
        /// <returns></returns>
        public CustomFieldDataList GetCustomFieldDataListItem(int cfdlID)
        {
            return _picStormContent.CustomFieldDataList.Where<CustomFieldDataList>(d => d.CustomFieldDataListID == cfdlID).FirstOrDefault();
        }
        #endregion
    }

    public class CustomFieldsColumnsList
    {
        public int CustomFieldID { get; set; }
        public int TableID { get; set; }
        public string FieldValue { get; set; }
    }

}
