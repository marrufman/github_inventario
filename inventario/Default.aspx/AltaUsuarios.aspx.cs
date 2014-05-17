using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Default.aspx
{
    public partial class AltaUsuarios : System.Web.UI.Page
    {
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            if (!Page.IsPostBack)
            {
                DataSet ds = new DataSet();
                ds = servicio.ObtieneUsuarios();
                if (ds == null || ds.Tables[0].Rows.Count == 0)
                {
                    Label1.Text = "No hay registros de usuarios.";
                }
                else
                {
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
                //llenamos el dropdownlist
                DataSet dsddl = new DataSet();
                dsddl = servicio.ObtienePerfiles();
                DropDownListPerfil.DataSource = dsddl;
                DropDownListPerfil.DataValueField = "id_perfil";
                DropDownListPerfil.DataTextField = "nombre_perfil";
                DropDownListPerfil.DataBind();
            }
        }
        protected void botonesSeleccion(object sender, GridViewCommandEventArgs e)
        {
            //obtenemos el indice de la fila con el argumento del comando
            double Num;
            bool isNum = double.TryParse(e.CommandArgument.ToString(), out Num);
            if (isNum)
            {
                int estatus;
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                // obtenemos la fila del grid donde el boton se presiono
                GridViewRow selectedRow = ((GridView)e.CommandSource).Rows[index];
                // enviamos el valor de la fila en la posicion deseada a una variable 
                int id_usuario = Convert.ToInt16(selectedRow.Cells[0].Text);
                String nombre_usuario = Convert.ToString(selectedRow.Cells[1].Text);
                String nombre = Convert.ToString(selectedRow.Cells[2].Text);
                String apellidos = Convert.ToString(selectedRow.Cells[3].Text);
                String email = Convert.ToString(selectedRow.Cells[4].Text);
                if (selectedRow.Cells[5].Text == "True")
                {
                    estatus = 1;
                }
                else
                {
                    estatus = 0;
                }
                String perfil = Convert.ToString(selectedRow.Cells[6].Text);
                string password = Convert.ToString(selectedRow.Cells[7].Text);
                //creamos una variable de session con el id_pto venta del registro que vamos a mandar
                if (Session["id_usuario"] != null)
                {
                    Session.Remove("id_usuario");
                    Session.Remove("nombre_usuario");
                    Session.Remove("email");
                    Session.Remove("estatus");
                    Session.Remove("nombre");
                    Session.Remove("apellidos");
                    Session.Remove("perfil");
                    Session.Remove("password");
                }
                Session.Add("id_usuario", id_usuario);
                Session.Add("nombre_usuario", nombre_usuario);
                Session.Add("email", email);
                Session.Add("estatus", estatus);
                Session.Add("nombre", nombre);
                Session.Add("apellidos", apellidos);
                Session.Add("perfil", perfil);
                Session.Add("password", password);
            }
            if (e.CommandName == "editar")
            {
                Response.Redirect("EditarUsuario.aspx");
            }
            if (e.CommandName == "borrar")
            {
                servicio.BajaUsuario(Convert.ToString(Session["id_usuario"]));
                Response.Redirect(Request.RawUrl);
            }
        }
            protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                servicio.AltaUsuario(TextBoxlogin.Text, TextBoxPassword.Text, TextBoxEmail.Text, DropDownListPerfil.SelectedValue.ToString(), TextBoxNombre.Text, TextBoxApellidos.Text);
                Label1.Text = "Usuario Guardado Exitosamente.";
                Response.Redirect(Request.RawUrl);
            }
            catch (Exception ex)
            {
                
                Label1.Text = "No se pudo guardar el usuario "+ex.ToString();
            }
        }

            protected void Button2_Click(object sender, EventArgs e)
            {
                Response.Redirect("Admon.aspx");
            }
    }

        
}