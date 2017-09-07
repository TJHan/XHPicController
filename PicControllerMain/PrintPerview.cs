using PicControllerMain.Common;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PicControllerMain
{
    public partial class PrintPerview : Form
    {

        private DataController controller;
        private int OrderID { get; set; }
        

        public PrintPerview(int orderID)
        {
            OrderID = orderID;
            controller = new DataController();
            InitializeComponent();
            LoadPrintData();
            LoadOrderSetting();
            LoadShopInfo();
        }

        private void LoadPrintData()
        {
            if (OrderID == 0)
            { return; }
            Order entity = new Order();
            entity = controller.FindOrder(OrderID);
            if (entity != null)
            {
                labNbr.Text = entity.OrderID.ToString().ToOrderNumber();
                Customer customer = new Customer();
                customer = controller.FindCustomer(entity.CustomerID);
                int customerID = 0;
                if (customer != null)
                {
                    labCustomerName.Text = string.Format(@"{0} [电话：{1}]", customer.CustomerName, customer.CustomerPhone);
                    customerID = customer.CustomerID;
                }
                labOrderDate.Text = entity.CreateDate.Value.ToString("yyyy-MM-dd");
                if (entity.TotalAmount.HasValue)
                {
                    labOrderPrice.Text = entity.TotalAmount.Value.ToString("C");
                    labTotalAmount.Text = entity.TotalAmount.Value.ToString("C");
                }
                if (entity.AdvanceAmount.HasValue)
                    labDingJin.Text = entity.AdvanceAmount.Value.ToString("C");
                //加载套系区域
                labGroupName.Text = string.Format(@"{0}     子套系名称：{1}", entity.GroupName, entity.SubGroupName);
                labGroupContent.Text = entity.GroupContent;

                labRemark.Text = entity.Comment;
                //加载自定义区域
                //LoadCustomFields(entity.TotalAmount.Value, customerID, entity.Comment);
            }
        }

        /// <summary>
        /// 加载订单设置信息
        /// </summary>
        private void LoadOrderSetting()
        {
            OrderSetting setting = controller.GetOrderSetting();
            if (setting != null)
            {
                labTitle.Text = setting.OrderTitle;
                labCommentTitle.Text = setting.CommentTitle;
                labComment.Text = setting.Comment;
            }
        }

        /// <summary>
        /// 加载店铺信息
        /// </summary>
        private void LoadShopInfo()
        {
            Shop shop = controller.GetShopInfo();
            if (shop != null)
            {
                labAddress.Text = shop.ShopAddress;
                labPhone.Text = shop.ShopPhone;
                labQQ.Text = shop.ShopQQ;
                labEmail.Text = shop.ShopEmail.Replace(";", "  ");
            }
        }

        private void LoadCustomFields(decimal totalAmount, int customerID, string comment)
        {
            CustomFieldsHandler cfHandler = new CustomFieldsHandler();
            //cfHandler.LoadPrintCustomFields(PanelCustomFields, customerID, OrderID, totalAmount, comment);
        }

        private void btnPrintSetup_Click(object sender, EventArgs e)
        {
            this.pageSetupDialog1.ShowDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            currentY = 0;
            this.printPreviewDialog1.Document = printDocument1;

            this.printPreviewDialog1.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            currentY = 0;
            this.printDialog1.Document = this.printDocument1;
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private int currentY = 0;
        public Font Fontfont;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Printing.PrintDocument pd = sender as System.Drawing.Printing.PrintDocument;
            int imageheight = 0;
            int width = PanelPrint.DisplayRectangle.Width;
            int height = PanelPrint.DisplayRectangle.Height;

            int pwidth = pd.DefaultPageSettings.Bounds.Width;
            int pheight = pd.DefaultPageSettings.Bounds.Height;
            if (currentY < height)
            {
                Bitmap bmp = new Bitmap(width, height);
                PanelPrint.DrawToBitmap(bmp, new Rectangle(10, 10, bmp.Width, bmp.Height));

                imageheight = (pwidth - bmp.Width) / 2;

                e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                e.Graphics.DrawImage(bmp, imageheight, 0, new RectangleF(0, currentY, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                currentY += pheight;

                if (height - currentY > 0)
                {
                    e.HasMorePages = true;
                }
            }
            else
            {
                e.HasMorePages = false;
            }
        }
    }
}
