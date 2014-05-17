using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Default.aspx
{
    public partial class capturaProducto : System.Web.UI.Page
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
                ds = servicio.ObtieneDetalleProducto(Convert.ToString(Session["id_producto"]));
                if (ds == null || ds.Tables[0].Rows.Count == 0)
                {
                    Label1.Text = "No hay caracteristicas para el producto "+Convert.ToString(Session["nombre_producto"]);
                }
                else
                {
                    Label1.Text = Convert.ToString(Session["nombre_producto"]);
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                    GridView1.Caption = "Atributos Capturados de producto: " + Convert.ToString(Session["nombre_producto"]);
                }
                //llenamos el dropdownlist
                DataSet dsddl = new DataSet();
                dsddl = servicio.ObtieneAtribDisponibles(Convert.ToString(Session["id_producto"]));
                DD_id_atributo_producto.DataSource = dsddl;
                //DD_id_atributo_producto.DataMember = "atributos";
                DD_id_atributo_producto.DataValueField = "id_atributo";
                DD_id_atributo_producto.DataTextField = "nombre_atributo";
                DD_id_atributo_producto.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //se guarda la informacion del producto
            servicio.CapturarProducto(Convert.ToString(Session["id_producto"]), Convert.ToString(DD_id_atributo_producto.SelectedValue), TextBoxValorAtributo.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("detallePuntoVenta.aspx");
        }
    }
}