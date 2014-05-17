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
    public partial class Atributos : Form
    {
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        public Atributos()
        {
            InitializeComponent();
            DataSet ds = new DataSet();
            ds = servicio.ObtieneDetalleProducto(Productos.id_producto.ToString());
            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No hay registros de Atributos para el producto.");
            }
            else
            {
                label1.Text = "Atributos del Producto: " + Productos.nombre_producto;
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "#";
                dataGridView1.Columns[1].HeaderText = "Atributo";
                dataGridView1.Columns[2].HeaderText = "Valor";
                dataGridView1.Refresh();
                Application.DoEvents();    
            }
            //llenamos el dropdownlist
            DataSet dsddl = new DataSet();
            dsddl = servicio.ObtieneAtribDisponibles(Productos.id_producto.ToString());
            comboBox1.DataSource = dsddl.Tables[0].DefaultView;
            comboBox1.DisplayMember = "nombre_atributo";
            comboBox1.ValueMember = "id_atributo";
            comboBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos frmHijo = new Productos();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            servicio.CapturarProducto(Productos.id_producto.ToString(),comboBox1.SelectedValue.ToString(),textBox1.Text);
            Atributos frmHijo = new Atributos();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }
    }
}
