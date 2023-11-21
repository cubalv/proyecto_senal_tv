using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negociacion;
using Comun;

namespace PresentacionWeb.UI.Tecnico
{
    public partial class Misiones : System.Web.UI.Page
    {
        misionesNegocios Mision = new misionesNegocios();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid1.DataSource = Mision.listadoMisiones(Comun.Cache.cacheLoginWeb.dpi_usuario);
                grid1.DataBind();
            }
        }

        protected void grid1_SelectedIndexChanged(object sender, EventArgs e)
        {

            GridViewRow rw = grid1.SelectedRow;
            if (rw != null)
            {
                lblCodigo.Text = rw.Cells[1].Text;
                tbconcepto.Text = rw.Cells[2].Text;
            }
        }

        protected void btnImprimir_Click1(object sender, EventArgs e)
        {
            if (lblCodigo.Text.Equals("0"))
            {
                Response.Write("<script>alert('Por favor seleccione una mision para imprimir sus detalles.')</script>");
            }
        }
        protected void btnImprimirDetalle_click(object sender, EventArgs e)
        {
            if (lblCodigo.Text == "0")
            {
                Response.Write("<script>alert('Por favor seleccione una mision.')</script>");
            }
            else
            {
                if (Mision.completarMision(Convert.ToInt32(lblCodigo.Text)))
                {
                    grid1.DataSource = Mision.listadoMisiones(Comun.Cache.cacheLoginWeb.dpi_usuario);
                    grid1.DataBind();
                    Response.Write("<script>alert('Mision completada exitosamente.')</script>");

                }
            }
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            grid1.SelectedIndex = -1;
            lblCodigo.Text = "0";
            tbconcepto.Text = "";
        }
    }
}