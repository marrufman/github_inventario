namespace InventarioEscritorio
{
    partial class EditaPuntoVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDescripcionPV = new System.Windows.Forms.TextBox();
            this.textBoxDireccionPV = new System.Windows.Forms.TextBox();
            this.textBoxNombrePV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDescripcionPV
            // 
            this.textBoxDescripcionPV.Location = new System.Drawing.Point(160, 83);
            this.textBoxDescripcionPV.Name = "textBoxDescripcionPV";
            this.textBoxDescripcionPV.Size = new System.Drawing.Size(179, 20);
            this.textBoxDescripcionPV.TabIndex = 12;
            // 
            // textBoxDireccionPV
            // 
            this.textBoxDireccionPV.Location = new System.Drawing.Point(160, 48);
            this.textBoxDireccionPV.Name = "textBoxDireccionPV";
            this.textBoxDireccionPV.Size = new System.Drawing.Size(179, 20);
            this.textBoxDireccionPV.TabIndex = 11;
            // 
            // textBoxNombrePV
            // 
            this.textBoxNombrePV.Location = new System.Drawing.Point(160, 13);
            this.textBoxNombrePV.Name = "textBoxNombrePV";
            this.textBoxNombrePV.Size = new System.Drawing.Size(179, 20);
            this.textBoxNombrePV.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripciom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Direccion del Punto de Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre del Punto de Venta";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditaPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 296);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDescripcionPV);
            this.Controls.Add(this.textBoxDireccionPV);
            this.Controls.Add(this.textBoxNombrePV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditaPuntoVenta";
            this.Text = "EditaPuntoVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDescripcionPV;
        private System.Windows.Forms.TextBox textBoxDireccionPV;
        private System.Windows.Forms.TextBox textBoxNombrePV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}