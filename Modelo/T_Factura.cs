//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheckEngineTaller.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Factura()
        {
            this.T_Detallefactura = new HashSet<T_Detallefactura>();
        }
    
        public decimal Fc_Impuesto { get; set; }
        public decimal Fc_Total { get; set; }
        public System.DateTime Fc_Fecha { get; set; }
        public int Fc_Id { get; set; }
        public decimal Fc_Descuento { get; set; }
        public decimal FC_Subtotal { get; set; }
        public int C_Id { get; set; }
    
        public virtual T_Caja T_Caja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Detallefactura> T_Detallefactura { get; set; }
    }
}
