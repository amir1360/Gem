namespace Gem.Report
{
    partial class prewiwe
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
            this.dailydataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetdaily = new Gem.Report.DataSetdaily();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dailydataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetdaily)).BeginInit();
            this.SuspendLayout();
            // 
            // dailydataBindingSource
            // 
            this.dailydataBindingSource.DataMember = "dailydata";
            this.dailydataBindingSource.DataSource = this.DataSetdaily;
            // 
            // DataSetdaily
            // 
            this.DataSetdaily.DataSetName = "DataSetdaily";
            this.DataSetdaily.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dailydataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gem.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(741, 443);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // prewiwe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 443);
            this.Controls.Add(this.reportViewer1);
            this.Name = "prewiwe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "prewiwe";
            this.Load += new System.EventHandler(this.prewiwe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dailydataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetdaily)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dailydataBindingSource;
        private DataSetdaily DataSetdaily;
    }
}