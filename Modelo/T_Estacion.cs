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
    
    public partial class T_Estacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Estacion()
        {
            this.T_Proyecto = new HashSet<T_Proyecto>();
        }
    
        public string Es_Nombre { get; set; }
        public int Ac_Id { get; set; }
        public int Es_Id { get; set; }
    
        public virtual T_Actividad T_Actividad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Proyecto> T_Proyecto { get; set; }
    }
}
