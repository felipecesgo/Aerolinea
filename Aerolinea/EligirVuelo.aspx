<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EligirVuelo.aspx.cs" Inherits="Aerolinea.EligirVuelo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <span id="title"> Elegir vuelo</span>
    <br />
    <span class="depart-return">Salida </span>
    <asp:Label id="lblOrigen" runat="server" CssClass="city-pair"></asp:Label>
     <br />
    <asp:Label id="lblFechaSalida" runat="server" CssClass="date-info"></asp:Label>
         <br />
</asp:Content>
