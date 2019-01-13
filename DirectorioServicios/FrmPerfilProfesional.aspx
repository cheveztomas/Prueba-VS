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
    <div id="contenedor" runat="server"></div>
</asp:Content>
