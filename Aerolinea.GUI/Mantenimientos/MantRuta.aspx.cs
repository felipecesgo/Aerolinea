using Aerolinea.Business;
using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Aerolinea.GUI.Mantenimientos.Rutas
{
    public partial class MantRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    var rutas = new RutasRepository();
                    limpiarForm(rutas.ListarRutas());
                }
                catch (Exception ex)
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textoMensajeError.InnerHtml = "Ocurrio un error: " + ex.Message;
                }
            }
        }

        private void limpiarForm(List<Ruta> rutas)
        {
            txtOrigen.Text = "";
            txtDestino.Text = "";
            txtTarifa.Text = "";
            ViewState.Add("IdRuta", -1);
            textoMensajeError.InnerHtml = "";
            textoMensaje.InnerHtml = "";
            gvRutas.DataSource = null;
            gvRutas.DataSource = rutas;
            gvRutas.DataBind();
        }

  
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var ruta = new Ruta();
                ruta.IdRuta = (int)ViewState["IdRuta"];
                ruta.Origen = txtOrigen.Text;
                ruta.Destino = txtDestino.Text;
                ruta.Tarifa = decimal.Parse(txtTarifa.Text);
                var rutas = new RutasRepository();
                if (fileUpload.HasFile)
                {
                    ruta.Imagen = fileUpload.FileBytes;
                }
                else
                {
                    var rutaAnt = rutas.BuscarRuta(ruta.IdRuta);
                    if (rutaAnt != null)
                        ruta.Imagen = rutaAnt.Imagen;
                }
          
                rutas.GuardarRuta(ruta);
                limpiarForm(rutas.ListarRutas());
                mensajeError.Visible = false;
                mensaje.Visible = true;
                textoMensaje.InnerHtml = "Se ha guardado correctamente";
            }
            catch (Exception ex)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensajeError.InnerHtml = "Ocurrio un error: " + ex.Message;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var idRuta = (int)ViewState["IdRuta"];
                var rutas = new RutasRepository();
                rutas.EliminarRuta(idRuta);
                limpiarForm(rutas.ListarRutas());
                mensajeError.Visible = false;
                mensaje.Visible = true;
                textoMensaje.InnerHtml = "Se eliminó correctamente";
            }
            catch (Exception ex)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensajeError.InnerHtml = "Ocurrio un error: " + ex.Message;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var textoAbuscar = txtBuscar.Text;
                var rutas = new RutasRepository();
                var listaVuelos = rutas.ListarRutas().Where(x => x.Origen.Contains(textoAbuscar) || x.Destino.Contains(textoAbuscar)).ToList();
                limpiarForm(listaVuelos);
            }
            catch (Exception ex)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensajeError.InnerHtml = "Ocurrio un error: " + ex.Message;
            }
        }

        protected void gvRutas_OnSelectedIndexChanged(object sender, EventArgs e)
        {
           try
           {
               if (gvRutas.SelectedIndex > -1)
               {
                   ViewState["IdRuta"] = Convert.ToInt32(gvRutas.SelectedDataKey.Value);
                   txtOrigen.Text = Page.Server.HtmlDecode(gvRutas.SelectedRow.Cells[1].Text);
                   txtDestino.Text = Page.Server.HtmlDecode(gvRutas.SelectedRow.Cells[2].Text);
                   txtTarifa.Text = Page.Server.HtmlDecode(gvRutas.SelectedRow.Cells[3].Text.Replace("$", ""));

               }
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