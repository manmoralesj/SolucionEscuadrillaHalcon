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
    
    public partial class BITACORAS_VUELOS
    {
        public int IDBITACORA_VUELO { get; set; }
        public int VUELOS_IDVUELO { get; set; }
        public System.DateTime HORA_INCIDENTE { get; set; }
        public string desc { get; set; }
    
        public virtual VUELOS VUELOS { get; set; }
    }
}