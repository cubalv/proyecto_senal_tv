using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negociacion;

namespace PresentacionAdmin.UI.Empleados
{
    public partial class formNuevoEmpleado : Form
    {
        empleadoNegocios NC = new empleadoNegocios();
        negociosClase GNC= new negociosClase();//clases generales de negocios General Negotiation Class
        public formNuevoEmpleado()
        {
            InitializeComponent();
        }

        private void formNuevoEmpleado_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = NC.dtEmpleados();
        }
        private void tbDpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void limpiar()
        {
            tbDpi.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            tbDireccion.Clear();
            tbTel1.Clear();
            tbCorreo.Clear();
            tbUser.Clear();
            tbPswrd.Clear();

            tbDpi.Enabled = true;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                tbDpi.Enabled = false;
                btnEditar.Enabled = true;
                btnAgregar.Enabled = false;

                string dpi = gridView1.GetFocusedRowCellValue("dpi").ToString();
                DataTable dt = NC.datosEmpleados(dpi);
                
                tbDpi.Text= dpi.ToString();
                tbNombre.Text = dt.Rows[0][1].ToString();
                tbApellido.Text = dt.Rows[0][2].ToString();
                tbDireccion.Text = dt.Rows[0][3].ToString();
                tbTel1.Text = dt.Rows[0][4].ToString();
                tbCorreo.Text = dt.Rows[0][5].ToString();
                tbUser.Text = dt.Rows[0][6].ToString();
                tbPswrd.Text = dt.Rows[0][7].ToString();


            }
            catch { }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (verificacionTodosDatos())
            {
                int resultado = NC.agregarEmpleado(tbDpi.Text, tbNombre.Text, tbApellido.Text, tbTel1.Text,tbDireccion.Text, tbCorreo.Text, tbUser.Text, tbPswrd.Text);
                switch (resultado)
                {
                    case 0:
                        MessageBox.Show("El empleado ya existe en el sistema. \nY tiene un contracto activo", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 1:
                        MessageBox.Show("El empleado ya existe en el sistema. \n¿Desea reactivarlo en el sistema?", "Advertencia",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        break;
                    case 2:
                        MessageBox.Show("El empleado ha sido agregado exitosamente.", "Exito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        gridControl1.DataSource = NC.dtEmpleados();
                        break;
                    case 3:
                        MessageBox.Show("Ha ocurrido un error.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor llene todos los datos requeridos.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbDpi_Leave(object sender, EventArgs e)
        {
            if (tbDpi.Text.Length == 13) 
            {
                int resul = NC.verificarExistenciaEmpleado(tbDpi.Text);
                switch (resul)
                {
                    case 0:
                        MessageBox.Show("El empleado ya existe en el sistema. \nY tiene un contracto activo", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbDpi.Clear();
                        break;
                    case 1:
                        MessageBox.Show("El empleado ya existe en el sistema. \n¿Desea crear un nuevo contrato?", "Advertencia",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        break;
                    default:
                        break;
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (verificacionTodosDatos())
            {
                if (NC.editarEmpleado(tbDpi.Text, tbNombre.Text, tbApellido.Text, tbTel1.Text, tbDireccion.Text, tbCorreo.Text))
                {
                    MessageBox.Show("Los datos del empleado se han actualizado con exito", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    gridControl1.DataSource = NC.dtEmpleados();

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.\nVuelva a intentarlo mas tarde.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor llene todos los datos requeridos.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbNombre_Leave(object sender, EventArgs e)
        {
            if (tbNombre.Text.Length >= 3 && tbApellido.Text.Length >= 3)
            {
                string[] credenciales = GNC.generaCredenciales(tbNombre.Text, tbApellido.Text);
                tbUser.Text = credenciales[0];
                tbPswrd.Text = credenciales[1];
            }
        }
        private bool verificacionTodosDatos()
        {
            if (tbDpi.Text.Length > 12 && tbNombre.Text != "" && tbApellido.Text.Length > 4 &&tbTel1.Text.Length>7 && tbDireccion.Text.Length > 4)
                return true;
            else
                return false;
        }
    }
}
