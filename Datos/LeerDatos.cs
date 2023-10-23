using Datos.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class LeerDatos
    {
        DB.ConexionLinqSqlDataContext linqConect = new DB.ConexionLinqSqlDataContext(ConexionSql.route);
        public DataTable listadoClientes()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("dpi");
            dt.Columns.Add("nombre");
            dt.Columns.Add("direccion");
            dt.Columns.Add("tel1");
            dt.Columns.Add("tel2");
            dt.Columns.Add("correo");

            try
            {
                var listadoCl = from clientess in linqConect.clientes
                                select new
                                {
                                    dpi = clientess.dpi_cliente,
                                    nombre = $"{clientess.nombre_cliente} {clientess.apellido_cliente}",
                                    direccion = clientess.direccion_cliente,
                                    tel1 = clientess.telefono1_cliente,
                                    tel2 = clientess.telefono2_cliente,
                                    correo = clientess.email_cliente
                                };

                foreach (var cliente in listadoCl)
                {
                    dt.Rows.Add(cliente.dpi, cliente.nombre, cliente.direccion, cliente.tel1, cliente.tel2, cliente.correo);
                };
            }
            catch { }
            return dt;
        }
        public DataTable datosClienteSeleccionado(string dpi)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("dpi");
            dt.Columns.Add("nombre");
            dt.Columns.Add("apellido");
            dt.Columns.Add("direccion");
            dt.Columns.Add("tel1");
            dt.Columns.Add("tel2");
            dt.Columns.Add("correo");

            try
            {
                var cliente = (from clientess in linqConect.clientes
                               where clientess.dpi_cliente.Equals(dpi)
                                select new
                                {
                                    nombre = clientess.nombre_cliente,
                                    apellido= clientess.apellido_cliente,
                                    direccion = clientess.direccion_cliente,
                                    tel1 = clientess.telefono1_cliente,
                                    tel2 = clientess.telefono2_cliente,
                                    correo = clientess.email_cliente
                                }).ToList();
                dt.Rows.Add( cliente[0].nombre, cliente[0].apellido, cliente[0].direccion, cliente[0].tel1, cliente[0].tel2, cliente[0].correo);
                
            }
            catch { }
            return dt;
        }

        //
        //datos de los contratos
        //

        public DataTable listadoContratos(bool estado)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("nombre");
            dt.Columns.Add("descripcion");
            dt.Columns.Add("sueldo");
            dt.Columns.Add("duracion");

            try
            {
                var listaContr = from contratos in linqConect.contratos_empleados
                                 where contratos.estado_contrato.Equals(estado)
                                 select new
                                 {
                                     codigo = contratos.id_contratos_empleados,
                                     nombre = contratos.nombre_contrato,
                                     descripcion = contratos.descripcion_contrato,
                                     sueldo = contratos.sueldo_contrato,
                                     duracion = contratos.duracion_contrato_meses
                                 };

                foreach (var empleado in listaContr)
                {
                    dt.Rows.Add(empleado.codigo, empleado.nombre, empleado.descripcion, empleado.sueldo, empleado.duracion);
                };
            }
            catch { }
            return dt;
        }
        public DataTable datosContrato(string codigo)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("nombre");
            dt.Columns.Add("descripcion");
            dt.Columns.Add("sueldo");
            dt.Columns.Add("duracion");
            dt.Columns.Add("rango");

            try
            {
                var listaContr = from contratos in linqConect.contratos_empleados
                                 where contratos.id_contratos_empleados.Equals(codigo)
                                 select new
                                 {
                                     codigo = contratos.id_contratos_empleados,
                                     nombre = contratos.nombre_contrato,
                                     descripcion = contratos.descripcion_contrato,
                                     sueldo = contratos.sueldo_contrato,
                                     duracion = contratos.duracion_contrato_meses,
                                     rango=contratos.rango_accesp_contrato,
                                 };

                foreach (var empleado in listaContr)
                {
                    dt.Rows.Add(empleado.codigo, empleado.nombre, empleado.descripcion, empleado.sueldo, empleado.duracion,empleado.rango);
                };
            }
            catch { }
            return dt;
        }

    }
}
