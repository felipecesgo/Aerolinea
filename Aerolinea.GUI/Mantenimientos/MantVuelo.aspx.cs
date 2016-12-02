using Aerolinea.Business;
using Aerolinea.Business.Clases;
using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aerolinea.GUI.Mantenimientos
{
    public partial class MantVuelo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    var crud = new VuelosCRUD();
                    limpiarForm(crud.Listar());
                    cargarRutas();
                    cargarAsientos();
                    cargarEstados();
                    cargarAviones();
                    cargarPilotos();

                }
                catch (Exception ex)
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textoMensajeError.InnerHtml = "Ocurrio un error: " + ex.Message;
                }
            }
        }

        private void limpiarForm(List<Vuelo> datos)
        {
            var allTextBoxes = new List<TextBox>();
            FindTextBoxes(Page, allTextBoxes);
            foreach (var control in allTextBoxes)
                control.Text = "";
            ViewState.Add("Id", -1);
            textoMensajeError.InnerHtml = "";
            textoMensaje.InnerHtml = "";
            gvDatos.DataSource = null;
            gvDatos.DataSource = datos;
            gvDatos.DataBind();
            ddlEstadoVuelo.SelectedIndex = 0;
            ddlOrigen.SelectedIndex = 0;
            ddlDestino.SelectedIndex = 0;
            ddlPiloto.SelectedIndex = 0;
            ddlAvion.SelectedIndex = 0;
            ddlCapacidadAsientos.SelectedValue = "100";
        }

        private void cargarRutas()
        {
            var crud = new RutasCRUD();

            ddlDestino.DataSource = null;
            ddlDestino.DataValueField = "IdRuta";
            ddlDestino.DataTextField = "Destino";
            ddlDestino.DataSource = crud.ListarRutas();
            ddlDestino.DataBind();

            ddlOrigen.DataSource = null;
            ddlOrigen.DataValueField = "IdRuta";
            ddlOrigen.DataTextField = "Origen";
            ddlOrigen.DataSource = crud.ListarRutas();
            ddlOrigen.DataBind();
        }


        private void cargarAviones()
        {
            var crud = new AvionesCRUD();
            ddlAvion.DataSource = null;
            ddlAvion.DataValueField = "IdAvion";
            ddlAvion.DataTextField = "Nombre";
            ddlAvion.DataSource = crud.Listar();
            ddlAvion.DataBind();
            ddlAvion.SelectedIndex = 0;
        }

        private void cargarEstados()
        {
            ddlEstadoVuelo.Items.Clear();
            ddlEstadoVuelo.Items.Add("En Horario");
            ddlEstadoVuelo.Items.Add("Cancelado");
            ddlEstadoVuelo.Items.Add("Embarcando");
            ddlEstadoVuelo.Items.Add("Despegado");
            ddlEstadoVuelo.Items.Add("Aterrizado");
            ddlEstadoVuelo.SelectedIndex = 0;
        }

        private void cargarPilotos()
        {
            var crud = new PilotosCRUD();
            ddlPiloto.DataSource = null;
            ddlPiloto.DataValueField = "IdPiloto";
            ddlPiloto.DataTextField = "NombreCompleto";
            ddlPiloto.DataSource = crud.Listar();
            ddlPiloto.DataBind();
        }

        private void cargarAsientos()
        {
            ddlCapacidadAsientos.Items.Clear();
            for (int i = 5; i <= 100; i += 5)
              ddlCapacidadAsientos.Items.Add(i.ToString());
            ddlCapacidadAsientos.SelectedIndex = 0;
        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var crud = new RutasCRUD();
                var ruta = crud.BuscarRutaOrigenYDestino(ddlOrigen.SelectedItem.Text, ddlDestino.SelectedItem.Text);

                if (ruta != null)
                {
                    var vuelo = new Vuelo();
                    vuelo.IdVuelo = (int)ViewState["Id"];

                    vuelo.IdRuta = ruta.IdRuta;

                    vuelo.IdAvion = Convert.ToInt32(ddlAvion.SelectedValue);
                    vuelo.IdPiloto = Convert.ToInt32(ddlPiloto.SelectedValue);

                    var fechaSalida = string.Format("{0} {1}", hdnfechaSalida.Value, txtHoraSalida.Text);
                    vuelo.FechaSalida = Convert.ToDateTime(fechaSalida);
                    
                    var fechaLlegada = string.Format("{0} {1}", hdnfechaSalida.Value, txtHoraSalida.Text);
                    vuelo.FechaLlegada = Convert.ToDateTime(fechaLlegada);

                    vuelo.EstadoVuelo = ddlEstadoVuelo.SelectedItem.Text;
                    vuelo.CapacidadAsientos = Convert.ToInt32(ddlCapacidadAsientos.SelectedValue);
                    
                    var crudvuelos = new VuelosCRUD();
                    crudvuelos.Guardar(vuelo);
                    limpiarForm(crudvuelos.Listar());

                    mensajeError.Visible = false;
                    mensaje.Visible = true;
                    textoMensaje.InnerHtml = "Se ha guardado correctamente";
                }
                else
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textoMensajeError.InnerHtml = "no se encontro ninguna ruta con ese origen y destino.";
                }
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
                var id = (int)ViewState["Id"];
                var crud = new VuelosCRUD();
                crud.Eliminar(id);
                limpiarForm(crud.Listar());
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
                var crud = new VuelosCRUD();
                var lista = crud.Buscar(txtBuscar.Text);
                limpiarForm(lista);
            }
            catch (Exception ex)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensajeError.InnerHtml = "Ocurrio un error: " + ex.Message;
            }
        }

        protected void gvDatos_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (gvDatos.SelectedIndex > -1)
                {
                    ViewState["Id"] = Convert.ToInt32(gvDatos.SelectedDataKey.Value);
                    ddlOrigen.SelectedItem.Text = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[3].Text);
                    ddlDestino.SelectedItem.Text = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[4].Text);
                    var fechaSalida = Convert.ToDateTime(Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[5].Text));
                    var hora = fechaSalida.ToShortTimeString();
                    txtHoraSalida.Text = hora;
                    hdnfechaSalida.Value = fechaSalida.ToShortDateString();
                    var fechallegada = Convert.ToDateTime(Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[6].Text));
                    ddlEstadoVuelo.SelectedItem.Text = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[7].Text);
                    ddlCapacidadAsientos.SelectedValue = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[8].Text);
                    ddlAvion.SelectedValue = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[9].Text);
                    ddlPiloto.SelectedValue = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[10].Text);
                }
            }
            catch (Exception ex)
            {
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensajeError.InnerHtml = "Ocurrio un error: " + ex.Message;
            }
        }

        private void FindTextBoxes(Control Parent, List<TextBox> ListOfTextBoxes)
        {
            foreach (Control c in Parent.Controls)
            {
                if (c.HasControls())
                {
                    FindTextBoxes(c, ListOfTextBoxes);
                }
                else
                {
                    if (c is TextBox)
                    {
                        ListOfTextBoxes.Add(c as TextBox);
                    }
                }
            }
        }
    
    }
}