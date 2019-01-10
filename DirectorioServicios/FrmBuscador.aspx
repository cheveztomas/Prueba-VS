<%@ Page Title="" Language="C#" MasterPageFile="~/App/paginaMaestra.Master" AutoEventWireup="true" CodeBehind="FrmBuscador.aspx.cs" Inherits="DirectorioServicios.FrmBuscador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #contenedor{
            width: 100px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contenedor">
        <div class="form-group">
      <label for="exampleDropdownFormEmail1">Email address</label>
      <input type="email" class="form-control" id="exampleDropdownFormEmail1" placeholder="email@example.com">
    </div>
    <div class="form-group">
      <label for="exampleDropdownFormPassword1">Password</label>
      <input type="password" class="form-control" id="exampleDropdownFormPassword1" placeholder="Password">
    </div>
    <div class="form-check">
      <input type="checkbox" class="form-check-input" id="dropdownCheck">
      <label class="form-check-label" for="dropdownCheck">
        Remember me
      </label>
    </div>
    <button type="submit" class="btn btn-primary">Sign in</button>
    </div>
</asp:Content>
