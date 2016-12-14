<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MantenimientoAsientos.aspx.cs" Inherits="Aerolinea.MantenimientoAsientos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table  style="margin-left: 20px">
        <tr>
            <td style="padding-left: 25px; padding-right: 25px; padding-bottom: 25px; background-color: #e2e2e2;">

                <table id="Plantilla" runat="server" style="margin: 0 auto; padding: 0">
                    <tr>
                        <td colspan="5" style="text-align: center">
                            <h3>Clase Ejecutiva</h3>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 40px; text-align: center">A</td>
                        <td style="width: 40px; text-align: center">B</td>
                        <td style="width: 40px;"></td>
                        <td style="width: 40px; text-align: center">C</td>
                        <td style="width: 40px; text-align: center">D</td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Button ID="Button1" CommandArgument="1" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button2" CommandArgument="2" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td style="width: 40px;"></td>
                        <td>
                            <asp:Button ID="Button3" CommandArgument="3" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button4" CommandArgument="4" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                    </tr>


                    <tr>
                        <td>
                            <asp:Button ID="Button5" CommandArgument="5" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button6" CommandArgument="6" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td style="width: 40px;"></td>
                        <td>
                            <asp:Button ID="Button7" CommandArgument="7" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button8" CommandArgument="8" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                    </tr>

                </table>
            </td>
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:DropDownList ID="ddlVuelo" runat="server" CssClass="form-control">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" CssClass="btn btn-primary" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="IdAvion"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_idAvion" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Origen"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_origen" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Destino"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_destino" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Piloto"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_piloto" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Fecha Salida"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_fechaSalida" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Fecha Llegada"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_fechaLlegada" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btn_Reservar" runat="server" Text="Reservar" OnClick="btn_Reservar_Click" CssClass="btn btn-success" />
                        </td>
                    </tr>

                </table>

            </td>
        </tr>

    </table>































</asp:Content>
