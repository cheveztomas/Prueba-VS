<%@ Page Title="" Language="C#" MasterPageFile="~/App/paginaMaestra.Master" AutoEventWireup="true" CodeBehind="FrmRecuperarPassword.aspx.cs" Inherits="DirectorioServicios.FrmRecuerarContraseña" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="DivSesion">
        <h2>Recupere su contraseña</h2>
        <form class="px-4 py-3">
            <div class="form-group" id="txt_Correo">
                <label for="exampleDropdownFormEmail1">Ingrese su correo electrónico</label>
                <asp:TextBox type="email" class="form-control" placeholder="email@example.com" ID="txt_Correo" runat="server" MaxLength="30" ValidationGroup="IniciarSesion"></asp:TextBox>
            </div>
            <asp:Button type="submit" class="btn btn-primary" runat="server" ID="btn_Recuperar" Text="Recuperar Contraseña" OnClick="btn_Recuperar_Click" />
        </form>
</asp:Content>
