<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MantVuelo.aspx.cs" Inherits="Aerolinea.GUI.Mantenimientos.MantVuelo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <title>Vuelos</title>

       <link href="../Scripts/bootstrap-3.3.7/content/bootstrap.min.css" rel="stylesheet" />
        <link href="../Scripts/jquery-ui-1.12.1/jquery-ui.min.css" rel="stylesheet" />
        <link href="../Styles/StyleMain.css" rel="stylesheet" />

       <script src="../Scripts/jquery-3.1.1/jquery-3.1.1.min.js"></script>
       <script src="../Scripts/bootstrap-3.3.7/scripts/bootstrap.min.js"></script>
        <script src="../Scripts/jquery-ui-1.12.1/jquery-ui.min.js"></script>

    <script type="text/javascript">

        $(document).ready(function () {

     
            var date = new Date();
            $("#fechaSalida").datepicker({
                minDate: 0,
                dateFormat: "dd/mm/yy",
                defaultDate: date,
                onSelect: function () {
                    var selectedDate = $.datepicker.formatDate("dd/mm/yy", $(this).datepicker('getDate'));
                    var element = $("#hdnfechaSalida")[0];
                    element.value = selectedDate;
                }
            });
            $("#fechaSalida").datepicker("setDate", date);
            $("#hdnfechaSalida")[0].value = date.toLocaleDateString();


            var date = new Date();
            $("#fechaLlegada").datepicker({
                minDate: 0,
                dateFormat: "dd/mm/yy",
                defaultDate: date,
                onSelect: function () {
                    var selectedDate = $.datepicker.formatDate("dd/mm/yy", $(this).datepicker('getDate'));
                    var element = $("#hdnfechaLlegada")[0];
                    element.value = selectedDate;

                }
            });
            $("#fechaLlegada").datepicker("setDate", date);
            $("#hdnfechaLlegada")[0].value = date.toLocaleDateString();

            
        });

      </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table class="dataTable" cellpadding="5">
    <tr>
        <td style="max-width: 50%">
            <span id="title">Vuelos</span>
            <br />
            <div>

                <div>
                    <asp:Label runat="server" Text="Origen: " CssClass="labelform"></asp:Label>
                    <asp:DropDownList ID="ddlOrigen" runat="server" class="form-control"></asp:DropDownList>
                </div>

                <div style="margin-top: 15px">
                    <asp:Label runat="server" Text="Destino: " CssClass="labelform"></asp:Label>
                    <asp:DropDownList ID="ddlDestino" runat="server" class="form-control"></asp:DropDownList>
                </div>

                <div style="margin-top: 15px">
                    <asp:Label runat="server" Text="Fecha de salida: " CssClass="labelform"></asp:Label>
                    <asp:HiddenField ID="hdnfechaSalida"  runat="server" ClientIDMode="Static" />
                    <input id="fechaSalida" type="text" class="form-control" />
                </div>

                <div style="margin-top: 15px">
                    <asp:Label runat="server" Text="Hora de salida: " CssClass="labelform"></asp:Label>
                   <asp:TextBox ID="txtHoraSalida" runat="server" class="form-control" TextMode="Time"></asp:TextBox>
                   <asp:RequiredFieldValidator runat="server" CssClass="error" ControlToValidate="txtHoraSalida" Text="*Ingrese la hora de salida." ValidationGroup="formData"></asp:RequiredFieldValidator>
                </div>

                <div>
                    <asp:Label runat="server" Text="Fecha de llegada: " CssClass="labelform"></asp:Label>
                    <asp:HiddenField ID="hdnfechaLlegada" runat="server" ClientIDMode="Static" />
                    <input id="fechaLlegada" type="text" class="form-control" />
                </div>

                 <div style="margin-top: 15px">
                    <asp:Label  runat="server" Text="Hora de llegada: " CssClass="labelform"></asp:Label>
                    <asp:TextBox ID="txtHoraLlegada" runat="server" class="form-control" TextMode="Time"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" CssClass="error" ControlToValidate="txtHoraLlegada" Text="*Ingrese la hora de llegada." ValidationGroup="formData"></asp:RequiredFieldValidator>
                </div>

                <div>
                    <asp:Label runat="server" Text="Avion: " CssClass="labelform"></asp:Label>
                    <asp:DropDownList ID="ddlAvion" runat="server" class="form-control"></asp:DropDownList>
                </div>

                <div style="margin-top: 15px">
                    <asp:Label runat="server" Text="Piloto: " CssClass="labelform"></asp:Label>
                    <asp:DropDownList ID="ddlPiloto" runat="server" class="form-control"></asp:DropDownList>
                </div>

                <div style="margin-top: 15px">
                    <asp:Label runat="server" Text="Estado del Vuelo: " CssClass="labelform"></asp:Label>
                    <asp:DropDownList ID="ddlEstadoVuelo" runat="server" class="form-control"></asp:DropDownList>
                </div>

                <div style="margin-top: 15px">
                    <asp:Label runat="server" Text="Capacidad Asientos: " CssClass="labelform"></asp:Label>
                    <asp:DropDownList ID="ddlCapacidadAsientos" runat="server" class="form-control"></asp:DropDownList>
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
                <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" Width="250px" placeholder="número, origen, destino ó fecha" ValidationGroup="search"></asp:TextBox>&nbsp;
                <asp:LinkButton ID="lbtnBuscar" runat="server" CssClass="btn btn-info" Text="Buscar" OnClick="btnBuscar_Click" ValidationGroup="search"><span class="glyphicon glyphicon-search" ></span>&nbsp;Buscar</asp:LinkButton>
            </div>
             <br />
            <asp:GridView ID="gvDatos" runat="server" CellPadding="4" ForeColor="#333333"
                GridLines="None" AutoGenerateColumns="False" CssClass="table"
                DataKeyNames="IdVuelo"
                OnSelectedIndexChanged="gvDatos_OnSelectedIndexChanged">
                <RowStyle BackColor="#EFF3FB" />
                <Columns>
                    <asp:CommandField HeaderText="Ver"
                        ShowDeleteButton="False" DeleteImageUrl="../images/Delete.gif"
                        ShowSelectButton="True" ButtonType="Image" SelectImageUrl="../images/editar.jpg"
                        InsertVisible="False" ShowCancelButton="False">
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:CommandField>

                     <asp:BoundField DataField="IdVuelo" HeaderText="Num" />

                    <asp:TemplateField>
                            <ItemTemplate>
                                <asp:HiddenField ID="IdRuta" runat="server" Value='<%# Bind("IdRuta") %>' />
                            </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="Ruta.Origen" HeaderText="Origen" />

                    <asp:BoundField DataField="Ruta.Destino" HeaderText="Destino" />

                    <asp:BoundField DataField="FechaSalida" HeaderText="Salida" />

                    <asp:BoundField DataField="FechaLlegada" HeaderText="Llegada" />

                    <asp:BoundField DataField="EstadoVuelo" HeaderText="Estado" />

                    <asp:BoundField DataField="CapacidadAsientos" HeaderText="Asientos" />
                     <asp:TemplateField>
                            <ItemTemplate>
                                <asp:HiddenField ID="IdAvion" runat="server" Value='<%# Bind("IdAvion") %>' />
                            </ItemTemplate>
                    </asp:TemplateField>
                  
                    
                    <asp:TemplateField>
                            <ItemTemplate>
                                <asp:HiddenField ID="IdPiloto" runat="server" Value='<%# Bind("IdPiloto") %>' />
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
