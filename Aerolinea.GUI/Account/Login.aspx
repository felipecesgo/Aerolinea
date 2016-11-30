<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Aerolinea.GUI.Account.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br />
<div class="row"  style="width: 42%; margin:0 auto;">

    <br />
        <div class="well">
              <div class="form-group">
             <span id="title" style="margin-left: 25%;">Iniciar Sesión</span>
                      </div>
            <div class="form-group">
                <label for="username" class="control-label">Usuario</label>
                <input runat="server" type="text" style="margin-top: 8px" class="form-control" id="username" name="username" value="" required="" title="Ingrese su nombre de usuario" placeholder="Nombre de Usuario" />
                <span runat="server" id="userError" class="help-block" style="color: red"></span>
            </div>
            <div class="form-group">
                <label for="password" class="control-label">Contraseña</label>
                <input runat="server" type="password" style="margin-top: 8px" class="form-control" id="password" name="password" value="" required="" title="Ingrese su contraseña"  placeholder="Contraseña"/>
                <span runat="server" id="passwdError" class="help-block" style="color: red"></span>
            </div>
            <div id="loginErrorMsg" runat="server" class="alert alert-error hide" style="color: red">Wrong username og password</div>
            <div class="checkbox">
                <label>
                    <input  runat="server" type="checkbox" name="remember" id="remember" />
                    Recordarme    
                </label>
            </div>
            <asp:Button ID="bntIngresar" runat="server" Text="Iniciar sesión" OnClick="bntIngresar_Click" CssClass="btn btn-primary btn-block"></asp:Button>
        </div>


</div>
</asp:Content>
