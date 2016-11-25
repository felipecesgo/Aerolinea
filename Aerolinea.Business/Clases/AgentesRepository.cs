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
        public List<Agente> ListarAgentes()
        {
            throw new NotImplementedException();
        }

        public void InsertarAgente(Agente agentes)
        {
            throw new NotImplementedException();
        }

        public void ActualizarAgente(Agente agentes)
        {
            throw new NotImplementedException();
        }

        public void EliminarAgente(int idAgente)
        {
            throw new NotImplementedException();
        }

        public Agente BuscarAgente(string nombreUsuario)
        {
           var agente = agentes.Get(x => x.Usuario == nombreUsuario).FirstOrDefault();
           return agente;
        }
    }
}
