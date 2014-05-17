using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Default.aspx
{
    public partial class EditarProducto : System.Web.UI.Page
    {
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            if(!Page.IsPostBack)
            {
            TextBox1.Text = Convert.ToString(Session["nombre_producto"]);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaProductos.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            servicio.EditarProducto(TextBox1.Text, Convert.ToString(Session["id_cat_producto"]));
            Response.Redirect("AltaProductos.aspx");
        }
    }
}