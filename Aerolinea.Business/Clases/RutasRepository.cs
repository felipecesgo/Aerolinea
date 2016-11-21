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
    public class RutasRepository : IRutasRepository
    {
        private Repository<Ruta> rutas;

        public RutasRepository()
        {
            rutas = new Repository<Ruta>();
        }

        public List<Ruta> ListarRutas()
        {
            return rutas.GetAll();
        }

        public void InsertarRuta(Ruta ruta)
        {
            rutas.Save(ruta);
        }

        public void ActualizarRuta(Ruta ruta)
        {
            rutas.Save(ruta);
        }

        public void EliminarRuta(int idRuta)
        {
            rutas.Delete(idRuta);
        }

        public Ruta BuscarRuta(int idRuta)
        {
            return rutas.GetById(idRuta);
        }
    }
}
