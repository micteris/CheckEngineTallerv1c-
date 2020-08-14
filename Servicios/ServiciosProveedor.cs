using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckEngineTaller.Modelo;

namespace CheckEngineTaller.Servicios
{
    public class ServiciosProveedor
    {
        public ServiciosProveedor()
        {
        }
        public bool AgregarProveedores(string descripcion, string formapago, string nombre)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Proveedores = new T_Proveedores
                    {
                        P_Descripcion = descripcion,
                        P_FormaPago = formapago,
                        P_Nombre = nombre
                    };
                    contexto.T_Proveedores.Add(Proveedores);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public object getProveedores()
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var ListaProveedores = contexto.T_Proveedores.Select(s => new
                    {
                        P_Id = s.P_Id,
                        P_Descripcion = s.P_Descripcion,
                        P_FormaPago = s.P_FormaPago,
                        P_Nombre = s.P_Nombre
                    }).ToList();
                    return ListaProveedores;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public T_Proveedores ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Proveedores = contexto.T_Proveedores.Find(id);
                    return Proveedores;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool EliminarProveedores(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Proveedores = contexto.T_Proveedores.Find(id);
                    contexto.T_Proveedores.Remove(Proveedores);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditarProveedores(int? id, string descripcion, string formapago, string nombre)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Proveedores = contexto.T_Proveedores.Find(id);
                    if (Proveedores == null) return false;
                    Proveedores.P_Descripcion = descripcion;
                    Proveedores.P_FormaPago = formapago;
                    Proveedores.P_Nombre = nombre;
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
