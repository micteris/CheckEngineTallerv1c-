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
    
    public partial class T_Bitacora
    {
        public int B_Id { get; set; }
        public string B_Formulario { get; set; }
        public string B_Funcion { get; set; }
        public int B_Llave { get; set; }
        public int E_Id { get; set; }
    
        public virtual T_Empleado T_Empleado { get; set; }
    }
}
