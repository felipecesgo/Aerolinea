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
    public class ReservaCRUD : IReserva

    {

        private Repository<Reserva> vuelos;
        private RutasCRUD rutas;
        public ReservaCRUD()
        {
            vuelos = new Repository<Reserva>();
            rutas = new RutasCRUD();
        }

        public void InsertarReserva(Data.Reserva reserva)
        {

            vuelos.Save(reserva);
        }

        public List<Data.Reserva> ListarReserva()
        {
            return vuelos.GetAll();
        }
    }
}
