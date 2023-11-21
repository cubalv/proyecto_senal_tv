using Datos.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Datos.Facturas
{
    public class GuardarFacturas
    {
        ConexionLinqSqlDataContext linqConect = new ConexionLinqSqlDataContext();
        public void crearFacturas()
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    List<int> codigosContratos = new List<int>();
                    var listadoContratos = (from contrato in linqConect.contrato_cliente_plan
                                            where contrato.estado_contrato.Equals(true)
                                            select contrato).ToList();
                    foreach(var item in listadoContratos)
                    {
                        codigosContratos.Add(Convert.ToInt32(item.id_contrato_cliente_plan));
                    }
                    
                    List<int> codigosContratosConFactura = new List<int>();
                    var listadoContratoConFactura = (from contrato in linqConect.encabezado_facturas
                                                     where contrato.fecha_pago_factura.Month.Equals(DateTime.Now.Month)
                                                     select contrato).ToList();
                    foreach (var item in listadoContratoConFactura)
                    {
                        codigosContratosConFactura.Add(Convert.ToInt32(item.id_contrato_cliente_plan));
                    }

                    List<int> codigoContratosSinFactura = codigosContratos.Except(codigosContratosConFactura).ToList();
                    foreach(int contrato in codigoContratosSinFactura)
                    {
                        var precioPlan = (from contraton in linqConect.contrato_cliente_plan
                                          where contraton.id_contrato_cliente_plan.Equals(contrato)
                                          select new
                                          {
                                              precio = contraton.precio_plan
                                          }).FirstOrDefault();
                        encabezado_facturas nuevaFactura = new encabezado_facturas()
                        {
                            fecha_creacion_factura = DateTime.Now,
                            monto_factura = precioPlan.precio,
                            mora_factura = 0,
                            total_factura = precioPlan.precio,
                            estado_factura = true,
                            fecha_pago_factura = Convert.ToDateTime(DateTime.Now.ToString("15/MM/yyyy")),
                            id_contrato_cliente_plan = contrato,
                            dias_retraso_pago=0
                        };
                        linqConect.encabezado_facturas.InsertOnSubmit(nuevaFactura);
                        linqConect.SubmitChanges();
                    }
                    transa.Complete();
                }
                catch
                {
                    transa.Dispose();
                }
            }
        }
        public void calcularMora()
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var cuotas = (from moraC in linqConect.cuota
                                where moraC.id_cuota.Equals(4)
                                select new
                                {
                                    cuotamora = moraC.costo_cuota
                                }).FirstOrDefault();
                    decimal mora = cuotas.cuotamora;

                    var listaFacturas = (from facturas in linqConect.encabezado_facturas
                                        where facturas.estado_factura.Equals(true)
                                        select facturas).ToList();
                    foreach (var f in listaFacturas)
                    {
                        if(f.ultima_fecha_mora != DateTime.Now)
                        {
                            int diaActual = DateTime.Now.Day;
                            int mesActual = DateTime.Now.Month;
                            int diaFactura = 15;
                            int mesFactura = f.fecha_creacion_factura.Month;
                            if (mesActual >= mesFactura && diaActual >= diaFactura)
                            {
                                f.mora_factura += mora;
                                f.total_factura = f.monto_factura + f.mora_factura;
                                f.dias_retraso_pago += 1;
                                f.ultima_fecha_mora = DateTime.Now;
                            }
                            linqConect.SubmitChanges();
                        }
                    }
                    transa.Complete();
                }
                catch
                {
                    transa.Dispose();
                }
            }
        }
        public bool pagarFactura(int codigoFactura)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var factrua = (from fact in linqConect.encabezado_facturas
                                   where fact.id_factura.Equals(codigoFactura)
                                   select fact
                                   ).FirstOrDefault();
                    factrua.estado_factura = false;
                    factrua.fecha_pago_factura = DateTime.Now;
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
