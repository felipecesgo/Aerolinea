<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MantAvion.aspx.cs" Inherits="Aerolinea.GUI.Mantenimientos.MantAvion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <title>Aviones</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table class="dataTable" cellpadding="5">
    <tr>
        <td style="max-width: 50%">
            <span id="title">Aviones</span>
            <br />
      
            <div>
                <div>
                    <asp:Label  runat="server" Text="Matricula: " CssClass="labelform"></asp:Label>
                    <asp:TextBox ID="txtMatricula" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvMatricula" runat="server" CssClass="error" ControlToValidate="txtMatricula" Text="*Ingrese la Matricula." ValidationGroup="rutaData"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <asp:Label  runat="server" Text="Marca: " CssClass="labelform"></asp:Label>
                    <asp:TextBox ID="txtMarca" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvMarca" runat="server" CssClass="error" ControlToValidate="txtMarca" Text="*Ingrese la Marca." ValidationGroup="rutaData"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <asp:Label runat="server" Text="Modelo: " CssClass="labelform"></asp:Label>
                    <asp:TextBox ID="txtModelo" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvModelo" runat="server" CssClass="error" ControlToValidate="txtModelo" Text="*Ingrese el Modelo." ValidationGroup="rutaData"></asp:RequiredFieldValidator>
                </div>
                 <br />
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" ValidationGroup="rutaData" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" ValidationGroup="rutaData" />

            </div>
            <br />
            <div class="alert alert-success" visible="false" id="mensaje" runat="server">
                <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span
                    id="textoMensaje" runat="server"></span>
            </div>
            <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
                <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span
                    id="textoMensajeError" runat="server"></span>
            </div>
        </td>
        <td style="vertical-align: top; max-width: 50%">
            <div style="float:right;  margin-right:25px;">
            <div class="form-inline" style="float:right; margin-bottom: 20px;">
                <asp:RequiredFieldValidator ID="rfvBuscar" runat="server" CssClass="error" ControlToValidate="txtBuscar" Text="*" ValidationGroup="search"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" Width="250px" placeholder="matricula, marca, ó modelo" ValidationGroup="search"></asp:TextBox>&nbsp;
                <asp:LinkButton ID="lbtnBuscar" runat="server" CssClass="btn btn-info" Text="Buscar" OnClick="btnBuscar_Click" ValidationGroup="search"><span class="glyphicon glyphicon-search" ></span>&nbsp;Buscar</asp:LinkButton>
            </div>
             <br />
            <asp:GridView ID="gvDatos" runat="server" CellPadding="4" ForeColor="#333333"
                GridLines="None" AutoGenerateColumns="False" CssClass="table"
                DataKeyNames="IdAvion"
                OnSelectedIndexChanged="gvDatos_OnSelectedIndexChanged">
                <RowStyle BackColor="#EFF3FB" />
                <Columns>
                    <asp:CommandField HeaderText="Ver"
                       ShowDeleteButton="False" DeleteImageUrl="../images/Delete.gif"
                        ShowSelectButton="True" ButtonType="Image" SelectImageUrl="../images/editar.jpg"
                        InsertVisible="False" ShowCancelButton="False">
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:CommandField>
                    <asp:BoundField DataField="Matricula" HeaderText="Matricula" />
                    <asp:BoundField DataField="Marca" HeaderText="Marca" />
                    <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                </Columns>
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
          </div>
        </td>
    </tr>
    </table>
</asp:Content>
