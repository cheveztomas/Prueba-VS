<%@ Page Title="" Language="C#" MasterPageFile="~/App/paginaMaestra.Master" AutoEventWireup="true" CodeBehind="FrmMostrarPerfilProf.aspx.cs" Inherits="DirectorioServicios.FrmPerfilProf" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Id Profecional"></asp:Label>
&nbsp;<asp:TextBox ID="txtIdProf" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="btnProfesion" runat="server" Text="Cargar profesiones" OnClick="btnProfesion_Click" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Profesional:"></asp:Label>
&nbsp;<asp:Label ID="lblUser" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Correo: "></asp:Label>
            <asp:Label ID="lblCorreo" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Teléfono: "></asp:Label>
            <asp:Label ID="lblTelefono" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Descripción:"></asp:Label>
            <asp:Label ID="lblDescripcion" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="grd_Ocupaciones" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ID_OCUPACION" HeaderText="ID" />
                    <asp:BoundField DataField="PROFESION" HeaderText="Profesión" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:GridView ID="grd_Ubicacion" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ID_UBICACION" HeaderText="Código de Ubicación" />
                    <asp:BoundField DataField="PROVINCIA" HeaderText="Provincia" />
                    <asp:BoundField DataField="CANTON" HeaderText="Cantón" />
                    <asp:BoundField DataField="DETALLES" HeaderText="Detalle" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:GridView  ID="grd_websites" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="COD_SITIO" HeaderText="Código sitio" />
                    <asp:BoundField DataField="NOMBRE_SITIO" HeaderText="Sitio" />
                    <asp:BoundField DataField="URL_SITIO" HeaderText="Url" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="Button1" runat="server" class="btn btn-danger" Text="Button" />

            <br />
&nbsp;</div>
</asp:Content>
