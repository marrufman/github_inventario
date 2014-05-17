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
    public partial class Admon : Form
    {
        public Admon()
        {
            InitializeComponent();
            if (login.id_perfil != 1)
            {
                MessageBox.Show("Acceso Denegado.");
                this.Close();
            }
        }
    }
}
