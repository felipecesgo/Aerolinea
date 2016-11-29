using Aerolinea.Business.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aerolinea
{
    public partial class MantenimientoPiloto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Business.Interfaces.IAgente iChofer = new Business.Clases.Agente();
            //List<Data.Agente> lista = iChofer.ListarAgente();
            //ddl_Agente.DataSource = lista.Select(x => x.IdAgente).ToList();
            //ddl_Agente.DataBind();
            ////this.ddl_Piloto.SelectedItem = null;


            //Business.Interfaces.IAgente eChofer = new Business.Clases.Agente();
            //List<Data.Agente> lista2 = eChofer.ListarAgente();
            //ddl_Agente.DataSource = lista2.ToList();
            //ddl_Agente.DataBind();

            //Business.Interfaces.IAgente iChofer2 = new Business.Clases.Agente();
            //List<Data.Agente> lista1 = iChofer2.ListarAgente();
            //ddl_Rol.DataSource = lista.Select(x => x.IdRol).ToList();
            //ddl_Rol.DataBind();
            ////this.ddl_Piloto.SelectedItem = null;


            //Business.Interfaces.IAgente Chofer = new Business.Clases.Agente();
            //List<Data.Agente> listam = Chofer.ListarAgente();
            //ddl_Rol.DataSource = lista2.ToList();
            //ddl_Rol.DataBind();


        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            
                //Business.Interfaces.IAgente iChofer = new Business.Clases.Agente();
                //List<Data.Agente> lista = iChofer.ListarAgente();
                //gb_Agentes.DataSource = lista.Where(X => X.IdAgente == Convert.ToInt32(ddl_Agente.Text)).ToList();
                // gb_Agentes.DataBind();

            
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                Data.Agente agente = new Data.Agente
                {
                    Nombre = TextBox1.Text,
                    Apellido = TextBox2.Text,
                    Telefono = TextBox4.Text,
                    Cedula = TextBox3.Text,
                    Email = TextBox5.Text,
                    Residencia = TextBox6.Text,
                    Usuario = TextBox7.Text,
                    Contrasena = TextBox8.Text
                };
                var agentes = new AgentesRepository();
                agentes.InsertarAgente(agente);
                mensaje.Visible = false;
                mensajeError.Visible = true;
                textoMensajeError.InnerHtml = "Agente creado con exito";


            }

            catch (SqlException)
            {
                Response.Write("<script>window.alert('No se logro agregar un nuevo agente');</script>");

            }
            catch (Exception)
            {
                Response.Write("<script>window.alert('La operacion no se ha logrado realizar');</script>");

            }
        }

        protected void ddl_Agente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}