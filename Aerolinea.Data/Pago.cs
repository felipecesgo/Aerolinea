using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Data
{
    public class Pago
    {
        public int IdPago { get; set; }

        public int IdTiquete { get; set; }

        public string FormaPago { get; set; }

        public decimal Monto { get; set; }

    }

}
