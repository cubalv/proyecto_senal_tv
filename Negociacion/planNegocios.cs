using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Planes;

namespace Negociacion
{
    public class planNegocios
    {
        GuardarPlan SavePlan = new GuardarPlan();
        LeerPlan ReadPlan = new LeerPlan();
        public bool guardarPlan(string nombre, string descripcion, decimal precioMens, decimal precioIns, int duracion)
        {
            return SavePlan.guardarPlan(nombre, descripcion, precioMens, precioIns, duracion);
        }
        public bool editarPlan(int codigo, string nombre, string descripcion, decimal precioMens, decimal precioIns, int duracion)
        {
            return SavePlan.editarPlan(codigo, nombre, descripcion, precioMens, precioIns, duracion);
        }
        public bool deshabilitarPlan(int codigo)
        {
            return SavePlan.deshabilitarPlan(codigo);
        }
        public bool rehabilitarPlan(int codigo)
        {
            return SavePlan.rehabilitarPlan(codigo);
        }
        public DataTable listadoPlanes(bool estado)
        {
            return ReadPlan.listadoPlanes(estado);
        }

        public DataTable datosPlanes(int codigoPlan)
        {
            return ReadPlan.datosPlanes(codigoPlan);
        }
        public bool editarDetallesPlan(int codigoPlan, List<int> servicios)
        {
            return SavePlan.editarDetallesPlan(codigoPlan, servicios);
        }
    }
}
