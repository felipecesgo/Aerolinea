using Aerolinea.Business.Clases;
using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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
                }
               
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                var tipo = Session["tipo"] != null ? Session["tipo"].ToString() : "";

                var vueloSalida = Session["VueloSalida"] != null ? (Vuelo)Session["VueloSalida"] : null;

                var asientos =  Session["asientosSalida"] != null ? Session["asientosSalida"].ToString() : null;
              
                var listaAsientos = asientos.Split(',');

                var cliente = (Cliente)Session["cliente"];

                 var crudTiquetes = new TiquetesCRUD();

                foreach(var asiento in listaAsientos)
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
                          pago.FormaPago = "Tarjeta";
                         
                      
                      }
                   
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
    }
}