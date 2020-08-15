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
        public bool AgregarCliente(T_Cliente tCliente)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var existCliente = contexto.T_Cliente.FirstOrDefault(f => f.CI_Identificacion == tCliente.CI_Identificacion);
                    if (existCliente != null) return false;

                    var clientes = new T_Cliente
                    {
                        CI_Nombre1 = tCliente.CI_Nombre1 ,
                        CI_Nombre2 = tCliente.CI_Nombre2 ,
                        CI_Apellido1 = tCliente.CI_Apellido1 ,
                        CI_Apellido2 = tCliente.CI_Apellido2 ,
                        CI_Identificacion = tCliente.CI_Identificacion ,
                        CI_Telefono = tCliente.CI_Telefono ,
                        CI_Direccion = tCliente.CI_Direccion 
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
                        s.CI_ID,
                        s.CI_Nombre1,
                        s.CI_Nombre2,
                        s.CI_Apellido1,
                        s.CI_Apellido2,
                        s.CI_Identificacion,
                        s.CI_Telefono,
                        s.CI_Direccion
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

        public T_Cliente GetClienteByIdentificacion(string identificacion)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var cliente = contexto.T_Cliente.FirstOrDefault(c => c.CI_Identificacion == identificacion.Trim());
                    return cliente;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string GenerateToken(string identificacion)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var cliente = contexto.T_Cliente.FirstOrDefault(c => c.CI_Identificacion == identificacion);
                    if (cliente == null) return null;

                    var timeNow = DateTime.Now.ToString();
                    string token = timeNow.Substring(timeNow.Length-3)+cliente.CI_Identificacion.Substring(10);
                    //cliente.CI_Token = token;
                    //contexto.SaveChanges();
                    return token;

                }
            }
            catch (Exception)
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
        public bool EditarCliente(T_Cliente tCliente)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var clientes = contexto.T_Cliente.Find(tCliente.CI_ID);
                    if (clientes == null) return false;

                    clientes.CI_Nombre1 = tCliente.CI_Nombre1;
                    clientes.CI_Nombre2 = tCliente.CI_Nombre2;
                    clientes.CI_Apellido1 = tCliente.CI_Apellido1;
                    clientes.CI_Apellido2 = tCliente.CI_Apellido2;
                    clientes.CI_Identificacion = tCliente.CI_Identificacion;
                    clientes.CI_Telefono = tCliente.CI_Telefono;
                    clientes.CI_Direccion = tCliente.CI_Direccion;
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
