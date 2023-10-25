using Datos.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ContratosClientes
{
    public class LeerContratoClientes
    {
        ConexionLinqSqlDataContext linqConect = new ConexionLinqSqlDataContext(ConexionSql.route);
        public bool verificarDisponibilidadZona(int codigoZona, int codigoPlan)
        {
            bool resultado = false;
            var serviciosRequeridosPorZona = (from serviciosZona in linqConect.disponibilidades
                                            where serviciosZona.id_zona.Equals(codigoZona) && serviciosZona.estado_disponibilidad.Equals(true)
                                            select new
                                            {
                                                idServicio=serviciosZona.id_servicio
                                            }).ToList();

            var serviciosRequeridosPorPlan = (from servicios in linqConect.detalle_plan
                                       where servicios.id_plan.Equals(codigoPlan) && servicios.estado_detalle.Equals(true)
                                      select new
                                      {
                                          idServicio = servicios.id_servicio
                                      }).ToList();

            if(serviciosRequeridosPorZona.Count >= serviciosRequeridosPorPlan.Count)
            {
                var serviciosQueSiExisten = (serviciosRequeridosPorZona.Intersect(serviciosRequeridosPorPlan)).ToList();
                if (serviciosQueSiExisten.Count == serviciosRequeridosPorPlan.Count)
                    resultado = true;
                else
                    resultado = false;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }
    }
}
