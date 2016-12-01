using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aerolinea.Business.Clases;
using Aerolinea.Data;

namespace Aerolinea.GUI.Mantenimientos
{
    public partial class MantPiloto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    var crud = new PilotosCRUD();
                    limpiarForm(crud.Listar());
                }
                catch (Exception ex)
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textoMensajeError.InnerHtml = "Ocurrio un error: " + ex.Message;
                }
            }
        }

        private void limpiarForm(List<Piloto> datos)
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
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var piloto = new Piloto();
                piloto.IdPiloto = (int)ViewState["Id"];
                piloto.Nombre = txtNombre.Text;
                piloto.Apellido = txtApellido.Text;
                piloto.Cedula = txtCedula.Text;
                piloto.Telefono = txtTelefono.Text;
                piloto.Email = txtEmail.Text;
                piloto.Residencia = txtResidencia.Text;

                var crud = new PilotosCRUD();
                crud.Guardar(piloto);
                limpiarForm(crud.Listar());
               
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
                var id = (int)ViewState["Id"];
                var crud = new PilotosCRUD();
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
                var textoAbuscar = txtBuscar.Text;
                var crud = new PilotosCRUD();
                var lista = crud.Buscar(textoAbuscar);
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
                    txtCedula.Text = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[1].Text);
                    txtNombre.Text = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[2].Text);
                    txtApellido.Text = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[3].Text);
                    txtTelefono.Text = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[4].Text);
                    txtEmail.Text = ((HiddenField)gvDatos.SelectedRow.Cells[5].FindControl("Email")).Value;
                    txtResidencia.Text = ((HiddenField)gvDatos.SelectedRow.Cells[6].FindControl("Residencia")).Value;
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