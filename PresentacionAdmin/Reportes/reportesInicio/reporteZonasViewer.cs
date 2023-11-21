using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PresentacionAdmin.Reportes.reportesInicio
{
    public partial class reporteZonasViewer : Form
    {
        public reporteZonasViewer()
        {
            InitializeComponent();
        }
        public List<reportePorZonasObj> Datos = new List<reportePorZonasObj>();
        private void reporteZonasViewer_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",Datos));

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
