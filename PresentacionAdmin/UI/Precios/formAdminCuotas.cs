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

namespace PresentacionAdmin.UI.Precios
{
    public partial class formAdminCuotas : Form
    {
        cuotasNegocios Cuotas = new cuotasNegocios();
        public formAdminCuotas()
        {
            InitializeComponent();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue("codigo"));
                lblcodigo.Text = codigo.ToString(); 
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
                rjToggleButton1.Enabled = false;
                btnEditar.Enabled = true;

                DataTable dt = Cuotas.datosCuotas(codigo);

                tbNombreCuota.Text = dt.Rows[0][1].ToString();
                tbDescripcion.Text = dt.Rows[0][2].ToString();
                tbCosto.Text = dt.Rows[0][3].ToString();
                rjToggleButton1.Enabled = false;
            }
            catch
            { }
        }

        private void formAdminCuotas_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = Cuotas.listadoCuotas(rjToggleButton1.Checked);
            }
            catch { }
        }

        private void tbSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && tbCosto.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                if (rjToggleButton1.Checked)
                {
                    if (Cuotas.guardarCuota(tbNombreCuota.Text, tbDescripcion.Text, Convert.ToDecimal(tbCosto.Text)))
                    {
                        gridControl1.DataSource = Cuotas.listadoCuotas(rjToggleButton1.Checked);
                        limpiar();
                        MessageBox.Show("Se ha agregado exitosamente la cuota.", "Exito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al guardar la cuota.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (MessageBox.Show("¿Seguro que desea rehabilitar la cuota?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (Cuotas.rehabilitarCuota(Convert.ToInt32(lblcodigo.Text)))
                        {
                            rjToggleButton1.Checked = true;
                            gridControl1.DataSource = Cuotas.listadoCuotas(rjToggleButton1.Checked);

                            limpiar();
                            MessageBox.Show("Se ha habilitado exitosamente la cuota.", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            rjToggleButton1.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar rehabilitar la cuota.\nPor favor vuelva a intentarlo mas tarde.", "Error",
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                int codigo = Convert.ToInt32(lblcodigo.Text);
                string nombre = tbNombreCuota.Text;
                string desc = tbDescripcion.Text;
                decimal costo = Convert.ToDecimal(tbCosto.Text);
                if (Cuotas.editarCuota(codigo, nombre, desc,costo))
                {
                    gridControl1.DataSource = Cuotas.listadoCuotas(rjToggleButton1.Checked);
                    limpiar();
                    MessageBox.Show("Se ha editado exitosamente la cuota.", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    rjToggleButton1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al editar la cuota.\nPor favor vuelva a intentarlo mas tarde.", "Error",
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
                if (MessageBox.Show("¿Seguro que desea deshabilitar la cuota?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    int codigo = Convert.ToInt32(lblcodigo.Text);
                    if (Cuotas.deshabilitarCuota(codigo))
                    {
                        MessageBox.Show("Se ha elimnado deshabilitado la cuota.", "Exito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        gridControl1.DataSource = Cuotas.listadoCuotas(rjToggleButton1.Checked);
                        rjToggleButton1.Checked = false;
                        rjToggleButton1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al deshabilitar la cuota.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
        }
        private void limpiar()
        {
            try
            {
                btnAgregar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;

                tbNombreCuota.Clear();
                tbCosto.Clear();
                tbDescripcion.Clear();

                rjToggleButton1.Enabled = true;
            }
            catch { }
        }
        private bool verificar()
        {
            if (tbNombreCuota.Text.Length > 2 && tbDescripcion.Text.Length > 2 && tbCosto.Text != "")
                return true;
            else
                return false;
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked)
            {
                gridControl1.DataSource = Cuotas.listadoCuotas(rjToggleButton1.Checked);
                btnAgregar.Text = "Agregar";
                btnAgregar.Enabled = true;
            }
            else
            {
                gridControl1.DataSource = Cuotas.listadoCuotas(rjToggleButton1.Checked);
                btnAgregar.Text = "Habilitar";
                btnAgregar.Enabled = false;
            }
        }
    }
}
