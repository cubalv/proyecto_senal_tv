using DevExpress.XtraBars.Docking.Paint;
using MaterialSkin;
using Negociacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionAdmin.UI.Zonas
{
    public partial class formAdminZona : Form
    {
        public formAdminZona()
        {
            InitializeComponent();
        }
        
        zonasNegocios Zonas = new zonasNegocios();
        servicioNegocios Servicios = new servicioNegocios();
        DataTable dtServiciosZona = new DataTable();
        List<int> idServicios= new List<int>();

        private void formAdminZona_Load(object sender, EventArgs e)
        {
            try
            {
                ddlDepto.DataSource = Zonas.listadoDeptos();
                ddlDepto.ValueMember = "id";
                ddlDepto.DisplayMember = "nombre";
                

            }
            catch { }
        }

        private void ddlDepto_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ddlMuni.DataSource = Zonas.listadoMunis(Convert.ToInt32(ddlDepto.SelectedValue));
                ddlMuni.ValueMember = "id";
                ddlMuni.DisplayMember = "nombre";
            }
            catch { }
        }

        private void ddlMuni_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = Zonas.listadoZonas(Convert.ToInt32(ddlMuni.SelectedValue));
            }
            catch { }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                lblCodigo.Text = gridView1.GetFocusedRowCellValue("codigo").ToString();
                DataTable dt = Zonas.datosZona(Convert.ToInt32(lblCodigo.Text));
                tbNombreZona.Text = dt.Rows[0][1].ToString();

                dt = Servicios.listadoServicios(true);
                gridControl2.DataSource = dt;

                dtServiciosZona = Servicios.listadoServiciosPorZona(Convert.ToInt32(lblCodigo.Text));
                gridControl3.DataSource = dtServiciosZona;

                idServicios.Clear();
                foreach (DataRow dr in dtServiciosZona.Rows)
                {
                    idServicios.Add(Convert.ToInt32(dr[0]));
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
                    if (MessageBox.Show("¿Esta seguro de querer agregar este servicio a la zona?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataTable dtAuxSer = Servicios.datosServicio(codigoServicio);
                        dtServiciosZona.Rows.Add(dtAuxSer.Rows[0][0], dtAuxSer.Rows[0][1], dtAuxSer.Rows[0][2]);
                        idServicios.Add(codigoServicio);
                        gridControl3.DataSource = dtServiciosZona;
                    }

                }
                else
                {
                    MessageBox.Show("El servicio ya está disponible en la zona.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }

        private void repositoryItemButtonEdit3_Click(object sender, EventArgs e)
        {
            try
            {

                int codigoServicio = Convert.ToInt32(gridView3.GetFocusedRowCellValue("codigo"));
                if (MessageBox.Show("¿Esta seguro de querer eliminar este servicio de la zona?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dtServiciosZona.Rows.RemoveAt(idServicios.IndexOf(codigoServicio));
                    idServicios.Remove(codigoServicio);
                }
            }
            catch { }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (MessageBox.Show("¿Seguro que desea guardar los cambios realizados a la zona?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (Zonas.editarDisponibilidades(Convert.ToInt32(lblCodigo.Text), idServicios))
                    {
                        negociosClase historial = new negociosClase();
                        historial.guardarHistorial(Comun.Cache.CacheLogin.dpi_usuario, $"Se guardarons los cambios hechos a los servicios disponibles en cada zona");
                        MessageBox.Show("Se han guardado los cambios hechos a las disponibilidades de la zona.", "Exito",
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
