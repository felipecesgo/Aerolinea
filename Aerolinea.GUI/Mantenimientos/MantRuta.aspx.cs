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
            try
            {
                limpiarForm();
            }
            catch (Exception ex)
            {
               mensaje.Visible = false;
               mensajeError.Visible = true;
               textoMensajeError.InnerHtml = "Ocurrio un error: " + ex.Message;
           }
        }

        private void limpiarForm()
        {
            txtOrigen.Text = "";
            txtDestino.Text = "";
            txtTarifa.Text = "";
            textoMensajeError.InnerHtml = "";
            textoMensaje.InnerHtml = "";
            var rutas = new RutasRepository();
            gvRutas.DataSource = rutas.ListarRutas();
            gvRutas.DataBind();
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
                limpiarForm();
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

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var rutaSelected = (Ruta) gvRutas.SelectedValue;

                var ruta = new Ruta();
                ruta.IdRuta = 1;
                ruta.Origen = txtOrigen.Text;
                ruta.Destino = txtDestino.Text;
                ruta.Tarifa = decimal.Parse(txtTarifa.Text);
                if (fileUpload.HasFile)
                {
                    ruta.Imagen = fileUpload.FileBytes;
                }
                var rutas = new RutasRepository();
                rutas.ActualizarRuta(ruta);
                limpiarForm();
                mensajeError.Visible = false;
                mensaje.Visible = true;
                textoMensaje.InnerHtml = "Se actualizó correctamente";
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
                var rutaSelected = (Ruta) gvRutas.SelectedValue;
                var rutas = new RutasRepository();
                rutas.EliminarRuta(rutaSelected.IdRuta);
                limpiarForm();
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


        protected void gvRutas_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (GridViewRow row in gvRutas.Rows)
            {
                if (row.RowIndex == gvRutas.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to select this row.";
                }
            }
        }


        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
               
                var textoAbuscar = txtBuscar.Text;

                var rutas = new RutasRepository();
                var listaVuelos = rutas.ListarRutas().Where(x => x.Origen.Contains(textoAbuscar) || x.Destino.Contains(textoAbuscar));

                mensajeError.Visible = false;
                mensaje.Visible = false;
                txtOrigen.Text = "";
                txtDestino.Text = "";
                txtTarifa.Text = "";
                textoMensajeError.InnerHtml = "";
                textoMensaje.InnerHtml = "";

                gvRutas.DataSource = listaVuelos;
                gvRutas.DataBind();
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