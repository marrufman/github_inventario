using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Default.aspx
{
    public partial class AltaRutas : System.Web.UI.Page
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
                ds = servicio.ObtieneTodasRutas();
                if (ds == null || ds.Tables[0].Rows.Count == 0)
                {
                    Label1.Text = "No hay registros de rutas.";
                }
                else
                {
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
                //ponemos la fecha de hoy en el calendario
                CalendarFecha.SelectedDate = DateTime.Today;
                CalendarFecha.VisibleDate = DateTime.Today;

                //llenamos el dropdownlistde promotores
                DataSet dsddl = new DataSet();
                dsddl = servicio.ObtieneTodosPromotores();
                DropDownListPromotor.DataSource = dsddl;
                DropDownListPromotor.DataValueField = "id_usuario";
                DropDownListPromotor.DataTextField = "nombre_usuario";
                DropDownListPromotor.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            servicio.AddRuta(TextBoxNombreRuta.Text, CalendarFecha.SelectedDate.ToString("yyyy/MM/dd"), DropDownListPromotor.SelectedValue.ToString());
            Response.Redirect(Request.RawUrl);
        }
        protected void botonesSeleccion(object sender, GridViewCommandEventArgs e)
        {
            //obtenemos el indice de la fila con el argumento del comando
            double Num;
            bool isNum = double.TryParse(e.CommandArgument.ToString(), out Num);
            if (isNum)
            {
                int estatus;
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                // obtenemos la fila del grid donde el boton se presiono
                GridViewRow selectedRow = ((GridView)e.CommandSource).Rows[index];
                // enviamos el valor de la fila en la posicion deseada a una variable 
                int id_ruta = Convert.ToInt16(selectedRow.Cells[0].Text);
                String nombre_ruta = Convert.ToString(selectedRow.Cells[1].Text);
                String fecha = Convert.ToString(selectedRow.Cells[2].Text);
                if (selectedRow.Cells[3].Text == "True")
                {
                    estatus = 1;
                }
                else
                {
                    estatus = 0;
                }
                String nombre_usuario = Convert.ToString(selectedRow.Cells[4].Text);
                //si viene nulo el nombre_de usuario
                if(nombre_usuario=="&nbsp;")
                {
                    nombre_usuario = "";
                }
                //creamos una variable de session con el id_pto venta del registro que vamos a mandar
                if (Session["id_ruta"] != null)
                {
                    Session.Remove("id_ruta");
                    Session.Remove("nombre_ruta");
                    Session.Remove("fecha");
                    Session.Remove("estatus");
                    Session.Remove("nombre_usuario");
                }
                Session.Add("id_ruta", id_ruta);
                Session.Add("nombre_ruta", nombre_ruta);
                Session.Add("fecha", fecha);
                Session.Add("estatus", estatus);
                Session.Add("nombre_usuario", nombre_usuario);
            }
            if (e.CommandName == "editar")
            {
                Response.Redirect("EditarRuta.aspx");
            }
            if (e.CommandName == "borrar")
            {
                servicio.BorraRuta(Session["id_ruta"].ToString());
                Response.Redirect(Request.RawUrl);
            } 
            if (e.CommandName == "configurar")
            {
                Response.Redirect("ConfigPuntosVenta.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admon.aspx");
        }
    }
}