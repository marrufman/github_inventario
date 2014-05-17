using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Net.Mail;

namespace Default.aspx
{
    public partial class Default : System.Web.UI.Page
    {
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet uid = new DataSet();
            try
            {
                uid = servicio.AccesoPortal(TextBoxUsr.Text, TextBoxPess.Text);
            }
            catch (Exception ex)
            {
                
                Label1.Text="El Servicio de Datos no esta disponible "+ ex.ToString();
                return;
            }
            
            if (uid != null && uid.Tables[0].Rows.Count!= 0)
            {
                //verificamos el estatus del usuario si esta inactivo no entra al sistema
                if (Convert.ToInt32(uid.Tables[0].Rows[0]["status"]) == 0)
                {
                    Label1.Text = "Falla de acceso.";
                    return;
                }
                //creamos variables de session con el id de usuario
                Session["uid"] = uid.Tables[0].Rows[0]["id_usuario"];
                Session["nombre"] = uid.Tables[0].Rows[0]["nombre"] + " " + uid.Tables[0].Rows[0]["apellidos"];
                Session["usr"] = uid.Tables[0].Rows[0]["nombre_usuario"];
                //verificamos el perfil del usuario y en base a eso decidimos que se muestra
                int perfil = Convert.ToInt32(uid.Tables[0].Rows[0]["id_perfil"]);
                switch (perfil)
                {
                    case 1:
                        Response.Redirect("Admon.aspx");
                        break;
                    case 2:
                        Response.Redirect("Rutas.aspx");
                        break;
                    default:
                        Console.WriteLine("Default.aspx");
                        break;
                }
            }
            else
            {
                Label1.Text = "Usuario o Contraseña incorrecto";
                Label2.Visible = true;
                emailPass.Visible = true;
                Button2.Visible = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = servicio.ObtienePassword(emailPass.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
                //se envia la contraseña al usuario
                negocio fn = new negocio();
              //  fn.email("Recuperacion de Contraseña",ds.Tables[0].Rows[0].ItemArray[3].ToString(),"Su contraseña es: "+ds.Tables[0].Rows[0].ItemArray[2].ToString());
                Label1.Text = "Contraseña Enviada";
            }
            else
            {
                Label1.Text = "Error al recuperar contraseña";
            }
        }
    }
}