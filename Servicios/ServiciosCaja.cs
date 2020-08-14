using CheckEngineTaller.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEngineTaller.Servicios
{    public class ServiciosCaja
    {
        public ServiciosCaja()
        {
        }
        public bool AgregarCaja(double SaldoInicial, double SaldoFinal, int ide)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var Caja = new T_Caja
                    {
                        C_SaldoInicial=(decimal)SaldoInicial,
                        C_SaldoFinal=(decimal)SaldoFinal,
                        E_Id=ide
                    };
                    contexto.T_Caja.Add(Caja);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public object getCaja()
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var ListaCaja = contexto.T_Caja.Select(s => new
                    {
                        C_Id=s.C_Id,
                        C_SaldoInicial = s.C_SaldoInicial,
                        C_SaldoFinal = s.C_SaldoFinal,
                        E_Id = s.E_Id
                    }).ToList();
                    return ListaCaja;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public T_Caja ObtenerDetalle(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var caja = contexto.T_Caja.Find(id);
                    return caja;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool EliminarCaja(int? id)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var caja = contexto.T_Caja.Find(id);
                    contexto.T_Caja.Remove(caja);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditarCaja(int? id, double SaldoInicial, double SaldoFinal, int ide)
        {
            try
            {
                using (var contexto = new DBTallerEntities2())
                {
                    var caja = contexto.T_Caja.Find(id);
                    if (caja == null) return false;
                    caja.C_SaldoInicial = (decimal)SaldoInicial;
                    caja.C_SaldoFinal = (decimal)SaldoFinal;
                    caja.E_Id = ide;
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
