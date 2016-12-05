<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EligirVuelo.aspx.cs" Inherits="Aerolinea.GUI.EligirVuelo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/EleccionVuelo.css" rel="stylesheet" />
    <title>Eligir Vuelo</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Label runat="server" ID="lblTitle" Text="Elegir vuelo" CssClass="title"></asp:Label>
    
    <br />
    <span class="depart-return">Salida </span>
    <asp:Label ID="lblOrigen" runat="server" CssClass="city-pair"></asp:Label>
    <br />
    <asp:Label ID="lblFechaSalida" runat="server" CssClass="date-info"></asp:Label>
    <br />
    <div style="margin-top: 20px">
        <asp:ListView ID="lvVuelos" runat="server"
            GroupItemCount="1"
            ItemType="Aerolinea.Data.Vuelo" DataKeyNames="IdVuelo">
            <EmptyDataTemplate>
                <table>
                    <tr>
                        <td> <div class="alert-danger">No Existen vuelos para este día</div> </td>
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
                              <td>
                                  <span class="flight-airport-code"> <%#: Item.Ruta.Origen %></span>
                              </td>
                              <td rowspan="3" style="width: 100px; text-align: center;  "> 
                                  <image src="Images/arrowright.jpg" style="width: 30px; height: 30px;  margin: auto;" />
                              </td>
                               <td><span class="flight-airport-code"> <%#: Item.Ruta.Destino %></span></td>
                                <td style="text-align: center;"><span class="flight-airport-code">Duración</span></td>
                                  <td><span class="flight-airport-code">Tarifa</span></td>
                           </tr>
                           <tr>
                               <td>
                                    <div class="span3 span-phone5">
	                                    <span class="flight-time gamma aa-strong">
		                                    <%#: Item.FechaSalida.ToShortTimeString() %>
	                                    </span>
                                    </div>
                               </td>
                               <td>
                                    <div class="span3 span-phone5">
	                                    <span class="flight-time gamma aa-strong">
		                                    <%#: Item.FechaLlegada.ToShortTimeString() %>
	                                    </span>
                                    </div>
                               </td>
                               <td style="width: 150px; text-align: center;"><span class="flight-airport-code"> <%#:  Item.Duration %></span></td>
                                <td>
                                    <span class="flight-time gamma aa-strong"> 
                                        <%#: Item.Ruta.Tarifa.ToString("$ 0") %>
                                    </span>
                                </td>
                               <td style="width: 200px; text-align: center;">
                                   <div style="margin-left: 20px">
                                       <asp:Button runat="server" CssClass="btn btn-success" ID="btnVueloSalida" Text="Eligir este vuelo" OnClick="btnVueloSalida_Click" />
                                   </div>
                               </td>
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
