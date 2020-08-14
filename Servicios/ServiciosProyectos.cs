using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckEngineTaller.Modelo;

namespace CheckEngineTaller.Servicios
{
    public class ServiciosProyectos
    {
        public ServiciosProyectos()
        {
        }
        public bool AgregarProyecto(int idestacion, int idmanodeobra, int idvehiculo,string comentario)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Proyecto = new T_Proyecto
                    {
                        Es_Id = idestacion,
                        Mdo_Id = idmanodeobra,
                        V_id = idvehiculo,
                        Pry_Comentario = comentario
                    };
                    contexto.T_Proyecto.Add(Proyecto);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public object getProyecto()
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var ListaProyecto = contexto.T_Proyecto.Select(s => new
                    {
                        Es_Id = s.Es_Id,
                        Mdo_Id = s.Mdo_Id,
                        Pry_Id = s.Pry_Id,
                        V_id = s.V_id,
                        Pry_Comentario = s.Pry_Comentario
                    }).ToList();
                    return ListaProyecto;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public T_Proyecto ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Proyecto = contexto.T_Proyecto.Find(id);
                    return Proyecto;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool EliminarProyecto(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Proyecto = contexto.T_Proyecto.Find(id);
                    contexto.T_Proyecto.Remove(Proyecto);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditarProyecto(int? id, int idestacion, int idmanodeobra, int idvehiculo, string comentario)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Proyecto = contexto.T_Proyecto.Find(id);
                    if (Proyecto == null) return false;
                    Proyecto.Es_Id = idestacion;
                    Proyecto.Mdo_Id = idmanodeobra;
                    Proyecto.V_id = idvehiculo;
                    Proyecto.Pry_Comentario = comentario;
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
