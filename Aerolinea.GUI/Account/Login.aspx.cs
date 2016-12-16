using Aerolinea.Business;
using Aerolinea.Business.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aerolinea.GUI.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bntIngresar_Click(object sender, EventArgs e)
        {
            userError.Visible = false;
            passwdError.Visible = false;
            loginErrorMsg.Visible = false;

            try
            {
                Session.Remove("LoginCliente");
                var clientes = new ClientesCRUD();
                var cliente = clientes.BuscarCliente(username.Value);
                var agentes = new AgentesCRUD();
                var user = agentes.BuscarAgente(username.Value);
                if (user == null && cliente == null)
                {
                    userError.Visible = true;
                    userError.InnerHtml = "Nombre de Usuario Incorrecto.";
                    return;
                }

                if (user != null)
                {
                    if (user.Contrasena.Equals(password.Value))
                    {
                        user.Contrasena = "";
                        Session.Add("usuario", user);
                        FormsAuthentication.SetAuthCookie(user.Nombre, remember.Checked);
                        Response.Redirect("../Mantenimientos/MantRuta.aspx");
                        return;
                    }
                    else
                    {
                        passwdError.Visible = true;
                        passwdError.InnerHtml = "La contraseña es incorrecta.";
                        return;
                    }
                }

                if (cliente != null)
                {
                    if (cliente.Contrasena.Equals(password.Value))
                    {
                        cliente.Contrasena = "";
                        var loginCliente = Request["LoginCliente"] != null ? Convert.ToBoolean(Request["LoginCliente"]) : false;
                        if (loginCliente)
                        {
                            Session.Add("cliente", cliente);
                            FormsAuthentication.SetAuthCookie(cliente.Nombre, remember.Checked);
                            Response.Redirect("../ConfirmarReserva.aspx");
                        }
                        else
                        {
                            Session.Add("cliente", cliente);
                            FormsAuthentication.SetAuthCookie(cliente.Nombre, remember.Checked);
                            Response.Redirect("../Index.aspx");
                        }
                    }
                    else
                    {
                        passwdError.Visible = true;
                        passwdError.InnerHtml = "La contraseña es incorrecta.";
                        return;
                    }
                }

            }
            catch (Exception ex)
            {
                loginErrorMsg.Visible = true;
                loginErrorMsg.InnerHtml = string.Format("Error Inesperado: {0}", ex.Message);
            }

        }

        public bool validateUser(string userPassword, string passwordToValidate)
        {
            //if (MD5Generator.VerifyMd5Hash(passwordToValidate, userPassword))
            if (passwordToValidate.Equals(userPassword))
                return true;
            return false;
        }




    }
}