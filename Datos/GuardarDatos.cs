using Datos.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Datos
{
    public class GuardarDatos
    {
        DB.ConexionLinqSqlDataContext linqConect = new DB.ConexionLinqSqlDataContext(ConexionSql.route);
        public int guardarClientesDt(string dpi, string nombre, string apellido, string tel1, string tel2, string direccion,  string email)
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
                            email_cliente = email
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
        public bool editarCliente(string dpi, string nombre, string apellido, string tel1, string tel2, string direccion,  string email)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var editaCliente = (from cliente in linqConect.clientes
                                       where cliente.dpi_cliente== dpi
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
        public bool guardaContrato(string nombre, string descripcion, decimal sueldo, int duracion, int tipo_permisos)
        {
            using(TransactionScope transa = new TransactionScope()) 
            {
                try
                {
                    contratos_empleados nuevoContrato = new contratos_empleados()
                    {
                        nombre_contrato = nombre,
                        descripcion_contrato = descripcion,
                        sueldo_contrato = sueldo,
                        duracion_contrato_meses = duracion,
                        estado_contrato = true,
                        rango_accesp_contrato=tipo_permisos

                    };
                    linqConect.contratos_empleados.InsertOnSubmit(nuevoContrato);
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
        public bool editaContrato(int codigo,string nombre, string descripcion, decimal sueldo, int duracion, int tipo_permisos)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var editarContrato= (from contratos in linqConect.contratos_empleados
                                        where contratos.id_contratos_empleados.Equals(codigo)
                                        select contratos).ToList();
                    editarContrato[0].nombre_contrato = nombre;
                    editarContrato[0].descripcion_contrato = descripcion;
                    editarContrato[0].sueldo_contrato = sueldo;
                    editarContrato[0].duracion_contrato_meses = duracion;
                    editarContrato[0].rango_accesp_contrato = tipo_permisos;

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
        public bool deshabilitaContrato(int codigo)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var editarContrato = (from contratos in linqConect.contratos_empleados
                                          where contratos.id_contratos_empleados.Equals(codigo) && contratos.estado_contrato.Equals(true)
                                          select contratos).ToList();
                    editarContrato[0].estado_contrato = false;

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
        public bool rehabilitaContrato(int codigo)
        {
            using (TransactionScope transa = new TransactionScope())
            {
                try
                {
                    var editarContrato = (from contratos in linqConect.contratos_empleados
                                          where contratos.id_contratos_empleados.Equals(codigo) && contratos.estado_contrato.Equals(false)
                                          select contratos).ToList();
                    editarContrato[0].estado_contrato = true;

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
