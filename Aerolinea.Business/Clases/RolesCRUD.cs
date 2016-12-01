using Aerolinea.Business.Interfaces;
using Aerolinea.Data;
using Aerolinea.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Business.Clases
{
    public class RolesCRUD : IRolesCRUD
    {

        private Repository<Rol> roles;

        public RolesCRUD()
        {
            roles = new Repository<Rol>();
        }

        public List<Rol> Listar()
        {
            return roles.GetAll();
        }

        public void Guardar(Rol ruta)
        {
            roles.Save(ruta);
        }

        public void Eliminar(int idRol)
        {
            roles.Delete(idRol);
        }

        public Rol Buscar(int idRol)
        {
            return roles.GetById(idRol);
        }
    }
}
