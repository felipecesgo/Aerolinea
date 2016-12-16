using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Aerolinea.GUI
{
    public class Correos
    {
        SmtpClient server = new SmtpClient("smtp-mail.outlook.com");

        public Correos()
        {
            server.Port = 587;
            server.DeliveryMethod = SmtpDeliveryMethod.Network;
            server.UseDefaultCredentials = false;
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("onepointhd@hotmail.com", "prueba123");
            server.EnableSsl = true;
            server.Credentials = credentials;
        }

        public void MandarCorreo(MailMessage mensaje)
        {
            server.Send(mensaje);
        }
    }
}