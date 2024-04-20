<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarClientePage.aspx.cs" Inherits="Proyecto.Pages.ListarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <a href="ClienteAgregarPage.aspx" class="btn btn-default">Agregar Nuevo Cliente</a>
    </div>

    <div class="primary-container">

        <asp:GridView ID="GvListaClientes" runat="server" AutoGenerateColumns="false" CssClass="table table-striped">
            <Columns>

                <asp:BoundField DataField="ClienteID" HeaderText="Codigo Cliente" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre Cliente" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="CorreoElectronico" HeaderText="Correo Electronico" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                <asp:BoundField DataField="Cedula" HeaderText="Cedula" />
                <asp:BoundField DataField="DescripcionTipo" HeaderText="Tipo Cliente" />

                <asp:TemplateField>
                    <ItemTemplate>
                        <a href="ClienteModificarPage.aspx?id=<%# Eval("ClienteID") %>">Modificar</a>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
    </div>
    <div style="text-align: center; margin-top: 20px;">
        <a href="Opciones.aspx" class="btn btn-primary">Regresar</a>
    </div>
</asp:Content>
