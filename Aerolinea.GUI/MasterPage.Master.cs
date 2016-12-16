using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aerolinea.GUI
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
                return;
            }

            //var usuarioTest = new Agente() { Nombre = "Felipe", Apellido = "Cespedes", Usuario = "lfcg", Contrasena = "123", IdRol = 1 };
            //Session.Add("usuario", usuarioTest);
            if (Session["cliente"] != null)
            {
                var cliente = (Cliente)Session["cliente"];
                lbtnLogOut.Text = string.Format("{0} {1} (Cerrar Sesión)", cliente.Nombre, cliente.Apellido);
                lbtnLogIn.Visible = false;
                lbtnLogOut.Visible = true;

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
                        Value = "Rutas",
                        Text = "Rutas",
                        NavigateUrl = "~/Mantenimientos/MantRuta.aspx",
                        Selected = currentPage.Contains("MantRuta.aspx")
                    };
                    mnuPrincipal.Items.Add(menuRutas);

                    var menuAgentes = new MenuItem
                    {
                        Value = "Agentes",
                        Text = "Agentes",
                        NavigateUrl = "~/Mantenimientos/MantAgente.aspx",
                        Selected = currentPage.Contains("MantAgente.aspx")
                    };
                    mnuPrincipal.Items.Add(menuAgentes);
                
                    var menuAvion = new MenuItem
                    {
                        Value = "Aviones",
                        Text = "Aviones",
                        NavigateUrl = "~/Mantenimientos/MantAvion.aspx",
                        Selected = currentPage.Contains("MantAvion.aspx")
                    };
                    mnuPrincipal.Items.Add(menuAvion);

                    var menuPiloto = new MenuItem
                    {
                        Value = "Pilotos",
                        Text = "Pilotos",
                        NavigateUrl = "~/Mantenimientos/MantPiloto.aspx",
                        Selected = currentPage.Contains("MantPiloto.aspx")
                    };
                    mnuPrincipal.Items.Add(menuPiloto);

                    var menuVuelo = new MenuItem
                    {
                        Value = "Vuelos",
                        Text = "Vuelos",
                        NavigateUrl = "~/Mantenimientos/MantVuelo.aspx",
                        Selected = currentPage.Contains("MantVuelo.aspx")
                    };
                    mnuPrincipal.Items.Add(menuVuelo);

                    var menuQueja = new MenuItem
                    {
                        Value = "Queja",
                        Text = "Quejas",
                        NavigateUrl = "~/Mantenimientos/Queja.aspx",
                        Selected = currentPage.Contains("Queja.aspx")
                    };
                    mnuPrincipal.Items.Add(menuQueja);

                    var menuAsientos = new MenuItem
                    {
                        Value = "Asientos",
                        Text = "Asientos",
                        NavigateUrl = "~/Mantenimientos/MantenimientoAsientos.aspx",
                        Selected = currentPage.Contains("mantenimientoAsientos.aspx")
                    };

            
                    mnuPrincipal.Items.Add(menuAsientos);
                }
                else if (usuario.IdRol == 2)
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
                        var menuAsientos = new MenuItem
                        {
                            Value = "Asientos",
                            Text = "Asientos",
                            NavigateUrl = "~/Mantenimientos/MantenimientoAsientos.aspx",
                            Selected = currentPage.Contains("mantenimientoAsientos.aspx")
                        };
                        mnuPrincipal.Items.Add(menuAsientos);
                    }
                }
                else if (usuario.IdRol == 3)
                {
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
                            var menuAsientos = new MenuItem
                            {
                                Value = "Asientos",
                                Text = "Asientos",
                                NavigateUrl = "~/Mantenimientos/MantenimientoAsientos.aspx",
                                Selected = currentPage.Contains("mantenimientoAsientos.aspx")
                            };
                            mnuPrincipal.Items.Add(menuAsientos);
                        }
                    }
             
                }
            }

            foreach (MenuItem item in mnuPrincipal.Items)
                item.Selected = item.NavigateUrl.Contains(currentPage);
         
        }

        protected void lbtnLogOut_Click(object sender, EventArgs e)
        {
            Session.Remove("LoginCliente");
            Session.Remove("usuario");
            Session.Remove("cliente");
            lbtnLogOut.Visible = false;
            lbtnLogIn.Visible = true;
            Response.Redirect("~/Index.aspx");
        }
    }
}