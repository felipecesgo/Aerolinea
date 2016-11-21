using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Data
{
    public class Reserva
    {
        [PrimaryKey, AutoIncrement]
        public int IdReserva { get; set; }
        public int IdUsuario { get; set; }
        public int IdCarrera { get; set; }
        public int Asiento { get; set; }
    }
}
