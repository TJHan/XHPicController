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
    public partial class GroupIndex : Form
    {
        private int GroupID;

        private DataController Controller;
        public GroupIndex()
        {
            InitializeComponent();
            Controller = new DataController();
            LoadMainGorup();
        }

        private void LoadMainGorup()
        {
            List<MainGroup> list = Controller.GetMainGroupList();
            lbMainGroup.DataSource = list;

        }

        /// <summary>
        /// 新建或修改主套系
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveMainGroup_Click(object sender, EventArgs e)
        {
            string errorMsg = string.Empty;
            string groupName = txtMainGroupName.Text;

            if (string.IsNullOrEmpty(txtMainGroupName.Text))
            {
                errorMsg = "先写上套系名称";

            }

            if (Controller.CheckMainGroupNameExists(groupName, GroupID))
            {
                errorMsg = "这个套系名称已经有了，重新换个";
            }

            if (!string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(errorMsg);
                txtMainGroupName.Focus();
                return;
            }

            if (GroupID > 0)
            {
                if (Controller.UpdateMainGroup(groupName, GroupID))
                {
                    MessageBox.Show("套系名称修改成功");
                }
            }
            else {
                int id = Controller.SaveMainGroup(groupName);
                LoadMainGorup();
                txtMainGroupName.Text = string.Empty;
            }
        }

        /// <summary>
        /// 主套系取消选择项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMainCancel_Click(object sender, EventArgs e)
        {
            lbMainGroup.SelectedIndex = -1;
            GroupID = 0;
            lbSubGroup.DataSource = null;
            txtInfo.Text = string.Empty;
        }

        private void lbMainGroup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MainGroup selectedItem = (MainGroup)lbMainGroup.SelectedItem;
            if (selectedItem != null)
            {

                GroupID = selectedItem.MainGroupID;
                List<SubGroup> list = Controller.GetSubGroupList(GroupID);
                lbSubGroup.DataSource = list;
            }            
        }

        private void btnSaveSubGroup_Click(object sender, EventArgs e)
        {
            string errorMsg = string.Empty;
            string groupName = txtSubGroupName.Text;

            if (string.IsNullOrEmpty(groupName))
            {
                errorMsg = "先写上套系名称";

            }

            if (Controller.CheckMainGroupNameExists(groupName, GroupID))
            {
                errorMsg = "这个套系名称已经有了，重新换个";
            }

            if (!string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(errorMsg);
                txtSubGroupName.Focus();
                return;
            }
        }
    }
}
