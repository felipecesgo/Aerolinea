using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Data
{
    public class Rol
    {
        [PrimaryKey, AutoIncrement]
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
