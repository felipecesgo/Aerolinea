using Aerolinea.Business.Interfaces;
using Aerolinea.Data;
using Aerolinea.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Business.Clases
{
    public class TiquetesCRUD : ITiquetesCRUD
    {

        private Repository<Tiquete> tiquetes;

        public TiquetesCRUD()
        {
            tiquetes = new Repository<Tiquete>();
        }

        public List<Tiquete> Listar()
        {
            return tiquetes.GetAll();
        }

        public void Guardar(Tiquete tiquete)
        {
            tiquetes.Save(tiquete);
        }

        public void Eliminar(int idTiquete)
        {
            tiquetes.Delete(idTiquete);
        }

        public Tiquete Buscar(int idTiquete)
        {
            return tiquetes.GetById(idTiquete);
        }


        public List<int> ListarAsientosOcupados(int idVuelo)
        {
            return tiquetes.Get(x => x.IdVuelo == idVuelo).Select(x => x.NumeroDeAsiento).ToList();
        }
    }
}
