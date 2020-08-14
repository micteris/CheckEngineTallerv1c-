using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckEngineTaller.Modelo;

namespace CheckEngineTaller.Servicios
{
    public class ServiciosProductos
    {
        public ServiciosProductos()
        {
        }
        public bool AgregarProducto(int ide, int codigorefaccion, string descripcion, int existencia, string marca, string nombre, double preciounitario, double descuento, int existenciaminima)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Producto = new T_Producto
                    {
                        P_Id = ide,
                        Pr_CodigoRefaccion = codigorefaccion,
                        Pr_Descripcion = descripcion,
                        Pr_Existencia = existencia,
                        Pr_Marca = marca,
                        Pr_Nombre = nombre,
                        Pr_PrecioUnitario = (decimal)preciounitario,
                        Pr_Descuento = (decimal)descuento,
                        Pr_ExistenciaMin = existenciaminima
                    };
                    contexto.T_Producto.Add(Producto);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public object getProducto()
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var ListaProducto = contexto.T_Producto.Select(s => new
                    {
                        Pr_Id=s.Pr_Id,
                        P_Id = s.P_Id,
                        Pr_CodigoRefaccion = s.Pr_CodigoRefaccion,
                        Pr_Descripcion = s.Pr_Descripcion,
                        Pr_Existencia = s.Pr_Existencia,
                        Pr_Marca = s.Pr_Marca,
                        Pr_Nombre = s.Pr_Nombre,
                        Pr_PrecioUnitario = s.Pr_PrecioUnitario,
                        Pr_Descuento = s.Pr_Descuento,
                        Pr_ExistenciaMin = s.Pr_ExistenciaMin                       
                    }).ToList();
                    return ListaProducto;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public T_Producto ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Producto = contexto.T_Producto.Find(id);
                    return Producto;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool EliminarProducto(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Producto = contexto.T_Producto.Find(id);
                    contexto.T_Producto.Remove(Producto);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditarProducto(int? id, int ide, int codigorefaccion, string descripcion, int existencia, string marca, string nombre, double preciounitario, double descuento, int existenciaminima)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Producto = contexto.T_Producto.Find(id);
                    if (Producto == null) return false;
                    Producto.P_Id = ide;
                    Producto.Pr_CodigoRefaccion = codigorefaccion;
                    Producto.Pr_Descripcion = descripcion;
                    Producto.Pr_Existencia = existencia;
                    Producto.Pr_Marca = marca;
                    Producto.Pr_Nombre = nombre;
                    Producto.Pr_PrecioUnitario = (decimal)preciounitario;
                    Producto.Pr_Descuento = (decimal)descuento;
                    Producto.Pr_ExistenciaMin = existenciaminima;
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

