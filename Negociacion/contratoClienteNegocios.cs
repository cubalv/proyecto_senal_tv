using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return LeerContratos.verificarDisponibilidadZona(codigoZona,codigoPlan);
        }
        public bool guardarContratoNuevoConInstalacionZona(string dpi, int codigoPlan, int codigoZona, string direccionInstalacion, string direccionCobro, string nit, string detallesContrato, decimal precioMensual, decimal precioInstalacion)
        {
            return GuardarContratos.guardarContratoNuevoConInstalacionZona(dpi,codigoPlan,codigoZona,direccionInstalacion,direccionCobro,nit,detallesContrato,precioMensual,precioInstalacion);
        }
        public bool guardarContratoNuevo(string dpi, int codigoPlan, int codigoZona, string direccionInstalacion, string direccionCobro, string nit, string detallesContrato, decimal precioMensual, decimal precioInstalacion)
        {
            return GuardarContratos.guardarContratoNuevo(dpi, codigoPlan, codigoZona, direccionInstalacion, direccionCobro, nit, detallesContrato, precioMensual, precioInstalacion);
        }
    }
}
