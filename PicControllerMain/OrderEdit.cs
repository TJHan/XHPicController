using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PicControllerMain.ParamsEntity;
using PicControllerMain.Common;


namespace PicControllerMain
{
    public partial class OrderEdit : Form
    {
        public OrderEdit()
        {
            InitializeComponent();
            InitControl();
            LoadCustomer();
        }

        private void InitControl()
        {
            txtCreateDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        /// <summary>
        /// 加载客户数据集合
        /// </summary>
        private void LoadCustomer()
        {
            DataController controller = new DataController();
            OrderCustomerSearchParams pars = new OrderCustomerSearchParams()
            {
                ParamsString = txtSearch.Text.Trim()
            };

            List<Customer> list = controller.LoadCustomerList(pars);
            lvCustomerList.Items.Clear();
            foreach (var customer in list)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(customer.CustomerID.ToString());
                item.SubItems.Add(string.Format(@"{0} [电话：{1}]", customer.CustomerName, customer.CustomerPhone));
                lvCustomerList.Items.Add(item);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerID.Text.Trim()))
            {
                MessageBox.Show("选个客户先！！");
                return;
            }
            if (string.IsNullOrEmpty(txtTotalAmount.Text.Trim()) || txtTotalAmount.Text.ToDecimal() <= 0)
            {
                MessageBox.Show("订单总金额不正常啊！！ 订单存不了，再改改");
                txtTotalAmount.Focus();
                return;
            }
            
            if (txtTotalAmount.Text.ToDecimal() < txtAdvanceAmount.Text.ToDecimal())
            {
                MessageBox.Show("预付款比订单总金额还大？ 订单存不了，再改改");
                return;
            }
            Order entity = new Order();
            entity.CustomerID = txtCustomerID.Text.ToInt();
            entity.TotalAmount = txtTotalAmount.Text.ToDecimal();
            entity.CreateDate = txtCreateDate.Text.ToDateTime();
            entity.AdvanceAmount = txtAdvanceAmount.Text.ToDecimal();
            entity.Status = Enum.GetName(typeof(EnumOrderStatus), EnumOrderStatus.订单进行中);
            entity.Comment = txtComment.Text.Trim();

            DataController controller = new DataController();
            if (controller.SaveOrder(entity))
            {
                MessageBox.Show("订单创建成功");
                this.Close();
            }
            else {
                MessageBox.Show("订单创建异常，请重试");
            }

        }

        private void lvCustomerList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lvCustomerList.SelectedIndices[0];
            txtCustomer.Text = lvCustomerList.Items[index].SubItems[2].Text;
            txtCustomerID.Text = lvCustomerList.Items[index].SubItems[1].Text;
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            Decimal total = txtTotalAmount.Text.ToDecimal();
            Decimal advance = txtAdvanceAmount.Text.ToDecimal();
            txtYuKuan.Text = (total - advance).ToString("F2");
        }

        private void txtAdvanceAmount_TextChanged(object sender, EventArgs e)
        {
            Decimal total = txtTotalAmount.Text.ToDecimal();
            Decimal advance = txtAdvanceAmount.Text.ToDecimal();
            txtYuKuan.Text = (total - advance).ToString("F2");
        }
    }
}
