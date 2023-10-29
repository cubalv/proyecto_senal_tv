using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Empleados
{
    public class LeerEmpleados
    {
        DB.ConexionLinqSqlDataContext linqConect = new DB.ConexionLinqSqlDataContext(ConexionSql.route);

        public DataTable listadoEmpleados()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("dpi");
            dt.Columns.Add("nombre");
            dt.Columns.Add("telefono");
            dt.Columns.Add("direccion");
            dt.Columns.Add("correo");

            try
            {
                var listadoEmp = from empleadoss in linqConect.empleados
                                 select new
                                 {
                                     dpi = empleadoss.dpi_empleado,
                                     nombre = $"{empleadoss.nombre_empleado} {empleadoss.apellidos_empleado}",
                                     telefono = empleadoss.telefono_empleado,
                                     direccion = empleadoss.direccion_empleado,
                                     correo = empleadoss.email_empleado
                                 };

                foreach (var empleado in listadoEmp)
                {
                    dt.Rows.Add(empleado.dpi, empleado.nombre, empleado.telefono, empleado.direccion, empleado.correo);
                };
            }
            catch { }
            return dt;
        }
        public DataTable listadoEmpleados(int permisos)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("dpi");
            dt.Columns.Add("nombre");
            dt.Columns.Add("telefono");
            dt.Columns.Add("direccion");
            dt.Columns.Add("correo");

            try
            {
                var listadoEmp = from empleadoss in linqConect.detalle_contrato_empleado
                                 where empleadoss.tipo_empleado.Equals(permisos)
                                 select new
                                 {
                                     dpi = empleadoss.empleados.dpi_empleado,
                                     nombre = $"{empleadoss.empleados.nombre_empleado} {empleadoss.empleados.apellidos_empleado}",
                                     telefono = empleadoss.empleados.telefono_empleado,
                                     direccion = empleadoss.empleados.direccion_empleado,
                                     correo = empleadoss.empleados.email_empleado
                                 };

                foreach (var empleado in listadoEmp)
                {
                    dt.Rows.Add(empleado.dpi, empleado.nombre, empleado.telefono, empleado.direccion, empleado.correo);
                };
            }
            catch { }
            return dt;
        }
        public DataTable datosEmpleado(string dpi)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("dpi");
            dt.Columns.Add("nombre");
            dt.Columns.Add("apellido");
            dt.Columns.Add("direccion");
            dt.Columns.Add("telefono");
            dt.Columns.Add("correo");
            dt.Columns.Add("usuario");
            dt.Columns.Add("contrasena");

            try
            {
                var listadoEmp = from empleadoss in linqConect.empleados
                                 where empleadoss.dpi_empleado.Equals(dpi)
                                 select new
                                 {
                                     dpi = empleadoss.dpi_empleado,
                                     nombre = $"{empleadoss.nombre_empleado}",
                                     apellido = $"{empleadoss.apellidos_empleado}",
                                     telefono = empleadoss.telefono_empleado,
                                     direccion = empleadoss.direccion_empleado,
                                     correo = empleadoss.email_empleado,
                                     usuario = empleadoss.usuario_empleado,
                                     contrasena = empleadoss.contrasena_empleado
                                 };

                foreach (var empleado in listadoEmp)
                {
                    dt.Rows.Add(empleado.dpi, empleado.nombre, empleado.apellido, empleado.direccion, empleado.telefono, empleado.correo, empleado.usuario, empleado.contrasena);
                };
            }
            catch { }
            return dt;
        }

        public int comprobarExistenciaEmpleado(string dpi)
        {
            var comprobacion1 = (from empleadoss in linqConect.detalle_contrato_empleado
                                 where empleadoss.dpi_empleado.Equals(dpi) && empleadoss.estado_contrato == true
                                 select empleadoss
                                ).ToList().Count > 0;
            if (comprobacion1)
                return 0;
            else
            {

                var comprobacion2 = (from empleadoss in linqConect.empleados
                                     where empleadoss.dpi_empleado.Equals(dpi)
                                     select empleadoss
                                    ).ToList().Count > 0;
                if (comprobacion2)
                    return 1;
                else
                    return 2;
            }
        }

        public bool comprobarContratoDelEmpleado(string dpi)
        {
            var comprobacion = (from detalles in linqConect.detalle_contrato_empleado
                                where detalles.estado_contrato == true && detalles.dpi_empleado.Equals(dpi)
                                select detalles).ToList().Count == 0;
            return comprobacion;
        }

        public DataTable misionesEmpleados(bool estadoAsignado)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("concepto");
            try
            {
                var misiones = (from mision in linqConect.encabezado_misiones
                               where mision.estado_asignacion.Equals(estadoAsignado)
                               select new
                               {
                                   codigo=mision.id_misiones,
                                   concepto =mision.concepto_mision,
                               }).ToList();
                foreach (var item in misiones)
                {
                    dt.Rows.Add(item.codigo,item.concepto);
                };
            }
            catch { }

            return dt;
        }

        public DataTable misionesEmpleados(string dpiEmpleado)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("concepto");
            try
            {
                var misiones = (from mision in linqConect.relacion_mision_empleado
                                where mision.dpi_empleado.Equals(dpiEmpleado)
                                select new
                                {
                                    codigo = mision.id_misiones,
                                    concepto = mision.encabezado_misiones.concepto_mision,
                                }).ToList();
                foreach (var item in misiones)
                {
                    dt.Rows.Add(item.codigo, item.concepto);
                };
            }
            catch { }

            return dt;
        }
    }
}
