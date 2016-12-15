<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NuevoUsuario.aspx.cs" Inherits="Aerolinea.GUI.Account.NuevoUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 272px;
        }
        .auto-style2 {
            width: 272px;
            height: 17px;
        }
        .auto-style3 {
            height: 17px;
        }
        .auto-style4 {
            width: 333%
        }
        .auto-style5 {
            width: 270px;
        }
        .auto-style6 {
            width: 270px;
            height: 17px;
        }
        .auto-style7 {
            margin-top: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <br />
    <div id="mensaje" runat="server" class="alert alert-success" visible="false">
        <a aria-label="close" class="close" data-dismiss="alert" href="#">×</a> <span id="textoMensaje" runat="server"></span>
    </div>
    <div id="mensajeError" runat="server" class="alert alert-danger" visible="false">
        <a aria-label="close" class="close" data-dismiss="alert" href="#">×</a> <span id="textoMensajeError" runat="server"></span>
    </div>
    <p>
        &nbsp;</p>
    <table class="nav-justified">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="279px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server" Text="Cédula"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Width="279px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label4" runat="server" Text="Teléfono"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox4" runat="server" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <br />
                <table class="auto-style4">
                    <tr>
                        <td class="auto-style5">&nbsp;</td>
                        <td>&nbsp;&nbsp;&nbsp; </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
                        </td>
                        <td class="auto-style3">
                            <asp:TextBox ID="TextBox7" runat="server" Width="178px" CssClass="auto-style7"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="Label7" runat="server" Text="Residencia"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox8" runat="server" Width="174px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="Label8" runat="server" Text="Usuario"></asp:Label>
                        </td>
                        <td>
                <asp:TextBox ID="TextBox6" runat="server" Width="175px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="Label9" runat="server" Text="Contraseña"></asp:Label>
                            <br />
                            <br />
                            <br />
                            <br />
                            <asp:Button ID="Button1" runat="server" Text="Agregar" Height="49px" OnClick="Button1_Click" Width="103px" />
                            <br />
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox9" runat="server" Width="175px"></asp:TextBox>
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>



</asp:Content>
