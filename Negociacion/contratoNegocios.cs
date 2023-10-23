using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negociacion
{
    
    public class contratoNegocios
    {
        ValidacionesDatos ValData = new ValidacionesDatos();
        LeerDatos ReadData = new LeerDatos();
        GuardarDatos SaveData = new GuardarDatos();
        public DataTable listadoContrato(bool estado)
        {
            return ReadData.listadoContratos(estado);
        }
        public DataTable datosContrato(string codigo)
        {
            return ReadData.datosContrato(codigo);
        }
        public bool guardaContacto(string nombre, string descripcion, decimal sueldo, int duracion,int rango)
        {
            return SaveData.guardaContrato(nombre, descripcion, sueldo, duracion, rango);
        }
        public bool editaContacto(int codigo,string nombre, string descripcion, decimal sueldo, int duracion, int rango)
        {
            return SaveData.editaContrato(codigo,nombre, descripcion, sueldo, duracion,rango);
        }
        public bool eliminarContrato(int codigo)
        {
            return SaveData.deshabilitaContrato(codigo);
        }
        public bool rehabilitaContrato(int codigo)
        {
            return SaveData.rehabilitaContrato(codigo);
        }
    }
}
