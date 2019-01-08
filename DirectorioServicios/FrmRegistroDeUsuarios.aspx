﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmRegistroDeUsuarios.aspx.cs" Inherits="DirectorioServicios.FrmRegistroDeUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0"/>
    <title>Registro de Usuarios</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
&nbsp;<br />
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblApellido1" runat="server" Text="Apellido 1"></asp:Label>
            <br />
            <asp:TextBox ID="txtApellido1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblApellido2" runat="server" Text="Apellido 2"></asp:Label>
            <br />
            <asp:TextBox ID="txtApellido2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblTelefono" runat="server" Text="Teléfono"></asp:Label>
            <br />
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCorreo" runat="server" Text="Correo"></asp:Label>
            <br />
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblUserProfesional" runat="server" Text="Profesional?"></asp:Label>
            <br />
            <asp:CheckBox ID="chkProfesional" runat="server" />
            <br />
            <br />
            <asp:Label ID="lblDescripcion" runat="server" Text="Descripción"></asp:Label>
            <br />
            <textarea id="txtAreaDescripcion" cols="20" name="S1" rows="2"></textarea><br />
            <br />
            <asp:Label ID="lblDireccion" runat="server" Text="Dirección"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblProvincia" runat="server" Text="Provincia"></asp:Label>
            <br />
            <asp:DropDownList ID="drpdlProvincia" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblCanton" runat="server" Text="Cantón"></asp:Label>
            <br />
            <asp:DropDownList ID="drpdlCanton" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
&nbsp;&nbsp;
            <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" />
            <br />

        </div>
    </form>
</body>
</html>
