using Datos.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Datos.Servicios
{
    public class GuardarServicios
    {
        ConexionLinqSqlDataContext linqConect = new ConexionLinqSqlDataContext(ConexionSql.route);
        public bool guardarServicio(string nombre, string descripcion)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    servicio nuevoServicio = new servicio()
                    {
                        nombre_servicio = nombre,
                        descripcion_servicio = descripcion,
                        estado_servicio = true,
                    };
                    linqConect.servicio.InsertOnSubmit(nuevoServicio);
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
        public bool editarServicio(int codigo,string nombre, string descripcion)
        {
            using(TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var editaServicio = (from servicioss in linqConect.servicio
                                         where servicioss.id_servicio.Equals(codigo)
                                         select servicioss).FirstOrDefault();
                    editaServicio.nombre_servicio=nombre;
                    editaServicio.descripcion_servicio = descripcion;

                    linqConect.SubmitChanges();

                    transa.Complete();
                    return true;
                }
                catch
                {
                    transa.Dispose ();
                    return false;
                }
            }
        }
        public bool deshabilitaServicio(int codigo)
        {
            using( TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var servicioADeshabilitar= (from  servicioss in linqConect.servicio
                                                where servicioss.id_servicio.Equals(codigo) && servicioss.estado_servicio==true
                                                select servicioss).FirstOrDefault();
                    servicioADeshabilitar.estado_servicio = false;
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
        public bool rehabilitaServicio(int codigo)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var servicioARehabilitar = (from servicioss in linqConect.servicio
                                                 where servicioss.id_servicio.Equals(codigo) && servicioss.estado_servicio == false
                                                 select servicioss).FirstOrDefault();
                    servicioARehabilitar.estado_servicio = true;
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
