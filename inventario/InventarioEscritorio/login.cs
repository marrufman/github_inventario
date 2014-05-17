using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace InventarioEscritorio
{
    public partial class login : Form
    {
        public static int id_usuario;
        public static string nombreCompleto;
        public static string nombre_usuario;
        public static int id_perfil;
        public static bool ws_flag;
        
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "Validando Usuario y contraseña.";
                ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();       
                DataSet uid = new DataSet();
                uid = servicio.AccesoPortal(textBoxUsr.Text,textBoxPass.Text);
                if (uid != null && uid.Tables[0].Rows.Count != 0)
                {
                    //verificamos el estatus del usuario si esta inactivo no entra al sistema
                    if (Convert.ToInt32(uid.Tables[0].Rows[0]["status"]) == 0)
                    {
                        MessageBox.Show( "Falla de acceso.");
                        return;
                    }
                    //creamos variables de session con el id de usuario
                    id_usuario= Convert.ToInt32(uid.Tables[0].Rows[0]["id_usuario"]);
                    nombreCompleto = uid.Tables[0].Rows[0]["nombre"].ToString() + " " + uid.Tables[0].Rows[0]["apellidos"].ToString();
                    nombre_usuario = uid.Tables[0].Rows[0]["nombre_usuario"].ToString();
                    //verificamos el perfil del usuario y en base a eso decidimos que se muestra
                    id_perfil = Convert.ToInt32(uid.Tables[0].Rows[0]["id_perfil"]);
                    if (id_perfil == 1)
                    {
                        //salto entre formularios 
                        AltaProductos frmHijo = new AltaProductos();
                        frmHijo.MdiParent = this.ParentForm;
                        frmHijo.Show();
                        frmHijo.WindowState = FormWindowState.Maximized;
                    
                    }
                    else 
                    {
                        Rutas frmHijo = new Rutas();
                        frmHijo.MdiParent = this.ParentForm;
                        frmHijo.Show();
                        frmHijo.WindowState = FormWindowState.Maximized;
                    }
                    //actualizamos - generamos catalogos XML
                    funciones fn = new funciones();
                    Thread p = new Thread(new ThreadStart(fn.leeCatalogosXML));
                    label1.Text = "Actualizando Catalogos de sistema.";
                    Application.DoEvents();
                    p.Start();
                    ws_flag = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Servicio de Datos no esta disponible ");
                ws_flag = false;
                //captura offline 
                CapturaOffline frmHijo = new CapturaOffline();
                frmHijo.MdiParent = this.ParentForm;
                frmHijo.Show();
                frmHijo.WindowState = FormWindowState.Maximized;
            }
        }

    }
}
