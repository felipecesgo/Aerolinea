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
         
            string currentPage = Request.Url.AbsolutePath;
            if (currentPage.Contains("Login"))
            {
                lbtnLogIn.Visible = false;
                mnuPrincipal.Items.Clear();
            }

            if (Session["usuario"] != null)
            {
                var usuario = (Agente)Session["usuario"];
                lbtnLogOut.Text = string.Format("{0} {1} (Cerrar Sesión)", usuario.Nombre, usuario.Apellido);
                lbtnLogIn.Visible = false;
                lbtnLogOut.Visible = true;

                if (usuario.IdRol == 1)
                {
                    mnuPrincipal.Items.Clear();
                    var menuRutas = new MenuItem
                    {
                        Value = "AdministrarRutas",
                        Text = "Rutas",
                        NavigateUrl = "~/Mantenimientos/MantRuta.aspx",
                        Selected = currentPage.Contains("MantRuta.aspx")
                    };
                    mnuPrincipal.Items.Add(menuRutas);
                    var menuAgentes = new MenuItem
                    {
                        Value = "AdministrarAgentes",
                        Text = "Agentes",
                        NavigateUrl = "~/Mantenimientos/MantAgente.aspx",
                        Selected = currentPage.Contains("MantAgente.aspx")
                    };
                    mnuPrincipal.Items.Add(menuAgentes);
                }
            }
            else
            {
                if (!currentPage.Contains("Login"))
                {
                    mnuPrincipal.Items.Clear();
                    var menuIndex = new MenuItem
                    {
                        Value = "ReservarVuelo",
                        Text = "Reserve su vuelo",
                        NavigateUrl = "~/Index.aspx",
                        Selected = currentPage.Contains("Index.aspx")
                    };
                    mnuPrincipal.Items.Add(menuIndex);
                    var menuEstadoVuelos = new MenuItem
                    {
                        Value = "EstadoVuelos",
                        Text = "Estado de vuelos",
                        NavigateUrl = "~/EstadoVuelos.aspx",
                        Selected = currentPage.Contains("EstadoVuelos.aspx")
                    };
                    mnuPrincipal.Items.Add(menuEstadoVuelos);
                }
            }



            foreach (MenuItem item in mnuPrincipal.Items)
            {
                item.Selected = item.NavigateUrl.Contains(currentPage);
            }
        }

        protected void lbtnLogOut_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            lbtnLogOut.Visible = false;
            lbtnLogIn.Visible = true;
            Response.Redirect("~/Index.aspx");
        }
    }
}