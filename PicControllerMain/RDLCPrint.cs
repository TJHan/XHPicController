using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PicControllerMain.Common;

namespace PicControllerMain
{
    public partial class RDLCPrint : Form
    {
        private DataController controller;
        private int OrderID { get; set; }
        public RDLCPrint(int orderID)
        {
            this.OrderID = orderID;
            controller = new DataController();
            InitializeComponent();
            LoadPrintData();
            LoadOrderSetting();
            LoadShopInfo();
        }

        private void RDLCPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PicStoreDataSet.Order' table. You can move, or remove it, as needed.
            this.OrderTableAdapter.Fill(this.PicStoreDataSet.Order);

            this.reportViewer1.RefreshReport();
        }


        private void LoadPrintData()
        {
            if (OrderID == 0)
            { return; }
            Order entity = new Order();
            entity = controller.FindOrder(OrderID);
            if (entity != null)
            {
                //订单编号
                SetupReportParameters("CustomerNumber", entity.OrderID.ToString().ToOrderNumber());

                Customer customer = new Customer();
                customer = controller.FindCustomer(entity.CustomerID);
                int customerID = 0;
                if (customer != null)
                {
                    //客户名称
                    SetupReportParameters("CustomerName", string.Format(@"{0} [电话：{1}]", customer.CustomerName, customer.CustomerPhone));
                    customerID = customer.CustomerID;
                }
                //下单时间
                SetupReportParameters("OrderDate", entity.CreateDate.Value.ToString("yyyy-MM-dd"));
                if (entity.TotalAmount.HasValue)
                {
                    //订单金额
                    SetupReportParameters("OrderAmount", entity.TotalAmount.Value.ToString());
                    //合计费用
                    SetupReportParameters("TotalAmount", entity.TotalAmount.Value.ToString());
                }
                //定金
                if (entity.AdvanceAmount.HasValue)
                    SetupReportParameters("DingJin", entity.AdvanceAmount.Value.ToString());
                //加载套系区域
                SetupReportParameters("GroupInfo", entity.GroupContent);
                SetupReportParameters("GroupTitle", string.Format(@"{0}     子套系名称：{1}", entity.GroupName, entity.SubGroupName));

                //订单备注
                SetupReportParameters("RemarkInfo", entity.Comment);
            }
        }

        /// <summary>
        /// 加载订单设置信息
        /// </summary>
        private void LoadOrderSetting()
        {
            OrderSetting setting = controller.GetOrderSetting();
            if (setting != null)
            {
                SetupReportParameters("OrderTitle", setting.OrderTitle);
                SetupReportParameters("CommentTitle", setting.CommentTitle);
                SetupReportParameters("CommentInfo", setting.Comment);
            }
        }

        /// <summary>
        /// 加载店铺信息
        /// </summary>
        private void LoadShopInfo()
        {
            Shop shop = controller.GetShopInfo();
            if (shop != null)
            {
                SetupReportParameters("ShopAddress", shop.ShopAddress);
                SetupReportParameters("Phone", shop.ShopPhone);
                SetupReportParameters("QQ", shop.ShopQQ);
                SetupReportParameters("EmailList", shop.ShopEmail.Replace(";", "  "));
            }
        }

        /// <summary>
        /// 给报表添加参数
        /// </summary>
        /// <param name="paraName">参数名</param>
        /// <param name="value">参数值</param>
        private void SetupReportParameters(string paraName, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                ReportParameter rp = new ReportParameter(paraName, value);
                reportViewer1.LocalReport.SetParameters(rp);
            }
        }
    }
}
