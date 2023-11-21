using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using Negociacion;

namespace PresentacionAdmin.UI
{
    public partial class formEstadisticasInicio : Form
    {
        public formEstadisticasInicio()
        {
            InitializeComponent();
        }
        zonasNegocios Zonas = new zonasNegocios();
        private void formEstadisticasInicio_Load(object sender, EventArgs e)
        {

            try
            {
                ddlDepto.DataSource = Zonas.listadoDeptos();
                ddlDepto.ValueMember = "id";
                ddlDepto.DisplayMember = "nombre";

                gridControl1.DataSource=Zonas.listadoPopularidaPlanes();

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
                DataTable dt = Zonas.listadoZonasConsMasServicio(Convert.ToInt32(ddlMuni.SelectedValue));
                chart1.Series["Zonas"].Enabled = true;
                chart1.Series["Zonas"].Points.Clear();
                int numerServicios = 0;
                int contador = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    chart1.Series["Zonas"].Points.Add(Convert.ToInt32(dr[1]));
                    chart1.Series["Zonas"].Points[contador].Label = dr[0].ToString();
                    contador++;
                    numerServicios += Convert.ToInt32(dr[1]);
                }
                lblDescripion.Text = $" Total de servicios instalados en {ddlMuni.Text}: {numerServicios.ToString()}";
            }
            catch { }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.reportesInicio.reporteZonasViewer nuevoReporte = new Reportes.reportesInicio.reporteZonasViewer();
            DataTable dt = Zonas.listadoPopularidaPlanes();
            foreach (DataRow rw in dt.Rows)
            {
                Reportes.reportesInicio.reportePorZonasObj datos = new Reportes.reportesInicio.reportePorZonasObj();
                datos.Zona = rw[0].ToString();
                datos.Popularidad = rw[1].ToString();
                nuevoReporte.Datos.Add(datos);
            }
            nuevoReporte.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Reportes.reportesInicio.formReportePopZonas nuevoReporte = new Reportes.reportesInicio.formReportePopZonas(ddlDepto.Text,ddlMuni.Text);

            DataTable dt = Zonas.listadoZonasConsMasServicio(Convert.ToInt32(ddlMuni.SelectedValue));
            foreach (DataRow rw in dt.Rows)
            {
                Reportes.reportesInicio.reportePorZonasObj datos = new Reportes.reportesInicio.reportePorZonasObj();
                datos.Zona = rw[0].ToString();
                datos.Popularidad = rw[1].ToString();
                nuevoReporte.Datos.Add(datos);
            }
            nuevoReporte.ShowDialog();

        }
    }
}
