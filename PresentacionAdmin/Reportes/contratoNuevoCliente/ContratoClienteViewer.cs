using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PresentacionAdmin.Reportes.contratoNuevoCliente
{
    public partial class ContratoClienteViewer : Form
    {
        public ContratoClienteViewer()
        {
            InitializeComponent();
        }

        private void ContratoClienteViewer_Load(object sender, EventArgs e)
        {

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
