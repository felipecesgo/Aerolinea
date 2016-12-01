using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aerolinea.Data;

namespace Aerolinea.Business.Interfaces
{
    public interface IAvionesCRUD
    {
        List<Avion> Listar();
        void Guardar(Avion avion);
        void Eliminar(int idAvion);
        Avion Buscar(int idAvion);
    }
}
