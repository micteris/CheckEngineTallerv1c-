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
    
    public partial class T_Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Empleado()
        {
            this.T_Bitacora = new HashSet<T_Bitacora>();
            this.T_Caja = new HashSet<T_Caja>();
            this.T_Gastos = new HashSet<T_Gastos>();
            this.T_Mecanico = new HashSet<T_Mecanico>();
        }
    
        public string E_Direccion { get; set; }
        public int E_edad { get; set; }
        public string E_Nombre1 { get; set; }
        public string E_Nombre2 { get; set; }
        public string E_Apellido1 { get; set; }
        public string E_Apellido2 { get; set; }
        public decimal E_Salario { get; set; }
        public string E_TipoSalario { get; set; }
        public string E_Tipo { get; set; }
        public string E_Telefono { get; set; }
        public int E_ID { get; set; }
        public string E_Identificacion { get; set; }
        public string E_Usuario { get; set; }
        public string E_Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Bitacora> T_Bitacora { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Caja> T_Caja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Gastos> T_Gastos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Mecanico> T_Mecanico { get; set; }
    }
}
