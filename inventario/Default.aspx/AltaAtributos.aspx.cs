using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Default.aspx
{
    public partial class AltaAtributos : System.Web.UI.Page
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
                ds = servicio.ObtieneTodosAtributos();
                if (ds == null || ds.Tables[0].Rows.Count == 0)
                {
                    Label1.Text = "No hay registros de atributos.";
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
            servicio.AddAtribProducto(TextBoxNuevoAtributo.Text);
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
                int id_atributo = Convert.ToInt16(selectedRow.Cells[0].Text);
                String nombre_atributo = Convert.ToString(selectedRow.Cells[1].Text);
                //creamos una variable de session con el id_pto venta del registro que vamos a mandar
                if (Session["id_atributo"] != null)
                {
                    Session.Remove("id_atributo");
                    Session.Remove("nombre_atributo");
                }
                Session.Add("id_atributo", id_atributo);
                Session.Add("nombre_atributo", nombre_atributo);
            }
            if (e.CommandName == "editar")
            {
                Response.Redirect("EditarAtributo.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admon.aspx");
        }
    }
}