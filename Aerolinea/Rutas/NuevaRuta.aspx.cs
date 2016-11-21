using Aerolinea.Business;
using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aerolinea.Rutas
{
    public partial class NuevaRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                var ruta = new Ruta();
                ruta.Origen = txtOrigen.Text;
                ruta.Destino = txtDestino.Text;
                ruta.Tarifa = decimal.Parse(txtTarifa.Text);
                if (fileUpload.HasFile)
                {
                    ruta.Imagen = fileUpload.FileBytes;
                }
                var rutas = new RutasRepository();
                rutas.InsertarRuta(ruta);
                mensajeError.Visible = false;
                mensaje.Visible = true;
                textoMensaje.InnerHtml = "Se insertó correctamente";
            }
            catch (Exception ex)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensajeError.InnerHtml = "Ocurrio un error: " + ex.Message;
            }
        }

      

        
    }
}