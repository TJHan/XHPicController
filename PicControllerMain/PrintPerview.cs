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
        public PrintPerview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pageSetupDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.Document = printDocument1;
            this.printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }
        private int currentY = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap map = new Bitmap(groupBox1.Width, groupBox1.Height);
            //groupBox1.DrawToBitmap(map, new Rectangle(0, 0, map.Width, map.Height));
            //e.Graphics.DrawImage(map, 0, 0, map.Width, map.Height);
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
    }
}
