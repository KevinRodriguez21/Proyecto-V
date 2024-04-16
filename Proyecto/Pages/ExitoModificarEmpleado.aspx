<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExitoModificarEmpleado.aspx.cs" Inherits="Proyecto.Pages.ExitoModificarEmpleado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Proceso completado con exito</h2>

    <div class="alert-success">
        <p>Se ha modificado correctamente el empleado</p>
    </div>

    <div>
        <a href="ListarEmpleadoPage.aspx">REGRESAR</a>
    </div>
</asp:Content>
