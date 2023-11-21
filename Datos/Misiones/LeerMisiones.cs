using Datos.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Datos.Misiones
{
    public class LeerMisiones
    {
        ConexionLinqSqlDataContext linqConect = new ConexionLinqSqlDataContext();
        public DataTable listadMisiones(string dpiEmpleado)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("concepto");
            dt.Columns.Add("fechaProg");
            try
            {
                var misiones = (from mision in linqConect.relacion_mision_empleado
                                where mision.dpi_empleado.Equals(dpiEmpleado) && mision.encabezado_misiones.estado_mision.Equals(true)
                                select new
                                {
                                    codigo =mision.id_misiones,
                                    concepto=mision.encabezado_misiones.concepto_mision,
                                    fechaProg=mision.encabezado_misiones.fecha_programada,
                                });
                foreach(var item in misiones)
                {
                    dt.Rows.Add(item.codigo,item.concepto,item.fechaProg.ToString("dd/MM/yyyy"));
                }
            }
            catch { }
            return dt;
        }
        public bool completarMision(int codigoMision)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var misionAcompletar = (from misio in linqConect.encabezado_misiones
                                            where misio.id_misiones.Equals(codigoMision)
                                            select misio).FirstOrDefault();
                    misionAcompletar.estado_mision = false;
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
