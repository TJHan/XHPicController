namespace PicControllerMain
{
    partial class GroupIndex
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
            this.btnDeleteMainGroup = new System.Windows.Forms.Button();
            this.btnMainCancel = new System.Windows.Forms.Button();
            this.btnSaveMainGroup = new System.Windows.Forms.Button();
            this.txtMainGroupName = new System.Windows.Forms.TextBox();
            this.lbMainGroup = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteSubGroup = new System.Windows.Forms.Button();
            this.btnSubCancel = new System.Windows.Forms.Button();
            this.btnSaveSubGroup = new System.Windows.Forms.Button();
            this.txtSubGroupName = new System.Windows.Forms.TextBox();
            this.lbSubGroup = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteMainGroup);
            this.groupBox1.Controls.Add(this.btnMainCancel);
            this.groupBox1.Controls.Add(this.btnSaveMainGroup);
            this.groupBox1.Controls.Add(this.txtMainGroupName);
            this.groupBox1.Controls.Add(this.lbMainGroup);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 546);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "一级主套系";
            // 
            // btnDeleteMainGroup
            // 
            this.btnDeleteMainGroup.Location = new System.Drawing.Point(139, 478);
            this.btnDeleteMainGroup.Name = "btnDeleteMainGroup";
            this.btnDeleteMainGroup.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMainGroup.TabIndex = 4;
            this.btnDeleteMainGroup.Text = "删除";
            this.btnDeleteMainGroup.UseVisualStyleBackColor = true;
            this.btnDeleteMainGroup.Click += new System.EventHandler(this.btnDeleteMainGroup_Click);
            // 
            // btnMainCancel
            // 
            this.btnMainCancel.Location = new System.Drawing.Point(139, 502);
            this.btnMainCancel.Name = "btnMainCancel";
            this.btnMainCancel.Size = new System.Drawing.Size(75, 23);
            this.btnMainCancel.TabIndex = 3;
            this.btnMainCancel.Text = "取消选择";
            this.btnMainCancel.UseVisualStyleBackColor = true;
            this.btnMainCancel.Click += new System.EventHandler(this.btnMainCancel_Click);
            // 
            // btnSaveMainGroup
            // 
            this.btnSaveMainGroup.Location = new System.Drawing.Point(139, 453);
            this.btnSaveMainGroup.Name = "btnSaveMainGroup";
            this.btnSaveMainGroup.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMainGroup.TabIndex = 2;
            this.btnSaveMainGroup.Text = "保存";
            this.btnSaveMainGroup.UseVisualStyleBackColor = true;
            this.btnSaveMainGroup.Click += new System.EventHandler(this.btnSaveMainGroup_Click);
            // 
            // txtMainGroupName
            // 
            this.txtMainGroupName.Location = new System.Drawing.Point(6, 455);
            this.txtMainGroupName.MaxLength = 100;
            this.txtMainGroupName.Name = "txtMainGroupName";
            this.txtMainGroupName.Size = new System.Drawing.Size(126, 21);
            this.txtMainGroupName.TabIndex = 1;
            // 
            // lbMainGroup
            // 
            this.lbMainGroup.DisplayMember = "GroupName";
            this.lbMainGroup.FormattingEnabled = true;
            this.lbMainGroup.ItemHeight = 12;
            this.lbMainGroup.Location = new System.Drawing.Point(6, 20);
            this.lbMainGroup.Name = "lbMainGroup";
            this.lbMainGroup.Size = new System.Drawing.Size(208, 424);
            this.lbMainGroup.TabIndex = 0;
            this.lbMainGroup.ValueMember = "MainGroupID";
            this.lbMainGroup.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbMainGroup_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteSubGroup);
            this.groupBox2.Controls.Add(this.btnSubCancel);
            this.groupBox2.Controls.Add(this.btnSaveSubGroup);
            this.groupBox2.Controls.Add(this.txtSubGroupName);
            this.groupBox2.Controls.Add(this.lbSubGroup);
            this.groupBox2.Location = new System.Drawing.Point(238, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 546);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "二级套系";
            // 
            // btnDeleteSubGroup
            // 
            this.btnDeleteSubGroup.Location = new System.Drawing.Point(138, 478);
            this.btnDeleteSubGroup.Name = "btnDeleteSubGroup";
            this.btnDeleteSubGroup.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSubGroup.TabIndex = 5;
            this.btnDeleteSubGroup.Text = "删除";
            this.btnDeleteSubGroup.UseVisualStyleBackColor = true;
            // 
            // btnSubCancel
            // 
            this.btnSubCancel.Location = new System.Drawing.Point(139, 502);
            this.btnSubCancel.Name = "btnSubCancel";
            this.btnSubCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSubCancel.TabIndex = 4;
            this.btnSubCancel.Text = "取消选择";
            this.btnSubCancel.UseVisualStyleBackColor = true;
            this.btnSubCancel.Click += new System.EventHandler(this.btnSubCancel_Click);
            // 
            // btnSaveSubGroup
            // 
            this.btnSaveSubGroup.Location = new System.Drawing.Point(139, 453);
            this.btnSaveSubGroup.Name = "btnSaveSubGroup";
            this.btnSaveSubGroup.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSubGroup.TabIndex = 4;
            this.btnSaveSubGroup.Text = "保存";
            this.btnSaveSubGroup.UseVisualStyleBackColor = true;
            this.btnSaveSubGroup.Click += new System.EventHandler(this.btnSaveSubGroup_Click);
            // 
            // txtSubGroupName
            // 
            this.txtSubGroupName.Location = new System.Drawing.Point(6, 455);
            this.txtSubGroupName.MaxLength = 100;
            this.txtSubGroupName.Name = "txtSubGroupName";
            this.txtSubGroupName.Size = new System.Drawing.Size(126, 21);
            this.txtSubGroupName.TabIndex = 3;
            // 
            // lbSubGroup
            // 
            this.lbSubGroup.DisplayMember = "GroupName";
            this.lbSubGroup.FormattingEnabled = true;
            this.lbSubGroup.ItemHeight = 12;
            this.lbSubGroup.Location = new System.Drawing.Point(6, 20);
            this.lbSubGroup.Name = "lbSubGroup";
            this.lbSubGroup.Size = new System.Drawing.Size(208, 424);
            this.lbSubGroup.TabIndex = 3;
            this.lbSubGroup.ValueMember = "SubGroupID";
            this.lbSubGroup.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSubGroup_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveInfo);
            this.groupBox3.Controls.Add(this.txtInfo);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(464, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 546);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "套系详情";
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Location = new System.Drawing.Point(519, 482);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSaveInfo.TabIndex = 2;
            this.btnSaveInfo.Text = "保存";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(6, 35);
            this.txtInfo.MaxLength = 20000;
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(588, 441);
            this.txtInfo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "套系详情：";
            // 
            // GroupIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 595);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GroupIndex";
            this.Text = "套系管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbMainGroup;
        private System.Windows.Forms.TextBox txtMainGroupName;
        private System.Windows.Forms.Button btnSaveMainGroup;
        private System.Windows.Forms.ListBox lbSubGroup;
        private System.Windows.Forms.Button btnSaveSubGroup;
        private System.Windows.Forms.TextBox txtSubGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.Button btnMainCancel;
        private System.Windows.Forms.Button btnSubCancel;
        private System.Windows.Forms.Button btnDeleteMainGroup;
        private System.Windows.Forms.Button btnDeleteSubGroup;
    }
}