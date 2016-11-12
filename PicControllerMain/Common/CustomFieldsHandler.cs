using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PicControllerMain.Common
{
    public class CustomFieldsHandler
    {
        public void LoadEditCustomFields(Panel controllerPanel, int orderID)
        {
            DataController controller = new DataController();

            //
            IEnumerable<CustomField> cfList = controller.GetCustomFieldList(2);
            int i = 1;

            //取当前用户的自定义字段的值集合
            List<CustomFieldData> valueList = GetCustomFieldValueList(orderID);
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
                        controllerPanel.Controls.Add(lb);
                        controllerPanel.Controls.Add(tb);
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
                        controllerPanel.Controls.Add(lbstr);
                        controllerPanel.Controls.Add(tbstr);
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
                        controllerPanel.Controls.Add(lbdate);
                        controllerPanel.Controls.Add(tbdate);
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
                        controllerPanel.Controls.Add(lbdecimal);
                        controllerPanel.Controls.Add(tbdecimal);
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
                        controllerPanel.Controls.Add(lbddl);
                        controllerPanel.Controls.Add(ddl);
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
                        controllerPanel.Controls.Add(panel);
                        controllerPanel.Controls.Add(lbradio);
                        break;
                    default:
                        break;
                }
                i++;
            }
        }

        /// <summary>
        /// 加载打印的自定义字段集合到打印Panel上
        /// </summary>
        /// <param name="controllerPanel"></param>
        /// <param name="customerID">客户主键ID</param>
        /// <param name="orderID">订单ID</param>
        /// <param name="totalAmount">总费用</param>
        /// <param name="comment">备注信息</param>
        public void LoadPrintCustomFields(Panel controllerPanel, int customerID, int orderID, decimal totalAmount, string comment)
        {
            DataController controller = new DataController();

            //抓取允许打印的自定义字段集合
            IEnumerable<CustomField> cfList = controller.GetPrintCustomFieldList();
            int i = 1;

            //取当前用户的自定义字段的值集合
            List<CustomFieldData> valueList = GetCustomFieldValueList(orderID, customerID);
            foreach (var item in cfList)
            {
                CustomFieldData cfEntity = new CustomFieldData();
                if (valueList != null)
                {
                    cfEntity = valueList.Where<CustomFieldData>(d => d.CustomFieldID == item.CustomFieldID).FirstOrDefault();
                }

                string textValue = string.Empty;
                //下拉菜单和单选按钮需要根据保存的id值查询选中的显示信息
                switch (item.CustomFieldTypeID)
                {
                    case 5:
                        if (cfEntity != null)
                        {
                            CustomFieldDataList selectedItem = controller.GetCustomFieldDataListItem(cfEntity.CustomFieldValue.ToInt());
                            if (selectedItem != null)
                                textValue = selectedItem.CustomFieldItemName;
                        }
                        break;
                    default:
                        textValue = cfEntity != null ? cfEntity.CustomFieldValue : string.Empty;
                        break;
                }
                Label lbValue = new Label()
                {
                    Name = item.CustomFieldID.ToString(),
                    Top = i * 21 + i * 8,
                    Left = (item.CustomFieldName.Length * 10 + 50),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Width = textValue.Length * 10 + 30,
                    Text = textValue,
                    Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)))
                };
                Label lb = new Label()
                {
                    Name = string.Format(@"labcf{0}", item.CustomFieldID),
                    Text = string.Format(@"{0}：", item.CustomFieldName),
                    Top = i * 21 + i * 8,
                    Left = 18,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Width = (item.CustomFieldName.Length * 10 + 30)
                };
                controllerPanel.Controls.Add(lb);
                controllerPanel.Controls.Add(lbValue);
                i++;
            }

            i += 1;
            //备注信息
            Label lbComment = new Label()
            {
                Name = string.Format(@"lbComment"),
                Text = string.Format(@"备注："),
                Top = i * 21 + i * 8,
                Left = 18,
                TextAlign = ContentAlignment.MiddleLeft,
                Width = 50
            };
            controllerPanel.Controls.Add(lbComment);
            Label lbCommentValue = new Label()
            {
                Name = string.Format(@"lbCommentValue"),
                Text = comment,
                Top = i * 21 + i * 8,
                Left = 70,
                TextAlign = ContentAlignment.MiddleLeft,
                //Width = 600,
                AutoSize = true,
                Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)))
            };
            controllerPanel.Controls.Add(lbCommentValue);

            i += 2;
            //合计费用
            Label lbsignTotalAmount = new Label()
            {
                Name = string.Format(@"labTotalAmount"),
                Text = string.Format(@"合计费用："),
                Top = i * 21 + i * 8 + 100,
                Left = 400,
                TextAlign = ContentAlignment.MiddleLeft
            };
            controllerPanel.Controls.Add(lbsignTotalAmount);
            Label lbsignTotalAmountValue = new Label()
            {
                Name = string.Format(@"labTotalAmountValue"),
                Text = totalAmount.ToString("C"),
                Top = i * 21 + i * 8 + 100,
                Left = 500,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)))
            };
            controllerPanel.Controls.Add(lbsignTotalAmountValue);

            i += 1;
            //老板签名区
            Label lbsign1 = new Label()
            {
                Name = string.Format(@"labSign1"),
                Text = string.Format(@"摄影师签字："),
                Top = i * 21 + i * 8 + 100,
                Left = 18,
                TextAlign = ContentAlignment.MiddleLeft
            };
            controllerPanel.Controls.Add(lbsign1);
            //客户签名区
            Label lbCustomSign = new Label()
            {
                Name = string.Format(@"labCustomSign"),
                Text = string.Format(@"客户签名："),
                Top = i * 21 + i * 8 + 100,
                Left = 400,
                TextAlign = ContentAlignment.MiddleLeft
            };
            controllerPanel.Controls.Add(lbCustomSign);
        }

        private List<CustomFieldData> GetCustomFieldValueList(int orderID, int customerID)
        {
            if (orderID > 0)
            {
                DataController controller = new DataController();
                List<CustomFieldData> list = controller.GetPrintCustomFieldValue(orderID, customerID);
                return list;
            }
            return null;
        }
        private List<CustomFieldData> GetCustomFieldValueList(int orderID)
        {
            if (orderID > 0)
            {
                DataController controller = new DataController();
                List<CustomFieldData> list = controller.GetCustomFieldValue(orderID);
                return list;
            }
            return null;
        }

    }
}
