﻿<%@ Page Title="" Language="C#" MasterPageFile="~/App/paginaMaestra.Master" AutoEventWireup="true" CodeBehind="FrmBuscador.aspx.cs" Inherits="DirectorioServicios.FrmBuscador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #contenedor{
            width: 960px;
            margin: 0 auto;
        }

        label, select, button{
            padding: 10px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contenedor" class="">
       <div class="form-inline">
            <label for="sel1">Seleccione: Servicio:</label>
           <asp:DropDownList ID="ddlProfecion" runat="server" class="form-control"></asp:DropDownList>
            
           <label for="sel1">Especialidad:</label>
           <asp:DropDownList ID="ddlEspecialidad" runat="server" class="form-control"></asp:DropDownList>

           <label for="sel1">Provincia:</label>
           <asp:DropDownList ID="ddlProvincia" runat="server" class="form-control"></asp:DropDownList>
           
           <label for="sel1">Cantón:</label>
           <asp:DropDownList ID="ddlCanton" runat="server" class="form-control"></asp:DropDownList>
           
            &nbsp;&nbsp;
           <br />
            <asp:Button ID="btnBuscar" runat="server" CssClass="btn btn-primary" Text="Buscar" />
    <!--<button type="submit" class="btn btn-primary" id="btnBuscar">Buscar</button>-->
    </div>
    </div>
    
</asp:Content>
