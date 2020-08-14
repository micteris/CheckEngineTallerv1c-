using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckEngineTaller.Modelo;
namespace CheckEngineTaller.Servicios
{
    public class ServiciosPedidos
    {
        public ServiciosPedidos()
        {
        }
        public bool AgregarPedido(int ide, int cantidad, string descripcion, double preciounitario)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Pedido = new T_Pedido
                    {
                        Pr_Id = ide,
                        Pd_Cantidad = cantidad,
                        Pd_Descripcion = descripcion,
                        Pd_PrecioUnitario = (decimal)preciounitario
                    };
                    contexto.T_Pedido.Add(Pedido);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public object getPedido()
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var ListaPedido = contexto.T_Pedido.Select(s => new
                    {
                        Pd_Id=s.Pd_Id,
                        Pr_Id = s.Pr_Id,
                        Pd_Cantidad = s.Pd_Cantidad,
                        Pd_Descripcion = s.Pd_Descripcion,
                        Pd_PrecioUnitario = s.Pd_PrecioUnitario
                    }).ToList();
                    return ListaPedido;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public T_Pedido ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Pedido = contexto.T_Pedido.Find(id);
                    return Pedido;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool EliminarPedido(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Pedido = contexto.T_Pedido.Find(id);
                    contexto.T_Pedido.Remove(Pedido);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditarPedido(int? id, int ide, int cantidad, string descripcion, double preciounitario)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Pedido = contexto.T_Pedido.Find(id);
                    if (Pedido == null) return false;
                    Pedido.Pr_Id = ide;
                    Pedido.Pd_Cantidad = cantidad;
                    Pedido.Pd_Descripcion = descripcion;
                    Pedido.Pd_PrecioUnitario = (decimal)preciounitario;
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

