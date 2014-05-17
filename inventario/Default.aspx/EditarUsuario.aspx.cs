using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Default.aspx
{
    public partial class EditarUsuario : System.Web.UI.Page
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
                //llenamos el dropdownlist
                DataSet dsddl = new DataSet();
                dsddl = servicio.ObtienePerfiles();
                DropDownListPerfil.DataSource = dsddl;
                DropDownListPerfil.DataValueField = "id_perfil";
                DropDownListPerfil.DataTextField = "nombre_perfil";
                DropDownListPerfil.DataBind();
                //llenamos los campos del formulario con los datos a editar
                TextBoxlogin.Text = Session["nombre_usuario"].ToString();
                TextBoxPassword.Text = Session["password"].ToString();
                TextBoxEmail.Text = Session["email"].ToString();
                DropDownList1Estado.SelectedValue= Session["estatus"].ToString();
                //DropDownListPerfil.SelectedItem.Text= Session["perfil"].ToString();
                DataSet dsperfil = new DataSet();
                dsperfil = servicio.ObtieneIdPerfilPorNombre(Session["perfil"].ToString());
                DropDownListPerfil.SelectedValue = dsperfil.Tables[0].Rows[0]["id_perfil"].ToString();
                TextBoxNombre.Text = Session["nombre"].ToString();
                TextBoxApellidos.Text = Session["apellidos"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            servicio.EditaUsuario(Session["id_usuario"].ToString(), TextBoxlogin.Text, TextBoxPassword.Text,
                TextBoxEmail.Text, DropDownList1Estado.SelectedValue.ToString(), DropDownListPerfil.SelectedValue.ToString(),
                TextBoxNombre.Text, TextBoxApellidos.Text);
            Response.Redirect("AltaUsuarios.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaUsuarios.aspx");
        }
    }
}