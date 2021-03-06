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
    
    public partial class AERONAVES
    {
        public AERONAVES()
        {
            this.MANTENIMIENTOS = new HashSet<MANTENIMIENTOS>();
            this.VUELOS = new HashSet<VUELOS>();
        }
    
        public int IDAERONAVE { get; set; }
        public int TIPO_AERONAVE_IDTIPO_AERONAVE { get; set; }
        public int ESTADO_IDESTADO { get; set; }
        public int FABRICANTES_AERO_IDFABRICANTE { get; set; }
        public int MODELOS_AERO_IDMODELO { get; set; }
        public int HORAS_VOLADAS { get; set; }
        public int CANT_MAX_HORAS { get; set; }
        public string PATENTE { get; set; }
        public long ANIO_FAB { get; set; }
        public short CANT_MAX_PILOTOS { get; set; }
        public Nullable<System.DateTime> FECHA_INSPECCION_ANUAL { get; set; }
        public int CAP_LITROS { get; set; }
        public string MOTOR { get; set; }
        public string RUEDAS { get; set; }
        public Nullable<int> CANT_HELICES { get; set; }
        public Nullable<int> CANT_TURBINAS { get; set; }
    
        public virtual ESTADO ESTADO { get; set; }
        public virtual FABRICANTES_AERO FABRICANTES_AERO { get; set; }
        public virtual MODELOS_AERO MODELOS_AERO { get; set; }
        public virtual TIPO_AERONAVE TIPO_AERONAVE { get; set; }
        public virtual ICollection<MANTENIMIENTOS> MANTENIMIENTOS { get; set; }
        public virtual ICollection<VUELOS> VUELOS { get; set; }
    }
}
