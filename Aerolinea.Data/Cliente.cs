using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerolinea.Data
{
   public class Cliente
    {

        [PrimaryKey, AutoIncrement]
        public int IdCliente { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string Residencia { get; set; }

        public string Usuario { get; set; }

        public string Contrasena { get; set; }


    }
}
