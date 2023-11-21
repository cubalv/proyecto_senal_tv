using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Facturas;

namespace Negociacion
{
    public class facturasNegocios
    {
        GuardarFacturas saveFactura = new GuardarFacturas();
        LeerFacturas readFactura = new LeerFacturas();
        
        public DataTable listadoFacturas(string dpi)
        {
            return readFactura.listadoFacturas(dpi);
        }

        public DataTable datosFactura(int codigo_factura)
        {
            return readFactura.datosFactura(codigo_factura);
        }
        public bool pagarFactura(int codigo_factura)
        {
            return saveFactura.pagarFactura(codigo_factura);
        }
    }
}
