<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ConfirmarReserva.aspx.cs" Inherits="Aerolinea.GUI.ConfirmarReserva" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/style_main2.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div style="margin-left: 20px">
    <asp:Label runat="server" ID="lblTitle" Text="Confirmar Reservación" CssClass="title"></asp:Label>
   </div>
         <div class="alert alert-success" visible="false" id="mensaje" runat="server">
                <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span
                    id="textoMensaje" runat="server">Su vuelo se ha reservado con éxito. recibirá un correo con la confirmación de su reservación.</span>
            </div>

      <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
                <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span
                    id="textoMensajeError" runat="server"></span>
            </div>

 <div style="margin-left:20px; margin-top:5px; margin-right: 10px;">

    <table cellpadding="15"  style="margin-left:10px; margin-top:5px;">
  
        <tr>
            <td colspan="2">
                <asp:ValidationSummary CssClass="ErrorInput" ID="ValidationSummary1" runat="server" HeaderText="Por favor, corrija los siguientes errores:"/>
            </td>
        </tr>

        <tr>
            <td colspan="2" class="Subtitle">Información Personal</td>
        </tr>

        <tr>
             <td class="formText">Nombre (*):</td>
             <td>
                 <asp:TextBox CssClass="textInput" ID="txtFirstName" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator CssClass="ErrorInput" ID="rfvFirstName"  ControlToValidate="txtFirstName" ErrorMessage="Por favor ingrese su nombre." Text="*" runat="server"></asp:RequiredFieldValidator>
             </td>
        </tr>

        <tr>
             <td class="formText">Apellidos (*):</td>
             <td>
                 <asp:TextBox CssClass="textInput" ID="txtLastName" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator CssClass="ErrorInput" ID="rfvLastName" ControlToValidate="txtLastName" ErrorMessage="Por favor ingrese su apellido." Text="*" runat="server"></asp:RequiredFieldValidator>
             </td>
        </tr>

        <tr>
             <td class="formText">Dirección (*):</td>
             <td>
                 <asp:TextBox CssClass="textInput" ID="txtResidencia" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator CssClass="ErrorInput" ControlToValidate="txtResidencia" ErrorMessage="Por favor ingrese su dirreción." Text="*" runat="server"></asp:RequiredFieldValidator>
             </td>
        </tr>

        <tr>
             <td class="formText">Telefono (*):</td>
             <td>
                 <asp:TextBox CssClass="textInput" ID="txtPhoneNumber" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator CssClass="ErrorInput" ID="rfvPhoneNumber" ControlToValidate="txtPhoneNumber" ErrorMessage="Por favor ingrese su telefono" Text="*" runat="server"></asp:RequiredFieldValidator>
             </td>
        </tr>

        <tr>
             <td class="formText">Email (*):</td>
             <td>
                 <asp:TextBox CssClass="textInput" ID="txtEmail" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator CssClass="ErrorInput" ID="rfvEmail" ControlToValidate="txtEmail" ErrorMessage="Por favor ingrese su email." Text="*" runat="server"></asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator  CssClass="ErrorInput" ID="revEmail" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Please enter a valid email." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
             </td>
        </tr>

        <tr>
            <td colspan="2" class="Subtitle">Información del pago</td>
        </tr>

        <tr>
             <td class="formText">Pago con tarjeta:</td>
             <td>
                 <asp:DropDownList CssClass="textInput" ID="ddlCardPayment" runat="server" AutoPostBack="True">
                    <asp:ListItem Selected="True">Seleccione el tipo de tarjeta...</asp:ListItem>
                    <asp:ListItem>American Express</asp:ListItem>
                    <asp:ListItem>Dinners Club</asp:ListItem>
                     <asp:ListItem>Discover Card</asp:ListItem>
                    <asp:ListItem>Visa</asp:ListItem>
                    <asp:ListItem>MasterCard</asp:ListItem>
                </asp:DropDownList>
                <asp:CompareValidator CssClass="ErrorInput" ID="cvCardPayment" ControlToValidate="ddlCardPayment" ErrorMessage="Por favor seleccione a tipo de tarjeta."  Text="*" ValueToCompare="Seleccione el tipo de tarjeta..." runat="server" Operator="NotEqual"></asp:CompareValidator>
             </td>
        </tr>


        <tr>
             <td class="formText">Numero de Tarjeta:</td>
             <td>
                 <asp:TextBox CssClass="textInput" ID="txtCardNumber" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator CssClass="ErrorInput" ID="rfvCardNumber" ControlToValidate="txtCardNumber" ErrorMessage="Por favor ingrese el número de tarjeta." Text="*" runat="server"></asp:RequiredFieldValidator>
             </td>
        </tr>

        <tr>
             <td class="formText">Fecha de expiración:</td>
             <td class="formText">
                 Month:
                 <asp:DropDownList CssClass="textInput" ID="ddlMonth" Width="40px" runat="server" AutoPostBack="True">
                    <asp:ListItem Selected="True">01</asp:ListItem>
                    <asp:ListItem>02</asp:ListItem>
                    <asp:ListItem>03</asp:ListItem>
                    <asp:ListItem>04</asp:ListItem>
                    <asp:ListItem>05</asp:ListItem>
                    <asp:ListItem>06</asp:ListItem>
                    <asp:ListItem>07</asp:ListItem>
                    <asp:ListItem>08</asp:ListItem>
                    <asp:ListItem>09</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
                 
                 Year: 
                 <asp:DropDownList CssClass="textInput" ID="ddlYear" Width="60px" runat="server" AutoPostBack="True">
             
                    <asp:ListItem  Selected="True">2016</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem>2020</asp:ListItem>
                    <asp:ListItem>2021</asp:ListItem>
                    <asp:ListItem>2022</asp:ListItem>
                    <asp:ListItem>2023</asp:ListItem>
                    <asp:ListItem>2024</asp:ListItem>
                    <asp:ListItem>2025</asp:ListItem>
                    <asp:ListItem>2026</asp:ListItem>
                </asp:DropDownList>
             </td>
        </tr>

        <tr>
             <td class="formText">Código de Seguridad:</td>
             <td>
                 <asp:TextBox CssClass="textInput" ID="txtSecurityCode" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator CssClass="ErrorInput" ID="rfvSecurityCode" ControlToValidate="txtSecurityCode" ErrorMessage="Por favor ingrese el codigo de seguridad de la tarjeta." Text="*" runat="server"></asp:RequiredFieldValidator>
                 <asp:CompareValidator ID="cvSecurityCode" runat="server" ControlToValidate="txtSecurityCode" Display="Dynamic" ErrorMessage="Por favor ingrese a codigo de segurudad valido." ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer">*</asp:CompareValidator>
             </td>
        </tr>

        <tr>
            <td colspan="2" class="formText" style="margin-bottom: 15px;padding-top:15px;">Se le facturará a su tarjeta la cantidad total cuando presione Confirmar Reservación.</td>
        </tr>

        <tr>
            <td colspan="2" class="formText" style="margin-top: 15px;padding-top:15px;"><asp:CheckBox ID="chbAcceptConditions" Text="&nbsp;Acepta terminos y condiciones" runat="server"/></td>
        </tr>

        <tr>
            <td colspan="2" class="formText" style="margin-top: 15px; padding-top:15px;"> 
                <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar Reservación" CssClass="btn btn-success" OnClick="btnConfirmar_Click"  />
            </td>
        
        </tr>

        <tr>
            <td  colspan="2">
                <div style="text-align: left">
                <img src="Images/payment_logos.jpg" width="75%" height="110" />
		    </div>
            </td>
        </tr>
    </table>          
    </div>
</asp:Content>
