using Aerolinea.Business;
using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aerolinea.GUI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var rutasRepository = new RutasCRUD();
                var rutas = rutasRepository.ListarRutas().Take(8);
                lvRutas.DataSource = rutas;
                lvRutas.DataBind();

                ddlOrigen.DataSource = rutas.Select(x => x.Origen).ToList();
                ddlOrigen.DataBind();

                ddlDestino.DataSource = rutas.Select(x => x.Destino).ToList();
                ddlDestino.DataBind();

            }
        }

        private void cargarDestinos()
        {
            try
            {
                if (ddlOrigen.SelectedIndex > -1)
                {
                    var crud = new RutasCRUD();
                    var origen = ddlOrigen.SelectedItem.Text;
                    ddlDestino.DataSource = null;
                    ddlDestino.DataValueField = "IdRuta";
                    ddlDestino.DataTextField = "Destino";
                    ddlDestino.DataSource = crud.BuscarRutasOrigen(origen);
                    ddlDestino.DataBind();
                }
            }
            catch (Exception ex)
            {
                
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

            Session.Add("tipo", rblTipoViaje.SelectedValue);
            Response.Redirect("EligirVuelo.aspx");
        }



       
    }
}