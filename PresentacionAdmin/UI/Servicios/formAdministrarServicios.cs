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

namespace PresentacionAdmin.UI.Servicios
{
    public partial class formAdministrarServicios : Form
    {
        public formAdministrarServicios()
        {
            InitializeComponent();
        }
        servicioNegocios Servicios = new servicioNegocios();
        private void formAdministrarServicios_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Servicios.listadoServicios(true);
        }
        private void limpiar()
        {
            try
            {
                tbNombreServicio.Clear();
                tbDescripcionServicio.Clear();
                btnAgregar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled= false;
                rjToggleButton1.Enabled = true;
            }
            catch
            { }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {

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

                int codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue("codigo"));
                lblCodigo.Text=codigo.ToString();
                DataTable dt = Servicios.datosServicio(codigo);
                tbNombreServicio.Text = dt.Rows[0][1].ToString();
                tbDescripcionServicio.Text = dt.Rows[0][2].ToString();

            }
            catch { }
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = Servicios.listadoServicios(rjToggleButton1.Checked);

            if (rjToggleButton1.Checked)
            {
                btnAgregar.Text = "Agregar";
                btnAgregar.Enabled = true;
            }
            else
            {
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
                    if (Servicios.guardarServicio(tbNombreServicio.Text, tbDescripcionServicio.Text))
                    {
                        gridControl1.DataSource = Servicios.listadoServicios(true);
                        limpiar();
                        MessageBox.Show("Se ha agregado exitosamente el servicio.", "Exito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al guardar el servicio.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (MessageBox.Show("¿Seguro que desea rehabilitar el servicio?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        if (Servicios.rehabilitaServicio(Convert.ToInt32(lblCodigo.Text)))
                        {
                            gridControl1.DataSource = Servicios.listadoServicios(true);
                            rjToggleButton1.Checked = true;

                            limpiar();
                            MessageBox.Show("Se ha habilitado exitosamente el servicio.", "Exito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rjToggleButton1.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al intentar rehabilitar el servicio.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {

            }
        }
        private bool verificar()
        {
            if (tbNombreServicio.Text != "" && tbDescripcionServicio.Text != "")
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                int codigo = Convert.ToInt32(lblCodigo.Text);
                string nombre = tbNombreServicio.Text;
                string desc = tbDescripcionServicio.Text;
                if (Servicios.editarServicio(codigo, nombre, desc))
                {
                    gridControl1.DataSource = Servicios.listadoServicios(true);
                    limpiar();
                    MessageBox.Show("Se ha editado exitosamente el servicio.", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rjToggleButton1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al editar el servicio.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese todos los datos requeridos.", "AdverteServiciosia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que desea deshabilitar el servicio?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    int codigo = Convert.ToInt32(lblCodigo.Text);
                    if (Servicios.deshabilitaServicio(codigo))
                    {
                        MessageBox.Show("Se ha deshabilitado exitosamente el servicio.", "Exito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        gridControl1.DataSource = Servicios.listadoServicios(false);
                        rjToggleButton1.Checked = false;
                        rjToggleButton1.Enabled = true;
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al deshabilitar el servicio.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
        }
    }
}
