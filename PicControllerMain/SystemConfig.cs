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
        }

        /// <summary>
        /// 加载字段类型列表数据
        /// </summary>
        private void BindFieldType()
        {
            DataController controller = new DataController();
            IEnumerable<CustomFieldType> list = controller.GetCustomFieldTypeList();
            ddlFieldType.DataSource = list;
            ddlFieldType.ValueMember = "CustomFieldTypeID";
            ddlFieldType.DisplayMember = "CustomFieldTypeName";
        }

        /// <summary>
        /// 加载已创建的自定义字段
        /// </summary>
        private void BindFieldList()
        {
            int type = 0;
            DataController controller = new DataController();
            IEnumerable<CustomField> list = controller.GetCustomFieldList(type);
            foreach (var customField in list)
            {
                ListViewItem item = new ListViewItem();
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
            if (controller.SaveCustomField(ddlTableList.SelectedValue.ToString().ToInt(), txtFieldName.Text, ddlFieldType.SelectedValue.ToString().ToInt()))
            {
                MessageBox.Show("保存成功");
            }
            else
            {
                MessageBox.Show("保存失败");
            }
        }

        private void ddlFieldType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
