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
    public partial class AltaPuntosVenta : Form
    {
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        public static int id_punto_venta;
        public static string nombre_pv;
        public static string direccion_pv;
        public static string descripcion;
        public AltaPuntosVenta()
        {
            InitializeComponent();
            if (login.id_perfil != 1)
            {
                MessageBox.Show("Acceso Denegado.");
                this.Close();
            }
            DataSet ds = new DataSet();
            ds = servicio.ObtieneTodosPuntosVenta();
            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No hay registros de Puntos de Venta en el sistema.");
            }
            else
            {
                label1.Text = "Puntos de Venta del Sistema: " + PuntosVenta.nombre_pv;
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "#";
                dataGridView1.Columns[1].HeaderText = "Nombre Punto Venta";
                dataGridView1.Columns[2].HeaderText = "Direccion";
                dataGridView1.Columns[3].HeaderText = "Detalle";
                dataGridView1.Refresh();
                Application.DoEvents();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            servicio.AltaPuntoVenta(textBoxNombrePV.Text, textBoxDireccionPV.Text, textBoxDescripcionPV.Text);
            //Refresca
            AltaPuntosVenta frmHijo = new AltaPuntosVenta();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //editar Puntos de venta
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            id_punto_venta = Convert.ToInt32(selectedRow.Cells["id_punto_venta"].Value);
            nombre_pv = Convert.ToString(selectedRow.Cells["nombre_pv"].Value);
            direccion_pv = Convert.ToString(selectedRow.Cells["direccion_pv"].Value);
            descripcion = Convert.ToString(selectedRow.Cells["descripcion"].Value);
            //Salto A Edita PV
            EditaPuntoVenta frmHijo = new EditaPuntoVenta();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //borra punto venta
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            servicio.BorrarPuntoVenta(selectedRow.Cells["id_punto_venta"].Value.ToString());
            //refresca
            AltaPuntosVenta frmHijo = new AltaPuntosVenta();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
