<%@ Page Title="" Language="C#" MasterPageFile="~/App/paginaMaestra.Master" AutoEventWireup="true" CodeBehind="FrmRegistrar.aspx.cs" Inherits="DirectorioServicios.FrmRegistrar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="DivSesion">
        <h2>Registrese Aquí</h2>
        <form class="px-4 py-3">
            <div class="form-group">
                <label for="exampleDropdownFormEmail1">Dirección de correo electrónico</label>
                <asp:TextBox ID="txt_Correo" runat="server" class="form-control" placeholder="email@example.com" TextMode="Email" MaxLength="30" ValidationGroup="Registrar"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_Correo" ErrorMessage="* Correo requerido." ForeColor="Red" ValidationGroup="Registrar"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="exampleDropdownFormPassword1">Contraseña</label>
                <asp:TextBox class="form-control" id="txt_Conrteasenia" placeholder="Password" runat="server" TextMode="Password" MaxLength="16" ValidationGroup="Registrar"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_Conrteasenia" ErrorMessage="*Contraseña requerido." ForeColor="Red" ValidationGroup="Registrar"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="exampleDropdownFormPassword1">Confirmar Contraseña</label>
                <asp:TextBox class="form-control" id="txt_ConrteaseniaConfir" placeholder="Password" runat="server" TextMode="Password" onblur="ValidarPassword()" MaxLength="16" ValidationGroup="Registrar"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" BackColor="White" ControlToCompare="txt_Conrteasenia" ControlToValidate="txt_ConrteaseniaConfir" ErrorMessage="* Contraseña no coincide." ForeColor="Red" ValidationGroup="Registrar"></asp:CompareValidator>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_ConrteaseniaConfir" ErrorMessage="*Confirmar contraseña raquerido." ForeColor="Red" ValidationGroup="Registrar"></asp:RequiredFieldValidator>
                <label id="MensajeCon"></label>
            </div>


            <div class="form-group">
                <label for="exampleDropdownFormEmail1">Nombre</label>
                <asp:TextBox ID="txt_Nombre" runat="server" class="form-control" MaxLength="20" ValidationGroup="Registrar"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Nombre requerido." ForeColor="Red" ValidationGroup="Registrar"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="exampleDropdownFormEmail1">Primer Apellido</label>
                <asp:TextBox ID="Txt_Apellido1" runat="server" class="form-control" MaxLength="20" ValidationGroup="Registrar"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ForeColor="Red" ValidationGroup="Registrar"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="exampleDropdownFormEmail1">Segundo Apellido</label>
                <asp:TextBox ID="Txt_Apellido2" runat="server" class="form-control" MaxLength="20" ValidationGroup="Registrar"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="exampleDropdownFormEmail1" id="df">Teléfono</label>
                <asp:TextBox ID="Txt_Telefono" runat="server" class="form-control" MaxLength="8" ValidationGroup="Registrar"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ForeColor="Red" ValidationGroup="Registrar"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="exampleDropdownFormEmail1">Descripción</label>
                <asp:TextBox ID="Txt_Descipcion" runat="server" class="form-control" TextMode="MultiLine" MaxLength="200" ValidationGroup="Registrar"></asp:TextBox>
            </div>

            <asp:Button ID="btn_Registrar" runat="server" class="btn btn-primary" Text="Registrarse" OnClick="btn_Registrar_Click" ValidationGroup="Registrar" />
        </form>
        <div class="dropdown-divider"></div>
    </div>
    <br />
    <br />
</asp:Content>
