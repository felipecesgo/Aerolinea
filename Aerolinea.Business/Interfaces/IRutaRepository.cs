using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Data;

namespace Aerolinea.Business
{
    public interface IRutaRepository
    {
        List<Ruta> ListarRutas();
        void InsertarRuta(Ruta ruta);
        void ActualizarRuta(Ruta ruta);
        void EliminarRuta(int idRuta);
        Ruta BuscarRuta(int idRuta);

    }
}
