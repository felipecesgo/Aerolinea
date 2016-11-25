using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aerolinea
{
    public partial class EligirVuelo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                if (Session["origen"] != null)
                    lblOrigen.Text = Session["origen"].ToString();

                if (Session["salida"] != null)
                {
                    var date = Convert.ToDateTime(Session["salida"].ToString());

                    lblFechaSalida.Text = date.ToLongDateString();
                }


            }
        }
    }
}