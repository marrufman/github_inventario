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
    public partial class AltaProductos : Form
    {
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        public static int id_cat_producto;
        public static string nombre_producto;
        public AltaProductos()
        {
            InitializeComponent();
            if (login.id_perfil != 1)
            {
                MessageBox.Show("Acceso Denegado.");
                this.Close();
                return;
            }
            DataSet ds = new DataSet();
            ds = servicio.ObtieneProductos();
            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No hay registros de Productos en el sistema.");
            }
            else
            {
                label1.Text = "Productos del Sistema: " + PuntosVenta.nombre_pv;
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "#";
                dataGridView1.Columns[1].HeaderText = "Nombre Producto";
                dataGridView1.Refresh();
                Application.DoEvents();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            id_cat_producto = Convert.ToInt32(selectedRow.Cells["id_cat_producto"].Value);
            nombre_producto = Convert.ToString(selectedRow.Cells["nombre_producto"].Value);
            //Salto A EditaPRoducto
            EditaProducto frmHijo = new EditaProducto();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            servicio.BorrarProducto(id_cat_producto.ToString());
            //refresca los datos
            AltaProductos frmHijo = new AltaProductos();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            servicio.AgregarProducto(textBoxNombreProducto.Text);
            //refresca los datos
            AltaProductos frmHijo = new AltaProductos();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
