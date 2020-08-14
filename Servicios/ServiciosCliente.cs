using CheckEngineTaller.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEngineTaller.Servicios
{
    public class ServiciosCliente
    {
        public ServiciosCliente()
        {
        }
        public bool AgregarCliente(string nombre1, string nombre2, string apellido1, string apellido2, string identidad, string telefono, string direccion)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var clientes = new T_Cliente
                    {
                        CI_Nombre1 = nombre1,
                        CI_Nombre2 = nombre2,
                        CI_Apellido1 = apellido1,
                        CI_Apellido2 = apellido2,
                        CI_Identificacion = identidad,
                        CI_Telefono = telefono,
                        CI_Direccion = direccion
                    };
                    contexto.T_Cliente.Add(clientes);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public object getClientes()
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var ListaClientes = contexto.T_Cliente.Select(s => new
                    {
                        CI_ID = s.CI_ID,
                        CI_Nombre1 = s.CI_Nombre1,
                        CI_Nombre2 = s.CI_Nombre2,
                        CI_Apellido1 = s.CI_Apellido1,
                        CI_Apellido2 = s.CI_Apellido2,
                        CI_Identificacion = s.CI_Identificacion,
                        CI_Telefono = s.CI_Telefono,
                        CI_Direccion = s.CI_Direccion
                    }).ToList();
                    return ListaClientes;
                }
                
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public T_Cliente ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var clientes = contexto.T_Cliente.Find(id);
                    return clientes;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool EliminarCliente(int? id)
        {
            try
            {
                using  (var contexto = new DBTallerEntities2()) 
                {
                    var clientes = contexto.T_Cliente.Find(id);
                    contexto.T_Cliente.Remove(clientes);
                    contexto.SaveChanges();
                    return true;
                }                
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditarCliente(int? id, string nombre1, string nombre2, string apellido1, string apellido2, string identidad, string telefono, string direccion)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var clientes = contexto.T_Cliente.Find(id);
                    if (clientes == null) return false;
                    clientes.CI_Nombre1 = nombre1;
                    clientes.CI_Nombre2 = nombre2;
                    clientes.CI_Apellido1 = apellido1;
                    clientes.CI_Apellido2 = apellido2;
                    clientes.CI_Identificacion = identidad;
                    clientes.CI_Telefono = telefono;
                    clientes.CI_Direccion = direccion;
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
