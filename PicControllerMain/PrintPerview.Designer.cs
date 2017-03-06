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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.labTotalAmount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labQQ = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labPhone = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.labComment = new System.Windows.Forms.Label();
            this.labCommentTitle = new System.Windows.Forms.Label();
            this.labRemark = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.labGroupName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labGroupContent = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labOrderDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labOrderPrice = new System.Windows.Forms.Label();
            this.labNbr = new System.Windows.Forms.Label();
            this.labCustomerName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labDingJin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PanelPrint.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.labTitle.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.Location = new System.Drawing.Point(250, 8);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(229, 20);
            this.labTitle.TabIndex = 3;
            this.labTitle.Text = "索尼娅婚纱摄影专用订单";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(495, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "下单日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户编号：";
            // 
            // btnPrintSetup
            // 
            this.btnPrintSetup.Location = new System.Drawing.Point(153, 12);
            this.btnPrintSetup.Name = "btnPrintSetup";
            this.btnPrintSetup.Size = new System.Drawing.Size(75, 23);
            this.btnPrintSetup.TabIndex = 1;
            this.btnPrintSetup.Text = "打印设置";
            this.btnPrintSetup.UseVisualStyleBackColor = true;
            this.btnPrintSetup.Click += new System.EventHandler(this.btnPrintSetup_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(266, 12);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "打印预览";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(493, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // PanelPrint
            // 
            this.PanelPrint.AutoSize = true;
            this.PanelPrint.BackColor = System.Drawing.Color.White;
            this.PanelPrint.Controls.Add(this.panel1);
            this.PanelPrint.Controls.Add(this.labEmail);
            this.PanelPrint.Controls.Add(this.label16);
            this.PanelPrint.Controls.Add(this.labQQ);
            this.PanelPrint.Controls.Add(this.label15);
            this.PanelPrint.Controls.Add(this.labPhone);
            this.PanelPrint.Controls.Add(this.label13);
            this.PanelPrint.Controls.Add(this.labAddress);
            this.PanelPrint.Controls.Add(this.label12);
            this.PanelPrint.Controls.Add(this.tableLayoutPanel3);
            this.PanelPrint.Controls.Add(this.tableLayoutPanel2);
            this.PanelPrint.Controls.Add(this.tableLayoutPanel1);
            this.PanelPrint.Controls.Add(this.labTitle);
            this.PanelPrint.Location = new System.Drawing.Point(12, 50);
            this.PanelPrint.Name = "PanelPrint";
            this.PanelPrint.Size = new System.Drawing.Size(706, 1100);
            this.PanelPrint.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.labTotalAmount);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(6, 953);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 52);
            this.panel1.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(494, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 24;
            this.label17.Text = "客户签字：";
            // 
            // labTotalAmount
            // 
            this.labTotalAmount.AutoSize = true;
            this.labTotalAmount.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTotalAmount.Location = new System.Drawing.Point(565, 6);
            this.labTotalAmount.Name = "labTotalAmount";
            this.labTotalAmount.Size = new System.Drawing.Size(53, 12);
            this.labTotalAmount.TabIndex = 23;
            this.labTotalAmount.Text = "合计费用";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(494, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 22;
            this.label14.Text = "合计费用：";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labEmail.Location = new System.Drawing.Point(77, 1065);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(29, 12);
            this.labEmail.TabIndex = 20;
            this.labEmail.Text = "邮箱";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(21, 1065);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 19;
            this.label16.Text = "Email：";
            // 
            // labQQ
            // 
            this.labQQ.AutoSize = true;
            this.labQQ.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labQQ.Location = new System.Drawing.Point(403, 1039);
            this.labQQ.Name = "labQQ";
            this.labQQ.Size = new System.Drawing.Size(29, 12);
            this.labQQ.TabIndex = 18;
            this.labQQ.Text = "qq号";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(374, 1039);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 17;
            this.label15.Text = "QQ：";
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPhone.Location = new System.Drawing.Point(77, 1039);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(29, 12);
            this.labPhone.TabIndex = 16;
            this.labPhone.Text = "电话";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(4, 1039);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "联系电话：";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAddress.Location = new System.Drawing.Point(78, 1015);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(65, 12);
            this.labAddress.TabIndex = 14;
            this.labAddress.Text = "店铺地址：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(4, 1015);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "店铺地址：";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 610F));
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labComment, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labCommentTitle, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labRemark, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 647);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(690, 300);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(4, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "备注：";
            // 
            // labComment
            // 
            this.labComment.AutoSize = true;
            this.labComment.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labComment.Location = new System.Drawing.Point(94, 1);
            this.labComment.MaximumSize = new System.Drawing.Size(580, 0);
            this.labComment.Name = "labComment";
            this.labComment.Size = new System.Drawing.Size(53, 12);
            this.labComment.TabIndex = 13;
            this.labComment.Text = "备注信息";
            // 
            // labCommentTitle
            // 
            this.labCommentTitle.AutoSize = true;
            this.labCommentTitle.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCommentTitle.Location = new System.Drawing.Point(4, 1);
            this.labCommentTitle.MaximumSize = new System.Drawing.Size(100, 0);
            this.labCommentTitle.Name = "labCommentTitle";
            this.labCommentTitle.Size = new System.Drawing.Size(65, 12);
            this.labCommentTitle.TabIndex = 12;
            this.labCommentTitle.Text = "备注名称：";
            // 
            // labRemark
            // 
            this.labRemark.AutoSize = true;
            this.labRemark.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRemark.Location = new System.Drawing.Point(94, 209);
            this.labRemark.MaximumSize = new System.Drawing.Size(580, 0);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(29, 12);
            this.labRemark.TabIndex = 14;
            this.labRemark.Text = "备注";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 610F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labGroupName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labGroupContent, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 130);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.83871F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.16129F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(690, 511);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(4, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "套系概述：";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // labGroupName
            // 
            this.labGroupName.AutoSize = true;
            this.labGroupName.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGroupName.Location = new System.Drawing.Point(94, 1);
            this.labGroupName.Name = "labGroupName";
            this.labGroupName.Size = new System.Drawing.Size(77, 12);
            this.labGroupName.TabIndex = 13;
            this.labGroupName.Text = "子套系名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "套系名称：";
            // 
            // labGroupContent
            // 
            this.labGroupContent.AutoSize = true;
            this.labGroupContent.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGroupContent.Location = new System.Drawing.Point(94, 26);
            this.labGroupContent.MaximumSize = new System.Drawing.Size(580, 0);
            this.labGroupContent.Name = "labGroupContent";
            this.labGroupContent.Size = new System.Drawing.Size(60, 20);
            this.labGroupContent.TabIndex = 14;
            this.labGroupContent.Text = "套系详情";
            this.labGroupContent.UseCompatibleTextRendering = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labOrderDate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labOrderPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labNbr, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labCustomerName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labDingJin, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 3);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 87);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // labOrderDate
            // 
            this.labOrderDate.AutoSize = true;
            this.labOrderDate.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOrderDate.Location = new System.Drawing.Point(567, 1);
            this.labOrderDate.Name = "labOrderDate";
            this.labOrderDate.Size = new System.Drawing.Size(53, 12);
            this.labOrderDate.TabIndex = 7;
            this.labOrderDate.Text = "下单时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(495, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "拍摄日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(4, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "订单金额：";
            // 
            // labOrderPrice
            // 
            this.labOrderPrice.AutoSize = true;
            this.labOrderPrice.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOrderPrice.Location = new System.Drawing.Point(94, 45);
            this.labOrderPrice.Name = "labOrderPrice";
            this.labOrderPrice.Size = new System.Drawing.Size(53, 12);
            this.labOrderPrice.TabIndex = 8;
            this.labOrderPrice.Text = "订单金额";
            // 
            // labNbr
            // 
            this.labNbr.AutoSize = true;
            this.labNbr.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNbr.ForeColor = System.Drawing.Color.Black;
            this.labNbr.Location = new System.Drawing.Point(94, 1);
            this.labNbr.Name = "labNbr";
            this.labNbr.Size = new System.Drawing.Size(53, 12);
            this.labNbr.TabIndex = 5;
            this.labNbr.Text = "客户编号";
            // 
            // labCustomerName
            // 
            this.labCustomerName.AutoSize = true;
            this.labCustomerName.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCustomerName.Location = new System.Drawing.Point(94, 23);
            this.labCustomerName.Name = "labCustomerName";
            this.labCustomerName.Size = new System.Drawing.Size(53, 12);
            this.labCustomerName.TabIndex = 6;
            this.labCustomerName.Text = "客户姓名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(4, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "预付定金：";
            // 
            // labDingJin
            // 
            this.labDingJin.AutoSize = true;
            this.labDingJin.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDingJin.Location = new System.Drawing.Point(94, 66);
            this.labDingJin.Name = "labDingJin";
            this.labDingJin.Size = new System.Drawing.Size(53, 12);
            this.labDingJin.TabIndex = 13;
            this.labDingJin.Text = "预付定金";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(495, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "选片日期：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(495, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "取片日期：";
            // 
            // PrintPerview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(748, 865);
            this.Controls.Add(this.PanelPrint);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnPrintSetup);
            this.Name = "PrintPerview";
            this.Text = "PrintPerview";
            this.PanelPrint.ResumeLayout(false);
            this.PanelPrint.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labGroupName;
        private System.Windows.Forms.Label labGroupContent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labDingJin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labComment;
        private System.Windows.Forms.Label labCommentTitle;
        private System.Windows.Forms.Label labRemark;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label labQQ;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labTotalAmount;
        private System.Windows.Forms.Label label17;
    }
}