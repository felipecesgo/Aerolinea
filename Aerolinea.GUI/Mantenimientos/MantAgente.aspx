<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MantAgente.aspx.cs" Inherits="Aerolinea.GUI.Mantenimientos.MantAgente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
        .auto-style2 {
            margin-left: 80px;
        }
    </style>
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />
    <br />
    
    <br />
    <br />
     <div class="alert alert-success" visible="false" id="mensaje" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <strong id="textoMensaje" runat="server"></strong>
        </div>
        <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <strong id="textoMensajeError" runat="server"></strong>
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />

    <br />

    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" Height="57px" Width="92px" />

    <asp:DropDownList ID="ddl_Agente" runat="server" Height="16px" Width="211px" OnSelectedIndexChanged="ddl_Agente_SelectedIndexChanged"></asp:DropDownList>

    <br />
&nbsp;<br />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <br />

    <br />
    <br />
    <br />
    <asp:GridView ID="gb_Agentes" runat="server" Width="681px">
    </asp:GridView>
    <br />
    <br />
    <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Nombre" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Apellido" runat="server" Text="Apellido"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label6" runat="server" Text="Cedula"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label3" runat="server" Text="Telefono"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label5" runat="server" Text="Residencia"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label7" runat="server" Text="Usuario"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label8" runat="server" Text="Contraseña"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label9" runat="server" Text="Rol"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddl_Rol" runat="server" Height="16px" Width="122px">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />

    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" Height="53px" OnClick="btnAgregar_Click" Width="106px" />

    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Height="47px" Text="Modificar" Width="104px" />
    <asp:Button ID="Button2" runat="server" Height="46px" Text="Eliminar" Width="96px" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />


</asp:Content>
