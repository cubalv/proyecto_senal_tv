using Datos.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Facturas
{
    public class LeerFacturas
    {
        ConexionLinqSqlDataContext linqConect = new ConexionLinqSqlDataContext();
        public DataTable listadoFacturas(string dpi)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("direccion");
            dt.Columns.Add("nit");
            dt.Columns.Add("monto");
            dt.Columns.Add("mora");
            dt.Columns.Add("total");
            try
            {
                var facturas = (from factura in linqConect.encabezado_facturas
                                where factura.estado_factura.Equals(true) && factura.contrato_cliente_plan.dpi_cliente.Equals(dpi)
                                select new
                                {
                                    codigo = factura.id_factura,
                                    direccion = factura.contrato_cliente_plan.direccion_contrato,
                                    nit = factura.contrato_cliente_plan.nit_facturacion,
                                    monto = factura.monto_factura,
                                    mora = factura.mora_factura,
                                    total = factura.total_factura,
                                }).ToList();
                foreach (var item in facturas)
                {
                    dt.Rows.Add(item.codigo, item.direccion, item.nit, item.monto, item.mora, item.total);
                }
            }
            catch { }
            return dt;
        }
        public DataTable datosFactura(int codigoFactura)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("concepto");
            dt.Columns.Add("precio");
            dt.Columns.Add("total");
            try
            {
                var factura = (from fact in linqConect.encabezado_facturas
                               where fact.id_factura.Equals(codigoFactura)
                               select new
                               {
                                   diasRetraso = fact.dias_retraso_pago,
                                   precio = fact.monto_factura,
                                   mora = fact.mora_factura,
                                   total = fact.total_factura,
                                   mes=fact.fecha_creacion_factura.Month
                               }).FirstOrDefault();
                string concepto = "";
                string[] meses =  {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
                if (factura.diasRetraso > 0)
                {
                    concepto = $"Pago del mes de {meses[factura.mes]} con {factura.diasRetraso} dias de mora con un costo de Q. {factura.mora}";
                }
                else
                {
                    concepto = $"Pago del mes de {meses[factura.mes]}";
                }
                dt.Rows.Add(codigoFactura, concepto, factura.precio, factura.total);
            }
            catch { }
            return dt;
        }
    }
}
