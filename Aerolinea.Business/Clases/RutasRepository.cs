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

        //private List<Ruta> rutasList;

        //public RutasRepository()
        //{
        //    rutasList = new List<Ruta>() { new Ruta() { IdRuta = 1, Origen = "Miami", Destino = "San José", Imagen = null, Tarifa = 613 } };
        //}

        //public List<Ruta> ListarRutas()
        //{
        //    return rutasList;
        //}

        //public void InsertarRuta(Ruta ruta)
        //{
        //    rutasList.Add(ruta);
        //}

        //public void ActualizarRuta(Ruta ruta)
        //{
        //    rutasList.Where(x => x.IdRuta == ruta.IdRuta).ToList()
        //        .ForEach(y => { y.Origen = ruta.Origen; y.Destino = ruta.Destino; });
        //}

        //public void EliminarRuta(int idRuta)
        //{
        //    rutasList.RemoveAll(x => x.IdRuta == idRuta);
        //}

        //public Ruta BuscarRuta(int idRuta)
        //{
        //    return rutasList.Where(x => x.IdRuta == idRuta).FirstOrDefault();
        //}



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
