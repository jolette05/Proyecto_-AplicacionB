
namespace Proyecto__AplicacionB
{
    partial class AccionaRealizar
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.lblventas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBoxInventario = new System.Windows.Forms.PictureBox();
            this.picBoxCompras = new System.Windows.Forms.PictureBox();
            this.picBoxClientes = new System.Windows.Forms.PictureBox();
            this.picBoxVentas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(351, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(350, 46);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Acción a Realizar";
            // 
            // lblventas
            // 
            this.lblventas.AutoSize = true;
            this.lblventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblventas.Location = new System.Drawing.Point(66, 369);
            this.lblventas.Name = "lblventas";
            this.lblventas.Size = new System.Drawing.Size(125, 38);
            this.lblventas.TabIndex = 1;
            this.lblventas.Text = "Ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clientes";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.Location = new System.Drawing.Point(602, 368);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(177, 39);
            this.lblInventario.TabIndex = 5;
            this.lblInventario.Text = "Inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(919, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Compras";
            // 
            // picBoxInventario
            // 
            this.picBoxInventario.BackgroundImage = global::Proyecto__AplicacionB.Properties.Resources.estanteria2_0;
            this.picBoxInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxInventario.Location = new System.Drawing.Point(575, 127);
            this.picBoxInventario.Name = "picBoxInventario";
            this.picBoxInventario.Size = new System.Drawing.Size(245, 186);
            this.picBoxInventario.TabIndex = 10;
            this.picBoxInventario.TabStop = false;
            // 
            // picBoxCompras
            // 
            this.picBoxCompras.BackgroundImage = global::Proyecto__AplicacionB.Properties.Resources.Despensa1;
            this.picBoxCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxCompras.Location = new System.Drawing.Point(857, 127);
            this.picBoxCompras.Name = "picBoxCompras";
            this.picBoxCompras.Size = new System.Drawing.Size(250, 186);
            this.picBoxCompras.TabIndex = 9;
            this.picBoxCompras.TabStop = false;
            // 
            // picBoxClientes
            // 
            this.picBoxClientes.BackgroundImage = global::Proyecto__AplicacionB.Properties.Resources.cchico_comprando;
            this.picBoxClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxClientes.Location = new System.Drawing.Point(300, 127);
            this.picBoxClientes.Name = "picBoxClientes";
            this.picBoxClientes.Size = new System.Drawing.Size(248, 186);
            this.picBoxClientes.TabIndex = 7;
            this.picBoxClientes.TabStop = false;
            this.picBoxClientes.Click += new System.EventHandler(this.picBoxClientes_Click);
            // 
            // picBoxVentas
            // 
            this.picBoxVentas.BackgroundImage = global::Proyecto__AplicacionB.Properties.Resources.Captura_de_pantalla_2023_11_20_233204;
            this.picBoxVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxVentas.Location = new System.Drawing.Point(12, 127);
            this.picBoxVentas.Name = "picBoxVentas";
            this.picBoxVentas.Size = new System.Drawing.Size(257, 186);
            this.picBoxVentas.TabIndex = 0;
            this.picBoxVentas.TabStop = false;
            this.picBoxVentas.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // AccionaRealizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1151, 496);
            this.Controls.Add(this.picBoxInventario);
            this.Controls.Add(this.picBoxCompras);
            this.Controls.Add(this.picBoxClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.picBoxVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblventas);
            this.Controls.Add(this.labelTitulo);
            this.Name = "AccionaRealizar";
            this.Load += new System.EventHandler(this.QuienInicia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label lblventas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBoxVentas;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBoxClientes;
        private System.Windows.Forms.PictureBox picBoxCompras;
        private System.Windows.Forms.PictureBox picBoxInventario;
    }
}