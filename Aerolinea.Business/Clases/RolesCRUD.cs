using Aerolinea.Business.Interfaces;
using Aerolinea.Data;
using System.Collections.Generic;
using System.Linq;
using Aerolinea.DataAccess;

namespace Aerolinea.Business.Clases
{
    public class RolesCRUD : IRolesCRUD
    {

        //private List<Rol> roles;

        //public RolesCRUD()
        //{
        //    roles = new List<Rol>() { new Rol() { IdRol = 1, Nombre = "Felipe" } };
        //}

        //public List<Rol> Listar()
        //{
        //    return roles;
        //}

        //public void Guardar(Rol agente)
        //{
        //    roles.Add(agente);
        //}

        //public void Eliminar(int idRol)
        //{
        //    roles.RemoveAll(x => x.IdRol == idRol);
        //}

        //public Rol Buscar(int idRol)
        //{
        //    return roles.Where(x => x.IdRol == idRol).FirstOrDefault();
        //}


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
