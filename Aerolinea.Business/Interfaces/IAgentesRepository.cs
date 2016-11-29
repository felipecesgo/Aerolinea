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
        void InsertarAgente(Agente agente);
        void ActualizarAgente(Agente agente);
        void EliminarAgente(int idAgente);
        Agente BuscarAgente(string nombreUsuario);

    }
}
