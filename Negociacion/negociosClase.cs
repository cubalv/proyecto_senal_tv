using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Facturas;

namespace Negociacion
{
    public class negociosClase
    {
        ValidacionesDatos ValData = new ValidacionesDatos();
        LeerDatos ReadData= new LeerDatos();
        GuardarDatos SaveData= new GuardarDatos();
        GuardarFacturas saveFacturas = new GuardarFacturas();
        public bool loginVerificacion(string user, string password)
        {
            return ValData.ValidacionCredencialesLogin(user, password);
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

        public int validarTecnico (string user, string pswrd)
        {
            return ValData.validacionTecnico(user, pswrd);
        }
        public void administrarFacturas()
        {
            saveFacturas.crearFacturas();
            saveFacturas.calcularMora();
        }
        public bool verificaCliente(string user, string pswrd) 
        {
            return ValData.validacionCliente(user, pswrd);
        }
        public DataTable historial()
        {
            return ReadData.historial();
        }
        public void guardarHistorial(string dpi, string concepto)
        {
            SaveData.guardarHistorial(dpi, concepto);
        }
    }
}
