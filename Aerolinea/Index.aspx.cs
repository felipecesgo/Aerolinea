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
            if (!IsPostBack)
            {
                var rutasRepository = new RutasRepository();
                var rutas = rutasRepository.ListarRutas();
                lvRutas.DataSource = rutas;
                lvRutas.DataBind();

                var vuelosRepository = new VuelosRepository();
                var tiposViaje = vuelosRepository.ListarTiposViaje();

                for (var x = 0; x < tiposViaje.Count; x++)
                {
                    var item = new ListItem(tiposViaje[x].Nombre, tiposViaje[x].IdTipoViaje.ToString());
                    if (x == 0)
                        item.Selected = true;
                    item.Attributes.Add("style", "margin-right:15px;");
                    rblTipoViaje.Items.Add(item);
                }

                ddlOrigen.DataSource = rutas.Select(x => x.Origen).ToList();
                ddlOrigen.DataBind();

                ddlDestino.DataSource = rutas.Select(x => x.Destino).ToList();
                ddlDestino.DataBind();

            }
        }

       

        protected void lvRutas_ItemCreated(object sender, ListViewItemEventArgs e)
        {
            var item = e.Item;
            var ruta = (Ruta) item.DataItem;
            if (ruta != null && ruta.Imagen != null && ruta.Imagen.Length > 0)
            {
                var imageCtrl = (Image) item.FindControl("imgRuta");
                string base64String = Convert.ToBase64String(ruta.Imagen, 0, ruta.Imagen.Length);
                imageCtrl.ImageUrl = "data:image/jpeg;base64," + base64String;
            }
        }

        protected void lkbtnSearch_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            var origen = ddlOrigen.SelectedValue;
            var destino = ddlDestino.SelectedValue;
            var salida = hdnfechaSalida.Value;
            var regreso = hdnfechaRegreso.Value;
            Session.Add("origen", origen);
            Session.Add("destino", destino);
            Session.Add("salida", salida);
            Session.Add("regreso", regreso);
            Response.Redirect("EligirVuelo.aspx");
        }



       
    }
}