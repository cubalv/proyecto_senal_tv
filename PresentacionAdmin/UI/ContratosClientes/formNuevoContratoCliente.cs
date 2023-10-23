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
using PresentacionAdmin.UI.Servicios;

namespace PresentacionAdmin.UI.ContratosClientes
{
    public partial class formNuevoContratoCliente : Form
    {
        zonasNegocios Zonas = new zonasNegocios();
        clientesNegocios Clientes = new clientesNegocios();
        planNegocios Planes = new planNegocios();
        public formNuevoContratoCliente()
        {
            InitializeComponent();
        }
        private void formNuevoContratoCliente_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = Clientes.dtClientes();
            }
            catch { }
        }

        private void ddlDepto_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void ddlMuni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit3_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificarDispon_Click(object sender, EventArgs e)
        {

        }
    }
}
