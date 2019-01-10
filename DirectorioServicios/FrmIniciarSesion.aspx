<%@ Page Title="" Language="C#" MasterPageFile="~/App/paginaMaestra.Master" AutoEventWireup="true" CodeBehind="FrmIniciarSesion.aspx.cs" Inherits="DirectorioServicios.FrmIniciarSesion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="DivSesion">
        <form class="px-4 py-3">
            <div class="form-group" id="txt_Correo">
                <label for="exampleDropdownFormEmail1">Dirección de correo electrónico</label>
                <input type="email" class="form-control" placeholder="email@example.com" ID="TextBox1" runat="server">
            </div>
            <div class="form-group">
                <label for="exampleDropdownFormPassword1">Contraseña</label>
                <input type="password" class="form-control" id="txt_Contrasenia" placeholder="Contraseña" runat="server">
            </div>
            <div class="form-check">
                <input type="checkbox" class="form-check-input" id="dropdownCheck">
                <label class="form-check-label" for="dropdownCheck">
                    Recuérdame
                </label>
            </div>
            <button type="submit" class="btn btn-primary">Sign in</button>
        </form>
        <div class="dropdown-divider"></div>
        <a class="dropdown-item" href="#">¿Nuevo por aquí? Registrarse</a>
        <a class="dropdown-item" href="#">¿Olvidaste la Contraseña?</a>
    </div>
</asp:Content>
