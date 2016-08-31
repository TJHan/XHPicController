using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicControllerMain.ParamsEntity
{
    /// <summary>
    /// 订单查询页面查询参数实体
    /// </summary>
    public class OrderSearchParams
    {
        /// <summary>
        /// 客户名
        /// </summary>
        public string ParamsCustomerName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string ParamsPhone { get; set; }
    }

    /// <summary>
    /// 订单创建页面查询客户条件实体
    /// </summary>
    public class OrderCustomerSearchParams
    {
        public string ParamsString { get; set; }
    }
}
