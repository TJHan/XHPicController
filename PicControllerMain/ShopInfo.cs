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
    public partial class ShopInfo : Form
    {
        DataController controller;
        public ShopInfo()
        {
            controller = new DataController();
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Shop entity = controller.GetShopInfo();
            if (entity != null)
            {
                txtShopName.Text = entity.ShopName;
                txtAddress.Text = entity.ShopAddress;
                txtPhone.Text = entity.ShopPhone;
                txtWeiXin.Text = entity.ShopWeiXin;
                txtQQ.Text = entity.ShopQQ;
                txtEmail.Text = entity.ShopEmail;
                txtFax.Text = entity.ShopFax;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop()
            {
                ShopName = txtShopName.Text.Trim(),
                ShopAddress = txtAddress.Text.Trim(),
                ShopPhone = txtPhone.Text.Trim(),
                ShopWeiXin = txtWeiXin.Text.Trim(),
                ShopQQ = txtQQ.Text.Trim(),
                ShopEmail = txtEmail.Text.Trim(),
                ShopFax = txtFax.Text.Trim()
            };
            controller.SaveShopInfo(shop);
            MessageBox.Show("保存成功");

        }
    }
}
