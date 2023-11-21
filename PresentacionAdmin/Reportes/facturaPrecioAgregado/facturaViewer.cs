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

namespace PresentacionAdmin.Reportes.facturaPrecioAgregado
{
    public partial class facturaViewer : Form
    {
        public facturaViewer(string codigo,string concepto,string precio,string total)
        {
            InitializeComponent();

            try
            {

                ReportParameter parameter = new ReportParameter();
                parameter.Name = "codigo";
                parameter.Values.Add(codigo);
                reportViewer1.LocalReport.SetParameters(parameter);

                parameter = new ReportParameter();
                parameter.Name = "concepto";
                parameter.Values.Add(concepto);
                reportViewer1.LocalReport.SetParameters(parameter);

                parameter = new ReportParameter();
                parameter.Name = "precio";
                parameter.Values.Add(precio);
                reportViewer1.LocalReport.SetParameters(parameter);


                parameter = new ReportParameter();
                parameter.Name = "total";
                parameter.Values.Add(total);
                reportViewer1.LocalReport.SetParameters(parameter);
            }
            catch { }

        }

        private void facturaViewer_Load(object sender, EventArgs e)
        {
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
