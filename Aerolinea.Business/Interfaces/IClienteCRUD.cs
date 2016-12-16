using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Data;

namespace Aerolinea.Business.Interfaces
{
   public interface IClienteCRUD
    {

        List<Cliente> ListarCliente();
        void GuardarCliente(Cliente cliente);
        void EliminarCliente(int cedula);
        Cliente BuscarCliente(string usuario);
    }
}
