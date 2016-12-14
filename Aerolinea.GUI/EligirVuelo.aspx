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

    <div id="vueloSalida" runat="server" visible="false">
        <table>
            <tr>
                <td>
                    <span id="origenSalida" runat="server" class="flight-airport-code"></span>
                </td>
                <td rowspan="3" style="width: 100px; text-align: center;">
                    <image src="Images/arrowright.jpg" style="width: 30px; height: 30px; margin: auto;" />
                </td>
                <td><span id="destinoSalida" runat="server" class="flight-airport-code"></span></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <div class="span3 span-phone5">
                        <span id="horaSalida1" runat="server" class="flight-time gamma aa-strong">
                        </span>
                    </div>
                </td>
                <td>
                    <div class="span3 span-phone5">
                        <span id="horaLlegada1" runat="server" class="flight-time gamma aa-strong">
                        </span>
                    </div>
                </td>
                <td style="text-align: center; padding-left: 30px">
                    <span id="duration" runat="server" class="flight-airport-code"></span>
                </td>
                <td style="width: 150px; text-align: center;">
                    <span  id="escalas" runat="server" class="flight-airport-code"></span>
                </td>
                 <td style="width: 150px; text-align: center;">
                    <span  id="tipoCabina" runat="server" class="flight-airport-code"></span>
                </td>
            </tr>
        </table>
    </div>

    <div id="titulosVuelta" runat="server" visible="false">
        <span class="depart-return">Regreso</span>
        <asp:Label ID="lblDestino" runat="server" CssClass="city-pair"></asp:Label>
        <br />
        <asp:Label ID="lblFechaRegreso" runat="server" CssClass="date-info"></asp:Label>
    </div>

    <div id="vueloRegreso" runat="server" visible="false">
        <table>
            <tr>
                <td>
                    <span id="origenRegreso" runat="server" class="flight-airport-code"></span>
                </td>
                <td rowspan="3" style="width: 100px; text-align: center;">
                    <image src="Images/arrowright.jpg" style="width: 30px; height: 30px; margin: auto;" />
                </td>
                <td><span id="destinoRegreso" runat="server" class="flight-airport-code"></span></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <div class="span3 span-phone5">
                        <span id="horaSalida2" runat="server" class="flight-time gamma aa-strong">
                        </span>
                    </div>
                </td>
                <td>
                    <div class="span3 span-phone5">
                        <span id="horaLlegada2" runat="server" class="flight-time gamma aa-strong">
                        </span>
                    </div>
                </td>
                <td style="text-align: center; padding-left: 30px">
                    <span id="duration2" runat="server" class="flight-airport-code"></span>
                </td>
                <td style="width: 150px; text-align: center;">
                    <span  id="escalas2" runat="server" class="flight-airport-code"></span>
                </td>
                 <td style="width: 150px; text-align: center;">
                    <span  id="tipoCabina2" runat="server" class="flight-airport-code"></span>
                </td>
            </tr>
        </table>
    </div>
      

    <div id="listaVuelos" runat="server" visible="true" style="margin-top: 10px">
        <div style="width: 85%; text-align: right;">
            <label style="width: 150px; text-align: right; margin-bottom: 0px; padding-bottom: 0px; height: 30px">Cabina Principal </label>
            <label style="width: 150px; text-align: right; margin-bottom: 0px; margin-left: 0px; padding-bottom: 0px; height: 30px">Cabina Ejecutiva </label>
            <br />
            <hr style="border: 0px; border-top: 1px solid gray; margin-top: 0px; padding-top: 0px" />
        </div>
        <asp:ListView ID="lvVuelos" runat="server"
            GroupItemCount="1"
            ItemType="Aerolinea.Data.Vuelo" DataKeyNames="IdVuelo">
            <EmptyDataTemplate>
                <table>
                    <tr>
                        <td>
                            <div class="error">No Existen vuelos para ese día</div>
                        </td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <ItemTemplate>
                <table style="width: 85%">
                    <tr>
                        <td>
                            <span class="flight-airport-code"><%#: Item.Ruta.Origen %></span>
                        </td>
                        <td rowspan="3" style="width: 100px; text-align: center;">
                            <image src="Images/arrowright.jpg" style="width: 30px; height: 30px; margin: auto;" />
                        </td>
                        <td><span class="flight-airport-code"><%#: Item.Ruta.Destino %></span></td>
                        <td></td>
                        <td></td>
                        <td rowspan="2" style="width: 150px; text-align: center;">
                            <div style="margin-left: 20px">
                                <asp:LinkButton ID="btnComprarPrincipal" runat="server" CssClass="btn btn-default" OnClick="btnComprarPrincipal_Click" CommandArgument="<%# Item.IdVuelo %>">
                                        <span class="content">
                                            <span class="triptype" style="font-size: 14px; font-weight: 500"><%#: Session["tipo"]  %></span>
                                            <span class="amount">
                                                <span class="price"> <%#: Item.Ruta.Tarifa.ToString("$ 0") %></span>
                                            </span>
                                        </span>
                                </asp:LinkButton>
                            </div>
                        </td>
                        <td rowspan="2" style="width: 150px; text-align: center;">
                            <div style="margin-left: 20px">
                                <asp:LinkButton ID="btnComprarEjecutiva" runat="server" CssClass="btn btn-default" OnClick="btnComprarEjecutiva_Click" CommandArgument="<%# Item.IdVuelo %>">
                                        <span class="content">
                                            <span class="triptype" style="font-size: 14px; font-weight: 500"><%#: Session["tipo"]  %></span>
                                            <span class="amount">
                                                <span class="price"> <%#: Item.Ruta.Tarifa.ToString("$ 0") %></span>
                                            </span>
                                        </span>
                                </asp:LinkButton>
                            </div>
                        </td>
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
                        <td style="text-align: center; padding-left: 30px">
                            <span class="flight-airport-code"><%#: Item.Duration %></span>
                        </td>
                        <td style="width: 150px; text-align: center;">
                            <span class="flight-airport-code"><%#: Item.CantidadEscalas %></span>
                        </td>
                    </tr>
                </table>
                <div style="text-align: left; width: 85%">
                    <hr style="border: 0px; border-top: 1px solid gray;" />
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>

    <asp:Label ID="lblMensajeError" runat="server" Text="" CssClass="error"></asp:Label>

    <div>
        <asp:Button ID="btnEligirAsientos" runat="server" Text="ElegirAsientos"  Visible="false" CssClass="btn btn-primary" />

        <asp:Button ID="btnRegresar" runat="server" Text="Regresar"  Visible="false" PostBackUrl="~/Index.aspx" CssClass="btn btn-default" />
    </div>


</asp:Content>
