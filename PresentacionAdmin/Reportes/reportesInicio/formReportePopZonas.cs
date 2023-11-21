using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionAdmin.Reportes.reportesInicio
{
    public partial class formReportePopZonas : Form
    {
        public formReportePopZonas(string depto,string muni)
        {
            InitializeComponent();


            ReportParameter parameter = new ReportParameter();
            parameter.Name = "Depto";
            parameter.Values.Add(depto);
            reportViewer1.LocalReport.SetParameters(parameter);

            parameter = new ReportParameter();
            parameter.Name = "Muni";
            parameter.Values.Add(muni);
            reportViewer1.LocalReport.SetParameters(parameter);
        }

        public List<reportePorZonasObj> Datos = new List<reportePorZonasObj>();
        private void formReportePopZonas_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Datos));

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
