using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDALC
{
   public partial class CL_PILOTOS_VUELOS
    {
        public CL_PILOTOS_VUELOS()
        {

        }


        public int VUELOS_ID_VUELO { get; set; }

        public int PILOTOS_IDUSUARIO { get; set; }

        public string PILOTOS_RUT{ get; set; }
    }
}
