using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Business.Interfaces
{
    public interface IReserva
    {
        List<Data.Reserva> ListarReserva();
        void InsertarReserva(Data.Reserva reserva);
    }
}
