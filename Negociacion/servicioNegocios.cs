using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Servicios;

namespace Negociacion
{
    public class servicioNegocios
    {
        GuardarServicios SaveData = new GuardarServicios();
        LeerServicios ReadData = new LeerServicios();

        public DataTable listadoServicios (bool estado)
        {
            return ReadData.listadoServicios(estado);
        }
        public DataTable datosServicio(int codigo)
        {
            return ReadData.datosServicios(codigo);
        }
        public bool guardarServicio(string nombre, string descripcion)
        {
            return SaveData.guardarServicio(nombre,descripcion);
        }
        public bool editarServicio(int codigo,string nombre, string descrpcion)
        {
            return SaveData.editarServicio(codigo, nombre, descrpcion);
        }
        public bool deshabilitaServicio(int codigo)
        {
            return SaveData.deshabilitaServicio(codigo);
        }
        public bool rehabilitaServicio(int codigo)
        {
            return SaveData.rehabilitaServicio(codigo);
        }
        public DataTable listadoServiciosPorZona(int codigoZona)
        {
            return ReadData.listadoServiciosPorZona(codigoZona);
        }
        public DataTable listadoServiciosPorPlan(int codigoZona)
        {
            return ReadData.listadoServiciosPorPlan(codigoZona);
        }
    }
}
