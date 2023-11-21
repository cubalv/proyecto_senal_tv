using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Datos;
using Datos.ContratosClientes;

namespace Negociacion
{
    public class contratoClienteNegocios
    {
        LeerContratoClientes LeerContratos = new LeerContratoClientes();
        GuardarContratoClientes GuardarContratos = new GuardarContratoClientes();
        public bool verificarDisponibilidadZona(int codigoZona, int codigoPlan)
        {
            return LeerContratos.verificarDisponibilidadZona(codigoZona, codigoPlan);
        }
        public bool guardarContratoNuevoConInstalacionZona(string dpi, int codigoPlan, int codigoZona, string direccionInstalacion, string direccionCobro, string nit, string detallesContrato, decimal precioMensual, decimal precioInstalacion)
        {
            return GuardarContratos.guardarContratoNuevoConInstalacionZona(dpi, codigoPlan, codigoZona, direccionInstalacion, direccionCobro, nit, detallesContrato, precioMensual, precioInstalacion);
        }
        public bool guardarContratoNuevo(string dpi, int codigoPlan, int codigoZona, string direccionInstalacion, string direccionCobro, string nit, string detallesContrato, decimal precioMensual, decimal precioInstalacion)
        {
            return GuardarContratos.guardarContratoNuevo(dpi, codigoPlan, codigoZona, direccionInstalacion, direccionCobro, nit, detallesContrato, precioMensual, precioInstalacion);
        }
        public DataTable listadoContratosCliente(bool estado)
        {
            return LeerContratos.listadoContratosCliente(estado);
        }
        public DataTable datosDelContrato(int codigo)
        {
            return LeerContratos.datosDelContrato(codigo);
        }
        public DataTable listadoContratosCliente(string dpi)
        {
            return LeerContratos.listadoContratosPorCliente(dpi);
        }
        public bool agregarMisionPorPlan(int codigoContrato)
        {
            return GuardarContratos.agregarMisionPorPlan(codigoContrato);
        }
        public bool misionDarDeBaja(int codigoContrato)
        {
            return GuardarContratos.misionDarDeBaja(codigoContrato);
        }
        public DataTable listadoContratosMora()
        {
            return LeerContratos.listadoContratosMora();
        }
    }
}
