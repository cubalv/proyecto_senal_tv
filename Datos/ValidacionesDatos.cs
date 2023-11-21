using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Comun;
using Datos.DB;
using System.Transactions;

namespace Datos
{
    public class ValidacionesDatos
    {
        DB.ConexionLinqSqlDataContext linqConect = new DB.ConexionLinqSqlDataContext(ConexionSql.route);
        public bool ValidacionCredencialesLogin(string user, string password)
        {
            var validacion = (from dtContrato in linqConect.detalle_contrato_empleado
                              where dtContrato.empleados.usuario_empleado.Equals(user) && dtContrato.empleados.contrasena_empleado.Equals(password) && dtContrato.estado_contrato == true
                              select new
                              {
                                  dpi = dtContrato.dpi_empleado,
                                  nombre = dtContrato.empleados.nombre_empleado,
                                  apellido = dtContrato.empleados.apellidos_empleado,
                                  rango = dtContrato.tipo_empleado
                              }).ToList();
            if (validacion.Count > 0)
            {
                Comun.Cache.CacheLogin.dpi_usuario = validacion[0].dpi;
                Comun.Cache.CacheLogin.nombre = validacion[0].nombre;
                Comun.Cache.CacheLogin.apellido = validacion[0].apellido;
                Comun.Cache.CacheLogin.rango_permisos = validacion[0].rango;

                return true;
            }
            else
                return false;
        }

        public int numeroUsuariosExitentesEmpleado(string User)
        {
            var numeroUsuarios = (from usuarios in linqConect.empleados
                                 where usuarios.usuario_empleado.StartsWith(User)
                                 select usuarios).ToList().Count;
            return numeroUsuarios;

        }
        public int validacionTecnico(string user, string password)
        {
            var validacion = (from dtContrato in linqConect.detalle_contrato_empleado
                              where dtContrato.empleados.usuario_empleado.Equals(user) && dtContrato.empleados.contrasena_empleado.Equals(password) && dtContrato.estado_contrato == true
                              select new
                              {
                                  dpi = dtContrato.dpi_empleado,
                                  nombre = dtContrato.empleados.nombre_empleado,
                                  apellido = dtContrato.empleados.apellidos_empleado,
                                  rango = dtContrato.tipo_empleado
                              }).ToList();
            if (validacion.Count > 0)
            {
                Comun.Cache.cacheLoginWeb.dpi_usuario = validacion[0].dpi;
                Comun.Cache.cacheLoginWeb.nombre = validacion[0].nombre;
                Comun.Cache.cacheLoginWeb.apellido = validacion[0].apellido;
                if (validacion[0].rango == 3)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }

            }
            else
                return 0;
        }
        public bool validacionCliente(string user, string password)
        {
            var cliente = (from clien in linqConect.clientes
                           where clien.dpi_cliente.Equals(user) && clien.contrasena_cliente.Equals(password)
                           select clien).FirstOrDefault();
            if(cliente == null)
            {
                return false;
            }
            else
            {
                Comun.Cache.cacheLoginWeb.dpi_usuario = cliente.dpi_cliente;
                Comun.Cache.cacheLoginWeb.nombre = cliente.nombre_cliente;
                Comun.Cache.cacheLoginWeb.apellido = cliente.apellido_cliente;
                return true;
            }
        }
    }
}
