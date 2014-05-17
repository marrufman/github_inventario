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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
        funciones fn = new funciones();
        public MDIParent1()
        {
            InitializeComponent();
            login formulario = new login();
            formulario.MdiParent = this;
            formulario.Show();
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }
        private void capturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form childFrm in MdiChildren)
            {
                childFrm.Close();
            }
            Rutas childForm = new Rutas();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            try
            {
                childForm.Show();
            }
            catch (Exception)
            {

            }
        }

        private void MDIParent1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void altaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childFrm in MdiChildren)
            {
                childFrm.Close();
            }
            AltaProductos childForm = new AltaProductos();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            try
            {
                childForm.Show();
            }
            catch (Exception)
            {

            }
        }

        private void altaDeAtributosDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childFrm in MdiChildren)
            {
                childFrm.Close();
            }
            AltaAtributos childForm = new AltaAtributos();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            try
            {
                childForm.Show();
            }
            catch (Exception)
            {

            }
        }

        private void altaDePuntosDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childFrm in MdiChildren)
            {
                childFrm.Close();
            }
            AltaPuntosVenta childForm = new AltaPuntosVenta();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            try
            {
                childForm.Show();
            }
            catch (Exception)
            {

            }
        }

        private void altaDeRutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childFrm in MdiChildren)
            {
                childFrm.Close();
            }
            AltaRutas childForm = new AltaRutas();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            try
            {
                childForm.Show();
            }
            catch (Exception)
            {

            }
        }

        private void cargaDeLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childFrm in MdiChildren)
            {
                childFrm.Close();
            }
            CargaLote childForm = new CargaLote();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            try
            {
                childForm.Show();
            }
            catch (Exception)
            {

            }
        }


    }
}
