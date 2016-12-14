using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Business.Interfaces
{
    public interface ITiquetesCRUD
    {
        List<Tiquete> Listar();
        void Guardar(Tiquete tiquete);
        void Eliminar(int idTiquete);
        Tiquete Buscar(int idTiquete);
        List<int> ListarAsientosOcupados(int idVuelo);
    }
}
