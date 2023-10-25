using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun;
using System.Linq.Expressions;

namespace PresentacionAdmin.UI
{
    public partial class Inicio : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private IconButton botonActual;
        private Panel panelSelec;
        private Form formAbiertoActual;
        public Inicio()
        {
            InitializeComponent();
            configurarDiseño();
        }
        private void configurarDiseño()
        {
            panelUsuarioMenu.Visible = false;

        }
        private void ocultarSubMenu()
        {
            if (panelUsuarioMenu.Visible)
                panelUsuarioMenu.Visible = false;
            if (panelMenuAdmin.Visible)
                panelMenuAdmin.Visible = false;
            if (panelClienteMenu.Visible)
                panelClienteMenu.Visible = false;
            if (panelEmpleadoMenu.Visible)
                panelEmpleadoMenu.Visible = false;
            if (panelServicesMenu.Visible)
                panelServicesMenu.Visible = false;
            if (panelContratosClientes.Visible)
                panelContratosClientes.Visible = false;
        }

        //botones con submenu--------------------------------------------------------------
        private void lblUsuario_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelUsuarioMenu);
        }
        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelMenuAdmin);
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelClienteMenu);
        }
        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelEmpleadoMenu);
        }
        private void iconButton9_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelServicesMenu);
        }
        private void btnContratarServicios_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelContratosClientes);
        }
        //
        //botones para abrir form 
        //
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            if (formAbiertoActual == null)
            {
                activarbutton(sender, panelClienteMenu);
                abrirHijo(new UI.Clientes.formClienteNuevo());
            }
            else
            {
                if (formAbiertoActual.Name != "formClienteNuevo")
                {
                    if (confirmarAbrirForm("¿Seguro que desea salir?\nSe perderan los datos no guardados."))
                    {
                        activarbutton(sender, panelClienteMenu);
                        abrirHijo(new UI.Clientes.formClienteNuevo());
                    }
                }
            }
        }
        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            if (formAbiertoActual == null)
            {
                activarbutton(sender, panelEmpleadoMenu);
                abrirHijo(new UI.Empleados.formNuevoEmpleado());
            }
            else
            {
                if (formAbiertoActual.Name != "formNuevoEmpleado")
                {
                    if (confirmarAbrirForm("¿Seguro que desea salir?\nSe perderan los datos no guardados."))
                    {
                        activarbutton(sender, panelEmpleadoMenu);
                        abrirHijo(new UI.Empleados.formNuevoEmpleado());
                    }
                }
            }
        }

        private void btnNuevoContrato_Click(object sender, EventArgs e)
        {
            if (formAbiertoActual == null)
            {
                activarbutton(sender, panelMenuAdmin);
                abrirHijo(new UI.Contratos.formNuevoContrato());
            }
            else
            {
                if (formAbiertoActual.Name != "formNuevoContrato")
                {
                    if (confirmarAbrirForm("¿Seguro que desea salir?\nSe perderan los datos no guardados."))
                    {
                        activarbutton(sender, panelMenuAdmin);
                        abrirHijo(new UI.Contratos.formNuevoContrato());
                    }
                }
            }
        }

        private void btnAdministrarServicios_Click(object sender, EventArgs e)
        {
            if (formAbiertoActual == null)
            {
                activarbutton(sender, panelServicesMenu);
                abrirHijo(new UI.Servicios.formAdministrarServicios());
            }
            else
            {
                if (formAbiertoActual.Name != "formAdministrarServicios")
                {
                    if (confirmarAbrirForm("¿Seguro que desea salir?\nSe perderan los datos no guardados."))
                    {
                        activarbutton(sender, panelServicesMenu);
                        abrirHijo(new UI.Servicios.formAdministrarServicios());
                    }
                }
            }
        }
        private void btnAdminPlanes_Click(object sender, EventArgs e)
        {
            if (formAbiertoActual == null)
            {
                activarbutton(sender, panelServicesMenu);
                abrirHijo(new UI.Servicios.formAdminPlanes());
            }
            else
            {
                if (formAbiertoActual.Name != "formAdminPlanes")
                {
                    if (confirmarAbrirForm("¿Seguro que desea salir?\nSe perderan los datos no guardados."))
                    {
                        activarbutton(sender, panelServicesMenu);
                        abrirHijo(new UI.Servicios.formAdminPlanes());
                    }
                }
            }
        }
        private void btnZonas_Click(object sender, EventArgs e)
        {
            if (formAbiertoActual == null)
            {
                activarbutton(sender, panelMenuAdmin);
                abrirHijo(new UI.Zonas.formZonas());
            }
            else
            {
                if (formAbiertoActual.Name != "formZonas")
                {
                    if (confirmarAbrirForm("¿Seguro que desea salir?\nSe perderan los datos no guardados."))
                    {
                        activarbutton(sender, panelMenuAdmin);
                        abrirHijo(new UI.Zonas.formZonas());
                    }
                }
            }
        }
        private void btnAdminZonas_Click(object sender, EventArgs e)
        {

            if (formAbiertoActual == null)
            {
                activarbutton(sender, panelServicesMenu);
                abrirHijo(new UI.Zonas.formAdminZona());
            }
            else
            {
                if (formAbiertoActual.Name != "formAdminZona")
                {
                    if (confirmarAbrirForm("¿Seguro que desea salir?\nSe perderan los datos no guardados."))
                    {
                        activarbutton(sender, panelServicesMenu);
                        abrirHijo(new UI.Zonas.formAdminZona());
                    }
                }
            }
        }
        private void btnPlanes_Click(object sender, EventArgs e)
        {

            if (formAbiertoActual == null)
            {
                activarbutton(sender, panelMenuAdmin);
                abrirHijo(new UI.Servicios.formAdministrarPlanes());
            }
            else
            {
                if (formAbiertoActual.Name != "formAdministrarPlanes")
                {
                    if (confirmarAbrirForm("¿Seguro que desea salir?\nSe perderan los datos no guardados."))
                    {
                        activarbutton(sender, panelMenuAdmin);
                        abrirHijo(new UI.Servicios.formAdministrarPlanes());
                    }
                }
            }
        }
        private void btnAdminCuotas_Click(object sender, EventArgs e)
        {
            if (formAbiertoActual == null)
            {
                activarbutton(sender, panelMenuAdmin);
                abrirHijo(new UI.Precios.formAdminCuotas());
            }
            else
            {
                if (formAbiertoActual.Name != "formAdminCuotas")
                {
                    if (confirmarAbrirForm("¿Seguro que desea salir?\nSe perderan los datos no guardados."))
                    {
                        activarbutton(sender, panelMenuAdmin);
                        abrirHijo(new UI.Precios.formAdminCuotas());
                    }
                }
            }
        }
        private void btnListaContratos_Click(object sender, EventArgs e)
        {

            activarbutton(sender, panelMenuAdmin);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {

            activarbutton(sender, panelMenuAdmin);
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (formAbiertoActual == null)
            {
                activarbutton(sender, panelContratosClientes);
                abrirHijo(new UI.ContratosClientes.formNuevoContratoCliente());
            }
            else
            {
                if (formAbiertoActual.Name != "formNuevoContratoCliente")
                {
                    if (confirmarAbrirForm("¿Seguro que desea salir?\nSe perderan los datos no guardados."))
                    {
                        activarbutton(sender, panelContratosClientes);
                        abrirHijo(new UI.ContratosClientes.formNuevoContratoCliente());
                    }
                }
            }
        }

        private void btnListadoClienteContrato_Click(object sender, EventArgs e)
        {
            activarbutton(sender, panelContratosClientes);
        }

        private void btnContratarEmpleado_Click(object sender, EventArgs e)
        {
            if (formAbiertoActual == null)
            {
                activarbutton(sender, panelEmpleadoMenu);
                abrirHijo(new UI.Empleados.formContratarEmpleado());
            }
            else
            {
                if(formAbiertoActual.Name != "formContratarEmpleado")
                {
                    if (confirmarAbrirForm("¿Seguro que desea salir?\nSe perderan los datos no guardados."))
                    {
                        activarbutton(sender, panelEmpleadoMenu);
                        abrirHijo(new UI.Empleados.formContratarEmpleado());
                    }
                }
            }
        }
        //
        //botones con submenu--------------------------------------------------------------
        //
        private void mostrarSubmenu(Panel submenu)
        {
            if (!submenu.Visible)
            {
                ocultarSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        //
        //
        //
        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que desea salir de la aplicacion?","Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                Application.Exit();

        }//Diseño panel menu----------------------------------------------------------------
        public void activarbutton(object sender, Panel panelaux)
        {
            if (sender != null)
            {
                desactivarbutton();
                //boton
                botonActual = (IconButton)sender;
                botonActual.ForeColor = ColorTranslator.FromHtml("#9E244B");
                botonActual.BackColor = ColorTranslator.FromHtml("#C9C9C9");
                botonActual.TextAlign = ContentAlignment.MiddleCenter;
                botonActual.IconColor = ColorTranslator.FromHtml("#9E244B");
                botonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonActual.ImageAlign = ContentAlignment.MiddleRight;

                //borde 

                panelSelec = new Panel();
                panelaux.Controls.Add(panelSelec);
                panelSelec.Size = new Size(10, 50);

                panelSelec.BackColor = ColorTranslator.FromHtml("#9E244B");
                panelSelec.Location = new Point(0, botonActual.Location.Y);
                panelSelec.Visible = true;
                panelSelec.BringToFront();


            }
        }
        private void desactivarbutton()
        {
            if (botonActual != null)
            {
                botonActual.ForeColor = Color.Black;
                botonActual.BackColor = ColorTranslator.FromHtml("#E0E0E0");
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.IconColor = Color.Black;
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActual.ImageAlign = ContentAlignment.MiddleLeft;
                panelSelec.Visible = false;
            }
        }
        //Diseño panel menu----------------------------------------------------------------
        //
        //Abrir forms hijos----------------------------------------------------------------
        private void reset()
        {
            try
            {
                desactivarbutton();
                panelSelec.Visible = false;
                ocultarSubMenu();
            }
            catch { }
        }
        private void abrirHijo(Form Hijo)
        {
            if (formAbiertoActual != null)
            {
                formAbiertoActual.Close();
            }
            formAbiertoActual = Hijo;
            Hijo.TopLevel = false;
            Hijo.FormBorderStyle = FormBorderStyle.None;
            Hijo.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(Hijo);
            panelContainer.Tag = Hijo;
            Hijo.BringToFront();
            Hijo.Show();
            lblTitulo.Text = Hijo.Text;
        }



        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"{Comun.Cache.CacheLogin.nombre} {Comun.Cache.CacheLogin.apellido}";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar sesion?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.Close();
        }
        private bool confirmarAbrirForm(string mensaje)
        {
            if (MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                return true;
            else
                return false;
        }

    }
}
