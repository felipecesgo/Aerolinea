using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Business
{
    public interface IAgentesRepository
    {
        List<Agente> ListarAgentes();
        void InsertarAgente(Agente agentes);
        void ActualizarAgente(Agente agentes);
        void EliminarAgente(int idAgente);
        Agente BuscarAgente(string nombreUsuario);

    }
}
