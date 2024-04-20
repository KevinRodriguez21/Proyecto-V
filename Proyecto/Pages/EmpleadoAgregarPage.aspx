<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmpleadoAgregarPage.aspx.cs" Inherits="Proyecto.Pages.EmpleadoAgregarPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .container {
            width: 300px; /* Ancho del contenedor */
            margin: 0 auto; /* Centrar el contenedor en la página */
        }
    </style>
    <h2 style="text-align: center; margin-top: 20px;">CREAR EMPLEADO</h2>
    <div class="container">
        <div style="text-align: left;">
            <span>Nombre de Empleado</span>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control" Style="margin-top: 10px; display: block;"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="TxtNombre" ErrorMessage="El campo Nombre es requerido." ForeColor="Red"/>
        </div>

        <div style="text-align: left;">
            <span>Apellido</span>
            <asp:TextBox ID="TxtApellido" runat="server" CssClass="form-control" Style="margin-top: 10px; display: block;"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="TxtApellido" ErrorMessage="El campo Apellido es requerido." ForeColor="Red"/>
        </div>

        <div style="text-align: left;">
            <span>Cedula</span>
            <asp:TextBox ID="TxtCedula" runat="server" CssClass="form-control" Style="margin-top: 10px; display: block;"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCedula" runat="server" ControlToValidate="TxtCedula" ErrorMessage="El campo Cedula es requerido." ForeColor="Red"/>
        </div>

        <div style="text-align: left;">
            <span>Telefono</span>
            <asp:TextBox ID="TxtTelefono" runat="server" CssClass="form-control" Style="margin-top: 10px; display: block;"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvTelfono" runat="server" ControlToValidate="TxtTelefono" ErrorMessage="El campo Telefono es requerido." ForeColor="Red"/>
        </div>

        <div style="text-align: left;">
            <span>CorreoElectronico</span>
            <asp:TextBox ID="TxtCorreo" runat="server" CssClass="form-control" Style="margin-top: 10px; display: block;"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="TxtCorreo" ErrorMessage="El campo Correo es requerido." ForeColor="Red"/>
        </div>

        <div style="text-align: left;">
            <span>Departamento</span>
            <asp:DropDownList ID="DdlDepartamento" runat="server" Enabled="True" CssClass="form-control" Style="margin-top: 10px; display: block;"></asp:DropDownList>
        </div>

        <div style="text-align: left;">
            <span>Jerarquia</span>
            <asp:DropDownList ID="DdlJerarquia" runat="server" Enabled="True" CssClass="form-control" Style="margin-top: 10px; display: block;"></asp:DropDownList>
        </div>

        <div style="text-align: center; margin-top: 20px;">
            <asp:Button ID="BtnAgregar" runat="server"
                Text="AGREGAR Empleado" BackColor="#006600"
                ForeColor="White" CssClass="btn btn-primary"
                OnClick="BtnAgregar_Click" />
        </div>

        <div style="text-align: center; margin-top: 20px;">
            <a href="ListarEmpleadoPage.aspx" class="btn btn-default">Regresar a Lista</a>
        </div>
    </div>
</asp:Content>
