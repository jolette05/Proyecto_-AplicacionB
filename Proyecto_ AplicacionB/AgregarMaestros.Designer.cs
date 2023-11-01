
namespace Proyecto__AplicacionB
{
    partial class AgregarMaestros
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarMaestros));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.textcorreo = new System.Windows.Forms.TextBox();
            this.comboBoxturno = new System.Windows.Forms.ComboBox();
            this.dgvDatosEstudiante = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imagenagregar = new System.Windows.Forms.PictureBox();
            this.imageneliminar = new System.Windows.Forms.PictureBox();
            this.imagenactualizar = new System.Windows.Forms.PictureBox();
            this.Imagenbuscar = new System.Windows.Forms.PictureBox();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidosusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenagregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageneliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenactualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagenbuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos del Docente ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(676, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "No.Tel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(676, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Turno";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(209, 126);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(403, 51);
            this.txtnombre.TabIndex = 7;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(837, 136);
            this.txtapellidos.Multiline = true;
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(403, 45);
            this.txtapellidos.TabIndex = 8;
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(209, 233);
            this.txtcelular.Multiline = true;
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(403, 49);
            this.txtcelular.TabIndex = 9;
            // 
            // textcorreo
            // 
            this.textcorreo.Location = new System.Drawing.Point(837, 216);
            this.textcorreo.Multiline = true;
            this.textcorreo.Name = "textcorreo";
            this.textcorreo.Size = new System.Drawing.Size(403, 49);
            this.textcorreo.TabIndex = 10;
            // 
            // comboBoxturno
            // 
            this.comboBoxturno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxturno.FormattingEnabled = true;
            this.comboBoxturno.Items.AddRange(new object[] {
            "Matutino ",
            "Vespertino ",
            "Ambos "});
            this.comboBoxturno.Location = new System.Drawing.Point(209, 331);
            this.comboBoxturno.Name = "comboBoxturno";
            this.comboBoxturno.Size = new System.Drawing.Size(403, 44);
            this.comboBoxturno.TabIndex = 11;
            // 
            // dgvDatosEstudiante
            // 
            this.dgvDatosEstudiante.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDatosEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Telefono,
            this.Nombre,
            this.Apellidosusuario,
            this.ID,
            this.Turno});
            this.dgvDatosEstudiante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDatosEstudiante.Location = new System.Drawing.Point(0, 420);
            this.dgvDatosEstudiante.Name = "dgvDatosEstudiante";
            this.dgvDatosEstudiante.RowHeadersWidth = 51;
            this.dgvDatosEstudiante.RowTemplate.Height = 24;
            this.dgvDatosEstudiante.Size = new System.Drawing.Size(1319, 136);
            this.dgvDatosEstudiante.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // imagenagregar
            // 
            this.imagenagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenagregar.BackgroundImage")));
            this.imagenagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenagregar.Location = new System.Drawing.Point(675, 301);
            this.imagenagregar.Name = "imagenagregar";
            this.imagenagregar.Size = new System.Drawing.Size(141, 104);
            this.imagenagregar.TabIndex = 17;
            this.imagenagregar.TabStop = false;
            this.imagenagregar.Click += new System.EventHandler(this.imagenagregar_Click);
            // 
            // imageneliminar
            // 
            this.imageneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageneliminar.BackgroundImage")));
            this.imageneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageneliminar.Location = new System.Drawing.Point(837, 301);
            this.imageneliminar.Name = "imageneliminar";
            this.imageneliminar.Size = new System.Drawing.Size(140, 104);
            this.imageneliminar.TabIndex = 18;
            this.imageneliminar.TabStop = false;
            this.imageneliminar.Click += new System.EventHandler(this.imageneliminar_Click);
            // 
            // imagenactualizar
            // 
            this.imagenactualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagenactualizar.BackgroundImage")));
            this.imagenactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenactualizar.Location = new System.Drawing.Point(993, 301);
            this.imagenactualizar.Name = "imagenactualizar";
            this.imagenactualizar.Size = new System.Drawing.Size(143, 104);
            this.imagenactualizar.TabIndex = 19;
            this.imagenactualizar.TabStop = false;
            this.imagenactualizar.Click += new System.EventHandler(this.imagenactualizar_Click);
            // 
            // Imagenbuscar
            // 
            this.Imagenbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Imagenbuscar.BackgroundImage")));
            this.Imagenbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagenbuscar.Location = new System.Drawing.Point(1155, 301);
            this.Imagenbuscar.Name = "Imagenbuscar";
            this.Imagenbuscar.Size = new System.Drawing.Size(142, 113);
            this.Imagenbuscar.TabIndex = 20;
            this.Imagenbuscar.TabStop = false;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellidosusuario
            // 
            this.Apellidosusuario.HeaderText = "Apellidos";
            this.Apellidosusuario.MinimumWidth = 6;
            this.Apellidosusuario.Name = "Apellidosusuario";
            this.Apellidosusuario.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.MinimumWidth = 6;
            this.Turno.Name = "Turno";
            this.Turno.Width = 125;
            // 
            // AgregarMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1319, 556);
            this.Controls.Add(this.Imagenbuscar);
            this.Controls.Add(this.imagenactualizar);
            this.Controls.Add(this.imageneliminar);
            this.Controls.Add(this.imagenagregar);
            this.Controls.Add(this.dgvDatosEstudiante);
            this.Controls.Add(this.comboBoxturno);
            this.Controls.Add(this.textcorreo);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarMaestros";
            this.Text = "AgregarMaestros";
            this.Load += new System.EventHandler(this.AgregarMaestros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenagregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageneliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenactualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagenbuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.TextBox textcorreo;
        private System.Windows.Forms.ComboBox comboBoxturno;
        private System.Windows.Forms.DataGridView dgvDatosEstudiante;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox imagenagregar;
        private System.Windows.Forms.PictureBox imageneliminar;
        private System.Windows.Forms.PictureBox imagenactualizar;
        private System.Windows.Forms.PictureBox Imagenbuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidosusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
    }
}