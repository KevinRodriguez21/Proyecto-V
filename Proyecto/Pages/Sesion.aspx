<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sesion.aspx.cs" Inherits="Proyecto.Pages.Sesion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center; margin-top: 20px;">Iniciar Sesión</h2>
    <div style="text-align: center; margin-top: 20px;">
        <div>
            <asp:Image ID="imgLogo" runat="server" ImageUrl="~/Imagen/Login.png" CssClass="center-block" Width="200px" Height="200px" />
        </div>
        <div style="display: inline-block; vertical-align: middle; text-align: left;">
            <span>Usuario:</span>
            <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" Style="margin-top: 20px;"></asp:TextBox>
        </div>
        <div style="display: inline-block; vertical-align: middle; text-align: left;">
            <span>Contraseña:</span>
            <asp:TextBox ID="txtContrasennia" runat="server" CssClass="form-control" Style="margin-top: 20px;"></asp:TextBox>
        </div>
        <div style="text-align: center; margin-top: 20px;">
            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
        </div>
        <div style="text-align: center; margin-top: 20px;">
            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-primary" OnClick="btnIngresar_Click" />
        </div>
    </div>
</asp:Content>
