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
    public partial class Rutas : Form
    {
        public static int id_ruta;
        public static string nombre_ruta;
        public Rutas()
        {
            InitializeComponent();
            if (login.id_perfil == null|| login.id_perfil==0)
            {
                MessageBox.Show("Acceso Denegado.");
                this.Close();
                return;
            }
            ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
            DataSet ds = new DataSet();
            ds = servicio.ObtieneRutas(login.id_usuario.ToString());
            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No hay registros de Rutas para el usuario.");
            }
            else
            {
                label1.Text = "Rutas del Promotor " + login.nombreCompleto;
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "#";
                dataGridView1.Columns[1].HeaderText = "Nombre Ruta";
                dataGridView1.Columns[2].HeaderText = "Fecha";
                dataGridView1.Columns[3].HeaderText = "Estatus";
                dataGridView1.Columns[3].ValueType = typeof(String);
                dataGridView1.Refresh();
                Application.DoEvents();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                id_ruta = Convert.ToInt32(selectedRow.Cells["id_ruta"].Value);
                nombre_ruta = Convert.ToString(selectedRow.Cells["nombre_ruta"].Value);
                //salto entre formularios 
                PuntosVenta frmHijo = new PuntosVenta();
                frmHijo.MdiParent = this.ParentForm;
                frmHijo.Show();
                this.Close();
            }
        }
    }
}
