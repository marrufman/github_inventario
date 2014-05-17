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
    public partial class VerCapturados : Form
    {
        funciones fn = new funciones();
        public VerCapturados()
        {
            InitializeComponent();
            //lee productos Capturados
            DataSet ds = new DataSet();
            ds=fn.MuestraProductosCapturados();
            if (ds == null)
            {
                MessageBox.Show("No hay productos Capturados.");
            }
            else
            {
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "Ruta";
                dataGridView1.Columns[1].HeaderText = "Punto de Venta";
                dataGridView1.Columns[2].HeaderText = "Direccion";
                dataGridView1.Columns[3].HeaderText = "Descripcion";
                dataGridView1.Columns[4].HeaderText = "Producto";
                dataGridView1.Columns[5].HeaderText = "Atributo";
                dataGridView1.Columns[6].HeaderText = "Valor";
                dataGridView1.Refresh();
                Application.DoEvents();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //refrescamos
            CapturaOffline frmHijo = new CapturaOffline();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            frmHijo.WindowState = FormWindowState.Maximized;
        }
    }
}
