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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace PresentacionAdmin.UI.Empleados
{
    public partial class formContratarEmpleado : Form
    {
        empleadoNegocios Empleados = new empleadoNegocios();
        contratoNegocios Contratos = new contratoNegocios();
        public formContratarEmpleado()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            try
            {
                limpiarContrato();
                limpiarEmpleado();
            }
            catch { }
        }
        private void limpiarEmpleado()
        {
            try
            {
                tbDpi.Clear();
                tbNombre.Clear();
                tbApellido.Clear();
                tbDireccion.Clear();
                tbTel1.Clear();
                tbCorreo.Clear();
            }
            catch { }
        }
        private void limpiarContrato()
        {
            try
            {
                tbNombreContrato.Clear();
                tbDescripcion.Clear();
                tbSueldo.Clear();
                tbDuracion.Clear();
            }
            catch { }
        }
        private void btnContratar_Click(object sender, EventArgs e)
        {
            if(tbDpi.Text!="" && tbNombreContrato.Text != "")
            {
                try
                {
                    string dpi = tbDpi.Text;
                    int codigo = Convert.ToInt32(lblCodigo.Text);
                    if (Empleados.contratarEmpleado(codigo, dpi))
                    {
                        MessageBox.Show("Se ha contratado al empleado exitosamente", "Exito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        negociosClase historial = new negociosClase();
                        historial.guardarHistorial(Comun.Cache.CacheLogin.dpi_usuario, $"Se contrato un nuevo empleado {tbDpi.Text}");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al contratar al empleado.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limpiar();
                    }
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error al contratar al empleado.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (tbDpi.Text == "" && tbNombreContrato.Text == "")
                {
                    MessageBox.Show("Por favor seleccione los campos necesarios", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (tbDpi.Text == "")
                    {
                        MessageBox.Show("Por favor seleccione un empleado", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (tbNombreContrato.Text == "")
                    {
                        MessageBox.Show("Por favor seleccione un contrato", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void formContratarEmpleado_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Empleados.dtEmpleados();
            gridControl2.DataSource = Contratos.listadoContrato(true);
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                string dpi = gridView1.GetFocusedRowCellValue("dpi").ToString();
                if (Empleados.comprobarContratoEmpleado(dpi))
                {
                    DataTable dt = Empleados.datosEmpleados(dpi);

                    tbDpi.Text = dpi.ToString();
                    tbNombre.Text = dt.Rows[0][1].ToString();
                    tbApellido.Text = dt.Rows[0][2].ToString();
                    tbDireccion.Text = dt.Rows[0][3].ToString();
                    tbTel1.Text = dt.Rows[0][4].ToString();
                    tbCorreo.Text = dt.Rows[0][5].ToString();
                }
                else
                {
                    MessageBox.Show("El empleado tiene un contrato activo actualmente.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiarEmpleado();
                }

            }
            catch { }
        }

        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = gridView2.GetFocusedRowCellValue("codigo").ToString();

                DataTable dt = Contratos.datosContrato(codigo);

                lblCodigo.Text = codigo;

                tbNombreContrato.Text = dt.Rows[0][1].ToString();
                tbDescripcion.Text = dt.Rows[0][2].ToString();
                tbSueldo.Text = dt.Rows[0][3].ToString();
                tbDuracion.Text = dt.Rows[0][4].ToString();
            }
            catch { }
        }
    }
}
