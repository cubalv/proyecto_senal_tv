using Datos.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Comun;
using Comun.Cache;
using Datos.Zonas;

namespace Datos.ContratosClientes
{
    public class GuardarContratoClientes
    {
        ConexionLinqSqlDataContext linqConect = new ConexionLinqSqlDataContext(ConexionSql.route);
        public bool guardarContratoNuevo(string dpi, int codigoPlan, int codigoZona,string direccionInstalacion, string direccionCobro, string nit,string detallesContrato,decimal precioMensual,decimal precioInstalacion)
        {
            using(TransactionScope transa = new TransactionScope())
            {
                try
                {
                    contrato_cliente_plan nuevoContrato = new contrato_cliente_plan()
                    {
                        dpi_cliente = dpi,
                        id_plan = codigoPlan,
                        fecha_contratacion = DateTime.Now,
                        direccion_contrato = direccionInstalacion,
                        direccion_de_cobro = direccionCobro,
                        estado_contrato = true,
                        nit_facturacion = nit,
                        id_zona = codigoZona,
                        detalles_contrato = detallesContrato,
                        dpi_empleado = CacheLogin.dpi_usuario,
                        precio_plan = precioMensual
                    };
                    linqConect.contrato_cliente_plan.InsertOnSubmit(nuevoContrato);
                    linqConect.SubmitChanges();

                    solicitudes_de_contrato NuevoSolicitud = new solicitudes_de_contrato()
                    {
                        fecha_solicitud=DateTime.Now,
                        id_contrato_cliente_plan=nuevoContrato.id_contrato_cliente_plan,
                        total_pago=precioInstalacion,
                        estado_solicitud=true,
                        concepto_solicitud="Instalacion",
                    };
                    linqConect.solicitudes_de_contrato.InsertOnSubmit(NuevoSolicitud);
                    linqConect.SubmitChanges();
                    DateTime manana = Convert.ToDateTime($"{DateTime.Now.Day}/{DateTime.Now.ToString("MM/yyyy")}");
                    encabezado_misiones NuevaMision = new encabezado_misiones()
                    {
                        fecha_creacion = DateTime.Now,
                        concepto_mision = "Instalar servicio contratado.",
                        fecha_programada = manana,
                        estado_asignacion = false,
                        estado_mision = true,

                    };
                    linqConect.encabezado_misiones.InsertOnSubmit(NuevaMision);
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
        public bool guardarContratoNuevoConInstalacionZona(string dpi, int codigoPlan, int codigoZona, string direccionInstalacion, string direccionCobro, string nit, string detallesContrato, decimal precioMensual, decimal precioInstalacion)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    contrato_cliente_plan nuevoContrato = new contrato_cliente_plan()
                    {
                        dpi_cliente = dpi,
                        id_plan = codigoPlan,
                        fecha_contratacion = DateTime.Now,
                        direccion_contrato = direccionInstalacion,
                        direccion_de_cobro = direccionCobro,
                        estado_contrato = true,
                        nit_facturacion = nit,
                        id_zona = codigoZona,
                        detalles_contrato = detallesContrato,
                        dpi_empleado = CacheLogin.dpi_usuario,
                        precio_plan = precioMensual
                    };
                    linqConect.contrato_cliente_plan.InsertOnSubmit(nuevoContrato);
                    linqConect.SubmitChanges();

                    solicitudes_de_contrato NuevoSolicitud = new solicitudes_de_contrato()
                    {
                        fecha_solicitud = DateTime.Now,
                        id_contrato_cliente_plan = nuevoContrato.id_contrato_cliente_plan,
                        total_pago = precioInstalacion,
                        estado_solicitud = true,
                        concepto_solicitud = "Instalacion",
                    };
                    linqConect.solicitudes_de_contrato.InsertOnSubmit(NuevoSolicitud);
                    linqConect.SubmitChanges();
                    DateTime manana = Convert.ToDateTime($"{DateTime.Now.Day}/{DateTime.Now.ToString("MM/yyyy")}");
                    encabezado_misiones NuevaMision = new encabezado_misiones()
                    {
                        fecha_creacion = DateTime.Now,
                        concepto_mision = "Instalar servicio contratado.",
                        fecha_programada = manana,
                        estado_asignacion = false,
                        estado_mision = true,

                    };
                    linqConect.encabezado_misiones.InsertOnSubmit(NuevaMision);
                    linqConect.SubmitChanges();

                    List<int> servicios = new List<int>();
                    var serviciosAinstalar = (from listado in linqConect.detalle_plan
                                              where listado.id_plan.Equals(codigoPlan)
                                              select new
                                              {
                                                  idServ = listado.id_servicio
                                              });
                    GuardarZonas auxZona = new GuardarZonas();
                    foreach(var item in serviciosAinstalar)
                    {
                        servicios.Add(item.idServ);
                    }
                    if(auxZona.editarDisponibilidades(codigoZona, servicios))
                    {
                        transa.Complete();
                        return true;
                    }
                    else
                    {
                        transa.Dispose();
                        return false;
                    }
                    

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
