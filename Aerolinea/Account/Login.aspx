<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Aerolinea.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div style="margin: 30px 30px 30px 30px;">
       <asp:Login ID="loginBox" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderPadding="4" BorderStyle="Solid"
           BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" Height="250px" Width="300px" OnAuthenticate="loginBox_Authenticate" UserNameLabelText="Usuario:" UserNameRequiredErrorMessage="El campo usurio es obligatorio.">
           <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
           <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" Height="30px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
           <TextBoxStyle Font-Size="0.8em" Width="250px" />
           <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
       </asp:Login>
    </div>
</asp:Content>
