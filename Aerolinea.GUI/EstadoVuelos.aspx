<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EstadoVuelos.aspx.cs" Inherits="Aerolinea.GUI.EstadoVuelos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Estado de Vuelo</title>
    <link href="Styles/style_main2.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin-left: 20px">
        <asp:Label runat="server" ID="lblTitle" Text="Estado de Vuelo" CssClass="title"></asp:Label>
    </div>


    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span
            id="textoMensajeError" runat="server"></span>
    </div>
    
    <table>
        <tr>
            <td  class="labelform" style="margin-left: 20px">
                           Número Vuelo
            </td>
        </tr>
        <tr>
            <td>
                  <div class="form-inline">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="error" ControlToValidate="txtBuscar" Text="*" ValidationGroup="search"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" Width="250px" placeholder="numero" ValidationGroup="search"></asp:TextBox>&nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-info" Text="Buscar" OnClick="lbtnBuscar_Click" ValidationGroup="search"><span class="glyphicon glyphicon-search" ></span>&nbsp;Buscar</asp:LinkButton>
            </div>
            </td>
        </tr>
    </table>

 


    <div class="form-group" >
             <hr style="border: 0px; border-top: 1px solid gray;" />
                <table id="detalleRegreso" runat="server" visible="false"  cellpadding="5" style="font-size: 14px; color:black; margin-left: 15px; margin-top: 25px;">
                   
                    <tr style="width: 100%; font-weight: bold">
                        <td colspan="3">Información del vuelo</td>
                    </tr>

                     <tr >
                        <td>Nro. de Vuelo: </td>
                        <td >
                            <asp:Label ID="lblNroVueloRegreso" runat="server"></asp:Label></td>
                      
                    </tr>


                    <tr >
                        <td >Origen: </td>
                        <td >
                            <asp:Label ID="lblOrigenRegreso" runat="server"></asp:Label></td>
                        <td ></td>
                    </tr>

                    <tr >
                        <td >Destino: </td>
                        <td >
                            <asp:Label ID="lblDestinoRegreso" runat="server"></asp:Label></td>
                        <td ></td>
                    </tr>

                    <tr >
                        <td >Salida: </td>
                        <td style="width: 150px">
                            <asp:Label ID="lblSalidaRegreso" runat="server"></asp:Label></td>
                        <td ></td>
                    </tr>

                    <tr >
                        <td >Llegada: </td>
                        <td style="width: 150px">
                            <asp:Label ID="lblLlegada" runat="server"></asp:Label></td>
                        <td ></td>
                    </tr>

                    <tr >
                        <td >Duracion: </td>
                        <td >
                            <asp:Label ID="lblDuracionRegreso" runat="server"></asp:Label></td>
                        <td ></td>
                    </tr>

                     <tr >
                        <td >Avion: </td>
                        <td >
                            <asp:Label ID="lblAvionRegreso" runat="server"></asp:Label></td>
                        <td ></td>
                    </tr>

                 
                    
                     <tr  style="width: 100%; font-weight: bold">
                        <td >Estado: </td>
                        <td >
                            <asp:Label ID="lblEstadoVuelo" runat="server"></asp:Label></td>
                        <td ></td>
                    </tr>
                     
               

              
                   
                </table>
    </div>
</asp:Content>
