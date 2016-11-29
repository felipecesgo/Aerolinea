using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Data;
using Aerolinea.DataAccess;

namespace Aerolinea.Business.Clases
{
    public class AgentesRepository: IAgentesRepository
    {
        private Repository<Agente> agentes;


        public AgentesRepository()
        {
            agentes = new Repository<Agente>();
        }


        public List<Agente> ListarAgentes()
        {
            return agentes.GetAll();
        }

        public void InsertarAgente(Agente agente)
        {
            agentes.Save(agente);
        }

        public void ActualizarAgente(Agente agente)
        {
            agentes.Save(agente);
        }

        public void EliminarAgente(int idAgente)
        {
            agentes.Delete(idAgente);
        }

        public Agente BuscarAgente(string nombreUsuario)
        {
           var agente = agentes.Get(x => x.Usuario == nombreUsuario).FirstOrDefault();
           return agente;
        }
    }
}
