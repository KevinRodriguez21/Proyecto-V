<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmpleadoAgregarPage.aspx.cs" Inherits="Proyecto.Pages.EmpleadoAgregarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>CREAR EMPLEADO</h2>

    <div>

        <div>
            <span>Nombre de Empleado</span>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="from-control"></asp:TextBox>
        </div>

        <div>
            <span>Apellido</span>
            <asp:TextBox ID="TxtApellido" runat="server" CssClass="from-control"></asp:TextBox>
        </div>

        <div>
            <span>Cedula</span>
            <asp:TextBox ID="TxtCedula" runat="server" CssClass="from-control"></asp:TextBox>
        </div>

        <div>
            <span>Telefono</span>
            <asp:TextBox ID="TxtTelefono" runat="server" CssClass="from-control"></asp:TextBox>
        </div>

        <div>
            <span>CorreoElectronico</span>
            <asp:TextBox ID="TxtCorreo" runat="server" CssClass="from-control"></asp:TextBox>
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
            <asp:Button ID="BtnAgregar" runat="server"
                Text="AGREGAR Empleado" BackColor="#006600"
                ForeColor="White" CssClass="btn btn-primary"
                OnClick="BtnAgregar_Click" />
        </div>

        <div>
            <a href="ListarEmpleadoPage.aspx" class="btn btn-default">Regresar a Lista</a>
        </div>

    </div>
</asp:Content>
