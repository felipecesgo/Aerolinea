using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Data
{
    public class Queja
    {
        [PrimaryKey, AutoIncrement]
        public int IdQueja { get; set; }

        public int IdVuelo { get; set; }

        public string Motivo { get; set; }

        public string Descripcion { get; set; }

        public string NombreCliente { get; set; }

        public string ApellidoCliente { get; set; }

        public string TelefonoCliente { get; set; }

        public string EmailCliente { get; set; }

    }
}
