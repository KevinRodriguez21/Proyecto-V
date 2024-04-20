using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Pages
{
    public partial class Opciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/ListarClientePage.aspx");
        }

        protected void btnEmpleados_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/ListarEmpleadoPage.aspx");
        }
    }
}