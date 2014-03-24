namespace Efos.Reportes
{
    partial class SimpleReport
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPersona = new Efos.Reportes.DataSetPersona();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new Efos.Reportes.DataSetPersonaTableAdapters.DataTable1TableAdapter();
            this.efosButton1 = new ControlesEfos.efosButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSetPersona;
            // 
            // DataSetPersona
            // 
            this.DataSetPersona.DataSetName = "DataSetPersona";
            this.DataSetPersona.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetReportPersona";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Efos.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(674, 329);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // efosButton1
            // 
            this.efosButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.efosButton1.Location = new System.Drawing.Point(145, 12);
            this.efosButton1.Name = "efosButton1";
            this.efosButton1.Size = new System.Drawing.Size(75, 50);
            this.efosButton1.TabIndex = 1;
            this.efosButton1.Text = "efosButton1";
            this.efosButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.efosButton1.UseVisualStyleBackColor = true;
            this.efosButton1.Click += new System.EventHandler(this.efosButton1_Click);
            // 
            // SimpleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 430);
            this.Controls.Add(this.efosButton1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SimpleReport";
            this.Text = "SimpleReport";
            this.Load += new System.EventHandler(this.SimpleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSetPersona DataSetPersona;
        private DataSetPersonaTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private ControlesEfos.efosButton efosButton1;

    }
}