using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Business.Interfaces
{
    public interface IRolesCRUD
    {
        List<Rol> Listar();
        void Guardar(Rol rol);
        void Eliminar(int idRol);
        Rol Buscar(int idRol);
    }
}
