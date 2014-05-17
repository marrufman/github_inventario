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
    public partial class AltaAtributos : Form
    {
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        public static int id_atributo;
        public static string nombre_atributo;
        public AltaAtributos()
        {
            InitializeComponent();
            if (login.id_perfil != 1)
            {
                MessageBox.Show("Acceso Denegado.");
                this.Close();
            }
            DataSet ds = new DataSet();
            ds = servicio.ObtieneTodosAtributos();
            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No hay registros de Atributos en el sistema.");
            }
            else
            {
                label1.Text = "Atributos del Sistema: " + PuntosVenta.nombre_pv;
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "#";
                dataGridView1.Columns[1].HeaderText = "Nombre Atributo";
                dataGridView1.Refresh();
                Application.DoEvents();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            servicio.AddAtribProducto(textBoxNombreAttrib.Text);
            AltaAtributos frmHijo = new AltaAtributos();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            id_atributo = Convert.ToInt32(selectedRow.Cells["id_atributo"].Value);
            nombre_atributo = Convert.ToString(selectedRow.Cells["nombre_atributo"].Value);
            //Salto A EditaPRoducto
            EditaAtributo frmHijo = new EditaAtributo();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }
    }
}
