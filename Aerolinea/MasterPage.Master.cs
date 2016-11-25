using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aerolinea
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = Request.AppRelativeCurrentExecutionFilePath;
       
            foreach (MenuItem item in mnuPrincipal.Items)
            {
                item.Selected = item.NavigateUrl.Equals(path, StringComparison.InvariantCultureIgnoreCase);
            }

            if (Session["user"] != null)
            {
                var usuario = (Agente)Session["user"];
                lbtnLogOut.Text = string.Format("{0} {1}", usuario.Nombre, usuario.Apellido) + "Cerrar Sesión";
                lbtnLogIn.Visible = false;
                lbtnLogOut.Visible = true;

                mnuPrincipal.Items.Clear();
                string currentPage = Request.Url.AbsolutePath;
                if (usuario.IdRol == 1)
                {
                    var menuRutas = new MenuItem
                    {
                        Value = "AdministrarRutas",
                        Text = "Rutas",
                        NavigateUrl = "~/Mantenimientos/MantRutas.aspx",
                        Selected = currentPage.Contains("MantRutas.aspx")
                    };
                    mnuPrincipal.Items.Add(menuRutas);

                    var menuAgentes = new MenuItem
                    {
                        Value = "AdministrarAgentes",
                        Text = "Agentes",
                        NavigateUrl = "~/Mantenimientos/MantAgentes.aspx",
                        Selected = currentPage.Contains("MantAgentes.aspx")
                    };
                    mnuPrincipal.Items.Add(menuAgentes);

                  
                }
            }
        


        }

        protected void lbtnLogOut_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            lbtnLogIn.Visible = true;
            lbtnLogOut.Visible = false;
        }
    }
}