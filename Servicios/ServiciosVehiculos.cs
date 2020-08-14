using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckEngineTaller.Modelo;

namespace CheckEngineTaller.Servicios
{
    public class ServiciosVehiculos
    {
        public ServiciosVehiculos()
        {
        }
        public bool AgregarVehiculo(int idcliente, string color, string estado, string marca, string modelo, string placa)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Vehiculo = new T_Vehiculo
                    {
                        CI_ID = idcliente,
                        V_Color = color,
                        V_Estado = estado,
                        V_Marca = marca,
                        V_Modelo = modelo,
                        V_Placa = placa
                    };
                    contexto.T_Vehiculo.Add(Vehiculo);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public object getVehiculo()
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var ListaVehiculo = contexto.T_Vehiculo.Select(s => new
                    {
                        CI_ID = s.CI_ID,
                        V_ID = s.V_ID,
                        V_Color = s.V_Color,
                        V_Estado = s.V_Estado,
                        V_Marca = s.V_Marca,
                        V_Modelo = s.V_Modelo,
                        V_Placa = s.V_Placa
                    }).ToList();
                    return ListaVehiculo;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public T_Vehiculo ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Vehiculo = contexto.T_Vehiculo.Find(id);
                    return Vehiculo;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool EliminarVehiculo(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Vehiculo = contexto.T_Vehiculo.Find(id);
                    contexto.T_Vehiculo.Remove(Vehiculo);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditarVehiculo(int? id, int idcliente, string color, string estado, string marca, string modelo, string placa)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Vehiculo = contexto.T_Vehiculo.Find(id);
                    if (Vehiculo == null) return false;
                    Vehiculo.CI_ID = idcliente;
                    Vehiculo.V_Color = color;
                    Vehiculo.V_Estado = estado;
                    Vehiculo.V_Marca = marca;
                    Vehiculo.V_Modelo = modelo;
                    Vehiculo.V_Placa = placa;
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

