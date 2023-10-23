using Datos.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data;
using System.Collections;

namespace Datos.Zonas
{
    public class GuardarZonas
    {
        ConexionLinqSqlDataContext linqConect = new ConexionLinqSqlDataContext(ConexionSql.route);
        public bool GuardarZona(string nombreZona,int codigoMuni)
        {
            using(TransactionScope transa = new TransactionScope())
            {
                try
                {
                    zonas nuevaZona = new zonas()
                    {
                        nombre_zona=nombreZona,
                        id_muni=codigoMuni,
                    };
                    linqConect.zonas.InsertOnSubmit(nuevaZona);
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
        public bool editarZona(int codigoZona, string nombreZona, int codigoMuni)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var zonaAEditar = (from zona in linqConect.zonas
                                       where zona.id_zona.Equals(codigoZona)
                                       select zona).FirstOrDefault();

                    zonaAEditar.nombre_zona = nombreZona;
                    zonaAEditar.id_muni = codigoMuni;

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
        public bool editarDisponibilidades( int codigoZona, List<int> servicios)
        {

            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var listaDisponibilidades = from dispo in linqConect.disponibilidades
                                                 where dispo.id_zona.Equals(codigoZona) orderby dispo.id_servicio
                                                 select dispo;
                    servicios.Sort();
                    foreach (var disponibilidad in listaDisponibilidades)
                    {
                        disponibilidad.estado_disponibilidad = false;
                    }
                    linqConect.SubmitChanges();

                    List<int> auxServicios= new List<int>();

                    foreach (var servic in servicios)
                    {
                        if (listaDisponibilidades.ToList().Exists(x => x.id_servicio == servic))
                        {
                            listaDisponibilidades.ToList().Find(x => x.id_servicio.Equals(servic)).estado_disponibilidad = true;
                            auxServicios.Add(servic);
                        }
                        linqConect.SubmitChanges();
                    }

                    List<int> serviciosRestantes = servicios.Except(auxServicios).ToList();
                    if (serviciosRestantes.Count > 0)
                    {
                        foreach (int i in serviciosRestantes)
                        {
                            disponibilidades nuevoServicioDisponible = new disponibilidades()
                            {
                                id_zona = codigoZona,
                                id_servicio = i,
                                estado_disponibilidad = true
                            };
                            linqConect.disponibilidades.InsertOnSubmit(nuevoServicioDisponible);
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
