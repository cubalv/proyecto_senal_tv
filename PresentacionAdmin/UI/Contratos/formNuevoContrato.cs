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

namespace PresentacionAdmin.UI.Contratos
{
    public partial class formNuevoContrato : Form
    {
        contratoNegocios NC = new contratoNegocios();
        public formNuevoContrato()
        {
            InitializeComponent();
        }

        private void materialTextBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && tbSueldo.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void materialTextBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
                btnAgregar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                rjToggleButton1.Enabled = true;
                tbNombreContrato.Text = string.Empty;
                tbDescripcion.Text = string.Empty;
                tbSueldo.Text = string.Empty;
                tbDuracion.Text = string.Empty;
                ddlRangos.SelectedValue = -1;
                ddlRangos.Refresh();

            }
            catch { }
        }
        private bool verificar()
        {
            if (tbNombreContrato.Text.Length > 2 && tbDescripcion.Text.Length > 2 && tbDuracion.Text != "" && tbSueldo.Text != "" && ddlRangos.SelectedValue.ToString() != "-1")
                return true;
            else
                return false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                if (rjToggleButton1.Checked)
                {
                    if (NC.guardaContacto(tbNombreContrato.Text, tbDescripcion.Text, Convert.ToDecimal(tbSueldo.Text), Convert.ToInt32(tbDuracion.Text), Convert.ToInt32(ddlRangos.SelectedValue)))
                    {
                        gridControl1.DataSource = NC.listadoContrato(true);
                        limpiar();
                        MessageBox.Show("Se ha agregado exitosamente el contrato.", "Exito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al guardar el contrato.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (MessageBox.Show("¿Seguro que desea rehabilitar el contrato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        if (NC.rehabilitaContrato(Convert.ToInt32(lblcodigo.Text)))
                        {
                            gridControl1.DataSource = NC.listadoContrato(true);
                            rjToggleButton1.Checked = true;

                            limpiar();
                            MessageBox.Show("Se ha habilitado exitosamente el contrato.", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rjToggleButton1.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar rehabilitar el contrato.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese todos los datos requeridos.","Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                lblcodigo.Text = gridView1.GetFocusedRowCellValue("codigo").ToString();

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
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                rjToggleButton1.Enabled = false;

                DataTable dt = NC.datosContrato(lblcodigo.Text);

                tbNombreContrato.Text = dt.Rows[0][1].ToString();
                tbDescripcion.Text = dt.Rows[0][2].ToString();
                tbSueldo.Text = dt.Rows[0][3].ToString();
                tbDuracion.Text = dt.Rows[0][4].ToString();
                ddlRangos.SelectedValue = dt.Rows[0][5].ToString();
                ddlRangos.Refresh();
            }
            catch { }
        }

        private void formNuevoContrato_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = NC.listadoContrato(true);
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Rows.Add("1", "Admnistrador");
            dt.Rows.Add("2", "Secretario");
            dt.Rows.Add("3", "Tecnico");
            ddlRangos.DataSource=dt;
            ddlRangos.ValueMember = "id";
            ddlRangos.DisplayMember= "name";
            ddlRangos.SelectedValue = -1;
            ddlRangos.Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                int codigo = Convert.ToInt32(lblcodigo.Text);
                string nombre = tbNombreContrato.Text;
                string desc=tbDescripcion.Text;
                decimal sueldo = Convert.ToDecimal(tbSueldo.Text);
                int duracion = Convert.ToInt32(tbDuracion.Text);
                if (NC.editaContacto(codigo, nombre, desc, sueldo, duracion,Convert.ToInt32(ddlRangos.SelectedValue)))
                {
                    gridControl1.DataSource = NC.listadoContrato(true);
                    limpiar();
                    MessageBox.Show("Se ha editado exitosamente el contrato.", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rjToggleButton1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al editar el contrato.\nPor favor vuelva a intentarlo mas tarde.", "Error",
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
                if (MessageBox.Show("¿Seguro que desea deshabilitar el contrato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int codigo = Convert.ToInt32(lblcodigo.Text);
                    if (NC.eliminarContrato(codigo))
                    {
                        MessageBox.Show("Se ha elimnado deshabilitado el contrato.", "Exito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        gridControl1.DataSource = NC.listadoContrato(false);
                        rjToggleButton1.Checked = false;
                        rjToggleButton1.Enabled = true;
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al deshabilitar el contrato.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked)
            {
                gridControl1.DataSource=NC.listadoContrato(true);
                btnAgregar.Text = "Agregar";
                btnAgregar.Enabled = true;
            }
            else
            {
                gridControl1.DataSource = NC.listadoContrato(false);
                btnAgregar.Text = "Habilitar";
                btnAgregar.Enabled = false;
            }
        }
    }
}
