<%@ Page Title="" Language="C#" MasterPageFile="~/App/paginaMaestra.Master" AutoEventWireup="true" CodeBehind="FrmPerfilProfesional.aspx.cs" Inherits="DirectorioServicios.FrmPerfilProfesional" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #contenedor, #lista{
            width: 85%;
            margin: 0 auto;
        }

        .col-sm-6{
            margin: 0 auto;
        }

        label, select, button{
            padding-right: 5px;
            padding-left: 2px;
        }

        a i{
            font-size: 2em;
            margin: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div>
&nbsp;&nbsp;
            <br />
            <br />
&nbsp;<br />
            <div id="contenedor" runat="server">
                <h2 class="text-info">Perfil Profesional</h2>
                <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                <br />
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblApellido1" runat="server" Text="Primer Apellido:"></asp:Label>
                <br />
                <asp:TextBox ID="txtApellido1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblApellido2" runat="server" Text="Segundo Apellido:"></asp:Label>
                <br />
                <asp:TextBox ID="txtApellido2" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblTelefono" runat="server" Text="Teléfono:"></asp:Label>
                <br />
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblCorreo" runat="server" Text="Correo Electrónico:"></asp:Label>
                <br />
                <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblAcercaDeMi" runat="server" Text="Acerca de mi:"></asp:Label>
                <br />
                <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-info" />

                <br />

                <br />

                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
                <br />
                <br />
                <asp:Label ID="lblProfesion1" runat="server" Text="Profesión:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblEspecialidad" runat="server" Text="Especialidad:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:DropDownList ID="ddlProfesion" runat="server">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlEspecialidad" runat="server">
                </asp:DropDownList>
                &nbsp;
                <asp:Button ID="btnGuardarProfesion" runat="server" Text="Agregar" CssClass="btn btn-info" />
                <br />
                <br />
                <asp:GridView ID="GridView2" runat="server">
                </asp:GridView>
                <br />
                <br />
                <asp:Label ID="lblProvincia" runat="server" Text="Provincia:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblCanton" runat="server" Text="Cantón:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDetalleDireccion" runat="server" Text="Dirección detallada:"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlProvincia" runat="server">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlCanton" runat="server">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDetalleDireccion" runat="server"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:Button ID="btnGuardarUbicacion" runat="server" Text="Agregar" CssClass="btn btn-info" />
                <br />
                <br />
                <asp:GridView ID="GridView3" runat="server">
                </asp:GridView>
                <br />
                <asp:Label ID="lblWebsites" runat="server" Text="Redes Sociales:"></asp:Label>
                <br />
                <asp:Label ID="lblUrl" runat="server" Text="Dirrección Web:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNombreSitio" runat="server" Text="Nombre del Sitio Web:"></asp:Label>
                <br />
                <asp:TextBox ID="txtURL" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNombreSitio" runat="server"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:Button ID="btnGuardarSitiosWeb" runat="server" Text="Agregar" CssClass="btn btn-info" />
                <br />
                <br />
                
                <br />
                </div>
&nbsp;</div>
</asp:Content>
