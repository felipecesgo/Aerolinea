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

        public VuelosRepository()
        {
            vuelos = new Repository<Vuelo>();
        }
        public List<Vuelo> ListarVuelos()
        {
            return vuelos.GetAll();
        }

        public void InsertarVuelo(Vuelo vuelo)
        {
            vuelos.Save(vuelo);
        }

        public void ActualizarVuelo(Vuelo vuelo)
        {
            vuelos.Save(vuelo);
        }

        public void EliminarVuelo(int idVuelo)
        {
            vuelos.Delete(idVuelo);
        }

        public Vuelo BuscarVuelo(int idVuelo)
        {
            return vuelos.GetById(idVuelo);
        }
        
    }
}
