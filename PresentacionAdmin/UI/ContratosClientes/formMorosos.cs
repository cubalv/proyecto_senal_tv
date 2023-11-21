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

namespace PresentacionAdmin.UI.ContratosClientes
{
    public partial class formMorosos : Form
    {
        public formMorosos()
        {
            InitializeComponent();
        }
        contratoClienteNegocios Contratos = new contratoClienteNegocios();
        private void formMorosos_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Contratos.listadoContratosMora();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Reportes.morosos.formMorososViewer formView = new Reportes.morosos.formMorososViewer();
            DataTable dt = Contratos.listadoContratosMora();

            foreach (DataRow rw in dt.Rows)
            {
                Reportes.morosos.morososObj datos = new Reportes.morosos.morososObj();
                datos.codigo = rw[0].ToString();
                datos.nombre = rw[1].ToString();
                datos.fechaCont = rw[2].ToString();
                datos.plan = rw[3].ToString();
                datos.direccion = rw[4].ToString();
                datos.dias = rw[5].ToString();
                formView.Datos.Add(datos);
            }
            formView.ShowDialog();
        }
    }
}
