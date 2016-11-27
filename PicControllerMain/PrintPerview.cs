using PicControllerMain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PicControllerMain
{
    public partial class PrintPerview : Form
    {
        private int OrderID { get; set; }
        public PrintPerview(int orderID)
        {
            OrderID = orderID;
            InitializeComponent();
            LoadPrintData();
        }

        private void btnPrintSetup_Click(object sender, EventArgs e)
        {
            this.pageSetupDialog1.ShowDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.Document = printDocument1;

            this.printPreviewDialog1.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.printDialog1.Document = this.printDocument1;
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int currentY = 0;
            System.Drawing.Printing.PrintDocument pd = sender as System.Drawing.Printing.PrintDocument;
            int width = PanelPrint.DisplayRectangle.Width;
            int height = PanelPrint.DisplayRectangle.Height;

            int pwidth = pd.DefaultPageSettings.Bounds.Width;
            int pheight = pd.DefaultPageSettings.Bounds.Height;
            if (currentY < height)
            {
                Bitmap bmp = new Bitmap(width, height);
                PanelPrint.DrawToBitmap(bmp, new Rectangle(10, 10, bmp.Width, bmp.Height));
                e.Graphics.DrawImage(bmp, (pwidth - bmp.Width) / 2, 0, new RectangleF(0, currentY, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                currentY += pheight;

                if (height - currentY > 0)
                {
                    e.HasMorePages = true;
                }
            }
            else {
                e.HasMorePages = false;
            }

        }

        private void LoadPrintData()
        {
            if (OrderID == 0)
            { return; }
            DataController controller = new DataController();
            Order entity = new Order();
            entity = controller.FindOrder(OrderID);
            if (entity != null)
            {
                labNbr.Text = entity.OrderID.ToString();
                Customer customer = new Customer();
                customer = controller.FindCustomer(entity.CustomerID);
                int customerID = 0;
                if (customer != null)
                {
                    labCustomerName.Text = string.Format(@"{0} [电话：{1}]", customer.CustomerName, customer.CustomerPhone);
                    customerID = customer.CustomerID;
                }
                labOrderDate.Text = entity.CreateDate.Value.ToString("yyyy-MM-dd");
                if (entity.FinishDate.HasValue)
                    labFinishDate.Text = entity.FinishDate.Value.ToString("yyyy-MM-dd");
                if (entity.TotalAmount.HasValue)
                    labOrderPrice.Text = entity.TotalAmount.Value.ToString("F2");

                //加载套系区域
                LoadGroupInfo(entity.SubGroupID.Value, entity.GroupContent);
                //加载自定义区域
                LoadCustomFields(entity.TotalAmount.Value, customerID, entity.Comment);
            }
        }

        private void LoadCustomFields(decimal totalAmount, int customerID, string comment)
        {
            CustomFieldsHandler cfHandler = new CustomFieldsHandler();
            cfHandler.LoadPrintCustomFields(PanelCustomFields, customerID, OrderID, totalAmount, comment);
        }

        private void LoadGroupInfo(int subGroupID, string content)
        {
            DataController controller = new DataController();
            V_GroupInfo entity = controller.GetGroupInfo(subGroupID);
            if (entity != null)
            {
                labGroupName.Text = string.Format(@"{0}     子套系名称：{1}", entity.GroupName, entity.SubGroupName);
            }
            labGroupContent.Text = content;
        }
    }
}
