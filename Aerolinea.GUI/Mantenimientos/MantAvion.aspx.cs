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
    public partial class MantAvion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    var crud = new AvionesCRUD();
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

        private void limpiarForm(List<Avion> datos)
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
                var avion = new Avion();
                avion.IdAvion = (int)ViewState["Id"];
                avion.Matricula = txtMatricula.Text;
                avion.Marca = txtMarca.Text;
                avion.Modelo = txtModelo.Text;

                var crud = new AvionesCRUD();
                crud.Guardar(avion);
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
                var crud = new AvionesCRUD();
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
                var crud = new AvionesCRUD();
                var lista = crud.Listar().Where(x => x.Matricula.Contains(textoAbuscar) || x.Marca.Contains(textoAbuscar) || x.Modelo.Contains(textoAbuscar)).ToList();
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
                    txtMatricula.Text = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[1].Text);
                    txtMarca.Text = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[2].Text);
                    txtModelo.Text = Page.Server.HtmlDecode(gvDatos.SelectedRow.Cells[3].Text);
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