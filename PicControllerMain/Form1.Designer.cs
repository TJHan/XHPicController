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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCreateOrder = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lvDataList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.编号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.客户姓名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.联系电话 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.添加时间 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.订单数量 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labSetting = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtCreateOrder);
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
            this.groupBox1.Text = "订单数据查询";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(87, 93);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCreateOrder
            // 
            this.txtCreateOrder.Location = new System.Drawing.Point(745, 93);
            this.txtCreateOrder.Name = "txtCreateOrder";
            this.txtCreateOrder.Size = new System.Drawing.Size(75, 23);
            this.txtCreateOrder.TabIndex = 6;
            this.txtCreateOrder.Text = "新建订单";
            this.txtCreateOrder.UseVisualStyleBackColor = true;
            this.txtCreateOrder.Click += new System.EventHandler(this.txtCreateOrder_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "客户姓名：";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(6, 42);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(137, 21);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lvDataList
            // 
            this.lvDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.编号,
            this.客户姓名,
            this.联系电话,
            this.添加时间,
            this.订单数量});
            this.lvDataList.Location = new System.Drawing.Point(6, 122);
            this.lvDataList.Name = "lvDataList";
            this.lvDataList.Size = new System.Drawing.Size(814, 343);
            this.lvDataList.TabIndex = 0;
            this.lvDataList.UseCompatibleStateImageBehavior = false;
            this.lvDataList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // 编号
            // 
            this.编号.Text = "编号";
            this.编号.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 客户姓名
            // 
            this.客户姓名.Text = "客户姓名";
            this.客户姓名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 联系电话
            // 
            this.联系电话.Text = "联系电话";
            // 
            // 添加时间
            // 
            this.添加时间.Text = "添加时间";
            // 
            // 订单数量
            // 
            this.订单数量.Text = "订单数量";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "客户管理";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button txtCreateOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
    }
}

