<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MantPiloto.aspx.cs" Inherits="Aerolinea.GUI.Mantenimientos.MantPiloto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <title>Pilotos</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table class="dataTable" cellpadding="5">
    <tr>
        <td style="max-width: 50%">
            <span id="title">Pilotos</span>
            <br />
            <div>
                <div style="margin-top: 15px">
                    <asp:Label runat="server" Text="Cedula: " CssClass="labelform"></asp:Label>
                    <asp:TextBox ID="txtCedula" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="error" ControlToValidate="txtCedula" Text="*Ingrese la Cedula." ValidationGroup="formData"></asp:RequiredFieldValidator>
                </div>

                <div>
                    <asp:Label  runat="server" Text="Nombre: " CssClass="labelform"></asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="error" ControlToValidate="txtNombre" Text="*Ingrese el Nombre." ValidationGroup="formData"></asp:RequiredFieldValidator>
                </div>

                <div>
                    <asp:Label runat="server" Text="Apellido: " CssClass="labelform"></asp:Label>
                    <asp:TextBox ID="txtApellido" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" CssClass="error" ControlToValidate="txtApellido" Text="*Ingrese el Apellido." ValidationGroup="formData"></asp:RequiredFieldValidator>
                </div>

                 <div>
                    <asp:Label runat="server" Text="Telefono: " CssClass="labelform"></asp:Label>
                    <asp:TextBox ID="txtTelefono" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" CssClass="error" ControlToValidate="txtTelefono" Text="*Ingrese el Telefono." ValidationGroup="formData"></asp:RequiredFieldValidator>
                </div>

                <div>
                    <asp:Label runat="server" Text="Email: " CssClass="labelform"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
                </div>
       
                <div style="margin-top: 15px">
                    <asp:Label runat="server" Text="Residencia: " CssClass="labelform"></asp:Label>
                    <asp:TextBox ID="txtResidencia" runat="server" class="form-control"></asp:TextBox>
                </div>

                 <br />
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" ValidationGroup="formData" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" ValidationGroup="formData" />

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
                <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" Width="250px" placeholder="cédula, nombre ó apellido" ValidationGroup="search"></asp:TextBox>&nbsp;
                <asp:LinkButton ID="lbtnBuscar" runat="server" CssClass="btn btn-info" Text="Buscar" OnClick="btnBuscar_Click" ValidationGroup="search"><span class="glyphicon glyphicon-search" ></span>&nbsp;Buscar</asp:LinkButton>
            </div>
             <br />
            <asp:GridView ID="gvDatos" runat="server" CellPadding="4" ForeColor="#333333"
                GridLines="None" AutoGenerateColumns="False" CssClass="table"
                DataKeyNames="IdPiloto"
                OnSelectedIndexChanged="gvDatos_OnSelectedIndexChanged">
                <RowStyle BackColor="#EFF3FB" />
                <Columns>
                    <asp:CommandField HeaderText="Ver"
                        ShowDeleteButton="False" DeleteImageUrl="../images/Delete.gif"
                        ShowSelectButton="True" ButtonType="Image" SelectImageUrl="../images/editar.jpg"
                        InsertVisible="False" ShowCancelButton="False">
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:CommandField>
           
                    <asp:BoundField DataField="Cedula" HeaderText="Cédula" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                   
                    <asp:TemplateField>
                            <ItemTemplate>
                                <asp:HiddenField ID="Email" runat="server" Value='<%# Bind("Email") %>' />
                            </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                            <ItemTemplate>
                                <asp:HiddenField ID="Residencia" runat="server" Value='<%# Bind("Residencia") %>' />
                            </ItemTemplate>
                    </asp:TemplateField>

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
