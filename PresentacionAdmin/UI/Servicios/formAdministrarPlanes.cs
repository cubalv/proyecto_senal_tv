using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Scrolling;
using Negociacion;

namespace PresentacionAdmin.UI.Servicios
{
    public partial class formAdministrarPlanes : Form
    {
        planNegocios Planes = new planNegocios();
        public formAdministrarPlanes()
        {
            InitializeComponent();
        }

        private void formAdministrarPlanes_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = Planes.listadoPlanes(rjToggleButton1.Checked);
            }
            catch
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            try
            {
                tbNombrePlan.Clear();
                tbDescripcionPlan.Clear();
                tbCostoInstalacion.Clear();
                tbCostoMensual.Clear();
                tbDuracionContrato.Clear();

                btnAgregar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;

                rjToggleButton1.Enabled = true;
            }
            catch { 
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                btnAgregar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;


                if (rjToggleButton1.Checked)
                {
                    btnAgregar.Enabled = false;
                    btnEliminar.Enabled = true;
                }
                else
                {
                    btnAgregar.Enabled = true;
                    btnEliminar.Enabled = false;
                }

                int codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue("codigo").ToString());
                lblcodigo.Text = codigo.ToString(); 

                DataTable dt = Planes.datosPlanes(codigo);

                tbNombrePlan.Text = dt.Rows[0][1].ToString();
                tbDescripcionPlan.Text = dt.Rows[0][2].ToString();
                tbCostoInstalacion.Text = dt.Rows[0][3].ToString();
                tbCostoMensual.Text = dt.Rows[0][4].ToString();
                tbDuracionContrato.Text = dt.Rows[0][5].ToString();


                rjToggleButton1.Enabled = false;

            }
            catch { }
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked)
            {
                gridControl1.DataSource = Planes.listadoPlanes(true);
                btnAgregar.Text = "Agregar";
                btnAgregar.Enabled = true;
                limpiar();
            }
            else
            {
                gridControl1.DataSource = Planes.listadoPlanes(false);

                btnAgregar.Text = "Habilitar";
                btnAgregar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                if (rjToggleButton1.Checked)
                {
                    if (Planes.guardarPlan(tbNombrePlan.Text, tbDescripcionPlan.Text, Convert.ToDecimal(tbCostoMensual.Text), Convert.ToDecimal(tbCostoInstalacion.Text), Convert.ToInt32(tbDuracionContrato.Text)))
                    {
                        gridControl1.DataSource = Planes.listadoPlanes(true);
                        negociosClase historial = new negociosClase();
                        historial.guardarHistorial(Comun.Cache.CacheLogin.dpi_usuario, $"Se agrego un nuevo plan {tbNombrePlan.Text}");
                        limpiar();
                        MessageBox.Show("Se ha agregado exitosamente el plan.", "Exito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al guardar el plan.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (MessageBox.Show("¿Seguro que desea rehabilitar el plan?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (Planes.rehabilitarPlan(Convert.ToInt32(lblcodigo.Text)))
                        {
                            gridControl1.DataSource = Planes.listadoPlanes(true);
                            rjToggleButton1.Checked = true;

                            negociosClase historial = new negociosClase();
                            historial.guardarHistorial(Comun.Cache.CacheLogin.dpi_usuario, $"Se rehabilito el plan {tbNombrePlan.Text}");
                            limpiar();
                            MessageBox.Show("Se ha habilitado exitosamente el plan.", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rjToggleButton1.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar rehabilitar el plan.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese todos los datos requeridos.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                int codigo = Convert.ToInt32(lblcodigo.Text);
                string nombre = tbNombrePlan.Text;
                string desc = tbDescripcionPlan.Text;
                decimal costoIns = Convert.ToDecimal(tbCostoInstalacion.Text);
                decimal costoMens = Convert.ToDecimal(tbCostoMensual.Text);
                int duracion = Convert.ToInt32(tbDuracionContrato.Text);
                if (Planes.editarPlan(codigo, nombre, desc,costoMens,costoIns, duracion))
                {
                    gridControl1.DataSource = Planes.listadoPlanes(true);
                    negociosClase historial = new negociosClase();
                    historial.guardarHistorial(Comun.Cache.CacheLogin.dpi_usuario, $"Se edito el plan {tbNombrePlan.Text}");
                    limpiar();
                    MessageBox.Show("Se ha editado exitosamente el Plan.", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rjToggleButton1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al editar el Plan.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese todos los datos requeridos.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que desea deshabilitar el plan?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int codigo = Convert.ToInt32(lblcodigo.Text);
                    if (Planes.deshabilitarPlan(codigo))
                    {
                        negociosClase historial = new negociosClase();
                        historial.guardarHistorial(Comun.Cache.CacheLogin.dpi_usuario, $"Se deshabilito el plan {tbNombrePlan.Text}");
                        MessageBox.Show("Se ha deshabilitado exitosamente el plan.", "Exito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        gridControl1.DataSource = Planes.listadoPlanes(false);
                        rjToggleButton1.Checked = false;
                        rjToggleButton1.Enabled = true;
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al eliminar el plan.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }

        }

        private void btnEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && tbCostoInstalacion.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void tbCostoMensual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && tbCostoMensual.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void tbDuracionContrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool verificar()
        {
            if (tbNombrePlan.Text.Length > 2 && tbDescripcionPlan.Text.Length > 2 && tbCostoInstalacion.Text != "" && tbCostoMensual.Text != "" && tbDuracionContrato.Text != "")
                return true;
            else
                return false;
        }
    }
}
