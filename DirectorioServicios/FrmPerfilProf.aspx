<%@ Page Title="" Language="C#" MasterPageFile="~/App/paginaMaestra.Master" AutoEventWireup="true" CodeBehind="FrmPerfilProf.aspx.cs" Inherits="DirectorioServicios.FrmPerfilProf" %>
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
            <asp:GridView ID="grd_Ocupaciones" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ID_OCUPACION" HeaderText="ID" />
                    <asp:BoundField DataField="PROFESION" HeaderText="Profesión" />
                </Columns>
            </asp:GridView>
        </div>
</asp:Content>
