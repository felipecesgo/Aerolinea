<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NuevaRuta.aspx.cs" Inherits="Aerolinea.Rutas.NuevaRuta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

        function uploadme() {
            $('#Uploadfile').click();

        }

        function splitpath(paths) {
            var st = paths.split("\\");
            return st[st.length - 1];
        }

        function updatemyname() {
            var varfile = document.getElementById("Uploadfile");
            document.getElementById("txtImagen").value = splitpath(varfile.value);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Nueva Ruta </h2>
    <br />
    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <span id="textoMensaje" runat="server"></span>
    </div>
    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <span id="textoMensajeError" runat="server"></span>
    </div>
    <div class="form-group" style="width: 40%;">
        <asp:Label ID="lbOrigen" runat="server" Text="Origen: "></asp:Label>
        <asp:TextBox ID="txtOrigen" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lbDestino" runat="server" Text="Destino: "></asp:Label>
        <asp:TextBox ID="txtDestino" runat="server" class="form-control"></asp:TextBox>

        <asp:Label ID="lbTarifa" runat="server" Text="Tarifa: "></asp:Label>
        <asp:TextBox ID="txtTarifa" runat="server" class="form-control"></asp:TextBox>

        <asp:Label ID="lbImagen" runat="server" Text="Imagen: "></asp:Label>

        <div>
            <input type="file" id="Uploadfile" style="display: none;" onchange="updatemyname();" />
            <div class="input-group">
                <input id="txtImagen" type="text" class="form-control" placeholder="No se eligió archivo" disabled="disabled" />
                <span class="input-group-btn">
                    <a href="javascript:void(0);" class="btn btn-success" onclick="uploadme();">Examinar..</a>
                </span>
            </div>
        </div>

        <br />
        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" CssClass="btn btn-primary" OnClick="btnInsertar_Click" />

    </div>
</asp:Content>
