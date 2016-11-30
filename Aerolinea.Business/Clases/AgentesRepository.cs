using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Data;
//using Aerolinea.DataAccess;

namespace Aerolinea.Business.Clases
{
    public class AgentesRepository: IAgentesRepository
    {
  
        private List<Agente> agentes;

        public AgentesRepository()
        {
            agentes = new List<Agente>() {   new Agente() { Nombre = "Felipe", Apellido = "Cespedes", Usuario= "lfcg", Contrasena = "123" } };
        }

        public List<Agente> ListarAgentes()
        {
            return agentes;
        }

        public void InsertarAgente(Agente agente)
        {
            agentes.Add(agente);
        }

        public void ActualizarAgente(Agente agente)
        {
            agentes.Where(x => x.IdAgente == agente.IdAgente).ToList()
           .ForEach(y => { y.Nombre = agente.Nombre; y.Telefono = agente.Telefono; }); 
        }

        public void EliminarAgente(int idAgente)
        {
            agentes.RemoveAll(x => x.IdAgente == idAgente);
        }

        public Agente BuscarAgente(string nombreUsuario)
        {
            return agentes.Where(x => x.Usuario == nombreUsuario).FirstOrDefault();
        }


        //private Repository<Agente> agentes;

        //public AgentesRepository()
        //{
        //    agentes = new Repository<Agente>();
        //}

        //public List<Agente> ListarAgentes()
        //{
        //    return agentes.GetAll();
        //}

        //public void InsertarAgente(Agente agente)
        //{
        //    agentes.Save(agente);
        //}

        //public void ActualizarAgente(Agente agente)
        //{
        //    agentes.Save(agente);
        //}

        //public void EliminarAgente(int idAgente)
        //{
        //    agentes.Delete(idAgente);
        //}

        //public Agente BuscarAgente(string nombreUsuario)
        //{
        //    var agente = agentes.Get(x => x.Usuario == nombreUsuario).FirstOrDefault();
        //   return agente;
        //}
    }
}
