using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Data
{
   public class Piloto
    {

        [PrimaryKey, AutoIncrement]
        public int IdPiloto { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string Residencia { get; set; }
    }
}
