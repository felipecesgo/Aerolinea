using Aerolinea.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aerolinea.GUI
{
    public partial class EstadoVuelos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var crud = new VuelosCRUD();
                var vuelo = crud.Buscar(txtBuscar.Text).FirstOrDefault();

                lblNroVueloRegreso.Text = vuelo.IdVuelo.ToString();
                lblAvionRegreso.Text = vuelo.Avion.Nombre;
                lblSalidaRegreso.Text = Convert.ToString( vuelo.FechaSalida);
                lblLlegada.Text = Convert.ToString(vuelo.FechaLlegada);
                lblDestinoRegreso.Text = vuelo.Ruta.Destino;
                lblOrigenRegreso.Text = vuelo.Ruta.Origen;
                lblEstadoVuelo.Text = vuelo.EstadoVuelo;
                lblDuracionRegreso.Text = vuelo.Duration;
                detalleRegreso.Visible = true;
            }
            catch (Exception ex)
            {
                mensajeError.Visible = true;
                textoMensajeError.InnerHtml = "Ocurrio un error: " + ex.Message;
            }
        }
    }
}