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
    public partial class Productos : Form
    {
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        public static int id_producto;
        public static string nombre_producto;
        public Productos()
        {
            InitializeComponent();
            DataSet ds = new DataSet();
            ds = servicio.ObtieneProductosPV(PuntosVenta.id_punto_venta.ToString());
            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No hay registros de Productos para el Punto de Venta.");
            }
            else
            {
                label1.Text = "Productos del Punto de Venta: " + PuntosVenta.nombre_pv;
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "#";
                dataGridView1.Columns[1].HeaderText = "Nombre Producto";
                dataGridView1.Refresh();
                Application.DoEvents();
            }
            //llenamos el dropdownlist
            DataSet dsddl = new DataSet();
            dsddl = servicio.ObtieneProductosDisponibles(PuntosVenta.id_punto_venta.ToString());
            comboBox1.DataSource = dsddl.Tables[0].DefaultView;
            comboBox1.DisplayMember = "nombre_producto";
            comboBox1.ValueMember = "id_cat_producto";
            comboBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PuntosVenta frmHijo = new PuntosVenta();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            servicio.AsignaProductoPV(comboBox1.SelectedValue.ToString(),PuntosVenta.id_punto_venta.ToString() );
            Productos frmHijo = new Productos();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                id_producto = Convert.ToInt32(selectedRow.Cells["id_producto"].Value);
                nombre_producto = Convert.ToString(selectedRow.Cells["nombre_producto"].Value);
                //salto entre formularios 
                Atributos frmHijo = new Atributos();
                frmHijo.MdiParent = this.ParentForm;
                frmHijo.Show();
                this.Close();
            }
        }
    }
}
