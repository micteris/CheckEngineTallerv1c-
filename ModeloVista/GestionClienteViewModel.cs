using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEngineTaller.ModeloVista
{
    public class GestionClienteViewModel
    {
        public bool EsModoEdicion { get; set; }

        public string CI_Direccion { get; set; }
        public string CI_Identificacion { get; set; }
        public string CI_Nombre1 { get; set; }
        public string CI_Nombre2 { get; set; }
        public string CI_Apellido1 { get; set; }
        public string CI_Apellido2 { get; set; }
        public string CI_Telefono { get; set; }
        
    }
}
