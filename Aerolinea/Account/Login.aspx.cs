using Aerolinea.Business;
using Aerolinea.Business.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aerolinea.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBox_Authenticate(object sender, AuthenticateEventArgs e)
        {
            try
            {
                var agentes = new AgentesRepository();
                var user = agentes.BuscarAgente(loginBox.UserName);
                if (string.IsNullOrEmpty(user.Nombre))
                {
                    loginBox.FailureText = "No existe ningun usuario registrado con ese email.";
                    return;
                }

                if (validateUser(user.Contrasena, loginBox.Password))
                {
                    user.Contrasena = "";
                    Session.Add("user", user);
                    //UserLogged.Usuario = user;
                    e.Authenticated = true;
                    Response.Redirect("Mantenimientos/MantRuta.aspx");
                }
                else
                {
                    loginBox.FailureText = "La contraseña es incorrecta.";
                    e.Authenticated = false;
                }

            }
            catch (Exception ex)
            {
                loginBox.FailureText = string.Format("Error Inesperado: {0}", ex.Message);
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