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
            LoadCustomFields();
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
                btnSave.Text = "更新";
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
            DataController controller = new DataController();
            if (CustomerID != 0)
            {
                entity.CustomerID = CustomerID;
                controller.UpdateCustomer(entity);
            }
            else {

                controller.SaveCustomer(entity);
            }

            MessageBox.Show("数据保存成功");
            this.Close();
        }

        private void LoadCustomFields()
        {
            DataController controller = new DataController();
            IEnumerable<CustomField> cfList = controller.GetCustomFieldList(1);
            int i = 1;
            foreach (var item in cfList)
            {
                switch (item.CustomFieldTypeID)
                {
                    case 1: //整数输入框
                        TextBox tb = new TextBox()
                        {
                            Name = item.CustomFieldID.ToString(),
                            MaxLength = 20,
                            Top = i * 21 + i * 8,
                            Left = (item.CustomFieldName.Length * 10 + 100),
                            Width = 222
                        };
                        Label lb = new Label()
                        {
                            Name = string.Format(@"labcf{0}", item.CustomFieldID),
                            Text = string.Format(@"{0}:", item.CustomFieldName),
                            Top = i * 21 + i * 8,
                            Left = 10,
                            TextAlign = ContentAlignment.MiddleRight,
                            Width = (item.CustomFieldName.Length * 10 + 50)
                        };
                        PanelCustomFieldList.Controls.Add(lb);
                        PanelCustomFieldList.Controls.Add(tb);
                        break;
                    case 2: //字符串输入框
                        TextBox tbstr = new TextBox()
                        {
                            Name = item.CustomFieldID.ToString(),
                            Top = i * 21 + i * 8,
                            Left = (item.CustomFieldName.Length * 10 + 100),
                            Width = 222
                        };
                        Label lbstr = new Label()
                        {
                            Name = string.Format(@"labcf{0}", item.CustomFieldID),
                            Text = string.Format(@"{0}:", item.CustomFieldName),
                            Top = i * 21 + i * 8,
                            Left = 10,
                            TextAlign = ContentAlignment.MiddleRight,
                            Width = (item.CustomFieldName.Length * 10 + 50)
                        };
                        PanelCustomFieldList.Controls.Add(lbstr);
                        PanelCustomFieldList.Controls.Add(tbstr);
                        break;
                    case 3://日期输入框
                        break;
                    case 4://浮点数输入框

                        break;
                    case 5: //下拉菜单
                        break;
                    case 6://单选按钮
                        break;
                    default:
                        break;
                }
                i++;
            }
        }

    }
}
