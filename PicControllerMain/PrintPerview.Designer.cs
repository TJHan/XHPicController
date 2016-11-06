namespace PicControllerMain
{
    partial class PrintPerview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintPerview));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.labTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintSetup = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.PanelPrint = new System.Windows.Forms.Panel();
            this.labFinishDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelCustomFields = new System.Windows.Forms.Panel();
            this.labOrderPrice = new System.Windows.Forms.Label();
            this.labOrderDate = new System.Windows.Forms.Label();
            this.labCustomerName = new System.Windows.Forms.Label();
            this.labNbr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.Location = new System.Drawing.Point(250, 16);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(229, 20);
            this.labTitle.TabIndex = 3;
            this.labTitle.Text = "索尼娅婚纱摄影专用订单";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "下单日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户编号：";
            // 
            // btnPrintSetup
            // 
            this.btnPrintSetup.Location = new System.Drawing.Point(134, 662);
            this.btnPrintSetup.Name = "btnPrintSetup";
            this.btnPrintSetup.Size = new System.Drawing.Size(75, 23);
            this.btnPrintSetup.TabIndex = 1;
            this.btnPrintSetup.Text = "打印设置";
            this.btnPrintSetup.UseVisualStyleBackColor = true;
            this.btnPrintSetup.Click += new System.EventHandler(this.btnPrintSetup_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(247, 662);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "打印预览";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(475, 662);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // PanelPrint
            // 
            this.PanelPrint.BackColor = System.Drawing.Color.White;
            this.PanelPrint.Controls.Add(this.labFinishDate);
            this.PanelPrint.Controls.Add(this.label6);
            this.PanelPrint.Controls.Add(this.PanelCustomFields);
            this.PanelPrint.Controls.Add(this.labOrderPrice);
            this.PanelPrint.Controls.Add(this.labOrderDate);
            this.PanelPrint.Controls.Add(this.labCustomerName);
            this.PanelPrint.Controls.Add(this.labNbr);
            this.PanelPrint.Controls.Add(this.label4);
            this.PanelPrint.Controls.Add(this.labTitle);
            this.PanelPrint.Controls.Add(this.label1);
            this.PanelPrint.Controls.Add(this.label2);
            this.PanelPrint.Controls.Add(this.label3);
            this.PanelPrint.Location = new System.Drawing.Point(12, 12);
            this.PanelPrint.Name = "PanelPrint";
            this.PanelPrint.Size = new System.Drawing.Size(731, 644);
            this.PanelPrint.TabIndex = 4;
            // 
            // labFinishDate
            // 
            this.labFinishDate.AutoSize = true;
            this.labFinishDate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labFinishDate.Location = new System.Drawing.Point(629, 77);
            this.labFinishDate.Name = "labFinishDate";
            this.labFinishDate.Size = new System.Drawing.Size(57, 12);
            this.labFinishDate.TabIndex = 11;
            this.labFinishDate.Text = "结单时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "结单日期：";
            // 
            // PanelCustomFields
            // 
            this.PanelCustomFields.Location = new System.Drawing.Point(3, 142);
            this.PanelCustomFields.Name = "PanelCustomFields";
            this.PanelCustomFields.Size = new System.Drawing.Size(725, 499);
            this.PanelCustomFields.TabIndex = 9;
            // 
            // labOrderPrice
            // 
            this.labOrderPrice.AutoSize = true;
            this.labOrderPrice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOrderPrice.Location = new System.Drawing.Point(92, 115);
            this.labOrderPrice.Name = "labOrderPrice";
            this.labOrderPrice.Size = new System.Drawing.Size(57, 12);
            this.labOrderPrice.TabIndex = 8;
            this.labOrderPrice.Text = "订单金额";
            // 
            // labOrderDate
            // 
            this.labOrderDate.AutoSize = true;
            this.labOrderDate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOrderDate.Location = new System.Drawing.Point(629, 51);
            this.labOrderDate.Name = "labOrderDate";
            this.labOrderDate.Size = new System.Drawing.Size(57, 12);
            this.labOrderDate.TabIndex = 7;
            this.labOrderDate.Text = "下单时间";
            // 
            // labCustomerName
            // 
            this.labCustomerName.AutoSize = true;
            this.labCustomerName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCustomerName.Location = new System.Drawing.Point(92, 77);
            this.labCustomerName.Name = "labCustomerName";
            this.labCustomerName.Size = new System.Drawing.Size(57, 12);
            this.labCustomerName.TabIndex = 6;
            this.labCustomerName.Text = "客户姓名";
            // 
            // labNbr
            // 
            this.labNbr.AutoSize = true;
            this.labNbr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNbr.Location = new System.Drawing.Point(92, 51);
            this.labNbr.Name = "labNbr";
            this.labNbr.Size = new System.Drawing.Size(57, 12);
            this.labNbr.TabIndex = 5;
            this.labNbr.Text = "客户编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "订单金额：";
            // 
            // PrintPerview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 697);
            this.Controls.Add(this.PanelPrint);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnPrintSetup);
            this.Name = "PrintPerview";
            this.Text = "PrintPerview";
            this.PanelPrint.ResumeLayout(false);
            this.PanelPrint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnPrintSetup;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Panel PanelPrint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labNbr;
        private System.Windows.Forms.Label labCustomerName;
        private System.Windows.Forms.Label labOrderDate;
        private System.Windows.Forms.Label labOrderPrice;
        private System.Windows.Forms.Panel PanelCustomFields;
        private System.Windows.Forms.Label labFinishDate;
        private System.Windows.Forms.Label label6;
    }
}