using Aerolinea.Business;
using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aerolinea
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var rutasRepository = new RutaRepository();
            var rutas = rutasRepository.ListarRutas();

            lvRutas.DataSource = rutas;
            lvRutas.DataBind();
        }

    
        protected void btnComprar_Click(object sender, EventArgs e)
        {

        }

        protected void lvRutas_ItemCreated(object sender, ListViewItemEventArgs e)
        {
            var item = e.Item;
            var ruta = (Ruta) item.DataItem;
            if(ruta.Imagen != null && ruta.Imagen.Length > 0)
            {
                var imageCtrl = (Image) item.FindControl("imgRuta");
                string base64String = Convert.ToBase64String(ruta.Imagen, 0, ruta.Imagen.Length);
                imageCtrl.ImageUrl = "data:image/jpeg;base64," + base64String;
            }
        }



       
    }
}