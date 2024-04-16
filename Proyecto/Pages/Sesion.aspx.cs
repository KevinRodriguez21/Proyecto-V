using Proyecto.DbContext;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Pages
{
    public partial class Sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/DetalleSesion.aspx");
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string usuario = txtUsuario.Text;
            //    string contrasena = txtContrasennia.Text;

            //    Llama al procedimiento almacenado para verificar las credenciales
            //    using (ProyectoEntities db = new ProyectoEntities())
            //    {
            //        Verifica si las credenciales son válidas
            //        var Lista = db.SpUsuariosListar().ToList();
            //        var resultado = db.SpUsuariosListar().FirstOrDefault(u => u.Usuario == usuario && u.Contrasennia == contrasena);
            //        GvListaUsuarios.DataSource = Lista;
            //        GvListaUsuarios.DataBind();

            //        if (resultado != null)
            //        {
            //            // Credenciales válidas, iniciar sesión
            //            Session["objeto"] = resultado;
            //            Response.Redirect("~/Pages/DetalleSesion.aspx");
            //        }
            //        else
            //        {
            //            // Credenciales inválidas, muestra un mensaje de error
            //            //lblMensaje.Text = "Usuario o contraseña incorrectos.";
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    lblMensaje.Text = ex.Message;
            //}
        }

    }
}