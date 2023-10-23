using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Servicios
{
    public class LeerServicios
    {
        DB.ConexionLinqSqlDataContext linqConect = new DB.ConexionLinqSqlDataContext(ConexionSql.route);
        public DataTable listadoServicios(bool estado)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("nombre");
            dt.Columns.Add("descripcion");

            try
            {
                var listaContr = from servicios in linqConect.servicio
                                 where servicios.estado_servicio.Equals(estado)
                                 select new
                                 {
                                     codigo = servicios.id_servicio,
                                     nombre = servicios.nombre_servicio,
                                     descripcion = servicios.descripcion_servicio,
                                 };

                foreach (var empleado in listaContr)
                {
                    dt.Rows.Add(empleado.codigo, empleado.nombre, empleado.descripcion);
                };
            }
            catch { }
            return dt;
        }
        public DataTable datosServicios(int codigo)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("nombre");
            dt.Columns.Add("descripcion");

            try
            {
                var datosContr = (from servicios in linqConect.servicio
                                 where servicios.id_servicio.Equals(codigo)
                                 select new
                                 {
                                     codigo = servicios.id_servicio,
                                     nombre = servicios.nombre_servicio,
                                     descripcion = servicios.descripcion_servicio,
                                 }).FirstOrDefault();
                dt.Rows.Add(datosContr.codigo, datosContr.nombre, datosContr.descripcion);
            }
            catch { }
            return dt;
        }
        public DataTable listadoServiciosPorZona(int codigoZona)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("nombre");
            dt.Columns.Add("descripcion");

            try
            {
                var listaContr = from dispo in linqConect.disponibilidades
                                 where dispo.id_zona.Equals(codigoZona) && dispo.estado_disponibilidad.Equals(true)
                                 select new
                                 {
                                     codigo = dispo.id_servicio,
                                     nombre = dispo.servicio.nombre_servicio,
                                     descripcion = dispo.servicio.descripcion_servicio,
                                 };

                foreach (var empleado in listaContr)
                {
                    dt.Rows.Add(empleado.codigo, empleado.nombre, empleado.descripcion);
                };
            }
            catch { }
            return dt;
        }
        public DataTable listadoServiciosPorPlan(int codigoPlan)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("nombre");
            dt.Columns.Add("descripcion");

            try
            {
                var listaContr = from detalle in linqConect.detalle_plan
                                 where detalle.id_plan.Equals(codigoPlan) && detalle.estado_detalle.Equals(true)
                                 select new
                                 {
                                     codigo = detalle.id_servicio,
                                     nombre = detalle.servicio.nombre_servicio,
                                     descripcion = detalle.servicio.descripcion_servicio,
                                 };

                foreach (var detalle in listaContr)
                {
                    dt.Rows.Add(detalle.codigo, detalle.nombre, detalle.descripcion);
                };
            }
            catch { }
            return dt;
        }
    }
}

