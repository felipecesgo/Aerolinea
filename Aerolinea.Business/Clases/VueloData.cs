using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Business
{
    public class VueloData : Vuelo
    {

        public VueloData(Vuelo vuelo)
        {
            var rutas = new RutasRepository();
            Ruta = rutas.BuscarRuta(vuelo.IdRuta);
        }

        public Ruta Ruta { get; set; }
    }
}
