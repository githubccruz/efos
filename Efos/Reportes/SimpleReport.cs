using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Efos.Reportes
{
    public partial class SimpleReport : Form
    {
        public SimpleReport()
        {
            InitializeComponent();
        }

        private void SimpleReport_Load(object sender, EventArgs e)
        {
            var result = PostgreSql.Execute("SELECT numeortr FROM orden_trabajo_encabezado");
            ShowReport(result, "ReportOrdenTrabajo");
        }

        public void ShowReport(DataTable dataTable, string nombreReporte)
        {
            nombreReporte = @"..\..\Reportes\" + nombreReporte+".rdlc";            
            var dataSetReport = new ReportDataSource("DataSet",dataTable);
            reportObject.Reset();
            reportObject.LocalReport.ReportPath = nombreReporte;
            reportObject.LocalReport.DataSources.Clear();
            reportObject.LocalReport.DataSources.Add(dataSetReport);
            reportObject.LocalReport.Refresh();
            reportObject.RefreshReport();

        }
    }
}
