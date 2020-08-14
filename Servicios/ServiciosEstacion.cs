using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckEngineTaller.Modelo;

namespace CheckEngineTaller.Servicios
{
    public class ServiciosEstacion
    {
        public ServiciosEstacion()
        {
        }
        public bool AgregarEstacion(string nombre, int ide)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Estacion = new T_Estacion
                    {
                        Es_Nombre=nombre,
                        Ac_Id=ide
                    };
                    contexto.T_Estacion.Add(Estacion);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public object getEstacion()
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var ListaEstacion = contexto.T_Estacion.Select(s => new
                    {
                        Es_Id=s.Es_Id,
                        Es_Nombre = s.Es_Nombre,
                        Ac_Id = s.Ac_Id
                    }).ToList();
                    return ListaEstacion;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public T_Estacion ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Estacion = contexto.T_Estacion.Find(id);
                    return Estacion;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool EliminarEstacion(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Estacion = contexto.T_Estacion.Find(id);
                    contexto.T_Estacion.Remove(Estacion);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditarEstacion(int? id, string nombre, int ide)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Estacion = contexto.T_Estacion.Find(id);
                    if (Estacion == null) return false;
                    Estacion.Es_Nombre = nombre;
                    Estacion.Ac_Id = ide;
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

