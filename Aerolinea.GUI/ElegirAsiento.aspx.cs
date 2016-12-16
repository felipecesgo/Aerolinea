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

        List<int> asientosOcupados = new List<int>();

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
                asientosOcupados = tiquetes.ListarAsientosOcupados(vuelo.IdVuelo);
                cargarAsientosOcupados();
             
            }
        }

        protected void btnAsiento_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            var numPasajeros = Convert.ToInt32(ViewState["pasajeros"]);

            if (lbAsientos.Items.Count < numPasajeros)
            {
                cargarAsientosOcupados();

                if (btn.BackColor != Color.Red)
                {
                    btn.BackColor = Color.Blue;
                    int idAsiento = Convert.ToInt32(btn.CommandArgument);
                    lbAsientos.Items.Add(idAsiento.ToString());
                }
            }
        }

        private void cargarAsientosOcupados()
        {
            var allButtons = new List<Button>();
            FindButtons(Plantilla, allButtons);
            foreach (var button in allButtons)
            {
                var numasiento = int.Parse(button.CommandArgument);
                var estaOcupado = asientosOcupados.Contains(numasiento);
                if (estaOcupado)
                {
                    button.BackColor = Color.Red;
                }
                else
                {
                    button.BackColor = Color.Green;
                }

                var seleccionado = lbAsientos.Items.FindByText(numasiento.ToString());
                if (seleccionado != null)
                {
                    button.BackColor = Color.Blue;
                }

                if (lblClase.Text == "Cabina Ejecutiva" && numasiento > 8)
                {
                    button.Visible = false;
                }
                if (lblClase.Text == "Cabina Principal" && numasiento < 9)
                {
                    button.Visible = false;
                }
            }
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
                cargarAsientosOcupados();
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Session.Add("LoginCliente", true);

            var asientosSalida = string.Join(",", lbAsientos.Items);
            Session.Add("asientosSalida", asientosSalida);

            Response.Redirect("Account/Login.aspx?LoginCliente=true");

        }

    
    }
}