using Datos.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Datos.Empleados
{
    public class GuardarEmpleados
    {

        DB.ConexionLinqSqlDataContext linqConect = new DB.ConexionLinqSqlDataContext(ConexionSql.route);
        public bool editarEmpleado(string dpi, string nombre, string apellido, string tel, string direccion, string correo)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var editEmpleado = (from empleado in linqConect.empleados
                                        where empleado.dpi_empleado.Equals(dpi)
                                        select empleado).FirstOrDefault();
                    editEmpleado.nombre_empleado = nombre;
                    editEmpleado.apellidos_empleado = apellido;
                    editEmpleado.telefono_empleado = tel;
                    editEmpleado.email_empleado = correo;
                    editEmpleado.direccion_empleado = direccion;

                    linqConect.SubmitChanges();
                    transa.Complete();
                    return true;
                }
                catch
                {
                    transa.Dispose();
                    return false;
                }
            }
        }

        public int guardarEmpleado(string dpi, string nombre, string apellido, string tel,string direccion, string correo, string usuario, string contrasena)
        {

            int resul = 0;
            var comprobacion1 = (from empleadoss in linqConect.detalle_contrato_empleado
                                 where empleadoss.dpi_empleado.Equals(dpi) && empleadoss.estado_contrato == true
                                 select empleadoss
                                ).ToList().Count == 0;
            if (comprobacion1)
            {
                resul = 1;
                var comprobacion2 = (from empleadoss in linqConect.empleados
                                     where empleadoss.dpi_empleado.Equals(dpi)
                                     select empleadoss
                                    ).ToList().Count == 0;
                if (comprobacion2)
                {
                    using (TransactionScope transa = new TransactionScope())
                    {
                        try
                        {
                            DB.empleados nuevoEmpleado = new DB.empleados()
                            {
                                dpi_empleado = dpi,
                                nombre_empleado = nombre,
                                apellidos_empleado = apellido,
                                telefono_empleado = tel,
                                email_empleado = correo,
                                usuario_empleado = usuario,
                                contrasena_empleado = contrasena,
                                estado_empleado = false,
                                direccion_empleado=direccion
                            };

                            linqConect.empleados.InsertOnSubmit(nuevoEmpleado);
                            linqConect.SubmitChanges();
                            transa.Complete();
                            resul = 2;
                        }
                        catch
                        {
                            transa.Dispose();
                            resul = 3;
                        }
                    }
                }
            }
            return resul;
        }
        public bool contrataEmpleado(int codigoContrato, string dpi)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var rangosEmpleado = (from contrato in linqConect.contratos_empleados
                                          where contrato.id_contratos_empleados.Equals(codigoContrato)
                                          select contrato).ToList();
                    detalle_contrato_empleado nuevaContratacion = new detalle_contrato_empleado()
                    {
                        dpi_empleado = dpi,
                        estado_contrato = true,
                        fecha_contrato = DateTime.Now,
                        tipo_empleado = rangosEmpleado[0].rango_accesp_contrato,
                        id_contratos_empleados = codigoContrato,
                    };
                    linqConect.detalle_contrato_empleado.InsertOnSubmit(nuevaContratacion);
                    linqConect.SubmitChanges();

                    var empleadoContratado = (from empleado in linqConect.empleados
                                              where empleado.dpi_empleado.Equals(dpi)
                                              select empleado).ToList();
                    empleadoContratado[0].estado_empleado = true;

                    linqConect.SubmitChanges();
                    transa.Complete();
                    return true;
                }
                catch
                {
                    transa.Dispose();
                    return false;
                }
            }
        }

    }
}
