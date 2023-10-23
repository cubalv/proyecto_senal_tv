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

namespace PresentacionAdmin.UI.Clientes
{
    public partial class formClienteNuevo : Form
    {
        public formClienteNuevo()
        {
            InitializeComponent();
        }
        clientesNegocios Clientes = new clientesNegocios();
        private void formClienteNuevo_Load(object sender, EventArgs e)
        {
            DataTable dt = Clientes.dtClientes();
            gridControl1.DataSource = dt;
            gridColumn1.FieldName = dt.Columns[0].ColumnName;
            gridColumn2.FieldName = dt.Columns[1].ColumnName;
            gridColumn3.FieldName = dt.Columns[2].ColumnName;
            gridColumn4.FieldName = dt.Columns[3].ColumnName;
            gridColumn5.FieldName = dt.Columns[4].ColumnName;
        }
        private void tbDpi_KeyPress(object sender, KeyPressEventArgs e)
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
            tbDpi.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            tbDireccion.Clear();
            tbTel1.Clear();
            tbTel2.Clear();
            tbCorreo.Clear();
            tbDpi.Enabled = true;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            tbDpi.Text = gridView1.GetFocusedRowCellValue("dpi").ToString();
            DataTable dt = Clientes.datosCliente(tbDpi.Text);
            if (dt.Rows.Count > 0)
            {
                tbDpi.Enabled = false;
                btnAgregar.Enabled = false;
                btnEditar.Enabled = true;

                tbNombre.Text = dt.Rows[0][0].ToString();
                tbApellido.Text = dt.Rows[0][1].ToString();
                tbDireccion.Text = dt.Rows[0][2].ToString();
                tbTel1.Text = dt.Rows[0][3].ToString();
                tbTel2.Text = dt.Rows[0][4].ToString();
                tbCorreo.Text = dt.Rows[0][5].ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int resultado = Clientes.guardarCliente(tbDpi.Text, tbNombre.Text, tbApellido.Text, tbTel1.Text, tbTel2.Text, tbDireccion.Text, tbCorreo.Text);
            switch (resultado)
            {
                case 0:
                    MessageBox.Show("El cliente ya existe en el sistema", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                case 1:
                    MessageBox.Show("El cliente ha sido agregado exitosamente.", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    gridControl1.DataSource = Clientes.dtClientes();
                    break;
                case 2:
                    MessageBox.Show("Ha ocurrido un error.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break; 
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(Clientes.editarCliente(tbDpi.Text, tbNombre.Text, tbApellido.Text, tbTel1.Text, tbTel2.Text, tbDireccion.Text, tbCorreo.Text))
            {
                MessageBox.Show("Se han actualizado los datos con exito", "Exito",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                gridControl1.DataSource = Clientes.dtClientes();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbDpi_Leave(object sender, EventArgs e)
        {

        }
    }
}
