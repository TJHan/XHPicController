namespace PicControllerMain
{
    partial class OrderEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdvanceAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYuKuan = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PanelOrderStatus = new System.Windows.Forms.Panel();
            this.ddlOrderStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PanelCustomSelect = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lvCustomerList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCreateDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PanelCustomFieldList = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMainGroup = new System.Windows.Forms.ComboBox();
            this.cbSubGroup = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGroupContent = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.PanelOrderStatus.SuspendLayout();
            this.PanelCustomSelect.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户名：";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Location = new System.Drawing.Point(96, 88);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(192, 21);
            this.txtCustomer.TabIndex = 1;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.Location = new System.Drawing.Point(98, 13);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(104, 19);
            this.labTitle.TabIndex = 2;
            this.labTitle.Text = "创建新订单";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "下单时间：";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(96, 150);
            this.txtTotalAmount.MaxLength = 11;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(192, 21);
            this.txtTotalAmount.TabIndex = 6;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "订单总金额：";
            // 
            // txtAdvanceAmount
            // 
            this.txtAdvanceAmount.Location = new System.Drawing.Point(96, 179);
            this.txtAdvanceAmount.MaxLength = 11;
            this.txtAdvanceAmount.Name = "txtAdvanceAmount";
            this.txtAdvanceAmount.Size = new System.Drawing.Size(192, 21);
            this.txtAdvanceAmount.TabIndex = 8;
            this.txtAdvanceAmount.TextChanged += new System.EventHandler(this.txtAdvanceAmount_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "预付定金：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "余款：";
            // 
            // txtYuKuan
            // 
            this.txtYuKuan.Enabled = false;
            this.txtYuKuan.Location = new System.Drawing.Point(96, 210);
            this.txtYuKuan.Name = "txtYuKuan";
            this.txtYuKuan.Size = new System.Drawing.Size(192, 21);
            this.txtYuKuan.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(39, 763);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "创建";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtGroupContent);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbSubGroup);
            this.groupBox1.Controls.Add(this.cbMainGroup);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.PanelOrderStatus);
            this.groupBox1.Controls.Add(this.PanelCustomSelect);
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
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单基础数据";
            // 
            // PanelOrderStatus
            // 
            this.PanelOrderStatus.Controls.Add(this.ddlOrderStatus);
            this.PanelOrderStatus.Controls.Add(this.label10);
            this.PanelOrderStatus.Location = new System.Drawing.Point(6, 237);
            this.PanelOrderStatus.Name = "PanelOrderStatus";
            this.PanelOrderStatus.Size = new System.Drawing.Size(282, 43);
            this.PanelOrderStatus.TabIndex = 22;
            // 
            // ddlOrderStatus
            // 
            this.ddlOrderStatus.FormattingEnabled = true;
            this.ddlOrderStatus.Location = new System.Drawing.Point(92, 11);
            this.ddlOrderStatus.Name = "ddlOrderStatus";
            this.ddlOrderStatus.Size = new System.Drawing.Size(187, 20);
            this.ddlOrderStatus.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "订单状态：";
            // 
            // PanelCustomSelect
            // 
            this.PanelCustomSelect.Controls.Add(this.label9);
            this.PanelCustomSelect.Controls.Add(this.lvCustomerList);
            this.PanelCustomSelect.Controls.Add(this.btnSearch);
            this.PanelCustomSelect.Controls.Add(this.label6);
            this.PanelCustomSelect.Controls.Add(this.txtSearch);
            this.PanelCustomSelect.Location = new System.Drawing.Point(294, 9);
            this.PanelCustomSelect.Name = "PanelCustomSelect";
            this.PanelCustomSelect.Size = new System.Drawing.Size(446, 271);
            this.PanelCustomSelect.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(5, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(377, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "【注：双击上面的客户条目即可选中客户到左边客户名和客户ID栏里】";
            // 
            // lvCustomerList
            // 
            this.lvCustomerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.lvCustomerList.FullRowSelect = true;
            this.lvCustomerList.HideSelection = false;
            this.lvCustomerList.Location = new System.Drawing.Point(7, 48);
            this.lvCustomerList.Name = "lvCustomerList";
            this.lvCustomerList.Size = new System.Drawing.Size(429, 177);
            this.lvCustomerList.TabIndex = 12;
            this.lvCustomerList.UseCompatibleStateImageBehavior = false;
            this.lvCustomerList.View = System.Windows.Forms.View.Details;
            this.lvCustomerList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvCustomerList_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 8;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "客户";
            this.columnHeader2.Width = 291;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(356, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "客户筛选条件：";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(132, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(218, 21);
            this.txtSearch.TabIndex = 13;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(96, 286);
            this.txtComment.MaxLength = 5000;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(580, 55);
            this.txtComment.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "备注：";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(98, 118);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(190, 21);
            this.txtCreateDate.TabIndex = 18;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(98, 57);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(192, 21);
            this.txtCustomerID.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "客户ID：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PanelCustomFieldList);
            this.groupBox2.Location = new System.Drawing.Point(12, 556);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 201);
            this.groupBox2.TabIndex = 13;
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(677, 763);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "结单";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(596, 763);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "打印订单";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "选择套系：";
            // 
            // cbMainGroup
            // 
            this.cbMainGroup.DisplayMember = "GroupName";
            this.cbMainGroup.FormattingEnabled = true;
            this.cbMainGroup.Location = new System.Drawing.Point(96, 347);
            this.cbMainGroup.Name = "cbMainGroup";
            this.cbMainGroup.Size = new System.Drawing.Size(166, 20);
            this.cbMainGroup.TabIndex = 24;
            this.cbMainGroup.ValueMember = "MainGroupID";
            this.cbMainGroup.SelectedIndexChanged += new System.EventHandler(this.cbMainGroup_SelectedIndexChanged);
            // 
            // cbSubGroup
            // 
            this.cbSubGroup.DisplayMember = "GroupName";
            this.cbSubGroup.FormattingEnabled = true;
            this.cbSubGroup.Location = new System.Drawing.Point(327, 347);
            this.cbSubGroup.Name = "cbSubGroup";
            this.cbSubGroup.Size = new System.Drawing.Size(144, 20);
            this.cbSubGroup.TabIndex = 25;
            this.cbSubGroup.ValueMember = "SubGroupID";
            this.cbSubGroup.SelectedIndexChanged += new System.EventHandler(this.cbSubGroup_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(268, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "子套系：";
            // 
            // txtGroupContent
            // 
            this.txtGroupContent.Location = new System.Drawing.Point(96, 373);
            this.txtGroupContent.MaxLength = 5000;
            this.txtGroupContent.Multiline = true;
            this.txtGroupContent.Name = "txtGroupContent";
            this.txtGroupContent.Size = new System.Drawing.Size(580, 124);
            this.txtGroupContent.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 376);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 28;
            this.label13.Text = "套系详情：";
            // 
            // OrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 798);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labTitle);
            this.Name = "OrderEdit";
            this.Text = "订单编辑";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelOrderStatus.ResumeLayout(false);
            this.PanelOrderStatus.PerformLayout();
            this.PanelCustomSelect.ResumeLayout(false);
            this.PanelCustomSelect.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdvanceAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYuKuan;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvCustomerList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.DateTimePicker txtCreateDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel PanelCustomFieldList;
        private System.Windows.Forms.Panel PanelCustomSelect;
        private System.Windows.Forms.Panel PanelOrderStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ddlOrderStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMainGroup;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbSubGroup;
        private System.Windows.Forms.TextBox txtGroupContent;
        private System.Windows.Forms.Label label13;
    }
}