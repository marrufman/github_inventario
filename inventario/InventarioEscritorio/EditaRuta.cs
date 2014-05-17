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
    public partial class EditaRuta : Form
    {
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        public EditaRuta()
        {
            InitializeComponent();
            if (login.id_perfil != 1)
            {
                MessageBox.Show("Acceso Denegado.");
                this.Close();
            }
            //nombre ruta
            textBoxRuta.Text = AltaRutas.nombre_ruta;
            //llenamos el dropdownlist
            DataSet dsddl = new DataSet();
            dsddl = servicio.ObtieneTodosPromotores();
            comboBoxPromotor.DataSource = dsddl.Tables[0].DefaultView;
            comboBoxPromotor.DisplayMember = "nombre_usuario";
            comboBoxPromotor.ValueMember = "id_usuario";
            comboBoxPromotor.Refresh();
            //colocamos el valor a editar en combobox
            DataSet dsnombre = new DataSet();
            dsnombre= servicio.ObtieneIdUsuarioPorNombre(AltaRutas.nombre_usuario.ToString());
            if(dsnombre != null)
            { 
            comboBoxPromotor.SelectedValue = dsnombre.Tables[0].Rows[0]["id_usuario"].ToString();
            }
            //colocamos la fecha actual
            dateTimePicker1.Value = Convert.ToDateTime(AltaRutas.fecha);
            //colocamos el estatus
            checkBoxEstatus.Checked = Convert.ToBoolean(AltaRutas.estatus);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string estado="0";
            if(checkBoxEstatus.Checked)
            {
            estado="1";
            }
            servicio.EditaRuta(AltaRutas.id_ruta.ToString(), textBoxRuta.Text, dateTimePicker1.Value.ToString("yyyy/MM/dd"), estado, comboBoxPromotor.SelectedValue.ToString());
            //regresa
            AltaRutas frmHijo = new AltaRutas();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //regresa
            AltaRutas frmHijo = new AltaRutas();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            this.Close();
        }
    }
}
