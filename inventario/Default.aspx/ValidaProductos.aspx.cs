using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Default.aspx
{
    public partial class ValidaProductos : System.Web.UI.Page
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
                ds = servicio.ObtieneLoteOffline(Session["uid"].ToString());
                if (ds == null || ds.Tables[0].Rows.Count == 0)
                {
                    Label1.Text = "No hay registros de productos.";
                }
                else
                {
                    Label1.Text = "Productos Capturados por el usuario "+Session["nombre"].ToString();
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
            }
        }
    }
}