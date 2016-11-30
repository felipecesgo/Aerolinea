<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EligirVuelo.aspx.cs" Inherits="Aerolinea.GUI.EligirVuelo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/EleccionVuelo.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <span id="title">Elegir vuelo</span>
    <br />
    <span class="depart-return">Salida </span>
    <asp:Label ID="lblOrigen" runat="server" CssClass="city-pair"></asp:Label>
    <br />
    <asp:Label ID="lblFechaSalida" runat="server" CssClass="date-info"></asp:Label>
    <br />
    <div style="margin-top: 20px">
        <asp:ListView ID="lvVuelos" runat="server"
            GroupItemCount="1"
            ItemType="Aerolinea.Business.VueloData" DataKeyNames="IdVuelo">
            <EmptyDataTemplate>
                <table>
                    <tr>
                        <td>No Existen vuelos para este día</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <EmptyItemTemplate>
                <td />
            </EmptyItemTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>
            <ItemTemplate>
                <td id="Td1" runat="server">
                       <table>
                           <tr>
                               <td> <%#: Item.Ruta.Origen %></td>
                                <td></td>
                               <td> <%#: Item.Ruta.Destino %></td>
                              
                           </tr>
                            <tr>
                             </tr>


                       </table>
                </td>
            </ItemTemplate>
            <LayoutTemplate>
                <table style="width: 100%;">
                    <tbody>
                        <tr>
                            <td>
                                <table id="groupPlaceholderContainer" runat="server" style="width: 100%">
                                    <tr id="groupPlaceholder"></tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                        <tr></tr>
                    </tbody>
                </table>
            </LayoutTemplate>
        </asp:ListView>
    </div>

                 

</asp:Content>
