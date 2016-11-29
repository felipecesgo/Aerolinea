using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Data
{
    public class Agente
    {
        [PrimaryKey, AutoIncrement]
        public int IdAgente { get; set; }

        public int IdRol { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public string Cedula { get; set; }

        public string Residencia { get; set; }

        public string Telefono { get; set; }
        public string Email { get; set; }

        public string Usuario { get; set; }

        public string Contrasena { get; set; }
    }
}
