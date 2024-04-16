using Proyecto.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Pages
{
    public partial class ClienteModificarPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {

                LlenarListaTipoCliente();

                CargarInformacionDeCliente();

            }
        }

        private void CargarInformacionDeCliente()
        {
            int idcliente = Convert.ToInt32(Request.QueryString["id"]);
            TxtClienteID.Text = idcliente.ToString();

            try
            {
                using (ProyectoEntities db = new ProyectoEntities())
                {
                    var datosCliente = db.SPClienteConsultarPorID(idcliente).FirstOrDefault();

                    if (datosCliente != null)
                    {

                        TxtNombre.Text = datosCliente.Nombre;
                        TxtApellido.Text = datosCliente.Apellido;
                        TxtCedula.Text = datosCliente.Cedula;
                        TxtTelefono.Text = datosCliente.Telefono;
                        TxtEmail.Text = datosCliente.CorreoElectronico;

                        //vamos a seleccionar el rol que tiene actualmente el +
                        //usuario

                        string idTipo = datosCliente.TipoClienteID.ToString();

                        DdlTipoCliente.Items.FindByValue(idTipo).Selected = true;
                    }
                }

            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/Error.aspx");
            }
        }

        private void LlenarListaTipoCliente()
        {
            try
            {
                //esta sera la lista que va a almacenar los datos
                //del SP para luego usarla en el dropdownlist
                var ListaTipoCliente = new List<ListItem>();

                using (ProyectoEntities db = new ProyectoEntities())
                {
                    //ahora vamos a usar un linq para invocar al sp y asignar los
                    //valores necesarios para que funcione el dropdownlist


                    //usamos LINQ para hacer consultas similares las que hemos hecho
                    //con T-SQL, los clasicos SELECT FORM de las base de datos.
                    //Estas consultas las podemos hacer directamente en el codigo
                    //usando COLECCIONES que sean consultables.

                    var query = (from lr in db.SPClienteTipo()
                                 select new ListItem
                                 {
                                     Value = lr.id.ToString(),
                                     Text = lr.descrip
                                 }
                                ).ToList();
                    //aca lo que hacemos es incorporar cada posible resultado
                    //a la variable que usamos para el datasource del dropdownlist
                    ListaTipoCliente.AddRange(query);

                    //y ahora hacer el binding entre la lista y el ddl
                    DdlTipoCliente.DataTextField = "Text";
                    DdlTipoCliente.DataValueField = "Value";

                    DdlTipoCliente.DataSource = ListaTipoCliente;
                    DdlTipoCliente.DataBind();

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
                int idcliente = Convert.ToInt32(TxtClienteID.Text.Trim());
                string nombre = TxtNombre.Text.Trim();
                string apellido = TxtApellido.Text.Trim();
                string cedula = TxtCedula.Text.Trim();
                string telefono = TxtTelefono.Text.Trim();
                string email = TxtEmail.Text.Trim();

                int idtipo = Convert.ToInt32(DdlTipoCliente.SelectedItem.Value);

                //llamamos al sp de modificacion de usuario
                using (ProyectoEntities db = new ProyectoEntities())
                {
                    db.SPClienteModificar(idcliente, nombre, apellido, cedula, telefono, email, idtipo);
                }

            }
            catch (Exception)
            {

                Response.Redirect("~/Pages/Error.aspx");
            }

            Response.Redirect("ExitoModificarCliente.aspx");
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idcliente = Convert.ToInt32(TxtClienteID.Text.Trim());

                using (ProyectoEntities db = new ProyectoEntities())
                {
                    db.SPClienteEliminar(idcliente);
                }
            }
            catch (Exception)
            {

                Response.Redirect("Error.aspx");
            }
            Response.Redirect("ExitoEliminarCliente.aspx");
        }


    }
}