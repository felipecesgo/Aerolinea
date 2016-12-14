<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ElegirAsiento.aspx.cs" Inherits="Aerolinea.GUI.ElegirAsiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <asp:Label runat="server" ID="lblTitle" Text="Elegir Asiento" CssClass="title"></asp:Label>

    <br />
        <table id="Plantilla" runat="server" style="margin-left:20px">
            <tr>
                <td style="padding-left: 25px; padding-right: 25px; padding-bottom: 25px; background-color:#e2e2e2;">
                   
                    <table id="ClaseEjecutiva"style="margin: 0 auto; padding: 0" >
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
                                <asp:Button ID="Button6" CommandArgument="6" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click"/>
                            </td>
                            <td style="width: 40px;"></td>
                            <td>
                                <asp:Button ID="Button7" CommandArgument="7" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                            <td>
                                <asp:Button ID="Button8" CommandArgument="8"  runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                        </tr>

                    </table>
                </td>
              
            </tr>
          
        </table>



</asp:Content>
