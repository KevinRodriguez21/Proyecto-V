using Proyecto.DbContext;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
            
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasennia = txtContrasennia.Text;

            // Conexión a la base de datos y llamada al procedimiento almacenado
            using (ProyectoEntities db = new ProyectoEntities())
            {
                try
                {
                    int resultado = db.SPUsuarioValidar(usuario, contrasennia).FirstOrDefault() ?? 0;

                    if (resultado == 1)
                    {
                        // Iniciar sesión
                        Session["Usuario"] = usuario;
                        Response.Redirect("~/Pages/Opciones.aspx"); // Página de bienvenida
                    }
                    else
                    {
                        lblMensaje.Text = "Usuario o contraseña incorrectos.";
                    }
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error al intentar iniciar sesión: " + ex.Message;
                }
            }
        }

    }
}