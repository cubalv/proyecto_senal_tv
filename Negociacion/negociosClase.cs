using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negociacion
{
    public class negociosClase
    {
        ValidacionesDatos ValData = new ValidacionesDatos();
        LeerDatos ReadData= new LeerDatos();
        GuardarDatos SaveData= new GuardarDatos();
        public bool loginVerificacion(string user, string password)
        {
            return ValData.ValidacionCredencialesLogin(user, password);
        }
        public DataTable dtClientes()
        {
            return ReadData.listadoClientes();
        }
        public int guardarCliente(string dpi, string nombre, string apellido, string tel1, string tel2, string direccion, string email)
        {
            return SaveData.guardarClientesDt(dpi, nombre, apellido, tel1, tel2, direccion,  email);
        }
        public DataTable datosCliente(string dpi)
        {
            return(ReadData.datosClienteSeleccionado(dpi));
        }


        public bool editarCliente(string dpi, string nombre, string apellido, string tel1, string tel2, string direccion, string email)
        {
            return SaveData.editarCliente(dpi, nombre, apellido, tel1, tel2, direccion, email);
        }

        //
        //Empleados
        //
        
        public string[] generaCredenciales(string nombre, string apellido)
        {
            string user = $"{nombre.Substring(0,3)}{apellido.Substring(0, 2)}".ToLower();
            user.Concat(ValData.numeroUsuariosExitentesEmpleado(user).ToString());

            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyz1234567890";
            int longitud = caracteres.Length;
            char letra;
            int longitudContrasenia = 8;
            string password = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                password += letra.ToString();
            }
            string[] variables = { user, password };
            return variables;
        }


    }
}
