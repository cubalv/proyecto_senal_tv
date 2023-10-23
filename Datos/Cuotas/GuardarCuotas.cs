using Datos.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Datos.Cuotas
{
    public class GuardarCuotas
    {
        ConexionLinqSqlDataContext linqConect = new ConexionLinqSqlDataContext(ConexionSql.route);
        public bool guardarCuota(string nombre, string descripcion, decimal precio)
        {
            using (TransactionScope transa = new TransactionScope()) 
            {
                try 
                {
                    cuota nuevaCuota = new cuota()
                    {
                        nombre_cuota = nombre,
                        descripcion_cuota = descripcion,
                        costo_cuota = precio,
                        estado_cuota = true
                    };
                    linqConect.cuota.InsertOnSubmit(nuevaCuota);
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
        public bool editarCuota(int codigo,string nombre, string descripcion, decimal precio)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var cuotaAEditar=(from cuot in linqConect.cuota
                                      where cuot.id_cuota.Equals(codigo)
                                      select cuot).FirstOrDefault();
                    cuotaAEditar.nombre_cuota= nombre;
                    cuotaAEditar.descripcion_cuota= descripcion;
                    cuotaAEditar.costo_cuota= precio;

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
        public bool deshabilitarCuota(int codigo)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var cuotaAEditar = (from cuot in linqConect.cuota
                                        where cuot.id_cuota.Equals(codigo) && cuot.estado_cuota.Equals(true)
                                        select cuot).FirstOrDefault();
                    cuotaAEditar.estado_cuota = false;

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
        public bool rehabilitarCuota(int codigo)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var cuotaAEditar = (from cuot in linqConect.cuota
                                        where cuot.id_cuota.Equals(codigo) && cuot.estado_cuota.Equals(false)
                                        select cuot).FirstOrDefault();
                    cuotaAEditar.estado_cuota = true;

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
