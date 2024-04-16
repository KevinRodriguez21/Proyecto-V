<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmpleadoModificarPage.aspx.cs" Inherits="Proyecto.Pages.EmpleadoModificarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Modificar Empleado</h2>

    <div>
        <div>
            <span>Codigo  Empleado</span>
            <asp:TextBox ID="TxtEmpleadoID" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
        <div>
            <span>Nombre  Empleado</span>
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
            <asp:TextBox ID="TxtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span>Departamento</span>
            <asp:DropDownList ID="DdlDepartamento" runat="server" Enabled="True"></asp:DropDownList>
        </div>
        <div>
            <span>Jerarquia</span>
            <asp:DropDownList ID="DdlJerarquia" runat="server" Enabled="True"></asp:DropDownList>
        </div>

        <div>
            <asp:Button ID="BtnModificar" runat="server" Text="MODIFICAR EMPLEADO" CssClass="btn btn-primary" OnClick="BtnModificar_Click" />
            <asp:Button ID="BtnEliminar" runat="server" Text="ELIMINAR EMPLEADO" CssClass="btn btn-primary" OnClick="BtnEliminar_Click" />
        </div>
        <div>
            <a href="ListarEmpleadoPage.aspx" class="btn btn-primary">Cancelar</a>
        </div>
    </div>
</asp:Content>
