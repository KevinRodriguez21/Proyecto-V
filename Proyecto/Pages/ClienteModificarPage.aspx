<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClienteModificarPage.aspx.cs" Inherits="Proyecto.Pages.ClienteModificarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Modificar Cliente</h2>

    <div>
        <div>
            <span>Codigo  Cliente</span>
            <asp:TextBox ID="TxtClienteID" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
        <div>
            <span>Nombre  Cliente</span>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Apellido</span>
            <asp:TextBox ID="TxtApellido" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Cedula</span>
            <asp:TextBox ID="TxtCedula" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Telefono</span>
            <asp:TextBox ID="TxtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Correo Electronico</span>
            <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span>TipoCliente</span>
            <asp:DropDownList ID="DdlTipoCliente" runat="server" Enabled="True"></asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="BtnModificar" runat="server" Text="MODIFICAR CLIENTE" CssClass="btn btn-primary" OnClick="BtnModificar_Click" />
            <asp:Button ID="BtnEliminar" runat="server" Text="ELIMINAR CLIENTE" CssClass="btn btn-primary" OnClick="BtnEliminar_Click" />
        </div>
        <div>
            <a href="ListarClientePage.aspx" class="btn btn-primary">Cancelar</a>
        </div>
    </div>
</asp:Content>
