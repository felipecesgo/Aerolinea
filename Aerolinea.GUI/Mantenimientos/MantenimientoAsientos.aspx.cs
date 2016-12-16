using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;
using Aerolinea.Business.Interfaces;
using Aerolinea.Business;
using Aerolinea.Business.Clases;
using Aerolinea.Data;
//BIBLIOTECAS PARA QR
using System.Drawing.Imaging;///Agregar biblioteca
using Gma.QrCodeNet.Encoding;///Agregar biblioteca
using Gma.QrCodeNet.Encoding.Windows.Render;///Agregar biblioteca
using System.IO;///Agregar biblioteca
//BIBLIOTECAS PARA CORREOS
using System.Net.Mail;///Agregar biblioteca
using System.Net.Mime;
using Aerolinea.GUI;
using System.Text;
using Aerolinea.GUI.Mantenimientos;

namespace Aerolinea
{
    
    public partial class MantenimientoAsientos : System.Web.UI.Page
    {
        public static IVuelosCRUD vuelos = new VuelosCRUD();
        public static IAvionesCRUD aviones = new AvionesCRUD();
        public static IPilotosCRUD pilotos = new PilotosCRUD();
        public static IRutasCRUD rutas = new RutasCRUD();
        public static IAgentesCRUD agentes = new AgentesCRUD();


        protected void Page_Load(object sender, EventArgs e)
        {
            var VuelosCRUD = new VuelosCRUD();
            var listaVuelos = VuelosCRUD.Listar();
            ddlVuelo.DataSource = listaVuelos.Select(x => x.IdVuelo).ToList();
            ddlVuelo.DataBind();
        }


        public void VerInfo()
        {
            try
            {
                  var vuelo = vuelos.Buscar(Convert.ToInt32(ddlVuelo.Text));

                  txt_idAvion.Text = Convert.ToString(vuelo.IdAvion);
                  txt_origen.Text = vuelo.Ruta.Origen;
                  txt_destino.Text = vuelo.Ruta.Destino;
                  txt_fechaSalida.Text =  Convert.ToString(vuelo.FechaSalida);
                  txt_fechaLlegada.Text = Convert.ToString(vuelo.FechaLlegada);
                  ViewState.Add("vueloID", vuelo.IdVuelo);
              
                  var tiquetes = new TiquetesCRUD();
                  var asientosOcupados = tiquetes.ListarAsientosOcupados(vuelo.IdVuelo);

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
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('Ocurrio un error' + ex);</script>");
            }

          
        }

   
  

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            VerInfo();
        }

        protected void btn_Reservar_Click(object sender, EventArgs e)
        {

            //Aqui se combina se debe llamar los valores CodigoTiquete + Numero Cedula Cliente y concatenarlos
            string codigoConvertir = "Aqui va la concatenacion";
            // 

            //Aqui debe venir el correo del cliente que fue asociado o solicitado
            string correoCliente = "felipe.0692@hotmail.com";
            Bitmap imagen;
       

     
            //ENVIO DE CODIGO QR
            try
            {
                //GENERADOR CODIGO QR

                QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
                QrCode qrCode = new QrCode();
                qrEncoder.TryEncode(codigoConvertir, out qrCode);


                GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                MemoryStream ms = new MemoryStream();

                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Jpeg, ms);
                var imageTemporal = new Bitmap(ms);
                imagen = new Bitmap(imageTemporal, new Size(new Point(200, 200)));


                ////GUARDA EN EL DISCO DURO LA IMAGEN(CARPETA DEL PROYECTO)
                imagen.Save(@"C:\Users\Felipe\Downloads\imagen.jpg", ImageFormat.Jpeg);
                Correos cr = new Correos();
                MailMessage mnsj = new MailMessage();

                mnsj.Subject = "Confirmacion Tiquete VejudiFede®";
                mnsj.To.Add(new MailAddress(correoCliente));
                mnsj.From = new MailAddress("onepointhd@hotmail.com", "Verito");
                //mnsj.Body = textBox3.Text;

                /////////////////////////////////////////////////////////////
                string text = "Hola, necesito hablar con vos ";

                AlternateView plainView =
                    AlternateView.CreateAlternateViewFromString(text,
                                            Encoding.UTF8,
                                            MediaTypeNames.Text.Plain);


                // Esta es la vista para clientes que
                // pueden mostrar contenido HTML...


           

                    string html = "<h2>Estimado Cliente:</h2><br/>" +
                       "Gracias por usar el servicio de Aerolinea VejudiFede®. <br/>" +
                       "Que disfrute su viaje. <br/><br/>" +
                       "<img src='cid:imagen'/>";


                    LinkedResource img =
                   new LinkedResource(@"C:\Users\Felipe\Downloads\imagen.jpg",
                                       MediaTypeNames.Image.Jpeg);

                    AlternateView htmlView =
                 AlternateView.CreateAlternateViewFromString(html,
                                         Encoding.UTF8,
                                         MediaTypeNames.Text.Html);

                    img.ContentId = "imagen";
                    htmlView.LinkedResources.Add(img);

                    // Por último, vinculamos ambas vistas al mensaje...

                    mnsj.AlternateViews.Add(plainView);
                    mnsj.AlternateViews.Add(htmlView);

                    /////////////////////////////////////////////////////////////


                    cr.MandarCorreo(mnsj);
              

             


                //AQUI VA MENSAJE DEL CORREO SALIO EXITOSAMENTE
                Response.Write("<script>window.alert('Envio realizado');</script>");
            }
            catch (Exception ex)
            {
                //AQUI DEBE IR MENSAJE QUE EL MENSAJE NO SE ENVIO
                Response.Write("<script>window.alert('Envio no realizado');</script>");
            }










            //    try
            //    {
            //        var vuelo = carr.Buscar(Convert.ToInt32(dd_Vuelo1.Text));
            //        vuelo.EstadoAsientos = CodigoSalida;
            //        carr.Guardar(vuelo);
            //        VerInfo();

            //        //-----INSERTA INFO EN TABLA RESERVA---------------------------------------
            //        Data.Agente usuarito = user.BuscarAgente(Login.LoginButtonCommandName);

            //        Reserva reserva = new Data.Reserva

            //        {
            //            IdUsuario = usuarito.IdAgente,
            //            IdCarrera = Convert.ToInt32(dd_Vuelo1.Text),
            //            Asiento = numeroAsiento

            //        };
            //        Business.Interfaces.IReserva ireserva = new Business.Clases.ReservaCRUD();
            //        ireserva.InsertarReserva(reserva);
            //        Response.Write("<script>window.alert('Se proceso su reserva');</script>");
            //    }
            //    catch (Exception ex)
            //    {
            //        Response.Write("<script>window.alert('Ocurrio un error');</script>");
            //    }
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

        protected void btnAsiento_Click(object sender, EventArgs e)
        {
           var idVuelo = Convert.ToInt32(ViewState["vueloID"]);

            var tiquetes = new TiquetesCRUD();
            var asientosOcupados = tiquetes.ListarAsientosOcupados(idVuelo);
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

            Button btn = (Button)sender;

            if (btn.BackColor != Color.Red)
            {
                btn.BackColor = Color.Blue;
                int idAsiento = Convert.ToInt32(btn.CommandArgument);
                Session.Add("idAsiento", idAsiento);
            }


        }


    }


}