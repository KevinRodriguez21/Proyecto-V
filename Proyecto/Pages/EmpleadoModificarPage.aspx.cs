using Proyecto.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Pages
{
    public partial class EmpleadoModificarPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarListaDepartamento();

            LlenarListaJerarquia();

            CargarInformacionDeCliente();
        }

        private void CargarInformacionDeCliente()
        {
            int idempleado = Convert.ToInt32(Request.QueryString["id"]);
            TxtEmpleadoID.Text = idempleado.ToString();

            try
            {
                using (ProyectoEntities db = new ProyectoEntities())
                {
                    var datosEmpleado = db.SPEmpleadoConsultarPorID(idempleado).FirstOrDefault();

                    if (datosEmpleado != null)
                    {

                        TxtNombre.Text = datosEmpleado.Nombre;
                        TxtApellido.Text = datosEmpleado.Apellido;
                        TxtCedula.Text = datosEmpleado.Cedula;
                        TxtTelefono.Text = datosEmpleado.Telefono;
                        TxtCorreo.Text = datosEmpleado.CorreoElectronico;

                        //vamos a seleccionar el rol que tiene actualmente el +
                        //usuario

                        string idDepartemento = datosEmpleado.DepartamentoID.ToString();
                        string idJerarquia = datosEmpleado.JerarquiaID.ToString();

                        DdlDepartamento.Items.FindByValue(idDepartemento).Selected = true;
                        DdlJerarquia.Items.FindByValue(idJerarquia).Selected = true;
                    }
                }

            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/Error.aspx");
            }
        }

        private void LlenarListaDepartamento()
        {
            try
            {
                //esta sera la lista que va a almacenar los datos
                //del SP para luego usarla en el dropdownlist
                var ListaDepartamento = new List<ListItem>();

                using (ProyectoEntities db = new ProyectoEntities())
                {
                    //ahora vamos a usar un linq para invocar al sp y asignar los
                    //valores necesarios para que funcione el dropdownlist


                    //usamos LINQ para hacer consultas similares las que hemos hecho
                    //con T-SQL, los clasicos SELECT FORM de las base de datos.
                    //Estas consultas las podemos hacer directamente en el codigo
                    //usando COLECCIONES que sean consultables.

                    var query = (from lr in db.SPEmpleadoDepartamento()
                                 select new ListItem
                                 {
                                     Value = lr.id.ToString(),
                                     Text = lr.descrip
                                 }
                                ).ToList();
                    //aca lo que hacemos es incorporar cada posible resultado
                    //a la variable que usamos para el datasource del dropdownlist
                    ListaDepartamento.AddRange(query);

                    //y ahora hacer el binding entre la lista y el ddl
                    DdlDepartamento.DataTextField = "Text";
                    DdlDepartamento.DataValueField = "Value";

                    DdlDepartamento.DataSource = ListaDepartamento;
                    DdlDepartamento.DataBind();

                }

            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }

        private void LlenarListaJerarquia()
        {
            try
            {
                //esta sera la lista que va a almacenar los datos
                //del SP para luego usarla en el dropdownlist
                var ListaJerarquia = new List<ListItem>();

                using (ProyectoEntities db = new ProyectoEntities())
                {
                    //ahora vamos a usar un linq para invocar al sp y asignar los
                    //valores necesarios para que funcione el dropdownlist


                    //usamos LINQ para hacer consultas similares las que hemos hecho
                    //con T-SQL, los clasicos SELECT FORM de las base de datos.
                    //Estas consultas las podemos hacer directamente en el codigo
                    //usando COLECCIONES que sean consultables.

                    var query = (from lr in db.SPEmpleadoJerarquia()
                                 select new ListItem
                                 {
                                     Value = lr.id.ToString(),
                                     Text = lr.descrip
                                 }
                                ).ToList();
                    //aca lo que hacemos es incorporar cada posible resultado
                    //a la variable que usamos para el datasource del dropdownlist
                    ListaJerarquia.AddRange(query);

                    //y ahora hacer el binding entre la lista y el ddl
                    DdlJerarquia.DataTextField = "Text";
                    DdlJerarquia.DataValueField = "Value";

                    DdlJerarquia.DataSource = ListaJerarquia;
                    DdlJerarquia.DataBind();

                }

            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idempleado = Convert.ToInt32(TxtEmpleadoID.Text.Trim());
                string nombre = TxtNombre.Text.Trim();
                string apellido = TxtApellido.Text.Trim();
                string cedula = TxtCedula.Text.Trim();
                string telefono = TxtTelefono.Text.Trim();
                string correo = TxtCorreo.Text.Trim();

                int iddepartamento = Convert.ToInt32(DdlDepartamento.SelectedItem.Value);
                int idjerarquia = Convert.ToInt32(DdlJerarquia.SelectedItem.Value);

                //llamamos al sp de modificacion de usuario
                using (ProyectoEntities db = new ProyectoEntities())
                {
                    db.SPEmpleadoModificar(idempleado, nombre, apellido, cedula, telefono, correo, iddepartamento, idjerarquia);
                }

            }
            catch (Exception)
            {

                Response.Redirect("~/Pages/Error.aspx");
            }

            Response.Redirect("ExitoModificarEmpleado.aspx");
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idempleado = Convert.ToInt32(TxtEmpleadoID.Text.Trim());

                using (ProyectoEntities db = new ProyectoEntities())
                {
                    db.SPEmpleadoEliminar(idempleado);
                }
            }
            catch (Exception)
            {

                Response.Redirect("Error.aspx");
            }
            Response.Redirect("ExitoEliminarEmpleado.aspx");
        }
    }
}