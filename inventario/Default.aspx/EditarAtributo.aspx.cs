using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Default.aspx
{
    public partial class EditarAtributo : System.Web.UI.Page
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
                TextBoxAtributo.Text = Session["nombre_atributo"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            servicio.EditAtribProducto(Session["id_atributo"].ToString(), TextBoxAtributo.Text);
            Response.Redirect("AltaAtributos.aspx");
        }
    }
}