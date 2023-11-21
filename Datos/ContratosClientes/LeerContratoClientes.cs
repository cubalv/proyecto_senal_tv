using Datos.DB;
using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable listadoContratosCliente(bool estado)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("cliente");
            dt.Columns.Add("plan");
            dt.Columns.Add("fechaCont");
            dt.Columns.Add("direccion");
            try
            {
                var listadoContratos = (from contratos in linqConect.contrato_cliente_plan
                                        where contratos.estado_contrato.Equals(estado)
                                        select new
                                        {
                                            codigo=contratos.id_contrato_cliente_plan,
                                            cliente=$"{contratos.clientes.nombre_cliente} {contratos.clientes.apellido_cliente}",
                                            plan=contratos.planes.nombre_plan,
                                            fechaCont=contratos.fecha_contratacion,
                                            direccion=contratos.direccion_contrato
                                        }).ToList();
                foreach (var item in listadoContratos)
                {
                    dt.Rows.Add(item.codigo,item.cliente,item.plan,Convert.ToDateTime(item.fechaCont).ToString("dd/MM/yyyy"),item.direccion);
                }
            }
            catch { }

            return dt;
        }
        public DataTable datosDelContrato(int codigo)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("dpi");
            dt.Columns.Add("cliente");
            dt.Columns.Add("plan");
            dt.Columns.Add("fechaCont");
            dt.Columns.Add("direccion");
            try
            {
                var datos = (from contratos in linqConect.contrato_cliente_plan
                                        where contratos.id_contrato_cliente_plan.Equals(codigo)
                                        select new
                                        {
                                            dpi = contratos.dpi_cliente,
                                            cliente = $"{contratos.clientes.nombre_cliente} {contratos.clientes.apellido_cliente}",
                                            plan = contratos.planes.nombre_plan,
                                            fechaCont = contratos.fecha_contratacion,
                                            direccion = contratos.direccion_contrato
                                        }).FirstOrDefault();
                dt.Rows.Add(datos.dpi, datos.cliente, datos.plan, Convert.ToDateTime(datos.fechaCont).ToString("dd/MM/yyyy"), datos.direccion);

            }
            catch { }

            return dt;
        }
        public DataTable listadoContratosPorCliente(string dpi)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("fechaContra");
            dt.Columns.Add("plan");
            dt.Columns.Add("direccion");
            dt.Columns.Add("detalles");
            try
            {
                var listadoContratos = (from contratos in linqConect.contrato_cliente_plan
                             where contratos.dpi_cliente.Equals(dpi)
                             select new
                             {
                                 codigo = contratos.id_contrato_cliente_plan,
                                 fechaCont = contratos.fecha_contratacion,
                                 plan = contratos.planes.nombre_plan,
                                 direccion = contratos.direccion_contrato,
                                 detalles = contratos.detalles_contrato,
                             }).ToList();

                foreach (var item in listadoContratos)
                {
                    dt.Rows.Add(item.codigo, item.fechaCont.ToString("dd/MM/yyyy"), item.plan, item.direccion, item.detalles);
                }
            }
            catch { }

            return dt;
        }
        public DataTable listadoContratosMora()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Fecha cont.");
            dt.Columns.Add("Plan");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Dias de Mora");
            try
            {
                var listadoContratos = (from contratos in linqConect.encabezado_facturas
                                        where contratos.dias_retraso_pago>0
                                        select new
                                        {
                                            codigo = contratos.contrato_cliente_plan.id_contrato_cliente_plan,
                                            nombre= $"{contratos.contrato_cliente_plan.clientes.nombre_cliente} {contratos.contrato_cliente_plan.clientes.nombre_cliente}",
                                            fechaCont = contratos.contrato_cliente_plan.fecha_contratacion,
                                            plan = contratos.contrato_cliente_plan.planes.nombre_plan,
                                            direccion = contratos.contrato_cliente_plan.direccion_contrato,
                                            dias = contratos.dias_retraso_pago,
                                        }).ToList();

                foreach (var item in listadoContratos)
                {
                    dt.Rows.Add(item.codigo,item.nombre, item.fechaCont.ToString("dd/MM/yyyy"), item.plan, item.direccion, item.dias);
                }
            }
            catch { }

            return dt;
        }
    }
}
