using Datos.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Cuotas
{
    public class LeerCuotas
    {
        ConexionLinqSqlDataContext linqConect = new ConexionLinqSqlDataContext(ConexionSql.route);
        public DataTable listadoCuotas(bool estado)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("nombre");
            dt.Columns.Add("descripcion");
            dt.Columns.Add("costo");
            try
            {
                var listaCuotas = (from cuotas in linqConect.cuota
                                   where cuotas.estado_cuota.Equals(estado)
                                   select new
                                   {
                                       codigo = cuotas.id_cuota,
                                       nombre = cuotas.nombre_cuota,
                                       descripcion = cuotas.descripcion_cuota,
                                       costo = cuotas.costo_cuota,
                                   });
                foreach (var item in listaCuotas)
                {
                    dt.Rows.Add(item.codigo,item.nombre,item.descripcion,item.costo);
                }  
            }
            catch { }

            return dt;
        }
        public DataTable datosCuotas(int codigo)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("nombre");
            dt.Columns.Add("descripcion");
            dt.Columns.Add("costo");
            try
            {
                var datosCuota = (from cuotas in linqConect.cuota
                                   where cuotas.id_cuota.Equals(codigo)
                                   select new
                                   {
                                       codigo = cuotas.id_cuota,
                                       nombre = cuotas.nombre_cuota,
                                       descripcion = cuotas.descripcion_cuota,
                                       costo = cuotas.costo_cuota,
                                   }).FirstOrDefault();
                dt.Rows.Add(datosCuota.codigo, datosCuota.nombre, datosCuota.descripcion, datosCuota.costo);
            }
            catch { }

            return dt;
        }
    }
}
