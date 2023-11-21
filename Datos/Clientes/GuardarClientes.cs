using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Datos.Clientes
{
    public class GuardarClientes
    {
        DB.ConexionLinqSqlDataContext linqConect = new DB.ConexionLinqSqlDataContext(ConexionSql.route);
        public int guardarClientesDt(string dpi, string nombre, string apellido, string tel1, string tel2, string direccion, string email)
        {
            int resul = 0;
            var comprobacion = (from clientess in linqConect.clientes
                                where clientess.dpi_cliente.Equals(dpi)
                                select clientess
                                ).ToList().Count == 0;
            if (comprobacion)
            {
                using (TransactionScope transa = new TransactionScope())
                {
                    try
                    {
                        DB.clientes nuevoCliente = new DB.clientes()
                        {
                            dpi_cliente = dpi,
                            nombre_cliente = nombre,
                            apellido_cliente = apellido,
                            telefono1_cliente = tel1,
                            telefono2_cliente = tel2,
                            direccion_cliente = direccion,
                            email_cliente = email,
                            contrasena_cliente = "123456789"
                        };
                        linqConect.clientes.InsertOnSubmit(nuevoCliente);
                        linqConect.SubmitChanges();
                        transa.Complete();
                        resul = 1;
                    }
                    catch
                    {
                        transa.Dispose();
                        resul = 2;
                    }
                }
            }
            return resul;
        }
        public bool editarCliente(string dpi, string nombre, string apellido, string tel1, string tel2, string direccion, string email)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var editaCliente = (from cliente in linqConect.clientes
                                        where cliente.dpi_cliente == dpi
                                        select cliente).ToList();
                    editaCliente[0].nombre_cliente = nombre;
                    editaCliente[0].apellido_cliente = apellido;
                    editaCliente[0].telefono1_cliente = tel1;
                    editaCliente[0].telefono2_cliente = tel2;
                    editaCliente[0].direccion_cliente = direccion;
                    editaCliente[0].email_cliente = email;

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
