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
    public partial class AltaRutas : Form
    {
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        public static int id_ruta;
        public static string nombre_ruta;
        public static string fecha;
        public static string estatus;
        public static string nombre_usuario;
        public AltaRutas()
        {
            InitializeComponent();
            if (login.id_perfil != 1)
            {
                MessageBox.Show("Acceso Denegado.");
                this.Close();
            }
            DataSet ds = new DataSet();
            ds = servicio.ObtieneTodasRutas();
            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No hay registros de Rutas en el sistema.");
            }
            else
            {
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "#";
                dataGridView1.Columns[1].HeaderText = "Descripcion";
                dataGridView1.Columns[2].HeaderText = "Fecha";
                dataGridView1.Columns[3].HeaderText = "Abierta";
                dataGridView1.Columns[4].HeaderText = "Promotor";
                dataGridView1.Refresh();
                Application.DoEvents();
            }
            //llenamos el dropdownlist
            DataSet dsddl = new DataSet();
            dsddl = servicio.ObtieneTodosPromotores();
            comboBox1.DataSource = dsddl.Tables[0].DefaultView;
            comboBox1.DisplayMember = "nombre_usuario";
            comboBox1.ValueMember = "id_usuario";
            comboBox1.Refresh();
            //colocamos la fecha actual
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Alta Rutas
            servicio.AddRuta(textBoxRuta.Text, dateTimePicker1.Value.ToString("yyyy/MM/dd"), comboBox1.SelectedValue.ToString());
            //Refresca
            AltaRutas frmHijo = new AltaRutas();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //editar Ruta
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            id_ruta = Convert.ToInt32(selectedRow.Cells["id_ruta"].Value);
            nombre_ruta = Convert.ToString(selectedRow.Cells["nombre_ruta"].Value);
            fecha = Convert.ToString(selectedRow.Cells["fecha"].Value);
            estatus = Convert.ToString(selectedRow.Cells["estatus"].Value);
            nombre_usuario = Convert.ToString(selectedRow.Cells["nombre_usuario"].Value);
            //Salto A Edita PV
            EditaRuta frmHijo = new EditaRuta();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Borra Ruta
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            servicio.BorraRuta(Convert.ToString(selectedRow.Cells["id_ruta"].Value));
            //Actualizar
            AltaRutas frmHijo = new AltaRutas();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //salto a configuracion de puntos de venta
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            id_ruta = Convert.ToInt32(selectedRow.Cells["id_ruta"].Value);
            nombre_ruta = Convert.ToString(selectedRow.Cells["nombre_ruta"].Value);
            ConfigPuntosVenta frmHijo = new ConfigPuntosVenta();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

    }
}
