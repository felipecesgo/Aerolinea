using Portal_Noticias.Data.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal_Noticias.Data.Common
{
    public static class UserLogged
    {
        public static User Usuario { get; set; }
        public static string UsuarioId { get { return Usuario.Email; } }
    }
}
