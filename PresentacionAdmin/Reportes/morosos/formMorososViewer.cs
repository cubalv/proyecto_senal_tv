using Microsoft.Reporting.WinForms;
using PresentacionAdmin.Reportes.reportesInicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionAdmin.Reportes.morosos
{
    public partial class formMorososViewer : Form
    {
        public List<morososObj> Datos = new List<morososObj>();
        public formMorososViewer()
        {
            InitializeComponent();
        }
        private void formMorososViewer_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Datos));

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
