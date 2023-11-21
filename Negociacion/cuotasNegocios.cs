using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Cuotas;

namespace Negociacion
{
    public class cuotasNegocios
    {
        LeerCuotas readCuotas= new LeerCuotas();
        GuardarCuotas saveCuotas = new GuardarCuotas();
        public bool guardarCuota(string nombre, string descripcion, decimal precio)
        {
            return saveCuotas.guardarCuota(nombre, descripcion, precio);    
        }
        public bool editarCuota(int codigo, string nombre, string descripcion, decimal precio)
        {
            return saveCuotas.editarCuota(codigo, nombre, descripcion,precio);
        }
        public bool deshabilitarCuota(int codigo)
        {
            return saveCuotas.deshabilitarCuota(codigo);
        }
        public bool rehabilitarCuota(int codigo)
        {
            return saveCuotas.rehabilitarCuota(codigo);
        }
        public DataTable datosCuotas(int codigo)
        {
            return readCuotas.datosCuotas(codigo);
        }
        public DataTable listadoCuotas(bool estado)
        {
            return readCuotas.listadoCuotas(estado);
        }
        public decimal costoDarDeBaja()
        {
            decimal costo = Convert.ToDecimal(readCuotas.datosCuotas(3).Rows[0][3]);
            return costo;
        }
        public decimal costoCambiarDireccion()
        {
            decimal costo = Convert.ToDecimal(readCuotas.datosCuotas(2).Rows[0][3]);
            return costo;
        }
    }
}
