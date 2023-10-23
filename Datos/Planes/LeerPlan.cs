using Datos.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Planes
{
    public class LeerPlan
    {
        ConexionLinqSqlDataContext linqConect = new ConexionLinqSqlDataContext(ConexionSql.route);

        public DataTable listadoPlanes(bool estado)
        {
            linqConect = new ConexionLinqSqlDataContext(ConexionSql.route);
            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("nombre");
            dt.Columns.Add("descripcion");
            dt.Columns.Add("precioIns");
            dt.Columns.Add("precioMens");
            dt.Columns.Add("duracion");

            try
            {
                var planess = from plan in linqConect.planes
                              where plan.estado_plan == estado
                                 select new
                                 {
                                     codigo = plan.id_plan,
                                     nombre = plan.nombre_plan,
                                     descripcion = plan.descripcion_plan,
                                     precioIns = plan.precio_instalacion,
                                     precioMens = plan.precio_plan,
                                     duracion = plan.minimo_meses_contratacion,
                                 };

                foreach (var plan in planess)
                {
                    dt.Rows.Add(plan.codigo, plan.nombre, plan.descripcion, plan.precioIns, plan.precioMens, plan.duracion);
                };
            }
            catch { }
            return dt;
        }
        public DataTable datosPlanes(int codigoPlan)
        {
            linqConect = new ConexionLinqSqlDataContext(ConexionSql.route);
            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("nombre");
            dt.Columns.Add("descripcion");
            dt.Columns.Add("precioIns");
            dt.Columns.Add("precioMens");
            dt.Columns.Add("duracion");

            try
            {
                var plan = (from plann in linqConect.planes
                            where plann.id_plan.Equals(codigoPlan)
                              select new
                              {
                                  codigo = plann.id_plan,
                                  nombre = plann.nombre_plan,
                                  descripcion = plann.descripcion_plan,
                                  precioIns = plann.precio_instalacion,
                                  precioMens = plann.precio_plan,
                                  duracion = plann.minimo_meses_contratacion,
                              }).FirstOrDefault();
                dt.Rows.Add(plan.codigo, plan.nombre, plan.descripcion, plan.precioIns, plan.precioMens, plan.duracion);
            }
            catch { }
            return dt;
        }
    }
}
