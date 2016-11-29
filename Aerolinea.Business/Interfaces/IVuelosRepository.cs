using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Data;

namespace Aerolinea.Business
{
    public interface IVuelosRepository
    {
        List<Vuelo> ListarVuelos();
        void InsertarVuelo(Vuelo ruta);
        void ActualizarVuelo(Vuelo ruta);
        void EliminarVuelo(int idVuelo);
        Vuelo BuscarVuelo(int idVuelo);


    }
}
