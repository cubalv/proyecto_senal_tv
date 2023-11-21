using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negociacion;

namespace PresentacionWeb.UI.Cliente
{
    public partial class Facturas : System.Web.UI.Page
    {
        facturasNegocios Factura = new facturasNegocios();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarGrid();
            }
        }
        private void llenarGrid()
        {
            grid1.DataSource = Factura.listadoFacturas(Comun.Cache.cacheLoginWeb.dpi_usuario);
            grid1.DataBind();
        }

        protected void grid1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow rw = grid1.SelectedRow;
                lblCodigo.Text = rw.Cells[1].Text;
                tbDireccion.Text = rw.Cells[2].Text;
                tbMonto.Text = $" Q. {rw.Cells[4].Text}";
                tbMora.Text = $" Q. {rw.Cells[5].Text}";
                tbTotal.Text = $" Q. {rw.Cells[6].Text}";
            }
            catch { }
        }
        protected void btnCancelar_click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            try
            {

                lblCodigo.Text = "0";
                tbDireccion.Text = "";
                tbMonto.Text = $"";
                tbMora.Text = $"";
                tbTotal.Text = $"";
            }
            catch
            {
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (!lblCodigo.Text.Equals("0"))
            {
                Comun.Cache.cachePagoFactura.codigo_factura = lblCodigo.Text;
                Session["idFactura"] = lblCodigo.Text;
                Response.Redirect("realizar_pago.aspx");
            }
            else
            {
                Response.Write("<script>alert('Por favor seleccione una factura')</script>");
            }
        }
    }
}