using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerolinea.Data
{
    public class Tiquete
    {
        [PrimaryKey, AutoIncrement]
        public int IdTiquete { get; set; }

        public int IdVuelo { get; set; }

        public int IdCliente { get; set; }

        public int NumeroDeAsiento { get; set; }

        public int Fecha { get; set; }
    }
}
