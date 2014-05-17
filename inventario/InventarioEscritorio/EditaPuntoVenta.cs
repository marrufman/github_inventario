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
    public partial class EditaPuntoVenta : Form
    {
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        public EditaPuntoVenta()
        {
            InitializeComponent();
            if (login.id_perfil != 1)
            {
                MessageBox.Show("Acceso Denegado.");
                this.Close();
            }
            textBoxNombrePV.Text = AltaPuntosVenta.nombre_pv.ToString();
            textBoxDireccionPV.Text = AltaPuntosVenta.direccion_pv.ToString();
            textBoxDescripcionPV.Text = AltaPuntosVenta.descripcion.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            servicio.EditaPuntoVenta(AltaPuntosVenta.id_punto_venta.ToString(), textBoxNombrePV.Text, textBoxDireccionPV.Text, textBoxDescripcionPV.Text);
            //Regresa
            AltaPuntosVenta frmHijo = new AltaPuntosVenta();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
