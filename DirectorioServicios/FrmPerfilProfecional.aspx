<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmPerfilProfecional.aspx.cs" Inherits="DirectorioServicios.FrmPerfilProfecional" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Id Profecional"></asp:Label>
&nbsp;<asp:TextBox ID="txtIdProf" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="btnProfesion" runat="server" OnClick="btnProfesion_Click" Text="Cargar profesiones" />
            <br />
            <br />
            <asp:GridView ID="grd_Ocupaciones" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ID_OCUPACION" HeaderText="ID" />
                    <asp:BoundField DataField="PROFESION" HeaderText="Profesión" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
