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
using PicControllerMain.Common;

namespace PicControllerMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadOrderStatus();
            LoadData();
        }

        private void LoadOrderStatus()
        {
            ddlOrderStatus.Items.Insert(0, "订单状态");
            foreach (var item in typeof(EnumOrderStatus).GetFields())
            {
                if (item.FieldType.IsEnum == true)
                {
                    ddlOrderStatus.Items.Add(item.Name);
                }
            }
            ddlOrderStatus.SelectedIndex = 0;
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
            parms.ParamsOrderStatus = ddlOrderStatus.SelectedIndex > 0 ? ddlOrderStatus.SelectedItem.ToString() : string.Empty;
            DataController controller = new DataController();
            IQueryable list = controller.LoadOrderList(parms);
            lvDataList.Items.Clear();
            foreach (dynamic order in list)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(order.OrderID.ToString());
                item.SubItems.Add(order.CustomerName);
                item.SubItems.Add(order.CustomerPhone);
                item.SubItems.Add(order.EnteredDate.ToString("yyyy-MM-dd"));
                item.SubItems.Add(order.Status);
                string finishDate = order.FinishDate != null ? order.FinishDate.ToString("yyyy-MM-dd") : string.Empty;
                item.SubItems.Add(finishDate);
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
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            OrderEdit oe = new OrderEdit();
            oe.ShowDialog();
            if (oe.DialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CustomerMain main = new CustomerMain();
            main.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            ddlOrderStatus.SelectedIndex = 0;
        }

        /// <summary>
        /// 点击订单修改订单信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvDataList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = lvDataList.SelectedIndices[0];
            int id = lvDataList.Items[index].SubItems[1].Text.ToInt();
            OrderEdit edit = new OrderEdit(id);
            edit.ShowDialog();
            if (edit.DialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void labSetting_MouseHover(object sender, EventArgs e)
        {
            this.labSetting.BackColor = Color.LightGray;

        }

        private void labSetting_MouseLeave(object sender, EventArgs e)
        {
            this.labSetting.BackColor = Color.WhiteSmoke;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            this.label3.BackColor = Color.LightGray;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.label3.BackColor = Color.WhiteSmoke;
        }

        private void labGroup_Click(object sender, EventArgs e)
        {
            GroupIndex group = new GroupIndex();
            group.Show();
        }

        private void labPrint_Click(object sender, EventArgs e)
        {
            PrintSetting setting = new PrintSetting();
            setting.Show();
        }
    }
}
