using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negociacion;

namespace PresentacionWeb.UI.Cliente
{
    public partial class servicios : System.Web.UI.Page
    {
        contratoClienteNegocios Contratos = new contratoClienteNegocios();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string dpi = Comun.Cache.cacheLoginWeb.dpi_usuario;
                grid1.DataSource = Contratos.listadoContratosCliente(dpi);
                grid1.DataBind();
            }
        }

        protected void grid1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow rw = grid1.SelectedRow;
                if (rw != null)
                {
                    lblCodigo.Text = rw.Cells[1].Text;
                    tbPlan.Text = rw.Cells[3].Text;
                    tbFechaContratacion.Text = rw.Cells[2].Text;
                    tbDireccion.Text = rw.Cells[4].Text;
                    tbDetalle.Text = rw.Cells[5].Text;
                }
            }
            catch{

            }
        }

        protected void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            if (lblCodigo.Text.Equals("0"))
            {
                Response.Write("<script language=javascript>alert('Seleccione un servicio por favor');</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('El servicio se ha dado de baja');</script>");

                string dpi = Comun.Cache.cacheLoginWeb.dpi_usuario;
                grid1.DataSource = Contratos.listadoContratosCliente(dpi);
                grid1.DataBind();
            }
        }

        protected void btnReportarError_Click(object sender, EventArgs e)
        {
            if (lblCodigo.Text.Equals("0"))
            {
                Response.Write("<script language=javascript>alert('Seleccione un servicio por favor');</script>");
            }
            else
            {
                int codigo = Convert.ToInt32(lblCodigo.Text);
                if (Contratos.agregarMisionPorPlan(codigo))
                {
                    Response.Write("<script language=javascript>alert('La revision ha sido programada, un tecnico se pondra en contacto con usted');</script>");
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Ocurrio un error al programar la revision.');</script>");
                }
            }
        }
    }
}