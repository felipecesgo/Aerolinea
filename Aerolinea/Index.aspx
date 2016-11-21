<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Aerolinea.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>aerolineas.com</title>
    <link href="Styles/StyleMain.css" rel="stylesheet" />
    <script>
        $(function () {
            $("input[type='radio']").on('click', function (e) {
                var value = $(this).val();
                if (value == "2") {
                    $("#lbRegreso")[0].style.display = 'none';
                    $("#ContentPlaceHolder1_fechaRegreso")[0].style.display = 'none';
                } else {
                    $("#lbRegreso")[0].style.display = 'block';
                    $("#ContentPlaceHolder1_fechaRegreso")[0].style.display = 'block';
                }
                
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color: #efefef; padding: 20px; ">
        <table style="padding: 20px; ">
            <tr>
                <td colspan="4">
                    <asp:RadioButtonList ID="rblTipoViaje" runat="server" RepeatDirection="Horizontal">
                    </asp:RadioButtonList>
                </td>
            </tr>
      
            <tr>
                <td>
                    <label for="ddlOrigen" class="depart">Origen </label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlOrigen" runat="server" class="form-control"></asp:DropDownList>
                </td>
                <td>
                    <label for="ddlDestino" class="return">Destino </label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDestino" runat="server" class="form-control"></asp:DropDownList>
                </td>
                <td>
                    <label for="ddlNumPasajeros" class="label">Número de pasajeros</label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlNumPasajeros" runat="server" class="form-control">
                        <asp:ListItem Selected="True">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
           <tr>
                <td>
                    <label class="salida">Salida</label>
                </td>
                <td>
                    <input id="fechaSalida" type="date" runat="server" class="form-control" />
                </td>

                <td>
                    <label id="lbRegreso" class="regreso">Regreso</label>
                </td>
               <td>
                   <input id="fechaRegreso" type="date" runat="server" class="form-control" />
               </td>
               <td colspan="2" style="text-align: center;  margin: 30px 20px 5px 20px; padding-top: 22px" > 
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar Vuelos" Width="190px" CssClass="btn btn-primary" OnClick="btnBuscar_Click" />
               </td>
            </tr>
         
        </table>
        <br />
    </div>

    
    <div style="margin-top: 20px">
        <asp:ListView ID="lvRutas" runat="server"
            GroupItemCount="2" OnItemCreated="lvRutas_ItemCreated"
            ItemType="Aerolinea.Data.Ruta" DataKeyNames="IdRuta">
            <EmptyDataTemplate>
                <table>
                    <tr>
                        <td>No se encontraron vuelos para la venta.</td>
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
                                <asp:Image ID="imgRuta" runat="server" Height="150px" Width="150px" />
                            </td>
                            <td style="background-color: #e2e2e2; vertical-align: top; padding: 15px 15px 0px 15px;">
                                <table>
                                    <tr>
                                        <td style="font-weight: 600; color: #757575; font-size: 13px; font-family: Regular-Semibold,'Open Sans',sans-serif;">
                                            <%#: Item.Origen %>

                                        </td>

                                    </tr>
                                    <tr>
                                        <td style="color: #0079ca; font-size: 16px; font-weight: bold; margin: 10px 0;">
                                            <%#: Item.Destino %>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td style="font-size: 14px; padding-top: 15px;">Tarifa:
                                        </td>
                                    </tr>

                                    <tr>
                                        <td style="color: #0079ca; font-size: 25px; margin-top: 0px;">$&nbsp;<%#: Convert.ToInt32(Item.Tarifa) %></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: right; font-size: 12px; margin-top: 12px; color: #0079ca;">
                                            <asp:LinkButton ID="lkbtnSearch" runat="server" OnClick="lkbtnSearch_Click" CommandArgument="<%# Item.IdRuta %>"><span style="font-weight: 600">Comprar</span></asp:LinkButton>
                                        </td>
                                    </tr>
                                </table>

                            </td>
                        </tr>

                    </table>
                    </p>
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
