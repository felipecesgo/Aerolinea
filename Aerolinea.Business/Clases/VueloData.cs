using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Business.Clases;

namespace Aerolinea.Business
{
    public class VueloData : Vuelo
    {

        public VueloData(Vuelo vuelo)
        {
            var rutas = new RutasCRUD();
            Ruta = rutas.BuscarRuta(vuelo.IdRuta);

            var aviones = new AvionesCRUD();
            Avion = aviones.Buscar(vuelo.IdAvion);

            var pilotos = new PilotosCRUD();
            Piloto = pilotos.Buscar(vuelo.IdPiloto);
        }

        public Ruta Ruta { get; set; }

        public Avion Avion { get; set; }

        public Piloto Piloto { get; set; }

      

    }
}
