<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Aerolinea.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
     <div class="form-group">
        <asp:ListView ID="lvRutas" runat="server"
            GroupItemCount="3" OnItemCreated="lvRutas_ItemCreated"
            ItemType="Aerolinea.Data.Ruta" DataKeyNames="IdRuta">
            <EmptyDataTemplate>
                <table>
                    <tr>
                        <td>No data was returned.</td>
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
                    <table align="center">
                        <tr>
                            <td>
                                <asp:Image ID="imgRuta"  runat="server" Height="100px" Width="100px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <%#: Item.Origen %>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <%#: Item.Destino %>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <%#: Item.Tarifa %>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnComprar" runat="server" Text="Comprar" CssClass="btn btn-primary" OnClick="btnComprar_Click" CommandArgument="<%# Item.IdRuta %>" />
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
