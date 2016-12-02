using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Data;

namespace Aerolinea.Business
{
    public interface IVuelosCRUD
    {
        List<Vuelo> Listar();
        void Guardar(Vuelo vuelo);
        void Eliminar(int idVuelo);
        Vuelo Buscar(int idVuelo);
    }
}
