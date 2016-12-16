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
                limpiarForm();
            }
        }

        private void limpiarForm()
        {
            var allTextBoxes = new List<TextBox>();
            FindTextBoxes(Page, allTextBoxes);
            foreach (var control in allTextBoxes)
                control.Text = "";
            ViewState.Add("Id", -1);
            textoMensajeError.InnerHtml = "";
            textoMensaje.InnerHtml = "";
        }


    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        try
        {
            var cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Cedula = txtCedula.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Email = txtEmail.Text;
            cliente.Residencia = txtResidencia.Text;
            cliente.Usuario = txtUsuario.Text;
            cliente.Contrasena = txtContrasena.Text;

            var crud = new ClientesCRUD();
            crud.GuardarCliente(cliente);
            limpiarForm();

            mensajeError.Visible = false;
            mensaje.Visible = true;
            textoMensaje.InnerHtml = "Se ha registrado correctamente.";
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