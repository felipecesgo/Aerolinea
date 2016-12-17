using Aerolinea.Business.Clases;
using Aerolinea.Data;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aerolinea.GUI
{
    public partial class ConfirmarReserva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["cliente"] != null)
                {
                    var cliente = (Cliente)Session["cliente"];
                    txtFirstName.Text = cliente.Nombre;
                    txtLastName.Text = cliente.Apellido;
                    txtPhoneNumber.Text = cliente.Telefono;
                    txtResidencia.Text = cliente.Residencia;
                    txtEmail.Text = cliente.Email;

                    var vueloSalida = Session["VueloSalida"] != null ? (Vuelo)Session["VueloSalida"] : null;
            
                    var cabina = Session["Cabina"] != null ? Session["Cabina"].ToString() : "";
                    var tarifa = cabina == "Cabina Ejecutiva" ? vueloSalida.Ruta.TarifaEjecutiva : vueloSalida.Ruta.Tarifa;
                    var listaAsientos = Session["asientosSalida"] != null ? Session["asientosSalida"].ToString() : "";
                    var pasajeros = Session["pasajeros"] != null ? Convert.ToInt32(Session["pasajeros"]) : 0;

                    lblVueloSalidaTitulo.Text = string.Format("Vuelo de {0} a {1}", vueloSalida.Ruta.Origen, vueloSalida.Ruta.Destino);
                    lblVueloSalida.Text = vueloSalida.IdVuelo.ToString();

                    lblClaseVueloSalida.Text = cabina;

                    lblAsientoVueloSalida.Text = listaAsientos;
                    lblPasajerosVueloSalida.Text = pasajeros.ToString();

                    lblTarifaVueloSalida.Text = string.Format("{0:0.0}",tarifa);

                    lblSubtotalVueloSalida.Text = string.Format("{0:0.0}", pasajeros * tarifa);
                    var total = pasajeros * tarifa;

                    if (Session["VueloRegreso"] != null)
                    {
                        var vueloRegreso = Session["VueloRegreso"] != null ? (Vuelo)Session["VueloRegreso"] : null;
                        var cabinaRegreso = Session["CabinaRegreso"] != null ? Session["CabinaRegreso"].ToString() : "";
                        var tarifaRegreso = cabinaRegreso == "Cabina Ejecutiva" ? vueloRegreso.Ruta.TarifaEjecutiva : vueloRegreso.Ruta.Tarifa;
                        var listaAsientosRegreso = Session["asientosRegreso"] != null ? Session["asientosRegreso"].ToString() : "";

                        lblVueloRegresoTitulo.Text = string.Format("Vuelo de {0} a {1}", vueloRegreso.Ruta.Origen, vueloRegreso.Ruta.Destino);
                        lblVueloRegreso.Text = vueloRegreso.IdVuelo.ToString();

                        lblClaseVueloRegreso.Text = cabinaRegreso;

                        lblAsientoVueloRegreso.Text = listaAsientosRegreso;
                        lblPasajeroVueloRegreso.Text = pasajeros.ToString();

                        lblTarifaVueloRegreso.Text = string.Format("{0:0.0}", tarifaRegreso);

                        lblSubtotalVueloRegreso.Text = string.Format("{0:0.0}", pasajeros * tarifaRegreso);

                        detalleVueloRegreso.Visible = true;
                        total += pasajeros * tarifaRegreso;
                    }

                    lblTotal.Text = string.Format("{0:0.0}", total);

                }
               
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                var vueloSalida = Session["VueloSalida"] != null ? (Vuelo)Session["VueloSalida"] : null;
            
                var cabina = Session["Cabina"] != null ? Session["Cabina"].ToString() : "";
                var tarifa = cabina == "Cabina Ejecutiva" ? vueloSalida.Ruta.TarifaEjecutiva : vueloSalida.Ruta.Tarifa;
                var listaAsientos = Session["asientosSalida"] != null ? Session["asientosSalida"].ToString().Split(',') : new string[0];
                guardarPagoTiquetes(vueloSalida, tarifa, listaAsientos, true);

                if (Session["VueloRegreso"] != null)
                {
                    var vueloRegreso = Session["VueloRegreso"] != null ? (Vuelo)Session["VueloRegreso"] : null;
                    var cabinaRegreso = Session["CabinaRegreso"] != null ? Session["CabinaRegreso"].ToString() : "";
                    var tarifaRegreso = cabinaRegreso == "Cabina Ejecutiva" ? vueloRegreso.Ruta.TarifaEjecutiva : vueloRegreso.Ruta.Tarifa;
                    var listaAsientosRegreso = Session["asientosRegreso"] != null ? Session["asientosRegreso"].ToString().Split(',') : new string[0];
                    guardarPagoTiquetes(vueloRegreso, tarifaRegreso, listaAsientosRegreso, false);
                }
              
                mensaje.Visible = true;
                mensajeError.Visible = false;
               
            }
            catch (Exception ex)
            {
                mensajeError.Visible = true;
                textoMensajeError.InnerHtml = "Ocurrio un error. " + ex.Message;
            }
        }

        private void enviarCorreo(string correoCliente, int IdTiquete, string cedulaCliente)
        {
            try
            {
                string codigoConvertir = string.Format("{0}+{1}", IdTiquete, cedulaCliente);

                QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
                QrCode qrCode = new QrCode();
                qrEncoder.TryEncode(codigoConvertir, out qrCode);

                GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                MemoryStream ms = new MemoryStream();

                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Jpeg, ms);
                var imageTemporal = new Bitmap(ms);
                var imagen = new Bitmap(imageTemporal, new Size(new Point(200, 200)));

                var archivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), "imagen.jpg");
                imagen.Save(archivo, ImageFormat.Jpeg);
                Correos cr = new Correos();
                MailMessage mnsj = new MailMessage();

                mnsj.Subject = "Confirmacion de compra de tiquete en aerolineas.com®";
                mnsj.To.Add(new MailAddress(correoCliente));
                mnsj.From = new MailAddress("onepointhd@hotmail.com", "Verito");


                string html = "<h2>Estimado Cliente:</h2><br/>" +
                   "Gracias por usar el servicio de Aerolinea VejudiFede®. <br/>" +
                   "Que disfrute su viaje. <br/><br/>" +
                   "<img src='cid:imagen'/>";


                LinkedResource img = new LinkedResource(archivo, MediaTypeNames.Image.Jpeg);

                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(html,
                                     Encoding.UTF8,
                                     MediaTypeNames.Text.Html);

                img.ContentId = "imagen";
                htmlView.LinkedResources.Add(img);


                mnsj.AlternateViews.Add(htmlView);

                cr.MandarCorreo(mnsj);
            }
            catch (Exception ex)
            { }
        }

        private void guardarPagoTiquetes(Vuelo vueloSalida, decimal tarifa, string[] listaAsientos, bool enviar)
        {
            var cliente = (Cliente)Session["cliente"];
            var crudTiquetes = new TiquetesCRUD();
            var crudPagos = new PagosCRUD();
         
            foreach (var asiento in listaAsientos)
            {
                var tiquete = new Tiquete();
                tiquete.IdCliente = cliente.IdCliente;
                tiquete.IdVuelo = vueloSalida.IdVuelo;
                tiquete.NumeroDeAsiento = int.Parse(asiento);
                crudTiquetes.Guardar(tiquete);
              

                var last_tiquete = crudTiquetes.Listar().LastOrDefault();
                if (last_tiquete != null)
                {
                    var pago = new Pago();
                    pago.IdTiquete = last_tiquete.IdTiquete;
                    pago.FormaPago = ddlCardPayment.SelectedValue;
                    pago.Monto = tarifa;
                    crudPagos.Guardar(pago);

                    if(enviar)
                    {
                        enviarCorreo(cliente.Email, last_tiquete.IdTiquete, cliente.Cedula);
                        enviar = false;
                    }
                }
            }
        }
    }
}