﻿using ServiceStack.DataAnnotations;
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

    }
}
