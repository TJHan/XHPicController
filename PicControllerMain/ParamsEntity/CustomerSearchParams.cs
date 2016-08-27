using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicControllerMain.ParamsEntity
{
    /// <summary>
    /// 客户查询参数实体
    /// </summary>
    public class CustomerSearchParams
    {
        /// <summary>
        /// 客户姓名
        /// </summary>
        public string ParamsCustomerName { get; set; }

        /// <summary>
        /// 客户联系电话
        /// </summary>
        public string ParamsPhone { get; set; }

        /// <summary>
        /// 客户地址
        /// </summary>
        public string ParamsAddress { get; set; }
    }
}
