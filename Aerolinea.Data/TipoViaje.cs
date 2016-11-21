using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Data
{
    public class TipoViaje
    {
        [PrimaryKey, AutoIncrement]
        public int IdTipoViaje { get; set; }

        public string Nombre { get; set; }
    }
}
