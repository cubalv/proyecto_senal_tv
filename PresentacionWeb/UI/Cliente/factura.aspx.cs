using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReportParameter = Microsoft.Reporting.WebForms.ReportParameter;
using Negociacion;
using System.Data;

namespace PresentacionWeb.UI.Cliente
{
    public partial class factura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //
                facturasNegocios Factura = new facturasNegocios();

                int codigFact = Convert.ToInt32(Comun.Cache.cachePagoFactura.codigo_factura);
                DataTable dt = Factura.datosFactura(codigFact);


                ReportParameter parameter = new ReportParameter();
                parameter.Name = "codigo";
                parameter.Values.Add(dt.Rows[0][0].ToString());
                ReportViewer1.LocalReport.SetParameters(parameter);

                parameter = new ReportParameter();
                parameter.Name = "concepto";
                parameter.Values.Add(dt.Rows[0][1].ToString());
                ReportViewer1.LocalReport.SetParameters(parameter);

                parameter = new ReportParameter();
                parameter.Name = "precio";
                parameter.Values.Add(dt.Rows[0][2].ToString());
                ReportViewer1.LocalReport.SetParameters(parameter);


                parameter = new ReportParameter();
                parameter.Name = "total";
                parameter.Values.Add(dt.Rows[0][3].ToString());

                this.ReportViewer1.LocalReport.SetParameters(parameter);
                this.ReportViewer1.LocalReport.Refresh();
            }
        }
    }
}