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
                 var idVuelo = Session["IdVuelo"] != null ? Convert.ToInt32(Session["IdVuelo"]) : 0;

                var tiquetes = new TiquetesCRUD();
                asientosOcupados = tiquetes.ListarAsientosOcupados(idVuelo);
                cargarAsientosOcupados();
                  
            }
        }

        protected void btnAsiento_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            cargarAsientosOcupados();

            if (btn.BackColor != Color.Red)
            {
                btn.BackColor = Color.Blue;
                int idAsiento = Convert.ToInt32(btn.CommandArgument);

                Session.Add("idAsiento", idAsiento);
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

    
    }
}