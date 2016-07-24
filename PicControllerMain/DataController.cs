using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicControllerMain
{
    public class DataController
    {
        private PicStoreEntities _picStormContent;
        public DataController()
        {
            _picStormContent = new PicStoreEntities();
        }
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
        public bool SaveCustomField(int tableID, string fieldName, int fieldType)
        {
            //检查是否此tableID下的此名字的字段已存在
            if (_picStormContent.CustomField.Where(d => d.CustomFieldName == fieldName && d.TableID == tableID).ToArray().Length > 0)
            {
                return false;
            }
            CustomField cf = new CustomField()
            {
                CustomFieldName = fieldName,
                TableID = tableID,
                CustomFieldTypeID = fieldType
            };
            _picStormContent.CustomField.Add(cf);
            int result = _picStormContent.SaveChanges();
            return result > 0;
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
                list = _picStormContent.CustomField.Where<CustomField>(d => d.TableID == type).ToList();
            }
            else
            {
                list = _picStormContent.CustomField.Where<CustomField>(d => 1 == 1).ToList();
            }
            return list;
        }

    }
}
