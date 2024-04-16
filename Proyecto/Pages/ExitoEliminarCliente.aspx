<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExitoEliminarCliente.aspx.cs" Inherits="Proyecto.Pages.ExitoEliminarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Proceso completado con exito</h2>

    <div class="alert-success">
        <p>Se ha eliminado correctamente el cliente</p>
    </div>

    <div>
        <a href="ListarClientePage.aspx">REGRESAR</a>
    </div>
</asp:Content>
