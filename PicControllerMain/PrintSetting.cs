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
    public partial class PrintSetting : Form
    {
        DataController controller;
        private int OrderSettingID;
        public PrintSetting()
        {
            InitializeComponent();
            controller = new DataController();
            LoadInfo();
        }

        private void LoadInfo()
        {

            OrderSetting setting = controller.GetOrderSetting();
            if (setting != null)
            {
                txtOrderTitle.Text = setting.OrderTitle;
                OrderSettingID = setting.OrderSettingID;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderTitle.Text))
            {
                MessageBox.Show("先填写订单标题来");
                return;
            }
            OrderSetting setting = new OrderSetting()
            {
                OrderSettingID = this.OrderSettingID,
                OrderTitle = txtOrderTitle.Text.Trim()
            };
            controller.SaveOrderSetting(setting);
            MessageBox.Show("保存成功");
            this.Close();
        }
    }
}
