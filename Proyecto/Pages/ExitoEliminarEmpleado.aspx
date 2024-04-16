<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExitoEliminarEmpleado.aspx.cs" Inherits="Proyecto.Pages.ExitoEliminarEmpleado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Proceso completado con exito</h2>

    <div class="alert-success">
        <p>Se ha eliminado correctamente el empleado</p>
    </div>

    <div>
        <a href="ListarEmpleadoPage.aspx">REGRESAR</a>
    </div>
</asp:Content>
