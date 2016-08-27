using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PicControllerMain
{
    public partial class CustomerEdit : Form
    {
        private int CustomerID { get; set; }
        public CustomerEdit(int id = 0)
        {
            CustomerID = id;
            InitializeComponent();
            InitCustomerEntity();
        }

        private void InitCustomerEntity()
        {
            DataController controller = new DataController();
            Customer entity = controller.FindCustomer(CustomerID);
            if (entity != null)
            {
                txtUserName.Text = entity.CustomerName;
                txtPhone.Text = entity.CustomerPhone;
                txtWeiXin.Text = entity.WeiXin;
                txtQQ.Text = entity.QQ;
                txtEmail.Text = entity.Email;
                txtAddress.Text = entity.Address;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer entity = new Customer();
            entity.CustomerName = txtUserName.Text.Trim();
            entity.CustomerPhone = txtPhone.Text.Trim();
            entity.WeiXin = txtWeiXin.Text.Trim();
            entity.QQ = txtQQ.Text.Trim();
            entity.Email = txtEmail.Text.Trim();
            entity.Address = txtAddress.Text.Trim();
            if (CustomerID != 0)
            {
                entity.CustomerID = CustomerID;
            }
            DataController controller = new DataController();
            controller.UpdateCustomer(entity);
            MessageBox.Show("数据保存成功");
            this.Close();
        }
    }
}
