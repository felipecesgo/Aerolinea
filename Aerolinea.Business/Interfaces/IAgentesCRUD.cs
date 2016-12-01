using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Business
{
    public interface IAgentesCRUD
    {
        List<Agente> ListarAgentes();
        void GuardarAgente(Agente agente);
        void EliminarAgente(int idAgente);
        Agente BuscarAgente(string nombreUsuario);

    }
}
