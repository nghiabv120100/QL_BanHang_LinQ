

namespace QL_BanHang_LinQ
{
    partial class frmReport
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
            this.TheBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QL_BanHang = new QL_BanHang_LinQ.QL_BanHang();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TheBillTableAdapter = new QL_BanHang_LinQ.QL_BanHangTableAdapters.TheBillTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TheBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QL_BanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // TheBillBindingSource
            // 
            this.TheBillBindingSource.DataMember = "TheBill";
            this.TheBillBindingSource.DataSource = this.QL_BanHang;
            // 
            // QL_BanHang
            // 
            this.QL_BanHang.DataSetName = "QL_BanHang";
            this.QL_BanHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TheBillBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_BanHang_LinQ.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(96, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(837, 682);
            this.reportViewer1.TabIndex = 0;
            // 
            // TheBillTableAdapter
            // 
            this.TheBillTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 759);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TheBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QL_BanHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TheBillBindingSource;
        private QL_BanHang QL_BanHang;
        private QL_BanHang_LinQ.QL_BanHangTableAdapters.TheBillTableAdapter TheBillTableAdapter;
    }
}