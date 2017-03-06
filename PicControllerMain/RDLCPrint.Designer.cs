namespace PicControllerMain
{
    partial class RDLCPrint
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PicStoreDataSet = new PicControllerMain.PicStoreDataSet();
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderTableAdapter = new PicControllerMain.PicStoreDataSetTableAdapters.OrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PicStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OrderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PicControllerMain.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(837, 656);
            this.reportViewer1.TabIndex = 0;
            // 
            // PicStoreDataSet
            // 
            this.PicStoreDataSet.DataSetName = "PicStoreDataSet";
            this.PicStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataMember = "Order";
            this.OrderBindingSource.DataSource = this.PicStoreDataSet;
            // 
            // OrderTableAdapter
            // 
            this.OrderTableAdapter.ClearBeforeFill = true;
            // 
            // RDLCPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 671);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RDLCPrint";
            this.Text = "RDLCPrint";
            this.Load += new System.EventHandler(this.RDLCPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private PicStoreDataSet PicStoreDataSet;
        private PicStoreDataSetTableAdapters.OrderTableAdapter OrderTableAdapter;
    }
}