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

namespace PresentacionAdmin.UI.ContratosClientes
{
    public partial class formAdministarContratosClientes : Form
    {
        contratoClienteNegocios Contratos = new contratoClienteNegocios();
        cuotasNegocios Cuotas = new cuotasNegocios();
        public formAdministarContratosClientes()
        {
            InitializeComponent();
        }
        private void formAdministarContratosClientes_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = Contratos.listadoContratosCliente(true);
                //btnCambiarDireccion.Visible = false;
            }
            catch { }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(gridView1.GetFocusedRowCellValue("codigo"));
                lblCodigo.Text=codigo.ToString();
                DataTable dt = Contratos.datosDelContrato(codigo);
                tbDpi.Text = dt.Rows[0][0].ToString();
                tbNombre.Text = dt.Rows[0][1].ToString();
                tbPlan.Text = dt.Rows[0][2].ToString();
                tbFecha.Text = dt.Rows[0][3].ToString();
                tbDireccion.Text = dt.Rows[0][4].ToString();

                btnCambiarDireccion.Enabled = true;
                btnDarBaja.Enabled = true;
                tbDireccion.Enabled = true;
            }
            catch { }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            try
            {
                lblCodigo.Text = "";
                tbDpi.Clear();
                tbNombre.Clear();
                tbPlan.Clear();
                tbFecha.Clear();
                tbDireccion.Clear();

                btnCambiarDireccion.Enabled = false;
                btnDarBaja.Enabled=false;
                tbDireccion.Enabled = false;
            }
            catch { }
        }

        private void btnCambiarDireccion_Click(object sender, EventArgs e)
        {
            decimal costo = Cuotas.costoCambiarDireccion();
            if (MessageBox.Show($"¿Está seguro de cambiar la direccion del servicio? Esto agregara un costo de Q.{costo} al cliente", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            decimal costo = Cuotas.costoDarDeBaja();
            if (MessageBox.Show($"¿Está seguro de dar de baja el servicio? Esto agregara un costo de Q.{costo} al cliente", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int codigoServicio = Convert.ToInt32(lblCodigo.Text);
                if (Contratos.misionDarDeBaja(codigoServicio))
                {
                    string codigo = lblCodigo.Text;
                    string concepto = "Dar de baja el servicio.";
                    string total = costo.ToString();

                    Reportes.facturaPrecioAgregado.facturaViewer factura = new Reportes.facturaPrecioAgregado.facturaViewer(codigo,concepto,costo.ToString(),total);
                    factura.ShowDialog();
                    MessageBox.Show("Servicio dado de baja con exito", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    negociosClase historial = new negociosClase();
                    historial.guardarHistorial(Comun.Cache.CacheLogin.dpi_usuario, $"Se dio de baja el contrato {codigo}");
                    limpiar();
                    gridControl1.DataSource = Contratos.listadoContratosCliente(true);
                }
            }
        }
    }
}
