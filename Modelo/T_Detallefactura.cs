//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheckEngineTaller.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Detallefactura
    {
        public int Pr_Id { get; set; }
        public int Mdo_Id { get; set; }
        public int DF_Cantidad { get; set; }
        public int C_Id { get; set; }
        public int Fc_id { get; set; }
    
        public virtual T_Factura T_Factura { get; set; }
        public virtual T_Manodeobra T_Manodeobra { get; set; }
        public virtual T_Producto T_Producto { get; set; }
    }
}