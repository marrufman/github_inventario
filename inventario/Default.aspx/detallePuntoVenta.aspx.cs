using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Default.aspx
{
    public partial class detallePuntoVenta : System.Web.UI.Page
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
                ds = servicio.ObtieneProductosPV(Convert.ToString(Session["id_punto_venta"]));
                if (ds == null || ds.Tables[0].Rows.Count == 0)
                {
                    Label1.Text = "No hay registros de Productos para este Punto de Venta.";
                }
                else
                {
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                    GridView1.Caption = "Productos de Punto de Venta " + Convert.ToString(Session["nombre_pv"]);
                }
                //llenamos el dropdownlist
                DataSet dsddl = new DataSet();
                dsddl = servicio.ObtieneProductosDisponibles(Convert.ToString(Session["id_punto_venta"]));
                DD_id_producto.DataSource = dsddl;
                //DD_id_atributo_producto.DataMember = "atributos";
                DD_id_producto.DataValueField = "id_cat_producto";
                DD_id_producto.DataTextField = "nombre_producto";
                DD_id_producto.DataBind();
            }
            
        }
        protected void botonesSeleccion(object sender, GridViewCommandEventArgs e)
        {
            //obtenemos el indice de la fila con el argumento del comando
            double Num;
            bool isNum = double.TryParse(e.CommandArgument.ToString(), out Num);
            if (isNum)
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                // obtenemos la fila del grid donde el boton se presiono
                GridViewRow selectedRow = ((GridView)e.CommandSource).Rows[index];
                // enviamos el valor de la fila en la posicion deseada a una variable 
                int id_producto = Convert.ToInt16(selectedRow.Cells[0].Text);
                string nombre_producto = Convert.ToString(selectedRow.Cells[1].Text);
                ////creamos una variable de session con el id_producto del registro que vamos a mandar
                if (Session["id_producto"] != null)
                {
                    Session.Remove("id_producto");
                    Session.Remove("nombre_producto");
                }
                Session.Add("id_producto", id_producto);
                Session.Add("nombre_producto", nombre_producto);
            }
            if (e.CommandName == "capturar")
            {
                Response.Redirect("capturaProducto.aspx");

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Asignamos el producto a la tienda
            servicio.AsignaProductoPV(DD_id_producto.SelectedValue, Convert.ToString(Session["id_punto_venta"]));
            Response.Redirect(Request.RawUrl);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("detalleruta.aspx");
        }

        
    }
}