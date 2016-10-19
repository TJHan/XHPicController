﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PicControllerMain.Common;

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
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                MessageBox.Show("客户姓名不能为空");
                txtUserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                MessageBox.Show("客户电话不能为空");
                txtPhone.Focus();
                return;
            }
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

                CustomerID = controller.SaveCustomer(entity);
            }
            SaveCustomFieldValue();

            MessageBox.Show("数据保存成功");
            this.DialogResult = DialogResult.OK;            
            this.Close();
        }

        /// <summary>
        /// 保存用户输入的自定义字段值
        /// </summary>
        private void SaveCustomFieldValue()
        {
            string sql = string.Empty;
            DataController controller = new DataController();
            List<CustomFieldsColumnsList> parList = new List<CustomFieldsColumnsList>();
            foreach (Control item in PanelCustomFieldList.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    parList.Add(new CustomFieldsColumnsList
                    {
                        CustomFieldID = txt.Name.ToInt(),
                        TableID = CustomerID,
                        FieldValue = txt.Text.Trim()
                    });
                }
                else if (item is ComboBox)
                {
                    ComboBox ddl = (ComboBox)item;
                    parList.Add(new CustomFieldsColumnsList
                    {
                        CustomFieldID = ddl.Name.ToInt(),
                        TableID = CustomerID,
                        FieldValue = ddl.SelectedValue.ToString()
                    });
                }
                else if (item is Panel)
                {
                    foreach (var pitem in item.Controls)
                    {
                        RadioButton rb = (RadioButton)pitem;
                        if (rb.Checked)
                        {
                            parList.Add(new CustomFieldsColumnsList
                            {
                                CustomFieldID = rb.Name.ToInt(),
                                TableID = CustomerID,
                                FieldValue = rb.Text
                            });
                        }
                    }
                }
            }
            controller.UpdateCustomFieldData(parList);
        }

        /// <summary>
        /// 加载自定义控件，以及用户输入的值
        /// </summary>
        private void LoadCustomFields()
        {
            DataController controller = new DataController();
            IEnumerable<CustomField> cfList = controller.GetCustomFieldList(1);
            int i = 1;

            //取当前用户的自定义字段的值集合
            List<CustomFieldData> valueList = GetCustomFieldValueList();
            foreach (var item in cfList)
            {
                CustomFieldData cfEntity = new CustomFieldData();
                if (valueList != null)
                {
                    cfEntity = valueList.Where<CustomFieldData>(d => d.CustomFieldID == item.CustomFieldID).FirstOrDefault();
                }
                switch (item.CustomFieldTypeID)
                {
                    case 1: //整数输入框
                        TextBox tb = new TextBox()
                        {
                            Name = item.CustomFieldID.ToString(),
                            MaxLength = 20,
                            Top = i * 21 + i * 8,
                            Left = (item.CustomFieldName.Length * 10 + 100),
                            Width = 222,
                            Text = cfEntity != null ? cfEntity.CustomFieldValue : string.Empty
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
                            Width = 222,
                            Text = cfEntity != null ? cfEntity.CustomFieldValue : string.Empty
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
                        TextBox tbdate = new TextBox()
                        {
                            Name = item.CustomFieldID.ToString(),
                            Top = i * 21 + i * 8,
                            Left = (item.CustomFieldName.Length * 10 + 100),
                            Width = 222,
                            Text = cfEntity != null ? cfEntity.CustomFieldValue : string.Empty
                        };
                        Label lbdate = new Label()
                        {
                            Name = string.Format(@"labcf{0}", item.CustomFieldID),
                            Text = string.Format(@"{0}:", item.CustomFieldName),
                            Top = i * 21 + i * 8,
                            Left = 10,
                            TextAlign = ContentAlignment.MiddleRight,
                            Width = (item.CustomFieldName.Length * 10 + 50)
                        };
                        PanelCustomFieldList.Controls.Add(lbdate);
                        PanelCustomFieldList.Controls.Add(tbdate);
                        break;
                    case 4://浮点数输入框
                        TextBox tbdecimal = new TextBox()
                        {
                            Name = item.CustomFieldID.ToString(),
                            Top = i * 21 + i * 8,
                            Left = (item.CustomFieldName.Length * 10 + 100),
                            Width = 222,
                            Text = cfEntity != null ? cfEntity.CustomFieldValue : string.Empty
                        };
                        Label lbdecimal = new Label()
                        {
                            Name = string.Format(@"labcf{0}", item.CustomFieldID),
                            Text = string.Format(@"{0}:", item.CustomFieldName),
                            Top = i * 21 + i * 8,
                            Left = 10,
                            TextAlign = ContentAlignment.MiddleRight,
                            Width = (item.CustomFieldName.Length * 10 + 50)
                        };
                        PanelCustomFieldList.Controls.Add(lbdecimal);
                        PanelCustomFieldList.Controls.Add(tbdecimal);
                        break;
                    case 5: //下拉菜单
                        ComboBox ddl = new ComboBox()
                        {
                            Name = item.CustomFieldID.ToString(),
                            Top = i * 21 + i * 8,
                            Left = (item.CustomFieldName.Length * 10 + 100),
                            Width = 222
                        };
                        IEnumerable<CustomFieldDataList> cfdList = controller.GetCustomFieldDataListList(item.CustomFieldID);
                        ddl.DataSource = cfdList.ToList();
                        ddl.DisplayMember = "CustomFieldItemName";
                        ddl.ValueMember = "CustomFieldDataListID";
                        //下拉控件无法加载默认选中项
                        ddl.SelectedValue = cfEntity != null ? cfEntity.CustomFieldValue : string.Empty;
                        Label lbddl = new Label()
                        {
                            Name = string.Format(@"labcf{0}", item.CustomFieldID),
                            Text = string.Format(@"{0}:", item.CustomFieldName),
                            Top = i * 21 + i * 8,
                            Left = 10,
                            TextAlign = ContentAlignment.MiddleRight,
                            Width = (item.CustomFieldName.Length * 10 + 50)
                        };
                        PanelCustomFieldList.Controls.Add(lbddl);
                        PanelCustomFieldList.Controls.Add(ddl);                        
                        break;
                    case 6://单选按钮
                        IEnumerable<CustomFieldDataList> cfdrList = controller.GetCustomFieldDataListList(item.CustomFieldID);
                        int radioWidth = 10;
                        Panel panel = new Panel()
                        {
                            Top = i * 21 + i * 8,
                            Left = (item.CustomFieldName.Length * 10 + 100),
                            Width = 700,
                            Height = 25,
                            AutoScroll = true
                        };
                        foreach (var radioItem in cfdrList.ToList())
                        {
                            RadioButton rb = new RadioButton()
                            {
                                Name = item.CustomFieldID.ToString(),
                                Text = radioItem.CustomFieldItemName,
                                Top = 1,
                                Left = radioWidth,
                                Width = (radioItem.CustomFieldItemName.Length * 20 + 10)
                            };
                            radioWidth += (radioItem.CustomFieldItemName.Length * 20 + 40);
                            if (cfEntity != null && rb.Text == cfEntity.CustomFieldValue)
                            {
                                rb.Checked = true;
                            }
                            panel.Controls.Add(rb);
                        }
                        Label lbradio = new Label()
                        {
                            Name = string.Format(@"labcf{0}", item.CustomFieldID),
                            Text = string.Format(@"{0}:", item.CustomFieldName),
                            Top = i * 21 + i * 8,
                            Left = 10,
                            TextAlign = ContentAlignment.MiddleRight,
                            Width = (item.CustomFieldName.Length * 10 + 50)
                        };
                        PanelCustomFieldList.Controls.Add(panel);
                        PanelCustomFieldList.Controls.Add(lbradio);
                        break;
                    default:
                        break;
                }
                i++;
            }
        }

        /// <summary>
        /// 一次性获取用户录入的自定义字段的值的集合
        /// </summary>
        /// <returns></returns>
        private List<CustomFieldData> GetCustomFieldValueList()
        {
            if (CustomerID > 0)
            {
                DataController controller = new DataController();
                List<CustomFieldData> list = controller.GetCustomFieldValue(CustomerID);
                return list;
            }
            return null;
        }
    }
}
