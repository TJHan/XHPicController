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
        private int OrderID { get; set; }
        public OrderEdit(int orderID = 0)
        {
            OrderID = orderID;
            InitializeComponent();
            InitControl();
            InitOrderEntity();
            LoadCustomFields();
        }

        private void InitControl()
        {
            txtCreateDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            if (OrderID > 0)
            {
                PanelCustomSelect.Visible = false;
                LoadOrderStatus();
                btnSave.Text = "更新";
            }
            else
            {
                PanelOrderStatus.Visible = false;
                LoadCustomer();
                btnClose.Visible = false;
            }
        }

        private void InitOrderEntity()
        {
            if (OrderID == 0)
                return;
            DataController controller = new DataController();
            Order entity = new Order();
            entity = controller.FindOrder(OrderID);
            if (entity != null)
            {
                txtCustomerID.Text = entity.CustomerID.ToString();
                Customer customer = new Customer();
                customer = controller.FindCustomer(entity.CustomerID);
                if (customer != null)
                {
                    txtCustomer.Text = string.Format(@"{0} [电话：{1}]", customer.CustomerName, customer.CustomerPhone);
                }
                txtCreateDate.Text = entity.CreateDate.ToString();
                txtTotalAmount.Text = entity.TotalAmount.ToString();
                txtAdvanceAmount.Text = entity.AdvanceAmount.ToString();
                txtYuKuan.Text = (entity.TotalAmount - entity.AdvanceAmount).ToString();
                ddlOrderStatus.Text = entity.Status;
                txtComment.Text = entity.Comment;
            }

        }

        private void LoadOrderStatus()
        {
            ddlOrderStatus.DataSource = Enum.GetNames(typeof(EnumOrderStatus));
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
            try
            {
                Order entity = new Order();
                entity.CustomerID = txtCustomerID.Text.ToInt();
                entity.TotalAmount = txtTotalAmount.Text.ToDecimal();
                entity.CreateDate = txtCreateDate.Text.ToDateTime();
                entity.AdvanceAmount = txtAdvanceAmount.Text.ToDecimal();
                entity.Status = Enum.GetName(typeof(EnumOrderStatus), EnumOrderStatus.订单进行中);
                entity.Comment = txtComment.Text.Trim();

                DataController controller = new DataController();
                if (OrderID > 0)
                {
                    entity.OrderID = OrderID;
                    entity.Status = ddlOrderStatus.SelectedItem as string;
                    if (entity.Status == Enum.GetName(typeof(EnumOrderStatus), 4))
                    {
                        entity.FinishDate = DateTime.Now;
                    }
                    controller.UpdateOrder(entity);
                }
                else {
                    OrderID = controller.SaveOrder(entity);
                }

                SaveCustomFieldValue();

                MessageBox.Show("订单数据保存成功");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("订单数据保存异常，请重试");
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

        private void LoadCustomFields()
        {
            DataController controller = new DataController();

            //
            IEnumerable<CustomField> cfList = controller.GetCustomFieldList(2);
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
                        ddl.Text = cfEntity != null ? cfEntity.CustomFieldValue : string.Empty;

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
            if (OrderID > 0)
            {
                DataController controller = new DataController();
                List<CustomFieldData> list = controller.GetCustomFieldValue(OrderID);
                return list;
            }
            return null;
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
                        TableID = OrderID,
                        FieldValue = txt.Text.Trim()
                    });
                }
                else if (item is ComboBox)
                {
                    ComboBox ddl = (ComboBox)item;
                    parList.Add(new CustomFieldsColumnsList
                    {
                        CustomFieldID = ddl.Name.ToInt(),
                        TableID = OrderID,
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
                                TableID = OrderID,
                                FieldValue = rb.Text
                            });
                        }
                    }
                }
            }
            controller.UpdateCustomFieldData(parList);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Order entity = new Order();
            DataController controller = new DataController();
            entity = controller.FindOrder(OrderID);            
            entity.Status = Enum.GetName(typeof(EnumOrderStatus), EnumOrderStatus.订单结束);
            entity.FinishDate = DateTime.Now;

            controller.UpdateOrder(entity);
            MessageBox.Show("订单已成功结束");
            this.Close();
        }

        /// <summary>
        /// 打印订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
