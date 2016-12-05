using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Data
{

   public class Vuelo
   {
        [PrimaryKey, AutoIncrement]
        public int IdVuelo { get; set; }

        public int IdAvion { get; set; }

        public int IdPiloto { get; set; }

        public int IdRuta { get; set; }

        public string EstadoVuelo { get; set; }

        public DateTime FechaSalida { get; set; }

        public DateTime FechaLlegada { get; set; }

        public int CapacidadAsientos { get; set; }

       [Ignore]
        public Ruta Ruta { get; set; }

       [Ignore]
       public string Duration
       {
           get
           {
               var duration = FechaLlegada - FechaSalida;
               if (duration.Days > 0)
                   return string.Format("{0:%d} d {0:%h} h {0:%m} minutes", duration);
               else
                   return string.Format("{0:%h} h {0:%m} m", duration);
           }
       }

    }
}
