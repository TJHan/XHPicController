using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PicControllerMain.ParamsEntity;

namespace PicControllerMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        /// <summary>
        /// 打开系统设置窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labSetting_Click(object sender, EventArgs e)
        {
            SystemConfig sc = new SystemConfig();
            sc.Show();
        }

        /// <summary>
        /// 加载订单数据
        /// </summary>
        private void LoadData()
        {
            OrderSearchParams parms = new OrderSearchParams();
            parms.ParamsCustomerName = txtCustomerName.Text.Trim();
            parms.ParamsPhone = txtPhone.Text.Trim();
            DataController controller = new DataController();
            IQueryable list = controller.LoadOrderList(parms);
            foreach (dynamic order in list)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(order.OrderID.ToString());
                item.SubItems.Add(order.CustomerName);
                item.SubItems.Add(order.CustomerPhone);
                item.SubItems.Add(order.EnteredDate.ToString("yyyy-MM-dd"));
                lvDataList.Items.Add(item);
            }
        }
              

        /// <summary>
        /// 订单查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// 打开新建订单窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCreateOrder_Click(object sender, EventArgs e)
        {
            OrderEdit oe = new OrderEdit();
            oe.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CustomerMain main = new CustomerMain();
            main.Show();
        }
    }
}
