<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarEmpleadoPage.aspx.cs" Inherits="Proyecto.Pages.ListarEmpleadoPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <a href="EmpleadoAgregarPage.aspx" class="btn btn-default">Agregar Nuevo Empleado</a>
    </div>

    <div class="primary-container">

        <asp:GridView ID="GvListaEmpleados" runat="server" AutoGenerateColumns="false" CssClass="table table-striped">
            <Columns>

                <asp:BoundField DataField="EmpleadoID" HeaderText="Codigo Empleado" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre Empleado" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="CorreoElectronico" HeaderText="Correo Electronico" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                <asp:BoundField DataField="Cedula" HeaderText="Cedula" />
                <asp:BoundField DataField="DescripcionDepart" HeaderText="Departamento" />
                <asp:BoundField DataField="DescripcionJerarq" HeaderText="Jerarquia" />

                <asp:TemplateField>
                    <ItemTemplate>
                        <a href="EmpleadoModificarPage.aspx?id=<%# Eval("EmpleadoID") %>">Modificar</a>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
    </div>
    <div style="text-align: center; margin-top: 20px;">
        <a href="Opciones.aspx" class="btn btn-primary">Regresar</a>
    </div>
</asp:Content>
