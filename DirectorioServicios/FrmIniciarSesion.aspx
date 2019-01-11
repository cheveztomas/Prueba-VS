<%@ Page Title="" Language="C#" MasterPageFile="~/App/paginaMaestra.Master" AutoEventWireup="true" CodeBehind="FrmIniciarSesion.aspx.cs" Inherits="DirectorioServicios.FrmIniciarSesion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="DivSesion">
        <h2>Inicie Sesión</h2>
        <form class="px-4 py-3">
            <div class="form-group" id="txt_Correo">
                <label for="exampleDropdownFormEmail1">Dirección de correo electrónico</label>
                <asp:TextBox type="email" class="form-control" placeholder="email@example.com" ID="txt_Correo" runat="server" MaxLength="30" ValidationGroup="IniciarSesion"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_Correo" ErrorMessage="* Correo requerido." ForeColor="Red" ValidationGroup="IniciarSesion"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="exampleDropdownFormPassword1">Contraseña</label>
                <asp:TextBox type="password" class="form-control" id="txt_Contrasenia" placeholder="Contraseña" runat="server" MaxLength="16" ValidationGroup="IniciarSesion"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_Contrasenia" ErrorMessage="*Contraseña requerida." ForeColor="Red" ValidationGroup="IniciarSesion"></asp:RequiredFieldValidator>
            </div>
            <div class="form-check">
                <input type="checkbox" class="form-check-input" id="dropdownCheck">
                <label class="form-check-label" for="dropdownCheck">
                    Recuérdame
                </label>
            </div>
            <asp:Button type="submit" class="btn btn-primary" runat="server" ID="btn_IniciarSesion" OnClick="btn_IniciarSesion_Click" Text="Iniciar Sesión" ValidationGroup="IniciarSesion" />
        </form>
        <div class="dropdown-divider"></div>
        <a class="dropdown-item" href="FrmRegistrar.aspx">¿Nuevo por aquí? Registrarse</a>
        <a class="dropdown-item" href="#">¿Olvidaste la Contraseña?</a>
    </div>
</asp:Content>
