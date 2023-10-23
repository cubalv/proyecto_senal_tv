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
