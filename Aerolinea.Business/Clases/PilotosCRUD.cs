using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aerolinea.Business.Interfaces;
using Aerolinea.Data;
//using Aerolinea.DataAccess;

namespace Aerolinea.Business.Clases
{
    public class PilotosCRUD : IPilotosCRUD
    {

        private List<Piloto> pilotos;

        public PilotosCRUD()
        {
            pilotos = new List<Piloto>() { new Piloto() { IdPiloto = 1, Cedula="115050504", Nombre = "Felipe", Apellido = "Cespedes", Email = "felipe9206@gmail.com", Telefono = "8721-9751", Residencia = "Cartago" } };
        }

        public List<Piloto> Listar()
        {
            return pilotos;
        }

        public void Guardar(Piloto piloto)
        {
            Eliminar(piloto.IdPiloto);
            pilotos.Add(piloto);
        }

        public void Eliminar(int idPiloto)
        {
            pilotos.RemoveAll(x => x.IdPiloto == idPiloto);
        }

        public Piloto Buscar(int idPiloto)
        {
            return pilotos.Where(x => x.IdPiloto == idPiloto).FirstOrDefault();
        }

        public List<Piloto> Buscar(string texto)
        {
            return pilotos.Where(x => x.Cedula.Contains(texto) || x.Nombre.Contains(texto) || x.Apellido.Contains(texto)).ToList();
        }


        //private Repository<Piloto> pilotos;

        //public PilotosCRUD()
        //{
        //    pilotos = new Repository<Agente>();
        //}

        //public List<Piloto> Listar()
        //{
        //    return pilotos.GetAll();
        //}

        //public void Guardar(Piloto piloto)
        //{
        //    pilotos.Save(piloto);
        //}

        //public void Eliminar(int idPiloto)
        //{
        //    pilotos.Delete(idPiloto);
        //}

        //public Piloto Buscar(int idPiloto)
        //{
        //    var piloto = pilotos.Get(x => x.IdPiloto == idPiloto).FirstOrDefault();
        //    return piloto;
        //}

        //public List<Piloto> Buscar(string texto)
        //{
        //    return pilotos.Get(x => x.Cedula.Contains(texto) || x.Nombre.Contains(texto) || x.Apellido.Contains(texto));
        //}



    
    }
}
