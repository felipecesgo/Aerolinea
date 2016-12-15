using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aerolinea.Data;
using Aerolinea.Business.Clases;


namespace Aerolinea.GUI.Account
{
    public partial class NuevoUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    var crud = new ClientesCRUD();
                    limpiarForm(crud.ListarCliente());
                }
                catch (Exception ex)
                {
                    mensaje.Visible = false;
                    mensajeError.Visible = true;
                    textoMensajeError.InnerHtml = "Ocurrio un error: " + ex.Message;
                }
            }
        }

        private void limpiarForm(List<Cliente> datos)
        {
            var allTextBoxes = new List<TextBox>();
           //FindTextBoxes(Page, allTextBoxes);
            foreach (var control in allTextBoxes)
                control.Text = "";
            ViewState.Add("Id", -1);
            textoMensajeError.InnerHtml = "";
            textoMensaje.InnerHtml = "";
        }
    
    protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var piloto = new Cliente();
                piloto.IdCliente = (int)ViewState["Id"];
                piloto.Nombre = TextBox1.Text;
                piloto.Apellido = TextBox2.Text;
                piloto.Cedula = TextBox3.Text;
                piloto.Telefono = TextBox4.Text;
                piloto.Email = TextBox7.Text;
                piloto.Residencia = TextBox8.Text;
                piloto.Usuario = TextBox6.Text;
                piloto.Contrasena = TextBox9.Text;

                var crud = new ClientesCRUD();
                crud.GuardarCliente(piloto);
                limpiarForm(crud.ListarCliente());

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

    }

}