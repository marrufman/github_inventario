using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Default.aspx
{
    public partial class Rutas : System.Web.UI.Page
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
                ds = servicio.ObtieneRutas(Convert.ToString(Session["uid"]));
                if (ds == null || ds.Tables[0].Rows.Count == 0)
                {
                    Label1.Text = "No hay registros de Rutas para el usuario.";
                }
                else
                {
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                    GridView1.Caption = "Rutas del Promotor " + Convert.ToString(Session["nombre"]);
                }
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
                    int id_ruta = Convert.ToInt16(selectedRow.Cells[0].Text);
                    string nombre_ruta = Convert.ToString(selectedRow.Cells[1].Text);
                    //creamos una variable de session con el id_ruta del registro que vamos a mandar
                    if(Session["id_ruta"]!=null)
                    {
                        Session.Remove("id_ruta");
                        Session.Remove("nombre_ruta");
                    }
                    Session.Add("id_ruta", id_ruta);
                    Session.Add("nombre_ruta", nombre_ruta);
            }
            if (e.CommandName == "detalle")
            {
                Response.Redirect("detalleruta.aspx");

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("ValidaProductos.aspx");
        }
    }
}