//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPO_AERONAVE
    {
        public TIPO_AERONAVE()
        {
            this.AERONAVES = new HashSet<AERONAVES>();
        }
    
        public int IDTIPO_AERONAVE { get; set; }
        public string desc { get; set; }
    
        public virtual ICollection<AERONAVES> AERONAVES { get; set; }
    }
}