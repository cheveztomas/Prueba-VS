<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="DirectorioServicios.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0"/>
    <title>Directorio de Servicios</title>
    <style type="text/css">
        #form1 {
            height: 134px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <nav>
        <asp:Label ID="Label1" runat="server" Text="Correo:"></asp:Label>
        <br />
        <asp:TextBox ID="txt_Correo" runat="server" MaxLength="30" TextMode="Email"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
        <br />
        <asp:TextBox ID="txt_Contrasenia" runat="server" MaxLength="16" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="btn_IniciarSesion" runat="server" OnClick="btn_IniciarSesion_Click" Text="Iniciar Sesión" />
        <br />
        <br />
        <a href="FrmRegistroDeUsuarios.aspx">Registrarse</a></nav>
        <div>
            <asp:GridView ID="grd_usuarios" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="636px">
                <Columns>
                    <asp:BoundField DataField="ID_USUARIO" HeaderText="Id" />
                    <asp:BoundField DataField="NOMBRE_PROFESIONAL" HeaderText="Nombre" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
