<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ElegirAsiento.aspx.cs" Inherits="Aerolinea.GUI.ElegirAsiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <asp:Label runat="server" ID="lblTitle" Text="Elegir Asiento" CssClass="title"></asp:Label>

    <br />
        <table style="margin-left:20px">
            <tr>
                <td style="padding-left: 25px; padding-right: 25px; padding-bottom: 25px; background-color:#e2e2e2;">
                   
                    <table id="Plantilla" runat="server" style="margin: 0 auto; padding: 0" >
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


                        <tr>
                            <td colspan="5" style="text-align: center">
                                <h3>Clase Principal</h3>
                            </td>
                        </tr>

                        <tr>
                            <td>
                                <asp:Button ID="Button9" CommandArgument="9" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                            <td>
                                <asp:Button ID="Button10" CommandArgument="10" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                            <td style="width: 40px;"></td>
                            <td>
                                <asp:Button ID="Button11" CommandArgument="11" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                            <td>
                                <asp:Button ID="Button12" CommandArgument="12" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                        </tr>


                        <tr>
                            <td>
                                <asp:Button ID="Button13" CommandArgument="13" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                            <td>
                                <asp:Button ID="Button14" CommandArgument="14" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click"/>
                            </td>
                            <td style="width: 40px;"></td>
                            <td>
                                <asp:Button ID="Button15" CommandArgument="15" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                            <td>
                                <asp:Button ID="Button16" CommandArgument="16"  runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                        </tr>

                        <tr>
                            <td>
                                <asp:Button ID="Button17" CommandArgument="17" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                            <td>
                                <asp:Button ID="Button18" CommandArgument="18" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                            <td style="width: 40px;"></td>
                            <td>
                                <asp:Button ID="Button19" CommandArgument="19" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                            <td>
                                <asp:Button ID="Button20" CommandArgument="20" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                        </tr>

                        <tr>
                            <td>
                                <asp:Button ID="Button21" CommandArgument="21" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                            <td>
                                <asp:Button ID="Button22" CommandArgument="22" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click"/>
                            </td>
                            <td style="width: 40px;"></td>
                            <td>
                                <asp:Button ID="Button23" CommandArgument="23" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                            <td>
                                <asp:Button ID="Button24" CommandArgument="24"  runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                            </td>
                        </tr>

                    </table>
                </td>
              
            </tr>
          
        </table>



</asp:Content>
