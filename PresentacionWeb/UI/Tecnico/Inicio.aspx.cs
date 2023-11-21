﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Comun;

namespace PresentacionWeb.UI.Tecnico
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = $", {Comun.Cache.cacheLoginWeb.nombre} {Comun.Cache.cacheLoginWeb.apellido}";
            }
        }
    }
}