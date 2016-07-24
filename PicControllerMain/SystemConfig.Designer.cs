﻿namespace PicControllerMain
{
    partial class SystemConfig
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
            this.lvFieldItemList = new System.Windows.Forms.ListView();
            this.LFieldNbr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LFieldName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LFieldDataType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LFieldTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LFieldEdit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlTableList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.ddlFieldType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbItemEdit = new System.Windows.Forms.GroupBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.lvItemList = new System.Windows.Forms.ListView();
            this.lItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IItemOrderNbr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddField = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbItemEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lvFieldItemList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 610);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已添加的字段";
            // 
            // lvFieldItemList
            // 
            this.lvFieldItemList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvFieldItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LFieldNbr,
            this.LFieldName,
            this.LFieldDataType,
            this.LFieldTable,
            this.LFieldEdit});
            this.lvFieldItemList.Location = new System.Drawing.Point(6, 59);
            this.lvFieldItemList.Name = "lvFieldItemList";
            this.lvFieldItemList.Size = new System.Drawing.Size(268, 545);
            this.lvFieldItemList.TabIndex = 1;
            this.lvFieldItemList.UseCompatibleStateImageBehavior = false;
            // 
            // LFieldNbr
            // 
            this.LFieldNbr.Text = "编号";
            // 
            // LFieldName
            // 
            this.LFieldName.Text = "名字";
            // 
            // LFieldDataType
            // 
            this.LFieldDataType.Text = "数据类型";
            // 
            // LFieldTable
            // 
            this.LFieldTable.Text = "所属分类";
            // 
            // LFieldEdit
            // 
            this.LFieldEdit.Text = "操作";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(298, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 610);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "字段详情";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddField);
            this.groupBox3.Controls.Add(this.gbItemEdit);
            this.groupBox3.Controls.Add(this.ddlFieldType);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtFieldName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ddlTableList);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(688, 426);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "新建字段";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "所属分类：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ddlTableList
            // 
            this.ddlTableList.FormattingEnabled = true;
            this.ddlTableList.Items.AddRange(new object[] {
            "客户",
            "订单"});
            this.ddlTableList.Location = new System.Drawing.Point(134, 32);
            this.ddlTableList.Name = "ddlTableList";
            this.ddlTableList.Size = new System.Drawing.Size(184, 20);
            this.ddlTableList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "字段名：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(135, 59);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(183, 21);
            this.txtFieldName.TabIndex = 3;
            // 
            // ddlFieldType
            // 
            this.ddlFieldType.FormattingEnabled = true;
            this.ddlFieldType.Location = new System.Drawing.Point(135, 86);
            this.ddlFieldType.Name = "ddlFieldType";
            this.ddlFieldType.Size = new System.Drawing.Size(184, 20);
            this.ddlFieldType.TabIndex = 5;
            this.ddlFieldType.SelectedIndexChanged += new System.EventHandler(this.ddlFieldType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "字段类型：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbItemEdit
            // 
            this.gbItemEdit.Controls.Add(this.lvItemList);
            this.gbItemEdit.Controls.Add(this.btnItemAdd);
            this.gbItemEdit.Controls.Add(this.txtItemName);
            this.gbItemEdit.Location = new System.Drawing.Point(408, 20);
            this.gbItemEdit.Name = "gbItemEdit";
            this.gbItemEdit.Size = new System.Drawing.Size(274, 281);
            this.gbItemEdit.TabIndex = 6;
            this.gbItemEdit.TabStop = false;
            this.gbItemEdit.Text = "选项编辑";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(7, 247);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(167, 21);
            this.txtItemName.TabIndex = 3;
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Location = new System.Drawing.Point(181, 247);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(75, 23);
            this.btnItemAdd.TabIndex = 4;
            this.btnItemAdd.Text = "添加";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            // 
            // lvItemList
            // 
            this.lvItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lItemName,
            this.IItemOrderNbr,
            this.columnHeader1});
            this.lvItemList.Location = new System.Drawing.Point(7, 21);
            this.lvItemList.Name = "lvItemList";
            this.lvItemList.Size = new System.Drawing.Size(261, 220);
            this.lvItemList.TabIndex = 5;
            this.lvItemList.UseCompatibleStateImageBehavior = false;
            // 
            // lItemName
            // 
            this.lItemName.Text = "选项名称";
            // 
            // IItemOrderNbr
            // 
            this.IItemOrderNbr.Text = "选项排序号";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "操作";
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(65, 397);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(75, 23);
            this.btnAddField.TabIndex = 7;
            this.btnAddField.Text = "保存";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // SystemConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SystemConfig";
            this.Text = "系统字段配置页面";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbItemEdit.ResumeLayout(false);
            this.gbItemEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvFieldItemList;
        private System.Windows.Forms.ColumnHeader LFieldNbr;
        private System.Windows.Forms.ColumnHeader LFieldName;
        private System.Windows.Forms.ColumnHeader LFieldDataType;
        private System.Windows.Forms.ColumnHeader LFieldTable;
        private System.Windows.Forms.ColumnHeader LFieldEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlTableList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.ComboBox ddlFieldType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbItemEdit;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.ListView lvItemList;
        private System.Windows.Forms.ColumnHeader lItemName;
        private System.Windows.Forms.ColumnHeader IItemOrderNbr;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnAddField;

    }
}