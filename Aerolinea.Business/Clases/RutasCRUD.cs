using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.DataAccess;

namespace Aerolinea.Business
{
    public class RutasCRUD : IRutasCRUD
    {

        //private List<Ruta> rutasList;

        //public RutasCRUD()
        //{
        //    rutasList = new List<Ruta>() { new Ruta() { IdRuta = 1, Origen = "Miami", Destino = "San José", Imagen = null, Tarifa = 613 } };
        //}

        //public List<Ruta> ListarRutas()
        //{
        //    return rutasList;
        //}

        //public void GuardarRuta(Ruta ruta)
        //{
        //    rutasList.Add(ruta);
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

        public RutasCRUD()
        {
            rutas = new Repository<Ruta>();
        }

        public List<Ruta> ListarRutas()
        {
            return rutas.GetAll();
        }

        public void GuardarRuta(Ruta ruta)
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

        public Ruta BuscarRutaOrigenYDestino(string origen, string destino)
        {
            return rutas.Get(x => x.Origen == origen && x.Destino == destino).FirstOrDefault();
        }
    }
}
