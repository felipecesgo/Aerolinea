using Aerolinea.Data;
using Aerolinea.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aerolinea.Business
{
    public class VuelosRepository : IVuelosRepository
    {
        private Repository<Vuelo> vuelos;
        private Repository<TipoViaje> tiposViajes;

        public VuelosRepository()
        {
            vuelos = new Repository<Vuelo>();
            tiposViajes = new Repository<TipoViaje>();
        }
        public List<Vuelo> ListarVuelos()
        {
            return vuelos.GetAll();
        }

        public void InsertarVuelo(Vuelo ruta)
        {
            throw new NotImplementedException();
        }

        public void ActualizarVuelo(Vuelo ruta)
        {
            throw new NotImplementedException();
        }

        public void EliminarVuelo(int idVuelo)
        {
            throw new NotImplementedException();
        }

        public Ruta BuscarVuelo(int idVuelo)
        {
            throw new NotImplementedException();
        }

        public List<TipoViaje> ListarTiposViaje()
        {
            return tiposViajes.GetAll();
        }
    }
}
