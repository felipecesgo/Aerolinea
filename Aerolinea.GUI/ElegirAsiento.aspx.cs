using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aerolinea.Data;
using Aerolinea.Business.Clases;
using System.Drawing;

namespace Aerolinea.GUI
{
    public partial class ElegirAsiento : System.Web.UI.Page
    {

        List<int> asientosOcupadosVueloIda = new List<int>();
        List<int> asientosOcupadosVueloRegreso = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var vuelo = Session["VueloSalida"] != null ? Session["VueloSalida"] as Vuelo : new Vuelo();
                lblNroVuelo.Text = vuelo.IdVuelo.ToString();
                lblOrigen.Text = vuelo.Ruta.Origen;
                lblDestino.Text = vuelo.Ruta.Destino;
                lblSalida.Text = Convert.ToString(vuelo.FechaSalida);
                lblLLegada.Text = Convert.ToString(vuelo.FechaLlegada);
                lblAvion.Text = vuelo.Avion.Nombre;
                lblDuracion.Text = vuelo.Duration;
                var cabina = Session["Cabina"] != null ? Session["Cabina"].ToString() : "";
                lblClase.Text = cabina;
                var pasajeros = Session["pasajeros"] != null ? Convert.ToInt32(Session["pasajeros"]) : 0;
                lblPasajeros.Text = pasajeros.ToString();
                ViewState.Add("pasajeros", pasajeros);
                var tiquetes = new TiquetesCRUD();
                asientosOcupadosVueloIda = tiquetes.ListarAsientosOcupados(vuelo.IdVuelo);
                cargarAsientosOcupadosVueloIda();
                lblInfoVueloIda.Text = string.Format("Información del Vuelo {0} a {1}", vuelo.Ruta.Origen, vuelo.Ruta.Destino);

