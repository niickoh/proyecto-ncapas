//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class medicamento
    {
        public int serie { get; set; }
        public string nombre { get; set; }
        public string componentes { get; set; }
        public string principioActivo { get; set; }
        public string dosis { get; set; }
        public System.DateTime fechaElaboracion { get; set; }
        public System.DateTime fechaVencimiento { get; set; }
        public int laboratorio { get; set; }
    
        public virtual laboratorio laboratorio1 { get; set; }
    }
}
