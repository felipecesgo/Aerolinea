﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Aerolinea.GUI.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>aerolineas.com</title>

    <script type="text/javascript">

        $(document).ready(function () {

            $("input[type='radio']").on('click', function (e) {
                var value = $(this).val();
                if (value == "Solo ida") {
                    $("#lbRegreso")[0].style.display = 'none';
                    $("#fechaRegreso")[0].style.display = 'none';
                } else {
                    $("#lbRegreso")[0].style.display = 'block';
                    $("#fechaRegreso")[0].style.display = 'block';
                }
            });

            var date = new Date();
            $("#fechaRegreso").datepicker({
                minDate: 0,
                dateFormat: "dd/mm/yy",
                defaultDate: date,
                onSelect: function () {
                    var selectedDate = $.datepicker.formatDate("dd/mm/yy", $(this).datepicker('getDate'));
                    var element = $("#hdnfechaRegreso")[0];
                    element.value = selectedDate;
                }
            });
            $("#fechaRegreso").datepicker("setDate", date);
            $("#hdnfechaRegreso")[0].value = date.toLocaleDateString();


            var date = new Date();
            $("#fechaSalida").datepicker({
                minDate: 0,
                dateFormat: "dd/mm/yy",
                defaultDate: date,
                onSelect: function () {
                    var selectedDate = $.datepicker.formatDate("dd/mm/yy", $(this).datepicker('getDate'));
                    var element = $("#hdnfechaSalida")[0];
                    element.value = selectedDate;

                }
            });
            $("#fechaSalida").datepicker("setDate", date);
            $("#hdnfechaSalida")[0].value = date.toLocaleDateString();

            
        });

     
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color: #efefef; padding: 20px; ">
        <table style="padding: 20px; ">
            <tr>
                <td colspan="4">
             <asp:RadioButtonList ID="rblTipoViaje" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True" Value="Ida y vuelta" style="margin-right:15px;">Ida y vuelta</asp:ListItem>
                        <asp:ListItem Value="Solo ida">S&#243;lo ida</asp:ListItem>
                    </asp:RadioButtonList>
                   
                </td>
            </tr>
      
            <tr>
                <td>
                    <label for="ddlOrigen" class="depart" style="margin-top: 6px">Origen </label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlOrigen" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlOrigen_SelectedIndexChanged"></asp:DropDownList>
                </td>
                <td>
                    <label for="ddlDestino" class="return" style="margin-top: 6px">Destino</label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDestino" runat="server" class="form-control" style="margin-top: 6px"></asp:DropDownList>
                </td>
                <td>
                    <label for="ddlNumPasajeros" class="label" style="margin-top: 6px">Número de pasajeros</label>
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
                    <asp:HiddenField ID="hdnfechaSalida"  runat="server" ClientIDMode="Static" />
                    <input id="fechaSalida" type="text" class="form-control" style="margin-top: 25px" />
                </td>

                <td>
                    <div id="lblregreso" runat="server" visible="true">
                    <label id="lbRegreso" class="regreso">Regreso</label>
                   </div>
                </td>
               <td>
                   <div id="txtregreso" runat="server" visible="true">
                   <asp:HiddenField ID="hdnfechaRegreso"  runat="server" ClientIDMode="Static" />
                   <input id="fechaRegreso" type="text" class="form-control"  style="margin-top: 25px" />
                    </div>
               </td>
               <td colspan="2" style="text-align: center;  margin: 30px 20px 5px 20px; padding-top: 25px" > 
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar Vuelos" Width="190px" CssClass="btn btn-primary" OnClick="btnBuscar_Click" />
               </td>
            </tr>
            <tr>
                <td colspan="5"> 
                    <asp:Label ID="lblError" runat="server" Text="" CssClass="error">

                    </asp:Label>
                   
                </td>
            </tr>
         
        </table>
        <br />
    </div>

    
    <div>
        <asp:ListView ID="lvRutas" runat="server"
            GroupItemCount="2" OnItemCreated="lvRutas_ItemCreated"
            ItemType="Aerolinea.Data.Ruta" DataKeyNames="IdRuta">
            <EmptyDataTemplate>
                <table>
                    <tr>
                        <td></td>
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
                <td runat="server">
                    <table  style="width: 50%; margin-top: 15px">
                        <tr>
                            <td>
                                <asp:Image ID="imgRuta" runat="server" Height="150px" Width="210px" />
                            </td>
                            <td style="background-color: #e2e2e2; vertical-align: top; padding: 15px 15px 0px 15px; min-width: 220px">
                                <table style="width: 100%">
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

                                    <tr style="text-align: right;">
                                        <td style="text-align: right; font-size: 12px; margin-top: 12px; color: #0079ca;">
                                            <asp:LinkButton ID="lkbtnSearch" runat="server" OnClick="lkbtnSearch_Click" CommandArgument="<%# Item.IdRuta %>"><span style="font-weight: 600; margin-right: 5px; width: 90px;">Comprar</span></asp:LinkButton>
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
