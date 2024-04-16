using Proyecto.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Pages
{
    public partial class ClienteAgregarPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarListaTipoCliente();
            }
        }

        private void LlenarListaTipoCliente()
        {
            try
            {
                //esta sera la lista que va a almacenar los datos
                //del SP para luego usarla en el dropdownlist
                var ListaTipoCLiente = new List<ListItem>();

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
                    ListaTipoCLiente.AddRange(query);

                    //y ahora hacer el binding entre la lista y el ddl
                    DdlTipoCliente.DataTextField = "Text";
                    DdlTipoCliente.DataValueField = "Value";

                    DdlTipoCliente.DataSource = ListaTipoCLiente;
                    DdlTipoCliente.DataBind();

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

            int idtipo = Convert.ToInt32(DdlTipoCliente.SelectedItem.Value);

            try
            {
                using (ProyectoEntities db = new ProyectoEntities())
                {
                    db.SPClienteAgregar(nombre, apellido, cedula, telefono, correo, idtipo);
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/Error.aspx");
            }

            Response.Redirect("~/Pages/ExitoAgregarCliente.aspx");
        }
    }
}