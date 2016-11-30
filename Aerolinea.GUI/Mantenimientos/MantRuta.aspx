<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="MantRuta.aspx.cs" Inherits="Aerolinea.GUI.Mantenimientos.Rutas.MantRuta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <span id="title">Rutas</span>
    <br />

    <div style="float: right" class="form-group">
         <div class="form-inline">
            <asp:Label runat="server" Text="Buscar: "></asp:Label>
            <asp:TextBox ID="txtBuscar" runat="server" class="form-control" Width="200"></asp:TextBox>
            <asp:ImageButton ID="btnBuscar" runat="server" ValidationGroup="search" Width="20" Height="20" CssClass="btnSearch"  ImageUrl="~/Images/search.png" OnClick="btnBuscar_Click" />
        </div>
         <asp:RequiredFieldValidator ID="rfvBuscar" runat="server" CssClass="error" ControlToValidate="txtOrigen" Text="*" ValidationGroup="search"></asp:RequiredFieldValidator>
    </div>


    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span
            id="textoMensaje" runat="server"></span>
    </div>
    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span
            id="textoMensajeError" runat="server"></span>
    </div>

    <div style="width: 40%;">
        <div class="form-group">
            <asp:Label ID="lbOrigen" runat="server" Text="Origen: "></asp:Label>
            <asp:TextBox ID="txtOrigen" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvOrigen" runat="server" CssClass="error" ControlToValidate="txtOrigen" Text="*Ingrese el Origen." ValidationGroup="rutaData"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="lbDestino" runat="server" Text="Destino: "></asp:Label>
            <asp:TextBox ID="txtDestino" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDestino" runat="server" CssClass="error" ControlToValidate="txtDestino" Text="*Ingrese el Destino." ValidationGroup="rutaData"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="lbTarifa" runat="server" Text="Tarifa: "></asp:Label>
            <asp:TextBox ID="txtTarifa" runat="server" class="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfvTarifa" runat="server" CssClass="error" ControlToValidate="txtTarifa" Text="*Ingrese la Tarifa." ValidationGroup="rutaData"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="lbImagen" runat="server" Text="Imagen: "></asp:Label>
            <asp:FileUpload ID="fileUpload" runat="server" />
        </div>
        <br />

        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" CssClass="btn btn-success" OnClick="btnInsertar_Click" ValidationGroup="rutaData" />
        <asp:Button ID="btnEditar" runat="server" Text="Actualizar" CssClass="btn btn-primary" OnClick="btnActualizar_Click" ValidationGroup="rutaData" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" ValidationGroup="rutaData" />

        <br />    <br />
        <asp:GridView ID="gvRutas" ItemType="Aerolinea.Data.Ruta" DataKeyNames="IdRuta" CssClass="table table-bordered" runat="server" OnSelectedIndexChanged="gvRutas_OnSelectedIndexChanged">
        </asp:GridView>
    </div>
    


 

</asp:Content>
