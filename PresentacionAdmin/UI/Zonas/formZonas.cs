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

namespace PresentacionAdmin.UI.Zonas
{
    public partial class formZonas : Form
    {
        public formZonas()
        {
            InitializeComponent();
        }
        zonasNegocios Zonas = new zonasNegocios();
        private void formZonas_Load(object sender, EventArgs e)
        {
            try
            {
                ddlDepto.DataSource = Zonas.listadoDeptos();
                ddlDepto.ValueMember = "id";
                ddlDepto.DisplayMember = "nombre";

            }
            catch { }
        }

        private void DdlDepto_SelectedValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            btnEditar.Enabled = true;
            btnAgregar.Enabled = false;
            try
            {
                lblCodigo.Text = gridView1.GetFocusedRowCellValue("codigo").ToString();
                DataTable dt = Zonas.datosZona(Convert.ToInt32(lblCodigo.Text));
                tbNombreZona.Text = dt.Rows[0][1].ToString();
            }
            catch { }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                if (MessageBox.Show($"Esta seguro de agregar la zona a {ddlMuni.Text} ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int codigo = Convert.ToInt32(ddlMuni.SelectedValue);
                    if (Zonas.guardarZona(tbNombreZona.Text, codigo))
                    {
                        negociosClase historial = new negociosClase();
                        historial.guardarHistorial(Comun.Cache.CacheLogin.dpi_usuario, $"Se agrego una nueva zona en el municipio de {ddlMuni.Text}");
                        MessageBox.Show("Se ha guardado con exito la zona", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        gridControl1.DataSource = Zonas.listadoZonas(codigo); 
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al ingresar la zona.\nPor favor vuelva a intentar mas tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                int codigo = Convert.ToInt32(lblCodigo.Text);
                int codigoMuni = Convert.ToInt32(ddlMuni.SelectedValue);
                if (Zonas.editarZona(codigo,tbNombreZona.Text, codigoMuni))
                {
                    negociosClase historial = new negociosClase();
                    historial.guardarHistorial(Comun.Cache.CacheLogin.dpi_usuario, $"Se editó la zona {tbNombreZona.Text}");
                    MessageBox.Show("Se ha editado con exito la zona", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = Zonas.listadoZonas(codigoMuni);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al editar la zona.\nPor favor vuelva a intentar mas tarde.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                gridControl1.DataSource = Zonas.listadoZonas(codigoMuni);
            }
        }
        private void limpiar()
        {
            try
            {
                btnEditar.Enabled = false;
                btnAgregar.Enabled = true;
                tbNombreZona.Clear();
            }
            catch { }
        }
        private bool verificar()
        {
            if(tbNombreZona.Text!="" && ddlMuni.SelectedValue.ToString() != "-1")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
