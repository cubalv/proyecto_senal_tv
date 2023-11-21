using Datos.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Datos.Planes
{
    public class GuardarPlan
    {
        ConexionLinqSqlDataContext linqConect = new ConexionLinqSqlDataContext(ConexionSql.route);
        public bool guardarPlan(string nombre,string descripcion, decimal precioMens, decimal precioIns,int duracion)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    planes nuevoPlan = new planes()
                    {
                        nombre_plan = nombre,
                        descripcion_plan = descripcion,
                        precio_plan = precioMens,
                        precio_instalacion = precioIns,
                        minimo_meses_contratacion = duracion,
                        estado_plan = true,
                        
                    };
                    linqConect.planes.InsertOnSubmit(nuevoPlan);
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
        public bool editarPlan(int codigo,string nombre, string descripcion, decimal precioMens, decimal precioIns, int duracion)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var planAEditar = (from plan in linqConect.planes
                                       where plan.id_plan.Equals(codigo)
                                       select plan).FirstOrDefault();

                    planAEditar.nombre_plan = nombre;
                    planAEditar.descripcion_plan = descripcion;
                    planAEditar.precio_plan = precioMens;
                    planAEditar.precio_instalacion = precioIns;
                    planAEditar.minimo_meses_contratacion = duracion;

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

        public bool deshabilitarPlan(int codigo)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var planAEditar = (from plan in linqConect.planes
                                       where plan.id_plan.Equals(codigo) && plan.estado_plan.Equals(true)
                                       select plan).FirstOrDefault();
                    planAEditar.estado_plan = false;

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
        public bool rehabilitarPlan(int codigo)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var planAEditar = (from plan in linqConect.planes
                                       where plan.id_plan.Equals(codigo) && plan.estado_plan.Equals(false)
                                       select plan).FirstOrDefault();
                    planAEditar.estado_plan = true;

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
        public bool editarDetallesPlan(int codigoPlan, List<int> servicios)
        {

            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var listaDetallesPlan = from planess in linqConect.detalle_plan
                                                where planess.id_plan.Equals(codigoPlan)
                                                orderby planess.id_servicio
                                                select planess;
                    servicios.Sort();
                    foreach (var disponibilidad in listaDetallesPlan)
                    {
                        disponibilidad.estado_detalle = false;
                    }
                    linqConect.SubmitChanges();

                    List<int> auxServicios = new List<int>();

                    foreach (var servic in servicios)
                    {
                        if (listaDetallesPlan.ToList().Exists(x => x.id_servicio == servic))
                        {
                            listaDetallesPlan.ToList().Find(x => x.id_servicio.Equals(servic)).estado_detalle = true;
                            auxServicios.Add(servic);
                        }
                        linqConect.SubmitChanges();
                    }

                    List<int> serviciosRestantes = servicios.Except(auxServicios).ToList();
                    if (serviciosRestantes.Count > 0)
                    {
                        foreach (int i in serviciosRestantes)
                        {
                            detalle_plan nuevoDetalle = new detalle_plan()
                            {
                                id_plan = codigoPlan,
                                id_servicio = i,
                                estado_detalle = true
                            };
                            linqConect.detalle_plan.InsertOnSubmit(nuevoDetalle);
                            linqConect.SubmitChanges();
                        }
                    }
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
