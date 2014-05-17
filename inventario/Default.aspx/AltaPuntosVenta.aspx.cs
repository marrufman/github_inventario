using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Default.aspx
{
    public partial class AltaPuntosVenta : System.Web.UI.Page
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
                 ds = servicio.ObtieneTodosPuntosVenta();
                 if (ds == null || ds.Tables[0].Rows.Count == 0)
                 {
                     Label1.Text = "No hay registros de puntos de venta.";
                 }
                 else
                 {
                     GridView1.DataSource = ds;
                     GridView1.DataBind();
                 }
             }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            servicio.AltaPuntoVenta(TextBoxNombrePV.Text, TextBoxDireccion.Text, TextBoxDescripcion.Text);
            Response.Redirect(Request.RawUrl);
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
                String nombre_pv = Convert.ToString(selectedRow.Cells[1].Text);
                String direccion_pv = Convert.ToString(selectedRow.Cells[2].Text);
                String descripcion = Convert.ToString(selectedRow.Cells[3].Text);
                //creamos una variable de session con el id_pto venta del registro que vamos a mandar
                if (Session["id_punto_venta"] != null)
                {
                    Session.Remove("id_punto_venta");
                    Session.Remove("nombre_pv");
                    Session.Remove("direccion_pv");
                    Session.Remove("descripcion");
                }
                Session.Add("id_punto_venta", id_punto_venta);
                Session.Add("nombre_pv", nombre_pv);
                Session.Add("direccion_pv", direccion_pv);
                Session.Add("descripcion", descripcion);
            }
            if (e.CommandName == "editar")
            {
                Response.Redirect("EditarPuntoVenta.aspx");
            }
            if (e.CommandName == "borrar")
            {
                servicio.BorrarPuntoVenta(Session["id_punto_venta"].ToString());
                Response.Redirect(Request.RawUrl);
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admon.aspx");
        }
    }
}