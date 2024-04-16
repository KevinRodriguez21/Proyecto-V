<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExitoAgregarCliente.aspx.cs" Inherits="Proyecto.Pages.ExitoAgregarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Proceso completado con exito</h2>

    <div class="alert-success">
        <p>Se ha agregado correctamente el cliente</p>
    </div>

    <div>
        <a href="ListarClientePage.aspx">REGRESAR</a>
    </div>
</asp:Content>
