using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negociacion;

namespace PresentacionWeb
{
    public partial class Login : System.Web.UI.Page
    {
        negociosClase General = new negociosClase();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            if(IsPostBack) 
            {
                if (tbUser.Text != "" && tbPswrd.Text != "")
                {
                    string user = tbUser.Text;
                    string pswrd = tbPswrd.Text;   
                    int resul = General.validarTecnico(user, pswrd);
                    if (resul == 1)
                    {
                        Response.Write("<script>alert('Si existe')</script>");
                        Response.Redirect("UI/Tecnico/Inicio.aspx");
                    }
                    else
                    {
                        if (resul == 2)
                        {
                            Response.Write("<script>alert('No tiene los permisos necesarios para ingresar.')</script>");
                        }
                        else
                        {

                            if (General.verificaCliente(user, pswrd))
                            {
                                Response.Redirect("UI/Cliente/InicioCliente.aspx");
                            }
                            else
                            {
                                Response.Write("<script>alert('El usuario no existe')</script>");
                            }
                        }
                    }
                }
                else
                {
                    Response.Write("<script>alert('Por favor ingrese los datos necesarios')</script>");
                }
            }
        }
    }
}