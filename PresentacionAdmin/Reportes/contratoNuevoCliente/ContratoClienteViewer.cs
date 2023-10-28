using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PresentacionAdmin.Reportes.contratoNuevoCliente
{
    public partial class ContratoClienteViewer : Form
    {
        public ContratoClienteViewer(string NoContrato, string Depto,string Munis, string NombreCliente,string Tel1,string Tel2,string NIT, string Correo,string NombrePlan, string PrecioMens,string DireccionInstalacion, string DireccionCobro)
        {
            InitializeComponent();
            try
            {
                ReportParameter parameter = new ReportParameter();
                parameter.Name = "NoContrato";
                parameter.Values.Add(NoContrato);
                reportViewer1.LocalReport.SetParameters(parameter);

                parameter = new ReportParameter();
                parameter.Name = "Depto";
                parameter.Values.Add(Depto);
                reportViewer1.LocalReport.SetParameters(parameter);

                parameter = new ReportParameter();
                parameter.Name = "Munis";
                parameter.Values.Add(Munis);
                reportViewer1.LocalReport.SetParameters(parameter);
                parameter = new ReportParameter();
                parameter.Name = "Munis";
                parameter.Values.Add(Munis);
                reportViewer1.LocalReport.SetParameters(parameter);

                parameter = new ReportParameter();
                parameter.Name = "NombreCliente";
                parameter.Values.Add(NombreCliente);
                reportViewer1.LocalReport.SetParameters(parameter);

                parameter = new ReportParameter();
                parameter.Name = "Tel2";
                parameter.Values.Add(Tel2);
                reportViewer1.LocalReport.SetParameters(parameter);

                parameter = new ReportParameter();
                parameter.Name = "Tel1";
                parameter.Values.Add(Tel1);
                reportViewer1.LocalReport.SetParameters(parameter);

                parameter = new ReportParameter();
                parameter.Name = "Correo";
                parameter.Values.Add(Correo);
                reportViewer1.LocalReport.SetParameters(parameter);

                parameter = new ReportParameter();
                parameter.Name = "NombrePlan";
                parameter.Values.Add(NombrePlan);
                reportViewer1.LocalReport.SetParameters(parameter);

                parameter = new ReportParameter();
                parameter.Name = "PrecioMens";
                parameter.Values.Add(PrecioMens);
                reportViewer1.LocalReport.SetParameters(parameter);

                parameter = new ReportParameter();
                parameter.Name = "DireccionInstalacion";
                parameter.Values.Add(DireccionInstalacion);
                reportViewer1.LocalReport.SetParameters(parameter);

                parameter = new ReportParameter();
                parameter.Name = "DireccionCobro";
                parameter.Values.Add(DireccionCobro);
                reportViewer1.LocalReport.SetParameters(parameter);

                parameter = new ReportParameter();
                parameter.Name = "NIT";
                parameter.Values.Add(NIT);
                reportViewer1.LocalReport.SetParameters(parameter);

            }
            catch
            {

            }
        }

        private void ContratoClienteViewer_Load(object sender, EventArgs e)
        {

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
