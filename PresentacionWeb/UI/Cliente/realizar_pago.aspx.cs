using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negociacion;

namespace PresentacionWeb.UI.Cliente
{
    public partial class realizar_pago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Comun.Cache.cachePagoFactura.codigo_factura = null;
                Response.Redirect("Facturas.aspx");
            }
            catch { }
        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                facturasNegocios Factura = new facturasNegocios();

                if (Factura.pagarFactura(Convert.ToInt32(Comun.Cache.cachePagoFactura.codigo_factura)))
                {
                    Response.Redirect("factura.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Ocurrio un error al procesar el pago')</script>");
                }
            }
            catch
            {
            }

        }
    }
}