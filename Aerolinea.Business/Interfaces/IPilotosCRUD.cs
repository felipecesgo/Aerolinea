using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aerolinea.Data;

namespace Aerolinea.Business.Interfaces
{
    public interface IPilotosCRUD
    {
        List<Piloto> Listar();
        void Guardar(Piloto piloto);
        void Eliminar(int idPiloto);
        Piloto Buscar(int idPiloto);
        List<Piloto> Buscar(string texto);
    }
}
