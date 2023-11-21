using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTab.Buttons;
using Negociacion;
using Comun;
using Comun.Cache;

namespace PresentacionAdmin.UI
{
    public partial class Logins : Form
    {
        public Logins()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "" && tbPswrd.Text == "")
            {
                lblError.Text = "Debe ingresar un usuario y una contraseña";
                lblError.Visible = true;
            }
            else
            {
                if (tbUser.Text != "")
                {
                    if (tbPswrd.Text != "")
                    {
                        negociosClase nC = new negociosClase();
                        if(nC.loginVerificacion(tbUser.Text, tbPswrd.Text))
                        {
                            if (Comun.Cache.CacheLogin.rango_permisos == 1)
                            {
                                Inicio inicio = new Inicio();
                                inicio.Show();
                                inicio.FormClosed += LogOut;
                                this.Hide();
                            }
                            else
                            {
                                lblError.Text = "No tiene los permisos necesarios para usar este sistema.\nPongase en contacto con algun administrador.";
                                lblError.Visible = true;
                                tbPswrd.Clear();
                                tbUser.Focus();
                            }
                        }
                        else
                        {
                            lblError.Text = "Nombre de usuario o contraseña equivocados.\nPor favor vuelva a intentar.";
                            lblError.Visible = true;
                            tbPswrd.Clear();
                            tbUser.Focus();
                        }
                        
                    }
                    else
                    {
                        lblError.Text = "Ingrese una contraseña por favor";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    lblError.Text = "Ingrese un nombre de usuario por favor";
                    lblError.Visible = true;
                }
            }
        }

        private void btnVerPswrd_Click(object sender, EventArgs e)
        {
            if (btnVerPswrd.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                tbPswrd.Password = true;
                btnVerPswrd.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                tbPswrd.Text = tbPswrd.Text;
            }
            else
            {
                tbPswrd.Password = false;
                btnVerPswrd.IconChar = FontAwesome.Sharp.IconChar.Eye;
                tbPswrd.Text = tbPswrd.Text;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbPswrd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                btnEntrar_Click(sender, e);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
        private void LogOut(object sender, EventArgs e)
        {
            tbPswrd.Clear();
            tbUser.Clear();
            lblError.Visible = false;
            this.Show();
            tbUser.Focus();
        }

        private void tbPswrd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender,e);
            }
        }

        private void tbUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
