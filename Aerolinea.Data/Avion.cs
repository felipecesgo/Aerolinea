using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Data
{
    public class Avion
    {
        [PrimaryKey, AutoIncrement]
        public int IdAvion { get; set; }

        public string Matricula { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        [Ignore]
        public string Nombre { get { return string.Format("{0} {1}", Marca, Modelo); } }

    }
}
