namespace Gem.Report
{
    partial class previwe2
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
            this.DataSetdaily = new Gem.Report.DataSetdaily();
            this.classdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetdaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classdataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.classdataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gem.Report.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(761, 361);
            this.reportViewer1.TabIndex = 1;
            // 
            // DataSetdaily
            // 
            this.DataSetdaily.DataSetName = "DataSetdaily";
            this.DataSetdaily.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classdataBindingSource
            // 
            this.classdataBindingSource.DataMember = "classdata";
            this.classdataBindingSource.DataSource = this.DataSetdaily;
            // 
            // previwe2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 361);
            this.Controls.Add(this.reportViewer1);
            this.Name = "previwe2";
            this.Text = "previwe2";
            this.Load += new System.EventHandler(this.previwe2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetdaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classdataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource classdataBindingSource;
        private DataSetdaily DataSetdaily;
    }
}