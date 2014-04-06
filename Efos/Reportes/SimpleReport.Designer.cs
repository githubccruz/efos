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
            //this.DataSetPersona = new Efos.Reportes.DataSetPersona();
            this.reportObject = new Microsoft.Reporting.WinForms.ReportViewer();
            //this.DataTable1TableAdapter = new Efos.Reportes.DataSetPersonaTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.DataSetPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            //this.DataTable1BindingSource.DataSource = this.DataSetPersona;
            // 
            // DataSetPersona
            // 
            //this.DataSetPersona.DataSetName = "DataSetPersona";
            //this.DataSetPersona.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportObject
            // 
            this.reportObject.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReportPersona";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportObject.LocalReport.DataSources.Add(reportDataSource1);
            this.reportObject.LocalReport.ReportEmbeddedResource = "Efos.Reportes.Report1.rdlc";
            this.reportObject.Location = new System.Drawing.Point(0, 0);
            this.reportObject.Name = "reportObject";
            this.reportObject.Size = new System.Drawing.Size(674, 430);
            this.reportObject.TabIndex = 0;
            // 
            // DataTable1TableAdapter
            // 
            //this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // SimpleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 430);
            this.Controls.Add(this.reportObject);
            this.Name = "SimpleReport";
            this.Text = "SimpleReport";
            this.Load += new System.EventHandler(this.SimpleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.DataSetPersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportObject;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        //private DataSetPersona DataSetPersona;
        //private DataSetPersonaTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;

    }
}