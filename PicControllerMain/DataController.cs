﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Objects;
using System.Text;
using System.Configuration;
using PicControllerMain.ParamsEntity;
using Rock.Data.DataAccess;
using System.Data.Entity;

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
            order.SubGroupID = entity.SubGroupID;
            order.GroupContent = entity.GroupContent;
            order.GroupID = entity.GroupID;
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

        /// <summary>
        /// 获取客户的订单列表
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public List<Order> GetOrderListByCID(int customerID)
        {
            return _picStormContent.Order.Where(d => d.CustomerID == customerID).ToList();
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
                IEnumerable<CustomFieldData> list;
                string sql = @"select *from CustomFieldData where TableID=@orderID and CustomFieldID in(
                                select CustomFieldID from CustomField where TableIndex = 2
                                )
                                union all
                                select* from CustomFieldData where TableID = @customerID and CustomFieldID in(
                                  select CustomFieldID from CustomField where TableIndex = 1
                                )";
                list = dbContext.FindByFilter<CustomFieldData>(sql, new { orderID = orderID, customerID = customerID });
                return list != null ? list.ToList() : null;
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

        #region 套系管理
        /// <summary>
        /// 获取主套系集合
        /// </summary>
        /// <returns></returns>
        public List<MainGroup> GetMainGroupList()
        {
            List<MainGroup> list = _picStormContent.MainGroup.Where<MainGroup>(d => 1 == 1).ToList();
            return list;
        }

        /// <summary>
        /// 新建主套系
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns>返回新建的主键ID</returns>
        public int SaveMainGroup(string groupName)
        {
            MainGroup entity = new MainGroup()
            {
                GroupName = groupName,
                EnteredDate = DateTime.Now
            };
            _picStormContent.MainGroup.Add(entity);
            _picStormContent.SaveChanges();
            return entity.MainGroupID;
        }

        /// <summary>
        /// 修改主套餐名称
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public bool UpdateMainGroup(string groupName, int groupID)
        {
            MainGroup entity = new MainGroup();
            entity = _picStormContent.MainGroup.FirstOrDefault(d => d.MainGroupID == groupID);
            entity.GroupName = groupName;
            return _picStormContent.SaveChanges() == 1;

        }

        /// <summary>
        /// 检查主套系名称是否已存在
        /// </summary>
        /// <param name="groupName">套系名称</param>
        /// <returns></returns>
        public bool CheckMainGroupNameExists(string groupName, int groupID = 0)
        {
            if (groupID == 0)
            {
                //新建检查
                return _picStormContent.MainGroup.Where<MainGroup>(d => d.GroupName.Equals(groupName)).ToList().Count > 0;
            }
            else {
                //修改检查
                return _picStormContent.MainGroup.Where<MainGroup>(d => d.GroupName.Equals(groupName) && d.MainGroupID != groupID).ToList().Count > 0;
            }
        }

        /// <summary>
        /// 获取子套餐集合
        /// </summary>
        /// <param name="mainGroupID">主套餐主键ID</param>
        /// <returns></returns>
        public List<SubGroup> GetSubGroupList(int mainGroupID)
        {
            return _picStormContent.SubGroup.Where<SubGroup>(d => d.MainGroupID == mainGroupID).ToList();
        }

        /// <summary>
        /// 检查子套系名字是否已存在
        /// </summary>
        /// <param name="groupName">子套系名称</param>
        /// <param name="groupID">主套系主键ID</param>
        /// <param name="subGroupID">子套系主键ID</param>
        /// <returns></returns>
        public bool CheckSubGroupNameExists(string groupName, int groupID, int subGroupID = 0)
        {
            if (subGroupID == 0)
            {
                //新建检查
                return _picStormContent.SubGroup.Where<SubGroup>(d => d.GroupName.Equals(groupName) && d.MainGroupID == groupID).ToList().Count > 0;
            }
            else {
                //修改检查
                return _picStormContent.SubGroup.Where<SubGroup>(d => d.GroupName.Equals(groupName) && d.MainGroupID == groupID && d.SubGroupID != subGroupID).ToList().Count > 0;
            }
        }

        /// <summary>
        /// 新建子套系
        /// </summary>
        /// <param name="groupName">子套系名称</param>
        /// <param name="groupID">主套系主键ID</param>
        /// <returns></returns>
        public int SaveSubGroup(string groupName, int groupID)
        {
            SubGroup entity = new SubGroup()
            {
                GroupName = groupName,
                MainGroupID = groupID,
                EnteredDate = DateTime.Now
            };
            _picStormContent.SubGroup.Add(entity);
            _picStormContent.SaveChanges();
            return entity.SubGroupID;
        }

        /// <summary>
        /// 修改子套系
        /// </summary>
        /// <param name="groupName">子套系名称</param>
        /// <param name="subGroupID">自套系主键ID</param>
        /// <returns></returns>
        public bool UpdateSubGroup(string groupName, int subGroupID)
        {
            SubGroup entity = new SubGroup();
            entity = _picStormContent.SubGroup.FirstOrDefault(d => d.SubGroupID == subGroupID);
            entity.GroupName = groupName;
            return _picStormContent.SaveChanges() == 1;
        }

        /// <summary>
        /// 保存套餐详情信息
        /// </summary>
        /// <param name="subGroupID"></param>
        /// <param name="content"></param>
        public void UpdateSubGroupContent(int subGroupID, string content)
        {
            SubGroup entity = new SubGroup();
            entity = _picStormContent.SubGroup.FirstOrDefault(d => d.SubGroupID == subGroupID);
            entity.Contents = content;
            _picStormContent.SaveChanges();
        }

        /// <summary>
        /// 获取套系的详情信息
        /// </summary>
        /// <param name="subGroupID"></param>
        /// <returns></returns>
        public string GetSubGroupContent(int subGroupID)
        {
            SubGroup entity = new SubGroup();
            entity = _picStormContent.SubGroup.FirstOrDefault(d => d.SubGroupID == subGroupID);
            return entity != null ? entity.Contents : string.Empty;
        }

        /// <summary>
        /// 获取套系信息
        /// </summary>
        /// <param name="subGroupID"></param>
        /// <returns></returns>
        public V_GroupInfo GetGroupInfo(int subGroupID)
        {
            return _picStormContent.V_GroupInfo.Where(d => d.SubGroupID == subGroupID).FirstOrDefault();
        }

        /// <summary>
        /// 删除子套系
        /// </summary>
        /// <param name="subGroupID"></param>
        /// <returns></returns>
        public bool DeleteSubGroup(int subGroupID)
        {
            bool result = true;
            try
            {
                SubGroup entity = _picStormContent.SubGroup.FirstOrDefault(d => d.SubGroupID == subGroupID);
                _picStormContent.SubGroup.Remove(entity);
                _picStormContent.SaveChanges();

            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 删除主套系
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public bool DeleteMainGroup(int groupID)
        {
            bool result = true;            
            using (MSSqlContext context = MSSqlContext.BeginTransaction(ConnectionString))
            {
                try
                {
                    string sql = @"DELETE FROM MainGroup WHERE MainGroupID = @MainGroupID;
                                    DELETE FROM SubGroup WHERE MainGroupID = @MainGroupID";
                    context.ExecuteNonQuery(sql, new
                    {
                        MainGroupID = groupID
                    });
                    context.Commit();
                }
                catch (Exception ex)
                {
                    result = false;
                    context.RollBack();
                    throw ex;
                }
                finally
                {
                    context.Close();
                }
            }

            return result;
        }
        #endregion

        #region 订单设置信息
        /// <summary>
        /// 获取订单信息设置对象
        /// </summary>
        /// <returns></returns>
        public OrderSetting GetOrderSetting()
        {
            return _picStormContent.OrderSetting.Where(d => 1 == 1).FirstOrDefault();
        }

        public void SaveOrderSetting(OrderSetting setting)
        {
            if (setting.OrderSettingID == 0)
            {
                _picStormContent.OrderSetting.Add(setting);
                _picStormContent.SaveChanges();
            }
            else {
                OrderSetting entity = _picStormContent.OrderSetting.Where(d => d.OrderSettingID == setting.OrderSettingID).FirstOrDefault();
                entity.OrderTitle = setting.OrderTitle;
                entity.Comment = setting.Comment;
                entity.CommentTitle = setting.CommentTitle;
                _picStormContent.SaveChanges();
            }
        }
        #endregion


        #region 店铺信息管理

        /// <summary>
        /// 获取店铺详情记录
        /// </summary>
        /// <returns></returns>
        public Shop GetShopInfo()
        {
            return _picStormContent.Shop.Where(d => 1 == 1).FirstOrDefault();
        }

        public void SaveShopInfo(Shop shop)
        {
            if (shop.ShopID == 0)
            {
                _picStormContent.Shop.Add(shop);
                _picStormContent.SaveChanges();
            }
            else {
                Shop entity = _picStormContent.Shop.Where(d => d.ShopID == shop.ShopID).FirstOrDefault();
                entity.ShopName = shop.ShopName;
                entity.ShopAddress = shop.ShopAddress;
                entity.ShopPhone = shop.ShopPhone;
                entity.ShopWeiXin = shop.ShopWeiXin;
                entity.ShopQQ = shop.ShopQQ;
                entity.ShopEmail = shop.ShopEmail;
                entity.ShopFax = shop.ShopFax;
                _picStormContent.SaveChanges();
            }
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
