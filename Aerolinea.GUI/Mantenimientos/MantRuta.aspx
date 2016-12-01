<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="MantRuta.aspx.cs" Inherits="Aerolinea.GUI.Mantenimientos.Rutas.MantRuta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Rutas</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table class="dataTable" cellpadding="5">
    <tr>
        <td style="max-width: 50%">
            <span id="title">Rutas</span>
            <br />
      
            <div>
                <div>
                    <asp:Label  runat="server" Text="Origen: " CssClass="labelform"></asp:Label>
                    <asp:TextBox ID="txtOrigen" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvOrigen" runat="server" CssClass="error" ControlToValidate="txtOrigen" Text="*Ingrese el Origen." ValidationGroup="rutaData"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <asp:Label runat="server" Text="Destino: " CssClass="labelform"></asp:Label>
                    <asp:TextBox ID="txtDestino" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvDestino" runat="server" CssClass="error" ControlToValidate="txtDestino" Text="*Ingrese el Destino." ValidationGroup="rutaData"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <asp:Label runat="server" Text="Tarifa: " CssClass="labelform"></asp:Label>
                    <asp:TextBox ID="txtTarifa" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTarifa" runat="server" CssClass="error" ControlToValidate="txtTarifa" Text="*Ingrese la Tarifa." ValidationGroup="rutaData"></asp:RequiredFieldValidator>
                </div>
                <div>
                    <asp:Label runat="server" Text="Imagen: " CssClass="labelform"></asp:Label>
                    <asp:FileUpload ID="fileUpload" runat="server" class="form-control" />
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
                <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" Width="250px" placeholder="origen ó destino" ValidationGroup="search"></asp:TextBox>&nbsp;
                <asp:LinkButton ID="lbtnBuscar" runat="server" CssClass="btn btn-info" Text="Buscar" OnClick="btnBuscar_Click" ValidationGroup="search"><span class="glyphicon glyphicon-search" ></span>&nbsp;Buscar</asp:LinkButton>
            </div>
             <br />
            <asp:GridView ID="gvRutas" runat="server" CellPadding="4" ForeColor="#333333"
                GridLines="None" AutoGenerateColumns="False" CssClass="table"
                DataKeyNames="IdRuta"
                OnSelectedIndexChanged="gvRutas_OnSelectedIndexChanged">
                <RowStyle BackColor="#EFF3FB" />
                <Columns>
                    <asp:CommandField HeaderText="Ver"
                       ShowDeleteButton="False" DeleteImageUrl="../images/Delete.gif"
                        ShowSelectButton="True" ButtonType="Image" SelectImageUrl="../images/editar.jpg"
                        InsertVisible="False" ShowCancelButton="False">
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:CommandField>
                    <asp:BoundField DataField="Origen" HeaderText="Origen" />
                    <asp:BoundField DataField="Destino" HeaderText="Destino" />
                    <asp:BoundField DataField="Tarifa" HeaderText="Tarifa" DataFormatString="${0:0}" />
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
