using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Comun;
using Comun.Cache;

namespace PresentacionWeb.UI.Cliente
{
    public partial class MasterCliente : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Comun.Cache.cacheLoginWeb.dpi_usuario == null)
            {
                Response.Redirect("~/Login.aspx");
            }
        }
        protected void btnSalir_click(object sender, EventArgs e)
        {
            try
            {
                cacheLoginWeb.dpi_usuario = null;
                cacheLoginWeb.nombre = null;
                cacheLoginWeb.apellido = null;

                Response.Redirect("~/Login.aspx");
            }
            catch { }
        }
    }
}