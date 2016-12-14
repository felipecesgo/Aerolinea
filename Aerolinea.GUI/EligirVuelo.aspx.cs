using Aerolinea.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aerolinea.Data;

namespace Aerolinea.GUI
{
    public partial class EligirVuelo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                var origen = Session["origen"] != null ? Session["origen"].ToString() : "";
                var destino = Session["destino"] != null ? Session["destino"].ToString() : "";
                var salida = Session["salida"] != null ? Convert.ToDateTime(Session["salida"].ToString()) : new DateTime();
                var regreso = Session["regreso"] != null ? Convert.ToDateTime(Session["regreso"].ToString()) : new DateTime();
                var tipo = Session["tipo"] != null ? Session["tipo"].ToString() : "";

                lblOrigen.Text = origen;
                lblFechaSalida.Text = salida.ToLongDateString();

                var fechasalida = salida.ToShortDateString();
                var vuelosRepository = new VuelosCRUD();
                var vuelosSalida = vuelosRepository.Listar().Where(x => x.Ruta.Origen == origen && x.Ruta.Destino == destino && x.FechaSalida.ToShortDateString() == fechasalida);

                if (vuelosSalida.Count() == 0)
                {
                    lblMensajeError.Text = string.Format("No se encontraron vuelos de {0} a {1} para el día {2}.", origen, destino, fechasalida);
                    return;
                }

                if (tipo == "Ida y vuelta")
                {
                    var fechaRegreso = regreso.ToShortDateString();
                    var vuelosRegreso = vuelosRepository.Listar().Where(x => x.Ruta.Origen == destino && x.Ruta.Destino == origen && x.FechaLlegada.ToShortDateString() == fechaRegreso);
                    if (vuelosRegreso.Count() == 0)
                    {
                        lblMensajeError.Text = string.Format("No se encontraron vuelos de {0} a {1} para el día {2}.", destino, origen, fechaRegreso);
                        return;
                    }
                }

                lvVuelos.DataSource = vuelosSalida;
                lvVuelos.DataBind();
            }
        }

     

        protected void btnComprarPrincipal_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int idVuelo = Convert.ToInt32(btn.CommandArgument);

            cargarInfoVuelo(idVuelo, "Cabina Principal");
        }

        protected void btnComprarEjecutiva_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idVuelo = Convert.ToInt32(btn.CommandArgument);

            cargarInfoVuelo(idVuelo, "Cabina Ejecutiva");
        }

        private void cargarInfoVuelo(int idVuelo, string cabina)
        {
            var vuelosRepository = new VuelosCRUD();
            var vuelo = vuelosRepository.Buscar(idVuelo);

            var tipo = Session["tipo"] != null ? Session["tipo"].ToString() : "";
            if (tipo == "Solo ida")
            {
                lblTitle.Text = "Usted eligió";
                tipoCabina.InnerHtml = cabina;
                mostrarVueloSalida(vuelo);
                listaVuelos.Visible = false;
                btnEligirAsientos.Visible = true;
            }
            else
            {
                if (Session["VueloSalida"] == null) // Elegir vuelo de Regreso 
                {
                    lblTitle.Text = "Usted eligió";
                    tipoCabina.InnerHtml = cabina;
                    mostrarVueloSalida(vuelo);
                    var regreso = Session["regreso"] != null ? Convert.ToDateTime(Session["regreso"].ToString()) : new DateTime();

                    lblDestino.Text = vuelo.Ruta.Destino;
                    lblFechaRegreso.Text = regreso.ToLongDateString();
                    titulosVuelta.Visible = true;

                    var fechaRegreso = regreso.ToShortDateString();
                    var vuelosRegreso = vuelosRepository.Listar().Where(x => x.Ruta.Origen == vuelo.Ruta.Destino && x.Ruta.Destino == vuelo.Ruta.Origen && x.FechaLlegada.ToShortDateString() == fechaRegreso);
                    lvVuelos.DataSource = vuelosRegreso;
                    lvVuelos.DataBind();
                }
                else
                {
                    tipoCabina2.InnerHtml = "Cabina Ejecutiva";
                    mostrarVueloRegreso(vuelo);
                    listaVuelos.Visible = false;
                    btnEligirAsientos.Visible = true;
                }
            }
        }

        private void mostrarVueloSalida(Vuelo vuelo)
        {
            origenSalida.InnerHtml = vuelo.Ruta.Origen;
            destinoSalida.InnerHtml = vuelo.Ruta.Destino;
            horaSalida1.InnerHtml = vuelo.FechaSalida.ToShortTimeString();
            horaLlegada1.InnerHtml = vuelo.FechaLlegada.ToShortTimeString();
            duration.InnerHtml = vuelo.Duration;
            escalas.InnerHtml = vuelo.CantidadEscalas;
            vueloSalida.Visible = true;
            Session.Add("VueloSalida", vuelo);
        }

        private void mostrarVueloRegreso(Vuelo vuelo)
        {
            origenRegreso.InnerHtml = vuelo.Ruta.Origen;
            destinoRegreso.InnerHtml = vuelo.Ruta.Destino;
            horaSalida2.InnerHtml = vuelo.FechaSalida.ToShortTimeString();
            horaLlegada2.InnerHtml = vuelo.FechaLlegada.ToShortTimeString();
            duration2.InnerHtml = vuelo.Duration;
            escalas2.InnerHtml = vuelo.CantidadEscalas;
            vueloRegreso.Visible = true;
            Session.Add("VueloRegreso", vuelo);
        }


    }
}