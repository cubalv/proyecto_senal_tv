using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Misiones;

namespace Negociacion
{
    public class misionesNegocios
    {
        LeerMisiones readMisiones = new LeerMisiones();
        public DataTable listadoMisiones(string dpi)
        {
            return readMisiones.listadMisiones(dpi);
        }
        public bool completarMision(int codigoMision)
        {
            return readMisiones.completarMision(codigoMision);
        }
    }
}
