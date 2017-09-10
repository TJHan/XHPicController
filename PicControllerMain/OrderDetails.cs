using PicControllerMain.Common;
using PicControllerMain.ParamsEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicControllerMain
{
    public partial class OrderDetails : Form
    {
        private int OrderID { get; set; }
        public OrderDetails(int orderID)
        {
            this.OrderID = orderID;
            InitializeComponent();
            InitControl();
            InitOrderEntity();
            LoadCustomFields();
        }
        private void InitControl()
        {
            txtCreateDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            LoadOrderStatus();
        }
        private void LoadOrderStatus()
        {
            ddlOrderStatus.DataSource = Enum.GetNames(typeof(EnumOrderStatus));
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
                txtMainGroup.Text = entity.GroupName;
                txtSubGroup.Text = entity.SubGroupName;
                txtGroupContent.Text = entity.GroupContent;
            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {           
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
                entity.GroupContent = txtGroupContent.Text.Trim();
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

                //SaveCustomFieldValue();

                MessageBox.Show("订单数据保存成功");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("订单数据保存异常，请重试");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RDLCPrint print = new RDLCPrint(OrderID);
            print.Show();
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
