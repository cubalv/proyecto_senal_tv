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

namespace PresentacionAdmin.UI.Administracion
{
    public partial class formHistorial : Form
    {
        negociosClase General = new negociosClase();
        public formHistorial()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formHistorial_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = General.historial();
        }
    }
}
