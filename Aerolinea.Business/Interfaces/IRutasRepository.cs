using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Data;

namespace Aerolinea.Business
{
    public interface IRutasRepository
    {
        List<Ruta> ListarRutas();
        void GuardarRuta(Ruta ruta);
        void EliminarRuta(int idRuta);
        Ruta BuscarRuta(int idRuta);

    }
}
