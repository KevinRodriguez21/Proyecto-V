using Proyecto.Class;
using Proyecto.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Pages
{
    public partial class DetalleSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["objeto"] == null)
            {
                Response.Redirect("~/Pages/Sesion.aspx");
            }

            // Obtener los datos del usuario de la sesión y mostrarlos en las etiquetas correspondientes
            var objPersona = (UsuarioData)Session["objeto"];
            lblObjUsuario.Text = objPersona.Usuario;
            lblObjContrasennia.Text = objPersona.Contrasennia;

        }
    }
}