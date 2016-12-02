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
        private RutasCRUD rutas;

        public VuelosCRUD()
        {
            rutas = new RutasCRUD();
            vuelos = new List<Vuelo>() { new Vuelo() { IdVuelo = 1, IdAvion = 1, IdRuta = 1, IdPiloto = 1, FechaSalida = DateTime.Now, FechaLlegada = DateTime.Now, EstadoVuelo = "En Horario", CapacidadAsientos = 100 } };
        }

        public List<Vuelo> Listar()
        {
            vuelos.ForEach(x => x.Ruta = rutas.BuscarRuta(x.IdRuta));
            return vuelos;
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

        public Vuelo Buscar(int idVuelo)
        {
            var vuelo = vuelos.Where(x => x.IdVuelo == idVuelo).FirstOrDefault();
            vuelo.Ruta = rutas.BuscarRuta(vuelo.IdRuta);
            return vuelo;
        }

        public List<Vuelo> Buscar(string textoAbuscar)
        {
            var numvuelo = -1;
            int.TryParse(textoAbuscar, out numvuelo);
            return this.Listar()
             .Where(x => x.IdVuelo == numvuelo || x.Ruta.Origen.Contains(textoAbuscar) || x.Ruta.Destino.Contains(textoAbuscar)).ToList();
       }

 
        //private Repository<Vuelo> vuelos;
        //private RutasCRUD rutas;
        //public VuelosCRUD()
        //{
        //    vuelos = new Repository<Vuelo>();
        //    rutas = new RutasCRUD();
        //}

        //public List<Vuelo> Listar()
        //{
           
        //    var listavuelos = vuelos.GetAll();
        //    listavuelos.ForEach(x => x.Ruta = rutas.BuscarRuta(x.IdRuta));
        //    return listavuelos;
        //}

        //public void Guardar(Vuelo vuelo)
        //{
        //    vuelos.Save(vuelo);
        //}

        //public void Eliminar(int idVuelo)
        //{
        //    vuelos.Delete(idVuelo);
        //}

        //public Vuelo Buscar(int idVuelo)
        //{
        //    var vuelo = vuelos.Get(x => x.IdVuelo == idVuelo).FirstOrDefault();
        //    vuelo.Ruta = rutas.BuscarRuta(vuelo.IdRuta);
        //    return vuelo;
        //}

        //public List<Vuelo> Buscar(string textoAbuscar)
        //{
        //    var numvuelo = -1;
        //    int.TryParse(textoAbuscar, out numvuelo);
        //    return this.Listar()
        //        .Where(x => x.IdVuelo == numvuelo || x.Ruta.Origen.Contains(textoAbuscar) || x.Ruta.Destino.Contains(textoAbuscar)).ToList();
           
        //}
    }
}
