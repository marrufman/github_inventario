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
    public partial class PuntosVenta : Form
    {
        public static int id_punto_venta;
        public static string nombre_pv;
        public PuntosVenta()
        {
            InitializeComponent();
            ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
            DataSet ds = new DataSet();
            ds = servicio.ObtienePuntosVenta(Rutas.id_ruta.ToString());
            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No hay registros de Puntos de Venta para la ruta.");
            }
            else
            {
                label1.Text = "Puntos de venta de la ruta: " + Rutas.nombre_ruta;
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "#";
                dataGridView1.Columns[1].HeaderText = "Nombre";
                dataGridView1.Columns[2].HeaderText = "Direccion";
                dataGridView1.Columns[3].HeaderText = "Descripcion";
                dataGridView1.Refresh();
                Application.DoEvents();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rutas frmHijo = new Rutas();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.WindowState = FormWindowState.Maximized;
            frmHijo.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                id_punto_venta = Convert.ToInt32(selectedRow.Cells["id_punto_venta"].Value);
                nombre_pv = Convert.ToString(selectedRow.Cells["nombre_pv"].Value);
                //salto entre formularios 
                Productos frmHijo = new Productos();
                frmHijo.MdiParent = this.ParentForm;
                frmHijo.Show();
                this.Close();
            }
        }
    }
}