                if (Session["VueloRegreso"] != null)
                {
                    var vueloRegreso = Session["VueloRegreso"] != null ? Session["VueloRegreso"] as Vuelo : new Vuelo();
                    lblNroVueloRegreso.Text = vueloRegreso.IdVuelo.ToString();
                    lblOrigenRegreso.Text = vueloRegreso.Ruta.Origen;
                    lblDestinoRegreso.Text = vueloRegreso.Ruta.Destino;
                    lblSalidaRegreso.Text = Convert.ToString(vueloRegreso.FechaSalida);
                    lblLlegadaRegreso.Text = Convert.ToString(vueloRegreso.FechaLlegada);
                    lblAvionRegreso.Text = vueloRegreso.Avion.Nombre;
                    lblDuracionRegreso.Text = vueloRegreso.Duration;
                    var cabinaRegreso = Session["CabinaRegreso"] != null ? Session["CabinaRegreso"].ToString() : "";
                    lblClaseRegreso.Text = cabinaRegreso;
                    lblPasajerosRegreso.Text = pasajeros.ToString();

                    asientosOcupadosVueloRegreso = tiquetes.ListarAsientosOcupados(vueloRegreso.IdVuelo);
                    cargarAsientosOcupadosVueloRegreso();
                    lblInfoVueloRegreso.Text = string.Format("Información del Vuelo {0} a {1}", vueloRegreso.Ruta.Origen, vueloRegreso.Ruta.Destino);
                    
                    PlantillaRegreso.Visible = true;
                    detalleRegreso.Visible = true;
                }

             
            }
        }

        protected void btnAsiento_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            var numPasajeros = Convert.ToInt32(ViewState["pasajeros"]);

            if (lbAsientos.Items.Count < numPasajeros)
            {
                cargarAsientosOcupadosVueloIda();

                if (btn.BackColor != Color.Red)
                {
                    btn.BackColor = Color.Blue;
                    int idAsiento = Convert.ToInt32(btn.CommandArgument);
                    lbAsientos.Items.Add(idAsiento.ToString());

                    if (lbAsientos.Items.Count == numPasajeros )
                    {
                        if (Session["VueloRegreso"] == null)
                        {
                            btnIngresar.Visible = true;
                        }
                    }
                   
                }
            }
            
        }

        private void cargarAsientosOcupadosVueloIda()
        {
            var allButtons = new List<Button>();
            FindButtons(Plantilla, allButtons);
            foreach (var button in allButtons)
            {
                var numasiento = int.Parse(button.CommandArgument);
                var estaOcupado = asientosOcupadosVueloIda.Contains(numasiento);
                if (estaOcupado)
                    button.BackColor = Color.Red;
                else
                    button.BackColor = Color.Green;
                var seleccionado = lbAsientos.Items.FindByText(numasiento.ToString());
                if (seleccionado != null)
                    button.BackColor = Color.Blue;
                if (lblClase.Text == "Cabina Ejecutiva" && numasiento > 8)
                    button.Visible = false;
                if (lblClase.Text == "Cabina Principal" && numasiento < 9)
                    button.Visible = false;
            }
            btnIngresar.Visible = false;
        }

        private void FindButtons(Control Parent, List<Button> ListOfButtons)
        {
            foreach (Control c in Parent.Controls)
            {
                if (c.HasControls())
                {
                    FindButtons(c, ListOfButtons);
                }
                else
                {
                    if (c is Button)
                    {
                        ListOfButtons.Add(c as Button);
                    }
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lbAsientos.SelectedIndex > -1)
            {
                lbAsientos.Items.RemoveAt(lbAsientos.SelectedIndex);
                cargarAsientosOcupadosVueloIda();
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Session.Add("LoginCliente", true);
            var asientosSalida ="";
            for(var i = 0; i < lbAsientos.Items.Count; i++)
                asientosSalida += "," + lbAsientos.Items[0].Value;
            asientosSalida = asientosSalida.Trim(',');
            Session.Add("asientosSalida", asientosSalida);

            var asientosLlegada = "";
            for (var i = 0; i < lbAsientosRegreso.Items.Count; i++)
                asientosLlegada += "," + lbAsientosRegreso.Items[0].Value;
            asientosLlegada = asientosLlegada.Trim(',');
            Session.Add("asientosRegreso", asientosLlegada);

            Response.Redirect("Account/Login.aspx?LoginCliente=true");

        }


        protected void btnAsientoRegreso_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            var numPasajeros = Convert.ToInt32(ViewState["pasajeros"]);

            if (lbAsientosRegreso.Items.Count < numPasajeros)
            {
                cargarAsientosOcupadosVueloRegreso();

                if (btn.BackColor != Color.Red)
                {
                    btn.BackColor = Color.Blue;
                    int idAsiento = Convert.ToInt32(btn.CommandArgument);
                    lbAsientosRegreso.Items.Add(idAsiento.ToString());

                    if (lbAsientosRegreso.Items.Count == numPasajeros)
                        btnIngresar.Visible = true;

                }
            }

        }

        private void cargarAsientosOcupadosVueloRegreso()
        {
            var allButtons = new List<Button>();
            FindButtons(PlantillaRegreso, allButtons);
            foreach (var button in allButtons)
            {
                var numasiento = int.Parse(button.CommandArgument);
                var estaOcupado = asientosOcupadosVueloRegreso.Contains(numasiento);
                if (estaOcupado)
                    button.BackColor = Color.Red;
                else
                    button.BackColor = Color.Green;
                var seleccionado = lbAsientosRegreso.Items.FindByText(numasiento.ToString());
                if (seleccionado != null)
                    button.BackColor = Color.Blue;
                if (lblClaseRegreso.Text == "Cabina Ejecutiva" && numasiento > 8)
                    button.Visible = false;
                if (lblClaseRegreso.Text == "Cabina Principal" && numasiento < 9)
                    button.Visible = false;
            }
            btnIngresar.Visible = false;
        }
        
        protected void btnEliminarRegreso_Click(object sender, EventArgs e)
        {
            if (lbAsientosRegreso.SelectedIndex > -1)
            {
                lbAsientosRegreso.Items.RemoveAt(lbAsientosRegreso.SelectedIndex);
                cargarAsientosOcupadosVueloRegreso();
            }
        }
    
    }
}