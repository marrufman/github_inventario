using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Default.aspx
{
    public partial class EditarRuta : System.Web.UI.Page
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
                //llenamos el dropdownlistde promotores
                DataSet dsddl = new DataSet();
                dsddl = servicio.ObtieneTodosPromotores();
                DropDownListPromotor.DataSource = dsddl;
                DropDownListPromotor.DataValueField = "id_usuario";
                DropDownListPromotor.DataTextField = "nombre_usuario";
                DropDownListPromotor.DataBind();
                //ponemos los valores en el formulario
                TextBoxNombreRuta.Text = Session["nombre_ruta"].ToString();
                CalendarFecha.SelectedDate = Convert.ToDateTime(Session["fecha"].ToString());
                CalendarFecha.VisibleDate = Convert.ToDateTime(Session["fecha"].ToString());
                DropDownListEstado.SelectedValue = Session["estatus"].ToString();
                //DropDownListPromotor.SelectedItem.Text = Session["nombre_usuario"].ToString();
                DataSet dsnombre = new DataSet();
                dsnombre= servicio.ObtieneIdUsuarioPorNombre(Session["nombre_usuario"].ToString());
                DropDownListPromotor.SelectedValue = dsnombre.Tables[0].Rows[0]["id_usuario"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            servicio.EditaRuta(Session["id_ruta"].ToString(),TextBoxNombreRuta.Text,CalendarFecha.SelectedDate.ToString("yyyy/MM/dd"),
                DropDownListEstado.SelectedValue.ToString(), DropDownListPromotor.SelectedValue.ToString());
            Response.Redirect("AltaRutas.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaRutas.aspx");
        }
    }
}