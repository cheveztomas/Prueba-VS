<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ocupaciones.aspx.cs" Inherits="DirectorioServicios.ocupaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
            <asp:Label ID="Label1" runat="server" Text="prueva para agregar una ocupación"></asp:Label>
&nbsp;</p>
        <p>
            ID
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Ocupación:"></asp:Label>
&nbsp;<asp:TextBox ID="txtOcupacion" runat="server" Width="321px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Especialidad:"></asp:Label>
&nbsp;<asp:TextBox ID="txtEspecialidad" runat="server" Width="314px"></asp:TextBox>
&nbsp;
            <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar ocupacion" />
        </p>
    </form>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
