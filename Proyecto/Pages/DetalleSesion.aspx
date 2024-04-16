<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleSesion.aspx.cs" Inherits="Proyecto.Pages.DetalleSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Detalle de la Sesión</h2>

    <div class="primary-container">
        <div>
            <span>Datos del objeto</span>
        </div>
        <div>
            <span>Usuario:</span>
            <asp:Label ID="lblObjUsuario" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <span>Contraseña:</span>
            <asp:Label ID="lblObjContrasennia" runat="server" Text=""></asp:Label>
        </div>

    </div>
</asp:Content>
