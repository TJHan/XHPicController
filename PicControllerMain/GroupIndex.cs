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
        private int SubGroupID;

        private DataController Controller;
        public GroupIndex()
        {
            InitializeComponent();
            Controller = new DataController();
            LoadMainGroup();
        }

        private void LoadMainGroup()
        {
            List<MainGroup> list = Controller.GetMainGroupList();
            lbMainGroup.DataSource = list;

        }

        private void LoadSubGroup()
        {
            if (GroupID != 0)
            {
                List<SubGroup> list = Controller.GetSubGroupList(GroupID);
                lbSubGroup.DataSource = list;
            }
        }

        private void LoadContent()
        {
            if (SubGroupID != 0)
            {
                string content = Controller.GetSubGroupContent(SubGroupID);
                txtInfo.Text = content;
            }
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
            try
            {
                if (GroupID > 0)
                {
                    if (Controller.UpdateMainGroup(groupName, GroupID))
                    {
                        MessageBox.Show("套系名称修改成功");
                    }
                }
                else {
                    int id = Controller.SaveMainGroup(groupName);                    
                }
                txtMainGroupName.Text = string.Empty;
                LoadMainGroup();
                ClearSubGroup();
            }
            catch (Exception ex) { }
        }
        
        private void lbMainGroup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MainGroup selectedItem = (MainGroup)lbMainGroup.SelectedItem;
            if (selectedItem != null)
            {
                GroupID = selectedItem.MainGroupID;
                txtMainGroupName.Text = selectedItem.GroupName;                
                LoadSubGroup();
            }
        }

        private void btnSaveSubGroup_Click(object sender, EventArgs e)
        {
            string errorMsg = string.Empty;
            string groupName = txtSubGroupName.Text;
            if (GroupID == 0)
            {
                MessageBox.Show("先选择一个主套系");
                return;
            }
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
            try
            {
                if (SubGroupID == 0)
                {
                    SubGroupID = Controller.SaveSubGroup(groupName, GroupID);
                }
                else {
                    Controller.UpdateSubGroup(groupName, SubGroupID);
                }
                txtSubGroupName.Text = string.Empty;
                txtInfo.Text = string.Empty;
                LoadSubGroup();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if (SubGroupID == 0)
            {
                MessageBox.Show("选个子套餐先");
                return;
            }
            try
            {
                Controller.UpdateSubGroupContent(SubGroupID, txtInfo.Text.Trim());
                lbSubGroup.SelectedIndex = -1;
                SubGroupID = 0;
                txtSubGroupName.Text = string.Empty;
                txtInfo.Text = string.Empty;                
                MessageBox.Show("保存成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("程序异常，一会儿再试，或者联系韩桑");
            }
        }

        private void lbSubGroup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SubGroup selectedItem = (SubGroup)lbSubGroup.SelectedItem;
            if (selectedItem != null)
            {
                SubGroupID = selectedItem.SubGroupID;
                txtSubGroupName.Text = selectedItem.GroupName;
                LoadContent();
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
            lbSubGroup.DataSource = new List<SubGroup>();
            txtInfo.Text = string.Empty;
            txtMainGroupName.Text = string.Empty;
        }

        private void btnSubCancel_Click(object sender, EventArgs e)
        {
            lbSubGroup.SelectedIndex = -1;
            SubGroupID = 0;
            txtInfo.Text = string.Empty;
            txtSubGroupName.Text = string.Empty;
        }

        private void ClearSubGroup()
        {
            SubGroupID = 0;
            txtSubGroupName.Text = string.Empty;
            lbSubGroup.DataSource = new List<SubGroup>();
            txtInfo.Text = string.Empty;
        }
        private void ClearMainGroup()
        {
            GroupID = 0;
            txtMainGroupName.Text = string.Empty;
            ClearSubGroup();
        }
    }
}
