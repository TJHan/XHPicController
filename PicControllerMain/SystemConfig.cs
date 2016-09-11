using System;
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
    public partial class SystemConfig : Form
    {
        public SystemConfig()
        {
            InitializeComponent();
            LoadPage();
        }

        /// <summary>
        /// 初始化页面
        /// </summary>
        private void LoadPage()
        {
            BindFieldType();
            BindTableType();
            BindFieldList();
        }

        /// <summary>
        /// 加载字段类型列表数据
        /// </summary>
        private void BindFieldType()
        {
            try
            {
                DataController controller = new DataController();
                IEnumerable<CustomFieldType> list = controller.GetCustomFieldTypeList();
                ddlFieldType.DataSource = list;
                ddlFieldType.ValueMember = "CustomFieldTypeID";
                ddlFieldType.DisplayMember = "CustomFieldTypeName";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        class item
        {
            public string Key { get; set; }
            public string Text { get; set; }
        }

        private void BindTableType()
        {
            List<item> list = new List<item>() {
                new item { Key="1", Text="客户" },
                new item { Key="2", Text="订单" }
            };
            ddlTableList.DataSource = list;
            ddlTableList.DisplayMember = "Text";
            ddlTableList.ValueMember = "Key";
        }

        /// <summary>
        /// 加载已创建的自定义字段
        /// </summary>
        private void BindFieldList()
        {
            int type = 0;
            DataController controller = new DataController();
            IEnumerable<CustomField> list = controller.GetCustomFieldList(type);
            string typeName = string.Empty;
            lvFieldItemList.Items.Clear();
            foreach (var customField in list)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(customField.CustomFieldID.ToString());                
                item.SubItems.Add(customField.CustomFieldName);
                item.SubItems.Add(customField.CustomFieldTypeID.ToString());
                typeName = customField.TableIndex == 1 ? "客户类" : "订单类";
                item.SubItems.Add(typeName);
                lvFieldItemList.Items.Add(item);
            }
        }

        /// <summary>
        /// 保存字段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddField_Click(object sender, EventArgs e)
        {
            if (ddlTableList.SelectedIndex < 0)
            {
                MessageBox.Show("选个所属分类先");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFieldName.Text))
            {
                MessageBox.Show("填写字段名字");
                return;
            }
            if (ddlFieldType.SelectedIndex < 0)
            {
                MessageBox.Show("选个字段类型");
                return;
            }
            DataController controller = new DataController();
            List<string> itemList = new List<string>();
            if (ddlFieldType.SelectedValue.ToString() == "5" || ddlFieldType.SelectedValue.ToString() == "6")
            {
                foreach (var item in lbItemList.Items)
                {
                    itemList.Add(item.ToString());
                }
            }
            int keyID = controller.SaveCustomField(ddlTableList.SelectedValue.ToString().ToInt(), txtFieldName.Text, ddlFieldType.SelectedValue.ToString().ToInt(), itemList);
            if (keyID > 0)
            {
                ClearController();
                MessageBox.Show("保存成功");
                BindFieldList();
            }
            else
            {
                MessageBox.Show("保存失败");
            }
        }

        private void ddlFieldType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlFieldType.SelectedIndex > -1)
            {
                if (ddlFieldType.SelectedValue.ToString() == "5" || ddlFieldType.SelectedValue.ToString() == "6")
                {
                    gbItemEdit.Visible = true;
                }
                else {
                    gbItemEdit.Visible = false;
                }
            }

        }

        /// <summary>
        /// 添加集合控件的选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            if (lbItemList.Items.Contains(txtItemName.Text.Trim()))
            {
                MessageBox.Show("此项已存在");
                return;
            }
            lbItemList.Items.Add(txtItemName.Text.Trim());
            txtItemName.Text = string.Empty;
            txtItemName.Focus();
        }

        private void ClearController()
        {
            ddlFieldType.SelectedIndex = 0;
            ddlTableList.SelectedIndex = 0;
            txtItemName.Text = string.Empty;
            txtFieldName.Text = string.Empty;
            lbItemList.Items.Clear();
            gbItemEdit.Visible = false;
        }
    }
}
