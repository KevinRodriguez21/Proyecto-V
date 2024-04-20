<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Opciones.aspx.cs" Inherits="Proyecto.Pages.Opciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align: center; margin-top: 20px;">
        <asp:Button ID="btnClientes" runat="server" Text="Clientes" CssClass="btn btn-primary" OnClick="btnClientes_Click" />
    </div>
    <div style="text-align: center; margin-top: 20px;">
        <asp:Button ID="btnEmpleados" runat="server" Text="Empleados" CssClass="btn btn-primary" OnClick="btnEmpleados_Click" />
    </div>
    <div style="text-align: center; margin-top: 20px;">
        <a href="Sesion.aspx" class="btn btn-primary">Regresar</a>
    </div>
</asp:Content>
