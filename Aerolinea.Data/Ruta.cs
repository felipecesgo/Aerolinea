using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Aerolinea.Data
{
    public class Ruta
    {
        [PrimaryKey, AutoIncrement]
        public int IdRuta { get; set; }

        public string Origen { get; set; }

        public string Destino { get; set; }

        public decimal Tarifa { get; set; }

        public byte[] Imagen { get; set; }

        [Ignore]
        public decimal TarifaEjecutiva { get; set; }

    }
}
