using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Datos;
using Datos.Clientes;

namespace Negociacion
{
    public class clientesNegocios
    {
        GuardarClientes saveCliente = new GuardarClientes();
        LeerClientes readClientes = new LeerClientes();

        public DataTable dtClientes()
        {
            return readClientes.listadoClientes();
        }
        public int guardarCliente(string dpi, string nombre, string apellido, string tel1, string tel2, string direccion, string email)
        {
            return saveCliente.guardarClientesDt(dpi, nombre, apellido, tel1, tel2, direccion, email);
        }
        public DataTable datosCliente(string dpi)
        {
            return (readClientes.datosClienteSeleccionado(dpi));
        }


        public bool editarCliente(string dpi, string nombre, string apellido, string tel1, string tel2, string direccion, string email)
        {
            return saveCliente.editarCliente(dpi, nombre, apellido, tel1, tel2, direccion, email);
        }

    }
}
