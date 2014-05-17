using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Default.aspx
{
    public partial class EditarPuntoVenta : System.Web.UI.Page
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
                //llenamos el formulario
                TextBoxNombrePV.Text = Session["nombre_pv"].ToString();
                TextBoxDireccion.Text=Session["direccion_pv"].ToString();
                TextBoxDescripcion.Text=Session["descripcion"].ToString();

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaPuntosVenta.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            servicio.EditaPuntoVenta(Session["id_punto_venta"].ToString(), TextBoxNombrePV.Text, TextBoxDireccion.Text, TextBoxDescripcion.Text);
            Response.Redirect("AltaPuntosVenta.aspx");
        }

    }
}