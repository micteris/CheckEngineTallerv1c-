using CheckEngineTaller.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEngineTaller.Servicios
{
    public class ServiciosEmpleados
    {
        public ServiciosEmpleados()
        {
        }
        public bool AgregarEmpleado(string direccion, int edad, string nombre1,string nombre2, string apellido1, string apellido2, double salario, string tiposalario, string tipo, string telefono, string identidad, string usuario, string password)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Empleado = new T_Empleado
                    {
                        E_Direccion = direccion,
                        E_edad = edad,
                        E_Nombre1 = nombre1,
                        E_Nombre2 = nombre2,
                        E_Apellido1 = apellido1,
                        E_Apellido2 = apellido2,
                        E_Salario = (decimal)salario,
                        E_TipoSalario = tiposalario,
                        E_Tipo = tipo,
                        E_Telefono = telefono,
                        E_Identificacion = identidad,
                        E_Usuario = usuario,
                        E_Password = password
                    };
                    contexto.T_Empleado.Add(Empleado);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public object getEmpleado()
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var ListaEmpleados = contexto.T_Empleado.Select(s => new
                    {
                        E_ID=s.E_ID,
                        E_Nombre1 = s.E_Nombre1,
                        E_Nombre2 = s.E_Nombre2,
                        E_Apellido1 = s.E_Apellido1,
                        E_Apellido2 = s.E_Apellido2,
                        E_Identificacion = s.E_Identificacion,
                        E_Telefono = s.E_Telefono,
                        E_Direccion = s.E_Direccion,
                        E_edad = s.E_edad,
                        E_Salario =s.E_Salario,
                        E_TipoSalario=s.E_TipoSalario,
                        E_Tipo = s.E_Tipo,
                        E_Usuario = s.E_Usuario,
                        E_Password = s.E_Password
                    }).ToList();
                    return ListaEmpleados;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public T_Empleado ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Empleados = contexto.T_Empleado.Find(id);
                    return Empleados;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool EliminarEmpleado(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Empleados = contexto.T_Empleado.Find(id);
                    contexto.T_Empleado.Remove(Empleados);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditarEmpleado(int? id, string direccion, int edad, string nombre1, string nombre2, string apellido1, string apellido2, double salario, string tiposalario, string tipo, string telefono, string identidad, string usuario, string password)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Empleados = contexto.T_Empleado.Find(id);
                    if (Empleados == null) return false;
                    Empleados.E_Direccion = direccion;
                    Empleados.E_edad = edad;
                    Empleados.E_Nombre1 = nombre1;
                    Empleados.E_Nombre2 = nombre2;
                    Empleados.E_Apellido1 = apellido1;
                    Empleados.E_Apellido2 = apellido2;
                    Empleados.E_Salario = (decimal)salario;
                    Empleados.E_TipoSalario = tiposalario;
                    Empleados.E_Tipo = tipo;
                    Empleados.E_Telefono = telefono;
                    Empleados.E_Identificacion = identidad;
                    Empleados.E_Usuario = usuario;
                    Empleados.E_Password = password;
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

 
