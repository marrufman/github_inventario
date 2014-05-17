using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioEscritorio
{
    public partial class CargaLote : Form
    {
        public CargaLote()
        {
            funciones fn = new funciones();
            InitializeComponent();
            if (login.id_perfil == 0)
            {
                MessageBox.Show("Acceso Denegado.");
                this.Close();
                return;
            }
            //leemos xml
            DataSet ds = new DataSet();
            ds = fn.MuestraProductosCapturados();
            //validamos que no esta vacio
            if (ds != null)
            {
                //inicializamos progress bar
                progressBar1.Minimum = 0;
                progressBar1.Maximum = ds.Tables[0].Rows.Count;

                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    //cargamos fila si no se ha cargado antes
                    if (Convert.ToInt32(fila["cargado"])==0)
                    { 
                        fn.CargaLote(login.id_usuario.ToString(), fila["nombre_ruta"].ToString(), fila["nombre_pv"].ToString(),
                            fila["direccion_pv"].ToString(),fila["descripcion_pv"].ToString(),
                            fila["nombre_producto"].ToString(), fila["atributo"].ToString(),
                            fila["valor"].ToString());
                        //actualizamos estatus para no cargarla nuevamente
                        ds.Tables[0].Rows[progressBar1.Value]["cargado"] = 1;
                        fn.UpdateXMLCarga(ds);
                    }
                    progressBar1.Value = progressBar1.Value + 1;
                    Application.DoEvents();
                }
                progressBar1.Value = ds.Tables[0].Rows.Count;
                MessageBox.Show("Se cargo la informacion Correctamente.");
                label1.Text = "Finalizado.";
                //borramos xml
                fn.BorraXMLCarga();
            }
            else
            {
                MessageBox.Show("No hay Datos que cargar.");
                label1.Text = "";
            }
        }
    }
}
