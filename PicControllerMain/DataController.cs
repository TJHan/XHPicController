using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using PicControllerMain.ParamsEntity;

namespace PicControllerMain
{
    public class DataController
    {
        private PicStoreEntities _picStormContent;
        public DataController()
        {
            _picStormContent = new PicStoreEntities();
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
        public int SaveCustomField(int tableID, string fieldName, int fieldType, List<string> itemList = null)
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
                CustomFieldDefaultValue = string.Empty
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
        public IEnumerable<CustomField> GetCustomFieldList(int type)
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
        #endregion

        #region 订单操作
        /// <summary>
        /// 获取订单集合
        /// </summary>
        /// <param name="pEntity">查询参数对象</param>
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
                           o.EnteredDate
                       };
            if (!string.IsNullOrEmpty(pEntity.ParamsCustomerName)) {
                list = list.Where(d => d.CustomerName.Contains(pEntity.ParamsCustomerName));
            }
            if (!string.IsNullOrEmpty(pEntity.ParamsPhone))
            {
                list = list.Where(d => d.CustomerPhone.Contains(pEntity.ParamsPhone));
            }
            return list;

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
                       select new {
                           c.CustomerID,
                           c.CustomerName,
                           c.CustomerPhone,
                           c.Address,
                           c.EnteredDate
                       };
            if (!string.IsNullOrEmpty(pEntity.ParamsCustomerName))
            {
                list = list.Where(d => d.CustomerName.Equals(pEntity.ParamsCustomerName));
            }
            if (!string.IsNullOrEmpty(pEntity.ParamsPhone))
            {
                list = list.Where(d => d.CustomerPhone.Equals(pEntity.ParamsPhone));
            }
            if (!string.IsNullOrEmpty(pEntity.ParamsAddress))
            {
                list = list.Where(d => d.Address.Equals(pEntity.ParamsAddress));
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
            entity.EnteredDate = DateTime.Now;
            entity.UpdateDate = DateTime.Now;
            _picStormContent.Customer.Add(entity);
            _picStormContent.SaveChanges();
        }
        #endregion
    }
}
