namespace PicControllerMain
{
    partial class OrderDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGroupContent = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ddlOrderStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCreateDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtYuKuan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdvanceAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.txtMainGroup = new System.Windows.Forms.TextBox();
            this.txtSubGroup = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PanelCustomFieldList = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSubGroup);
            this.groupBox1.Controls.Add(this.txtMainGroup);
            this.groupBox1.Controls.Add(this.ddlOrderStatus);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtGroupContent);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCreateDate);
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCustomer);
            this.groupBox1.Controls.Add(this.txtYuKuan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAdvanceAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTotalAmount);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 503);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单基础数据";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 28;
            this.label13.Text = "套系详情：";
            // 
            // txtGroupContent
            // 
            this.txtGroupContent.Location = new System.Drawing.Point(83, 255);
            this.txtGroupContent.MaxLength = 5000;
            this.txtGroupContent.Multiline = true;
            this.txtGroupContent.Name = "txtGroupContent";
            this.txtGroupContent.Size = new System.Drawing.Size(593, 253);
            this.txtGroupContent.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "子套系：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "选择套系：";
            // 
            // ddlOrderStatus
            // 
            this.ddlOrderStatus.FormattingEnabled = true;
            this.ddlOrderStatus.Location = new System.Drawing.Point(484, 112);
            this.ddlOrderStatus.Name = "ddlOrderStatus";
            this.ddlOrderStatus.Size = new System.Drawing.Size(192, 20);
            this.ddlOrderStatus.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "订单状态：";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(84, 157);
            this.txtComment.MaxLength = 5000;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(592, 55);
            this.txtComment.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "备注：";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(84, 109);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(190, 21);
            this.txtCreateDate.TabIndex = 18;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(84, 28);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(193, 21);
            this.txtCustomerID.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "客户ID：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户名：";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Location = new System.Drawing.Point(484, 28);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(192, 21);
            this.txtCustomer.TabIndex = 1;
            // 
            // txtYuKuan
            // 
            this.txtYuKuan.Enabled = false;
            this.txtYuKuan.Location = new System.Drawing.Point(85, 82);
            this.txtYuKuan.Name = "txtYuKuan";
            this.txtYuKuan.Size = new System.Drawing.Size(192, 21);
            this.txtYuKuan.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "下单时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "余款：";
            // 
            // txtAdvanceAmount
            // 
            this.txtAdvanceAmount.Location = new System.Drawing.Point(484, 55);
            this.txtAdvanceAmount.MaxLength = 11;
            this.txtAdvanceAmount.Name = "txtAdvanceAmount";
            this.txtAdvanceAmount.Size = new System.Drawing.Size(192, 21);
            this.txtAdvanceAmount.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "订单总金额：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "预付定金：";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(85, 55);
            this.txtTotalAmount.MaxLength = 11;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(192, 21);
            this.txtTotalAmount.TabIndex = 6;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.Location = new System.Drawing.Point(93, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(85, 19);
            this.labTitle.TabIndex = 14;
            this.labTitle.Text = "订单详情";
            // 
            // txtMainGroup
            // 
            this.txtMainGroup.Enabled = false;
            this.txtMainGroup.Location = new System.Drawing.Point(84, 221);
            this.txtMainGroup.Name = "txtMainGroup";
            this.txtMainGroup.Size = new System.Drawing.Size(193, 21);
            this.txtMainGroup.TabIndex = 29;
            // 
            // txtSubGroup
            // 
            this.txtSubGroup.Enabled = false;
            this.txtSubGroup.Location = new System.Drawing.Point(342, 221);
            this.txtSubGroup.Name = "txtSubGroup";
            this.txtSubGroup.Size = new System.Drawing.Size(193, 21);
            this.txtSubGroup.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PanelCustomFieldList);
            this.groupBox2.Location = new System.Drawing.Point(12, 561);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 201);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自定义字段";
            // 
            // PanelCustomFieldList
            // 
            this.PanelCustomFieldList.AutoScroll = true;
            this.PanelCustomFieldList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCustomFieldList.Location = new System.Drawing.Point(6, 20);
            this.PanelCustomFieldList.Name = "PanelCustomFieldList";
            this.PanelCustomFieldList.Size = new System.Drawing.Size(734, 175);
            this.PanelCustomFieldList.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(596, 768);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "打印订单";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(677, 768);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "结单";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 768);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "保存修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 798);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGroupContent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ddlOrderStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtCreateDate;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtYuKuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdvanceAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.TextBox txtMainGroup;
        private System.Windows.Forms.TextBox txtSubGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel PanelCustomFieldList;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}