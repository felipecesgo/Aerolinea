using Aerolinea.Data;
using Aerolinea.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Business.Clases
{
    public class PagosCRUD
    {

         private Repository<Pago> pagos;

         public PagosCRUD()
        {
            pagos = new Repository<Pago>();
        }

  
        public void Guardar(Pago pago)
        {
            pagos.Save(pago);
        }

    }
}
