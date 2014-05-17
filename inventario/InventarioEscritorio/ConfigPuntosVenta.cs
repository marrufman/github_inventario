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
    public partial class ConfigPuntosVenta : Form
    {
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        public ConfigPuntosVenta()
        {
            InitializeComponent();
            if (login.id_perfil != 1)
            {
                MessageBox.Show("Acceso Denegado.");
                this.Close();
            }
            label5.Text = AltaRutas.nombre_ruta.ToString();
            //traemos puntos de venta asignados a la ruta
            DataSet ds = new DataSet();
            ds = servicio.ObtienePuntosVenta(AltaRutas.id_ruta.ToString());
            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No hay puntos de venta asignados a esta ruta.");
            }
            else
            {
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "#";
                dataGridView1.Columns[1].HeaderText = "Nombre de Punto de Venta";
                dataGridView1.Columns[2].HeaderText = "Direccion";
                dataGridView1.Columns[3].HeaderText = "Descipcion";
                dataGridView1.Refresh();
                Application.DoEvents();
            }
            //traemos los puntos de venta libres
            DataSet ds2 = new DataSet();
            ds2 = servicio.ObtienePuntosVentaDisponibles(AltaRutas.id_ruta.ToString());
            if (ds2 == null || ds2.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No hay puntos de venta disponibles para asignar.");
            }
            else
            {
                dataGridView2.DataSource = ds2.Tables[0];
                dataGridView2.Columns[0].HeaderText = "#";
                dataGridView2.Columns[1].HeaderText = "Nombre de Punto de Venta";
                dataGridView2.Columns[2].HeaderText = "Direccion";
                dataGridView2.Columns[3].HeaderText = "Descipcion";
                dataGridView2.Refresh();
                Application.DoEvents();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //asigna punto de venta
            int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
            servicio.AddRutaPuntoVenta(AltaRutas.id_ruta.ToString(),Convert.ToString(selectedRow.Cells["id_punto_venta"].Value));
            //refresca
            ConfigPuntosVenta frmHijo = new ConfigPuntosVenta();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //suprime punto de venta
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            servicio.BorraRutaPuntoVenta(AltaRutas.id_ruta.ToString(), Convert.ToString(selectedRow.Cells["id_punto_venta"].Value));
            //refresca
            ConfigPuntosVenta frmHijo = new ConfigPuntosVenta();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //regresar
            AltaRutas frmHijo = new AltaRutas();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }
    }
}
