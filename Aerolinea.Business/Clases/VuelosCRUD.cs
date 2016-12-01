using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Data;
//using Aerolinea.DataAccess;

namespace Aerolinea.Business
{
    public class VuelosCRUD : IVuelosCRUD
    {

        private List<Vuelo> vuelos;

        public VuelosCRUD()
        {
            vuelos = new List<Vuelo>() { new Vuelo() { IdVuelo = 1, IdAvion = 1, IdRuta = 1, IdPiloto = 1, FechaSalida = DateTime.Now, FechaLlegada = DateTime.Now, EstadoVuelo = "Disponible" } };
        }

        public List<VueloData> Listar()
        {
            return vuelos.Select(x => x as VueloData).ToList();
        }

        public void Guardar(Vuelo vuelo)
        {
            Eliminar(vuelo.IdVuelo);
            vuelos.Add(vuelo);
        }

        public void Eliminar(int idVuelo)
        {
            vuelos.RemoveAll(x => x.IdVuelo == idVuelo);
        }

        public VueloData Buscar(int idVuelo)
        {
            return vuelos.Where(x => x.IdVuelo == idVuelo).FirstOrDefault() as VueloData;
        }


        //private Repository<Vuelo> vuelos;

        //public VuelosCRUD()
        //{
        //    vuelos = new Repository<Vuelo>();
        //}

        //public List<VueloData> Listar()
        //{
        //    return vuelos.GetAll().Select(x => x as VueloData).ToList();
        //}

        //public void Guardar(Vuelo vuelo)
        //{
        //    vuelos.Save(vuelo);
        //}

        //public void Eliminar(int idVuelo)
        //{
        //    vuelos.Delete(idVuelo);
        //}

        //public VueloData Buscar(int idVuelo)
        //{
        //    var vuelo = vuelos.Get(x => x.IdVuelo == idVuelo).FirstOrDefault() as VueloData;
        //    return vuelo;
        //}


    }
}
