using Datos;
using Datos.DB;
using Datos.Empleados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negociacion
{
    public class empleadoNegocios
    {
        LeerEmpleados ReadData = new LeerEmpleados();
        GuardarEmpleados SaveData = new GuardarEmpleados();
        public int agregarEmpleado(string dpi, string nombre, string apellido, string tel,string direccion, string correo, string usuario, string contrasena)
        {
            return SaveData.guardarEmpleado(dpi, nombre, apellido, tel,direccion, correo, usuario, contrasena);
        }
        public int verificarExistenciaEmpleado(string dpi)
        {
            return ReadData.comprobarExistenciaEmpleado(dpi);
        }
        public bool editarEmpleado(string dpi, string nombre, string apellido, string tel, string direccion, string correo)
        {
            return SaveData.editarEmpleado(dpi, nombre, apellido, tel, direccion, correo);
        }

        public DataTable dtEmpleados()
        {
            return ReadData.listadoEmpleados();
        }
        public DataTable listadoEmpleados(int permisos)
        {
            return ReadData.listadoEmpleados(permisos);
        }
        public DataTable datosEmpleados(string dpi)
        {
            return ReadData.datosEmpleado(dpi);
        }
        public bool contratarEmpleado(int codigoContrato, string dpi)
        {
            return SaveData.contrataEmpleado(codigoContrato, dpi);
        }
        public bool comprobarContratoEmpleado(string dpi)
        {
            return ReadData.comprobarContratoDelEmpleado(dpi);
        }

        public DataTable listaMisiones(bool estado)
        {
            return ReadData.misionesEmpleados(estado);
        }
        public DataTable listaMisiones(string dpiEmpleado)
        {
            return ReadData.misionesEmpleados(dpiEmpleado);
        }
        public bool asignarMisionesEmpleados(List<int> misiones, string dpiEmpleado)
        {
            return SaveData.asignarMisionesEmpleados(misiones, dpiEmpleado);
        }
    }
}
