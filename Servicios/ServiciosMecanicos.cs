using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckEngineTaller.Modelo;

namespace CheckEngineTaller.Servicios
{
    public class ServiciosMecanicos
    {
        public ServiciosMecanicos()
        {
        }
        public bool AgregarMecanico(int ide, string especialidad, bool estado)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Mecanico = new T_Mecanico
                    {
                        E_ID = ide,
                        M_Especialidad = especialidad,
                        M_Estado = estado
                    };
                    contexto.T_Mecanico.Add(Mecanico);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public object getMecanico()
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var ListaMecanico = contexto.T_Mecanico.Select(s => new
                    {
                        M_ID=s.M_ID,
                        E_ID = s.E_ID,
                        M_Especialidad = s.M_Especialidad,
                        M_Estado = s.M_Estado
                        }).ToList();
                    return ListaMecanico;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public T_Mecanico ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Mecanico = contexto.T_Mecanico.Find(id);
                    return Mecanico;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool EliminarMecanico(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Mecanico = contexto.T_Mecanico.Find(id);
                    contexto.T_Mecanico.Remove(Mecanico);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditarMecanico(int? id, int ide, string especialidad, bool estado)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Mecanico = contexto.T_Mecanico.Find(id);
                    if (Mecanico == null) return false;
                    Mecanico.E_ID = ide;
                    Mecanico.M_Especialidad = especialidad;
                    Mecanico.M_Estado = estado;
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
