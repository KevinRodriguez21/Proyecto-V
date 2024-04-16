using Proyecto.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Pages
{
    public partial class EmpleadoAgregarPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarListaDepartamento();
                LlenarListaJerarqia();
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

        private void LlenarListaJerarqia()
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

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            //primero vamos a capturar en varibles locales los valores
            //digitados en la pagina.
            string nombre = TxtNombre.Text.Trim();
            string apellido = TxtApellido.Text.Trim();
            string cedula = TxtCedula.Text.Trim();
            string telefono = TxtTelefono.Text.Trim();
            string correo = TxtCorreo.Text.Trim();

            int idDepartamento = Convert.ToInt32(DdlDepartamento.SelectedItem.Value);
            int idJerarquia = Convert.ToInt32(DdlJerarquia.SelectedItem.Value);

            try
            {
                using (ProyectoEntities db = new ProyectoEntities())
                {
                    db.SPEmpleadoAgregar(nombre, apellido, cedula, telefono, correo, idDepartamento, idJerarquia);
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/Error.aspx");
            }

            Response.Redirect("~/Pages/ExitoAgregarEmpleado.aspx");
        }
    }
}