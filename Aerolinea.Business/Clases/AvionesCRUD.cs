using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Data;
using Aerolinea.Business.Interfaces;
//using Aerolinea.DataAccess;

namespace Aerolinea.Business.Clases
{
    public class AvionesCRUD : IAvionesCRUD
    {
        private List<Avion> aviones;

        public AvionesCRUD()
        {
            aviones = new List<Avion>() { new Avion() { IdAvion = 1, Marca = "Boeign", Modelo = "700", Matricula = "12345" } };
        }

        public List<Avion> Listar()
        {
            return aviones;
        }

        public void Guardar(Avion avion)
        {
            aviones.Add(avion);
        }

        public void Eliminar(int idAvion)
        {
            aviones.RemoveAll(x => x.IdAvion == idAvion);
        }

        public Avion Buscar(int idAvion)
        {
            return aviones.Where(x => x.IdAvion == idAvion).FirstOrDefault();
        }


        //private Repository<Avion> aviones;

        //public AvionesCRUD()
        //{
        //    aviones = new Repository<Rol>();
        //}
   
        //public List<Avion> Listar()
        //{
        //    return aviones.GetAll();
        //}

        //public void Guardar(Avion avion)
        //{
        //    aviones.Save(avion);
        //}

        //public void Eliminar(int idAvion)
        //{
        //    aviones.Delete(idAvion);
        //}

        //public Avion Buscar(int idAvion)
        //{
        //    return aviones.GetById(idAvion);
        //}

    }
}
