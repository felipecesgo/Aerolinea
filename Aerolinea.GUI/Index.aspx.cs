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
                var rutas = cargarRutas();

                var origenes = rutas.Select(x => x.Origen).Distinct().ToList();
           
                ddlOrigen.DataSource = origenes;
                ddlOrigen.DataBind();
                ddlOrigen.SelectedIndex = 0;
                cargarDestinos();
            }
        }

        private List<Ruta> cargarRutas()
        {
            RutasCRUD rutasRepository = new RutasCRUD();
            var rutas = rutasRepository.ListarRutas();
            lvRutas.DataSource = rutas.Take(8);
            lvRutas.DataBind();
            return rutas;
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
                    ddlDestino.DataSource = crud.BuscarRutasOrigen(origen).Select(x => x.Destino).Distinct().ToList();
                    ddlDestino.DataBind();
                    cargarRutas();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Ocurrio un error. " + ex.Message;
            }
        }

        protected void lvRutas_ItemCreated(object sender, ListViewItemEventArgs e)
        {
       
                var item = e.Item;
                var ruta = (Ruta)item.DataItem;
                if (ruta != null && ruta.Imagen != null && ruta.Imagen.Length > 0)
                {
                    var imageCtrl = (Image)item.FindControl("imgRuta");
                    imageCtrl.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String(ruta.Imagen, 0, ruta.Imagen.Length);
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
            var numPasajeros = ddlNumPasajeros.SelectedValue;


            Session.Add("origen", origen);
            Session.Add("destino", destino);
            Session.Add("salida", salida);
            Session.Add("regreso", regreso);
            Session.Add("pasajeros", numPasajeros);
            Session.Add("tipo", rblTipoViaje.SelectedValue);
            Response.Redirect("ElegirVuelo.aspx");


        }

        protected void ddlOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDestinos();
        }



       
    }
}