using Aerolinea.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

                lblOrigen.Text = origen;
                lblFechaSalida.Text = salida.ToLongDateString();

                var fechasalida = salida.ToShortDateString();
                var vuelosRepository = new VuelosCRUD();
                lvVuelos.DataSource = vuelosRepository.Listar().Where(x => x.Ruta.Origen == origen && x.Ruta.Destino == destino && x.FechaSalida.ToShortDateString() == fechasalida);
                lvVuelos.DataBind();

            }
        }

     

        protected void btnComprarPrincipal_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Usted eligió";
            LinkButton btn = (LinkButton)sender;
            int idVuelo = Convert.ToInt32(btn.CommandArgument);
            tipoCabina.InnerHtml = "Cabina Principal";

            mostrarVueloSalida(idVuelo);
        }

        protected void btnComprarEjecutiva_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Usted eligió";
            Button btn = (Button)sender;
            int idVuelo = Convert.ToInt32(btn.CommandArgument);

            tipoCabina.InnerHtml = "Cabina Ejecutiva";
            mostrarVueloSalida(idVuelo);
        }

        private void mostrarVueloSalida(int idVuelo)
        {
            var vuelosRepository = new VuelosCRUD();
            var vuelo = vuelosRepository.Buscar(idVuelo);
            origenSalida.InnerHtml = vuelo.Ruta.Origen;
            destinoSalida.InnerHtml = vuelo.Ruta.Destino;
            horaSalida1.InnerHtml = vuelo.FechaSalida.ToShortTimeString();
            horaLlegada1.InnerHtml = vuelo.FechaLlegada.ToShortTimeString();
            duration.InnerHtml = vuelo.Duration;
            escalas.InnerHtml = vuelo.CantidadEscalas;
            vueloSalida.Visible = true;
            var tipo = Session["tipo"] != null ? Session["tipo"].ToString() : "";
            if (tipo == "Solo ida")
            {
                listaVuuelos.Visible = false;
                btnEligirAsientos.Visible = true;
            }

        }


    }
}