<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NuevoUsuario.aspx.cs" Inherits="Aerolinea.GUI.Account.NuevoUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="dataTable" cellpadding="5" style="width: 40%">
        <tr>
            <td>
                <span id="title">Registro de Clientes</span>
                <br />
                <div>
                    <div style="margin-top: 15px">
                        <asp:Label  runat="server" Text="Cedula: " CssClass="labelform"></asp:Label>
                        <asp:TextBox ID="txtCedula" runat="server" class="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="error" ControlToValidate="txtCedula" Text="*Ingrese la Cedula." ValidationGroup="formData"></asp:RequiredFieldValidator>
                    </div>

                    <div>
                        <asp:Label ID="Label2" runat="server" Text="Nombre: " CssClass="labelform"></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="error" ControlToValidate="txtNombre" Text="*Ingrese el Nombre." ValidationGroup="formData"></asp:RequiredFieldValidator>
                    </div>

                    <div>
                        <asp:Label ID="Label3" runat="server" Text="Apellido: " CssClass="labelform"></asp:Label>
                        <asp:TextBox ID="txtApellido" runat="server" class="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" CssClass="error" ControlToValidate="txtApellido" Text="*Ingrese el Apellido." ValidationGroup="formData"></asp:RequiredFieldValidator>
                    </div>

                    <div>
                        <asp:Label ID="Label4" runat="server" Text="Telefono: " CssClass="labelform"></asp:Label>
                        <asp:TextBox ID="txtTelefono" runat="server" class="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" CssClass="error" ControlToValidate="txtTelefono" Text="*Ingrese el Telefono." ValidationGroup="formData"></asp:RequiredFieldValidator>
                    </div>

                    <div>
                        <asp:Label ID="Label5" runat="server" Text="Email: " CssClass="labelform"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
                    </div>

                    <div style="margin-top: 15px">
                        <asp:Label ID="Label6" runat="server" Text="Residencia: " CssClass="labelform"></asp:Label>
                        <asp:TextBox ID="txtResidencia" runat="server" class="form-control"></asp:TextBox>
                    </div>
                     <div style="margin-top: 15px">
                    <asp:Label runat="server" Text="Usuario: " CssClass="labelform"></asp:Label>
                    <asp:TextBox ID="txtUsuario" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" CssClass="error" ControlToValidate="txtUsuario" Text="*Ingrese el Usuario." ValidationGroup="formData"></asp:RequiredFieldValidator>
                </div>
                 
                <div>
                    <asp:Label runat="server" Text="Contraseña: " CssClass="labelform"></asp:Label>
                    <asp:TextBox ID="txtContrasena" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvContrasena" runat="server" CssClass="error" ControlToValidate="txtContrasena" Text="*Ingrese la Contraseña." ValidationGroup="formData"></asp:RequiredFieldValidator>
                </div>
             
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrarme" CssClass="btn btn-primary" OnClick="btnRegistrar_Click" ValidationGroup="formData" />
                </div>
                <br />
                <div class="alert alert-success" visible="false" id="mensaje" runat="server">
                    <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span
                        id="textoMensaje" runat="server"></span>
                </div>
                <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
                    <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span
                        id="textoMensajeError" runat="server"></span>
                </div>
            </td>

        </tr>
    </table>
</asp:Content>
