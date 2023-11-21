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
    public partial class formAdminPlanes : Form
    {
        planNegocios Planes = new planNegocios();
        servicioNegocios Servicios  = new servicioNegocios();

        DataTable dtServiciosPorPlan = new DataTable();
        List<int> idServicios = new List<int>();

        public formAdminPlanes()
        {
            InitializeComponent();
        }

        private void formAdminPlanes_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource= Planes.listadoPlanes(true);
            }
            catch { }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue("codigo").ToString());
                lblCodigo.Text= codigo.ToString();
                DataTable dt = Planes.datosPlanes(codigo);

                tbNombrePlan.Text = dt.Rows[0][1].ToString();
                tbDescripcionPlan.Text = dt.Rows[0][2].ToString();


                dt = Servicios.listadoServicios(true);
                gridControl2.DataSource = dt;

                dtServiciosPorPlan = Servicios.listadoServiciosPorPlan(Convert.ToInt32(lblCodigo.Text));
                gridControl3.DataSource = dtServiciosPorPlan;

                idServicios.Clear();
                foreach (DataRow dr in dtServiciosPorPlan.Rows)
                {
                    idServicios.Add(Convert.ToInt32(dr[0]));
                }
            }
            catch { }
        }

        private void repositoryItemButtonEdit3_Click(object sender, EventArgs e)
        {
            try
            {

                int codigoServicio = Convert.ToInt32(gridView3.GetFocusedRowCellValue("codigo"));
                if (MessageBox.Show("¿Esta seguro de querer eliminar este servicio del plan?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dtServiciosPorPlan.Rows.RemoveAt(idServicios.IndexOf(codigoServicio));
                    idServicios.Remove(codigoServicio);
                }
            }
            catch { }
        }

        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoServicio = Convert.ToInt32(gridView2.GetFocusedRowCellValue("codigo"));
                if (!idServicios.Contains(codigoServicio))
                {
                    if (MessageBox.Show("¿Esta seguro de querer agregar este servicio a al plan?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataTable dtAuxSer = Servicios.datosServicio(codigoServicio);
                        dtServiciosPorPlan.Rows.Add(dtAuxSer.Rows[0][0], dtAuxSer.Rows[0][1], dtAuxSer.Rows[0][2]);
                        idServicios.Add(codigoServicio);
                        gridControl3.DataSource = dtServiciosPorPlan;
                    }
                }
                else
                {
                    MessageBox.Show("El servicio ya está disponible en el plan.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que desea guardar los cambios realizados al plan?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (Planes.editarDetallesPlan(Convert.ToInt32(lblCodigo.Text), idServicios))
                    {
                        negociosClase historial = new negociosClase();
                        historial.guardarHistorial(Comun.Cache.CacheLogin.dpi_usuario, $"Se editaron los servicios que ofrece el plan {tbNombrePlan.Text}");
                        MessageBox.Show("Se han guardado los cambios hechos a los detalles del plan.", "Exito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al guardar los cambios.\nPor favor vuelva a intentarlo mas tarde.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
        }
    }
}
