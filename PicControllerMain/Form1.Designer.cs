namespace PicControllerMain
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labSetting = new System.Windows.Forms.Label();
            this.lvDataList = new System.Windows.Forms.ListView();
            this.编号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.客户姓名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.联系电话 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.添加时间 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.订单数量 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.编辑 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCreateCustomer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCreateCustomer);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.lvDataList);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据查询";
            // 
            // labSetting
            // 
            this.labSetting.AutoSize = true;
            this.labSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labSetting.Location = new System.Drawing.Point(12, 9);
            this.labSetting.Name = "labSetting";
            this.labSetting.Size = new System.Drawing.Size(53, 12);
            this.labSetting.TabIndex = 0;
            this.labSetting.Text = "系统设置";
            this.labSetting.Click += new System.EventHandler(this.labSetting_Click);
            // 
            // lvDataList
            // 
            this.lvDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.编号,
            this.客户姓名,
            this.联系电话,
            this.添加时间,
            this.订单数量,
            this.编辑});
            this.lvDataList.Location = new System.Drawing.Point(6, 122);
            this.lvDataList.Name = "lvDataList";
            this.lvDataList.Size = new System.Drawing.Size(814, 343);
            this.lvDataList.TabIndex = 0;
            this.lvDataList.UseCompatibleStateImageBehavior = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(6, 42);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(137, 21);
            this.txtCustomerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "客户姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "联系电话：";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(163, 42);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(137, 21);
            this.txtPhone.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtCreateCustomer
            // 
            this.txtCreateCustomer.Location = new System.Drawing.Point(87, 93);
            this.txtCreateCustomer.Name = "txtCreateCustomer";
            this.txtCreateCustomer.Size = new System.Drawing.Size(75, 23);
            this.txtCreateCustomer.TabIndex = 6;
            this.txtCreateCustomer.Text = "新建客户";
            this.txtCreateCustomer.UseVisualStyleBackColor = true;
            this.txtCreateCustomer.Click += new System.EventHandler(this.txtCreateCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.labSetting);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "俺家客户信息管理平台";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labSetting;
        private System.Windows.Forms.ListView lvDataList;
        private System.Windows.Forms.ColumnHeader 编号;
        private System.Windows.Forms.ColumnHeader 客户姓名;
        private System.Windows.Forms.ColumnHeader 联系电话;
        private System.Windows.Forms.ColumnHeader 添加时间;
        private System.Windows.Forms.ColumnHeader 订单数量;
        private System.Windows.Forms.ColumnHeader 编辑;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button txtCreateCustomer;


    }
}

