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
    public partial class EditaProducto : Form
    {
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        public EditaProducto()
        {
            InitializeComponent();
            if (login.id_perfil != 1)
            {
                MessageBox.Show("Acceso Denegado.");
                this.Close();
            }
            textBox1.Text = AltaProductos.nombre_producto.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            servicio.EditarProducto(textBox1.Text, AltaProductos.id_cat_producto.ToString());
            //Salto A Altaproductos
            AltaProductos frmHijo = new AltaProductos();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }
    }
}
