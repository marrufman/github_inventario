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
    public partial class EditaAtributo : Form
    {
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        public EditaAtributo()
        {
            InitializeComponent();
            if (login.id_perfil != 1)
            {
                MessageBox.Show("Acceso Denegado.");
                this.Close();
            }
            textBox1.Text = AltaAtributos.nombre_atributo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            servicio.EditAtribProducto(AltaAtributos.id_atributo.ToString(), textBox1.Text);
            AltaAtributos frmHijo = new AltaAtributos();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }
    }
}
