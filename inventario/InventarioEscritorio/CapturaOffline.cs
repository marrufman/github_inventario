using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Xml.Linq;
using System.IO;

namespace InventarioEscritorio
{
    public partial class CapturaOffline : Form
    {
        funciones fn = new funciones();
        public CapturaOffline()
        {
            InitializeComponent();
            //leemos rutas
            DataSet ds = new DataSet();
            ds.ReadXml(funciones.path + "rutas.xml");
            comboBoxRuta.DataSource = ds.Tables[0].DefaultView;
            comboBoxRuta.DisplayMember = "nombre_ruta";
            comboBoxRuta.ValueMember = "nombre_ruta";
            comboBoxRuta.Refresh();
            ds = null;
            //llena puntos venta
            DataSet dspv = new DataSet();
            dspv.ReadXml(funciones.path + "punto_venta.xml");
            comboBoxPV.DataSource = dspv.Tables[0].DefaultView;
            comboBoxPV.DisplayMember = "nombre_pv";
            comboBoxPV.ValueMember = "nombre_pv";
            comboBoxPV.Refresh();
            dspv = null;
            //llena productos
            DataSet dsprod = new DataSet();
            dsprod.ReadXml(funciones.path + "cat_productos.xml");
            comboBoxProducto.DataSource = dsprod.Tables[0].DefaultView;
            comboBoxProducto.DisplayMember = "nombre_producto";
            comboBoxProducto.ValueMember = "nombre_producto";
            comboBoxProducto.Refresh();
            dspv = null;
            //llena atributos
            DataSet dsatri = new DataSet();
            dsatri.ReadXml(funciones.path + "cat_atributos_producto.xml");
            comboBoxAtributo.DataSource = dsatri.Tables[0].DefaultView;
            comboBoxAtributo.DisplayMember = "nombre_atributo";
            comboBoxAtributo.ValueMember = "nombre_atributo";
            comboBoxAtributo.Refresh();
            dspv = null;
            //registros capturados
            label12.Text= "Productos Capturados: "+fn.cuentaXMLCapturados().ToString();
        }

        private void comboBoxRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRuta.SelectedValue.ToString()!="System.Data.DataRowView")
            textBoxRuta.Text = comboBoxRuta.SelectedValue.ToString();
        }

        private void comboBoxPV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPV.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                textBoxNombrePV.Text = comboBoxPV.SelectedValue.ToString();
                //llenamos direccion y descripcion con LINQ
                DataSet ds = new DataSet();
                ds.ReadXml(funciones.path + "punto_venta.xml");
                DataTable table = ds.Tables["Table1"];
                string expression;
                expression = "nombre_pv='" + textBoxNombrePV.Text+"'";
                DataRow[] foundRows;
                // aplicamos el filtro.
                foundRows = table.Select(expression);
                textBoxDireccionPV.Text = foundRows[0]["direccion_pv"].ToString();
                textBoxDescripcionPV.Text = foundRows[0]["descripcion"].ToString();
            }
        }

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProducto.SelectedValue.ToString() != "System.Data.DataRowView")
                textBoxProducto.Text = comboBoxProducto.SelectedValue.ToString();
        }

        private void comboBoxAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAtributo.SelectedValue.ToString() != "System.Data.DataRowView")
                textBoxAtributo.Text = comboBoxAtributo.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creamos - cargamos el xml
            fn.CreaXMLCarga(textBoxRuta.Text, textBoxNombrePV.Text, textBoxDireccionPV.Text,
                textBoxDescripcionPV.Text, textBoxProducto.Text, textBoxAtributo.Text, textBoxValor.Text); 
            //refrescamos
            CapturaOffline frmHijo = new CapturaOffline();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            frmHijo.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //salto
            VerCapturados frmHijo = new VerCapturados();
            frmHijo.MdiParent = this.ParentForm;
            frmHijo.Show();
            frmHijo.WindowState = FormWindowState.Maximized;
        }
    }
}
