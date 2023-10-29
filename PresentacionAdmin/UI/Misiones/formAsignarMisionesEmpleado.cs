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

namespace PresentacionAdmin.UI.Misiones
{
    public partial class formAsignarMisionesEmpleado : Form
    {
        empleadoNegocios Empleados = new empleadoNegocios();
        DataTable dtMisionesSinAsignar = new DataTable();
        DataTable dtMisionesDelEmpleado = new DataTable();
        public formAsignarMisionesEmpleado()
        {
            InitializeComponent();
        }

        private void formAsignarMisionesEmpleado_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Empleados.listadoEmpleados(3);
            dtMisionesSinAsignar = Empleados.listaMisiones(false);
            gridControl2.DataSource = dtMisionesSinAsignar;
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                string dpi = gridView1.GetFocusedRowCellValue("dpi").ToString();
                DataTable dt = Empleados.datosEmpleados(dpi);

                tbDpi.Text = dpi.ToString();
                tbNombre.Text = dt.Rows[0][1].ToString();
                tbApellido.Text = dt.Rows[0][2].ToString();
                tbDireccion.Text = dt.Rows[0][3].ToString();
                tbTel1.Text = dt.Rows[0][4].ToString();
                tbCorreo.Text = dt.Rows[0][5].ToString();

                dtMisionesDelEmpleado = Empleados.listaMisiones(dpi);
                gridControl3.DataSource = dtMisionesDelEmpleado;
            }
            catch { }
        }

        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            if(tbDpi.Text!="")
            {
                int codigoMision = Convert.ToInt32(gridView2.GetFocusedRowCellValue("codigo"));
                string concepto = gridView2.GetFocusedRowCellValue("concepto").ToString();
                List<int> misiones = new List<int>();
                foreach (DataRow dr in dtMisionesDelEmpleado.Rows)
                {
                    misiones.Add(Convert.ToInt32(dr[0]));
                }
                if ( !misiones.Contains(codigoMision))
                    dtMisionesDelEmpleado.Rows.Add(codigoMision,concepto);
                else
                    MessageBox.Show("La mision ya se le ha agregado al empleado.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Por favor seleccione un empleado para asignar las misiones.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool verificar()
        {
            if (tbDpi.Text != "" && dtMisionesDelEmpleado.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Por favor seleccione los datos necesarios.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
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
                tbDpi.Clear();
                tbNombre.Clear();
                tbApellido.Clear();
                tbDireccion.Clear();
                tbTel1.Clear();
                tbCorreo.Clear();

                gridControl3.DataSource = null;

                dtMisionesSinAsignar = Empleados.listaMisiones(false);
                gridControl2.DataSource = dtMisionesSinAsignar;
            }
            catch { }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (verificar())
            {
                if (MessageBox.Show("¿Seguro que desea guardar los cambios realizados a las misiones del empleado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<int> misiones = new List<int>();
                    foreach (DataRow dr in dtMisionesDelEmpleado.Rows)
                    {
                        misiones.Add(Convert.ToInt32(dr[0]));
                    }
                    if (Empleados.asignarMisionesEmpleados(misiones, tbDpi.Text))
                    {
                        MessageBox.Show("Se le han asignado exitosamente las misiones al empleado.", "Operacion exitosa",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error. Por favor intentelo de nuevo mas tarde.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
