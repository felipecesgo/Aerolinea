using Aerolinea.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Data;
using Aerolinea.DataAccess;

namespace Aerolinea.Business.Clases
{
    public class ClientesCRUD : IClienteCRUD

    {
        private Repository<Cliente> clientes;

        public ClientesCRUD()
        {
            clientes = new Repository<Cliente>();
        }

        public Cliente BuscarCliente(string cedula)
        {
            var cliente = clientes.Get(x => x.Nombre == cedula).FirstOrDefault();
            return cliente;
        }

        public void EliminarCliente(int cedula)
        {
            clientes.Delete(cedula);
        }

        public void GuardarCliente(Cliente cliente)
        {
            //cliente.Save(cliente);
        }

        public List<Cliente> ListarCliente()
        {

            return clientes.GetAll();
        }
    }
}
