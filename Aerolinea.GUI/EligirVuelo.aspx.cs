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

        protected void btnVueloSalida_Click(object sender, EventArgs e)
        {
           //lblTitle.Text = "Usted eligió";
           //ViewState["IdVueloSalida"] = 1000;
           //var vuelosRepository = new VuelosCRUD();

           //lvVuelos.DataSource = vuelosRepository.Listar().Where(x => x.Ruta.Origen == origen && x.Ruta.Destino == destino && x.FechaSalida.ToShortDateString() == fechasalida);
           //lvVuelos.DataBind();
        }
    }
}