using Proyecto.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Pages
{
    public partial class ListarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //La implementacion de using asegura que el objeto que se crea
                //Sea destruido automaticamente una vez que salimos del bloque de codigo
                //using
                using (ProyectoEntities db = new ProyectoEntities())
                {
                    //usamos el procedimiento almacenado para cargar una lista que se
                    //mostrara en el gridview de la pagina

                    var Lista = db.SPClientesListar().ToList();

                    GvListaClientes.DataSource = Lista;
                    GvListaClientes.DataBind();

                }

            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/Error.aspx");
            }
        }

        
    }
}