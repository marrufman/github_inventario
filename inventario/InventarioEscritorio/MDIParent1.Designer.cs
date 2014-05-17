namespace InventarioEscritorio
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.rutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeAtributosDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDePuntosDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeRutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeLoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rutasToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // rutasToolStripMenuItem
            // 
            this.rutasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturaToolStripMenuItem1,
            this.administracionToolStripMenuItem,
            this.cargaDeLoteToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.rutasToolStripMenuItem.Name = "rutasToolStripMenuItem";
            this.rutasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.rutasToolStripMenuItem.Text = "Menu";
            // 
            // capturaToolStripMenuItem1
            // 
            this.capturaToolStripMenuItem1.Name = "capturaToolStripMenuItem1";
            this.capturaToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.capturaToolStripMenuItem1.Text = "Captura";
            this.capturaToolStripMenuItem1.Click += new System.EventHandler(this.capturaToolStripMenuItem1_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeProductosToolStripMenuItem,
            this.altaDeAtributosDeProductoToolStripMenuItem,
            this.altaDePuntosDeVentaToolStripMenuItem,
            this.altaDeRutasToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.administracionToolStripMenuItem.Text = "Administracion";
            this.administracionToolStripMenuItem.Click += new System.EventHandler(this.administracionToolStripMenuItem_Click);
            // 
            // altaDeProductosToolStripMenuItem
            // 
            this.altaDeProductosToolStripMenuItem.Name = "altaDeProductosToolStripMenuItem";
            this.altaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.altaDeProductosToolStripMenuItem.Text = "Alta de Productos";
            this.altaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.altaDeProductosToolStripMenuItem_Click);
            // 
            // altaDeAtributosDeProductoToolStripMenuItem
            // 
            this.altaDeAtributosDeProductoToolStripMenuItem.Name = "altaDeAtributosDeProductoToolStripMenuItem";
            this.altaDeAtributosDeProductoToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.altaDeAtributosDeProductoToolStripMenuItem.Text = "Alta de Atributos de Producto";
            this.altaDeAtributosDeProductoToolStripMenuItem.Click += new System.EventHandler(this.altaDeAtributosDeProductoToolStripMenuItem_Click);
            // 
            // altaDePuntosDeVentaToolStripMenuItem
            // 
            this.altaDePuntosDeVentaToolStripMenuItem.Name = "altaDePuntosDeVentaToolStripMenuItem";
            this.altaDePuntosDeVentaToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.altaDePuntosDeVentaToolStripMenuItem.Text = "Alta de Puntos de Venta";
            this.altaDePuntosDeVentaToolStripMenuItem.Click += new System.EventHandler(this.altaDePuntosDeVentaToolStripMenuItem_Click);
            // 
            // altaDeRutasToolStripMenuItem
            // 
            this.altaDeRutasToolStripMenuItem.Name = "altaDeRutasToolStripMenuItem";
            this.altaDeRutasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.altaDeRutasToolStripMenuItem.Text = "Alta de Rutas";
            this.altaDeRutasToolStripMenuItem.Click += new System.EventHandler(this.altaDeRutasToolStripMenuItem_Click);
            // 
            // cargaDeLoteToolStripMenuItem
            // 
            this.cargaDeLoteToolStripMenuItem.Name = "cargaDeLoteToolStripMenuItem";
            this.cargaDeLoteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.cargaDeLoteToolStripMenuItem.Text = "Carga de Lote";
            this.cargaDeLoteToolStripMenuItem.Click += new System.EventHandler(this.cargaDeLoteToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "Inventario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIParent1_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem rutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDePuntosDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeRutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeAtributosDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeLoteToolStripMenuItem;
    }
}



