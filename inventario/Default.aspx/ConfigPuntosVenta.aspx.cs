using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Default.aspx
{
    public partial class ConfigPuntosVenta : System.Web.UI.Page
    {
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
            {
                Response.Redirect("Default.aspx");
            }
                Label1.Text = Session["nombre_ruta"].ToString() + " " + Session["fecha"];
                //llenamos dataset para grids de disponibles y asignados
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();
                ds = servicio.ObtienePuntosVentaDisponibles(Session["id_ruta"].ToString());
                ds2 = servicio.ObtienePuntosVenta(Session["id_ruta"].ToString());
                GridView1.DataSource = ds2;
                GridView1.DataBind();
                GridView2.DataSource = ds;
                GridView2.DataBind();
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
                int id_punto_venta = Convert.ToInt16(selectedRow.Cells[0].Text);
                //creamos una variable de session con el id_pto venta del registro que vamos a mandar
                if (Session["id_punto_venta"] != null)
                {
                    Session.Remove("id_punto_venta");
                }
                Session.Add("id_punto_venta", id_punto_venta);
            }
            if (e.CommandName == "agregar")
            {
                servicio.AddRutaPuntoVenta(Session["id_ruta"].ToString(), Session["id_punto_venta"].ToString());
                Response.Redirect(Request.RawUrl);
            }
            if (e.CommandName == "eliminar")
            {
                servicio.BorraRutaPuntoVenta(Session["id_ruta"].ToString(), Session["id_punto_venta"].ToString());
                Response.Redirect(Request.RawUrl);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaRutas.aspx");
        }
    }
}