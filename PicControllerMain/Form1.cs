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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        

        /// <summary>
        /// 打开系统设置窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labSetting_Click(object sender, EventArgs e)
        {
            SystemConfig sc = new SystemConfig();
            sc.Show();
        }

        private void LoadData()
        { 

        }

        /// <summary>
        /// 打开新建客户窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCreateCustomer_Click(object sender, EventArgs e)
        {
            CustomerEdit ce = new CustomerEdit();
            ce.Show();
        }
    }
}
