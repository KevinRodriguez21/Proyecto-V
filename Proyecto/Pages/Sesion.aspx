<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sesion.aspx.cs" Inherits="Proyecto.Pages.Sesion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Inicio</h2>

    <div class="primary-container">
        <asp:GridView ID="GvListaUsuarios" runat="server" AutoGenerateColumns="false" CssClass="table table-striped">
            <Columns>

                <asp:BoundField DataField="UsuarioID" HeaderText="Codigo Usuario" />
                <asp:BoundField DataField="Usuario" HeaderText="Nombre Usuario" />
                <asp:BoundField DataField="Contrasennia" HeaderText="Telefono" />

            </Columns>
        </asp:GridView>
        <%--<div>
            <span>Usuario</span>
            <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <span>Contraseña</span>
            <asp:TextBox ID="txtContrasennia" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-primary" OnClick="btnIngresar_Click" />
        </div>--%>
    </div>
</asp:Content>
