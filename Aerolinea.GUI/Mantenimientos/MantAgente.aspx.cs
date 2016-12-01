using Aerolinea.Business.Clases;
using Aerolinea.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aerolinea.GUI.Mantenimientos
{
    public partial class MantAgente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    var crud = new AgentesCRUD();
                    limpiarForm(crud.ListarAgentes());
                    cargarRoles();
                }
                catch (Exception ex)
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textoMensajeError.InnerHtml = "Ocurrio un error: " + ex.Message;
                }
            }
        }

        private void limpiarForm(List<Agente> datos)
        {

            var allTextBoxes = new List<TextBox>();
            FindTextBoxes(Page, allTextBoxes);
            foreach (var control in allTextBoxes)
            {
                control.Text = "";
            }
            ViewState.Add("Id", -1);
            textoMensajeError.InnerHtml = "";
            textoMensaje.InnerHtml = "";
            gvDatos.DataSource = null;
            gvDatos.DataSource = datos;
            gvDatos.DataBind();
        }

        private void cargarRoles()
        {
            ddlRol.DataSource = null;
            ddlRol.DataValueField = "IdRol";
            ddlRol.DataTextField = "Nombre";
            var crud = new RolesCRUD();
            ddlRol.DataSource = crud.Listar();
            ddlRol.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var agente = new Agente();
                agente.IdAgente = (int)ViewState["Id"];
                agente.Nombre = txtNombre.Text;
                agente.Apellido = txtApellido.Text;
                agente.Cedula = txtCedula.Text;
                agente.IdRol = Convert.ToInt32(ddlRol.SelectedValue);
                agente.Telefono = txtTelefono.Text;
                agente.Email = txtEmail.Text;
                agente.Residencia = txtResidencia.Text;
                agente.Usuario = txtUsuario.Text;
                agente.Contrasena = txtContrasena.Text;

                var crud = new AgentesCRUD();
                crud.GuardarAgente(agente);
                limpiarForm(crud.ListarAgentes());
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
                var crud = new AgentesCRUD();
                crud.EliminarAgente(id);
                limpiarForm(crud.ListarAgentes());
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
                var crud = new AgentesCRUD();
                var lista = crud.ListarAgentes().Where(x => x.Cedula.Contains(textoAbuscar) || x.Nombre.Contains(textoAbuscar) ||
                                                       x.Apellido.Contains(textoAbuscar)).ToList();
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

                    ddlRol.SelectedValue = ((HiddenField)gvDatos.SelectedRow.Cells[1].FindControl("IdRol")).Value;

                    txtCedula.Text = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[2].Text);
                    txtNombre.Text = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[3].Text);
                    txtApellido.Text = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[4].Text);
                    txtTelefono.Text = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[5].Text);

                    txtEmail.Text = ((HiddenField)gvDatos.SelectedRow.Cells[6].FindControl("Email")).Value;

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