
namespace UI
{
    partial class MantenimientoPreguntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoPreguntas));
            this.tspPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtEnunciado = new System.Windows.Forms.RichTextBox();
            this.btnCambiarImagen = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelCerti = new System.Windows.Forms.Label();
            this.labelExamen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMarcar3 = new System.Windows.Forms.Button();
            this.btnMarcar2 = new System.Windows.Forms.Button();
            this.btnMarcar1 = new System.Windows.Forms.Button();
            this.txtCorrecta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtR3 = new System.Windows.Forms.TextBox();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cEnunciado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRespuesta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRespuesta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRespuesta3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCorrecta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.tspPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tspPrincipal
            // 
            this.tspPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNuevo,
            this.toolStripBtnEditar,
            this.toolStripBtnBorrar,
            this.toolStripBtnSalir});
            this.tspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tspPrincipal.Name = "tspPrincipal";
            this.tspPrincipal.Size = new System.Drawing.Size(1273, 55);
            this.tspPrincipal.TabIndex = 5;
            // 
            // toolStripBtnNuevo
            // 
            this.toolStripBtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnNuevo.Image")));
            this.toolStripBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNuevo.Name = "toolStripBtnNuevo";
            this.toolStripBtnNuevo.Size = new System.Drawing.Size(103, 52);
            this.toolStripBtnNuevo.Text = "&Nueva";
            this.toolStripBtnNuevo.Click += new System.EventHandler(this.toolStripBtnNuevo_Click);
            // 
            // toolStripBtnEditar
            // 
            this.toolStripBtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnEditar.Image")));
            this.toolStripBtnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEditar.Name = "toolStripBtnEditar";
            this.toolStripBtnEditar.Size = new System.Drawing.Size(100, 52);
            this.toolStripBtnEditar.Text = "&Editar";
            this.toolStripBtnEditar.Click += new System.EventHandler(this.toolStripBtnEditar_Click);
            // 
            // toolStripBtnBorrar
            // 
            this.toolStripBtnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnBorrar.Image")));
            this.toolStripBtnBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBorrar.Name = "toolStripBtnBorrar";
            this.toolStripBtnBorrar.Size = new System.Drawing.Size(102, 52);
            this.toolStripBtnBorrar.Text = "&Borrar";
            this.toolStripBtnBorrar.Click += new System.EventHandler(this.toolStripBtnBorrar_Click);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSalir.Image")));
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(90, 52);
            this.toolStripBtnSalir.Text = "&Salir";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.txtEnunciado);
            this.splitContainer1.Panel2.Controls.Add(this.btnCambiarImagen);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.btnAceptar);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.labelCerti);
            this.splitContainer1.Panel2.Controls.Add(this.labelExamen);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.btnMarcar3);
            this.splitContainer1.Panel2.Controls.Add(this.btnMarcar2);
            this.splitContainer1.Panel2.Controls.Add(this.btnMarcar1);
            this.splitContainer1.Panel2.Controls.Add(this.txtCorrecta);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtR3);
            this.splitContainer1.Panel2.Controls.Add(this.txtR2);
            this.splitContainer1.Panel2.Controls.Add(this.txtR1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1273, 673);
            this.splitContainer1.SplitterDistance = 700;
            this.splitContainer1.TabIndex = 6;
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cEnunciado,
            this.cRespuesta1,
            this.cRespuesta2,
            this.cRespuesta3,
            this.cCorrecta,
            this.cImagen});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(700, 673);
            this.dgvDatos.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Location = new System.Drawing.Point(17, 316);
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(537, 72);
            this.txtEnunciado.TabIndex = 49;
            this.txtEnunciado.Text = "";
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCambiarImagen.Enabled = false;
            this.btnCambiarImagen.Location = new System.Drawing.Point(413, 115);
            this.btnCambiarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(141, 29);
            this.btnCambiarImagen.TabIndex = 47;
            this.btnCambiarImagen.Text = "Cambiar Imagen";
            this.btnCambiarImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCambiarImagen.UseVisualStyleBackColor = true;
            this.btnCambiarImagen.Click += new System.EventHandler(this.btnCambiarImagen_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(152, 115);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(228, 166);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 48;
            this.pictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Imagen:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(401, 607);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(155, 53);
            this.btnAceptar.TabIndex = 43;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(19, 607);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 53);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelCerti
            // 
            this.labelCerti.AutoSize = true;
            this.labelCerti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCerti.Location = new System.Drawing.Point(19, 71);
            this.labelCerti.Name = "labelCerti";
            this.labelCerti.Size = new System.Drawing.Size(224, 20);
            this.labelCerti.TabIndex = 17;
            this.labelCerti.Text = "Aquí dice la certificación ";
            // 
            // labelExamen
            // 
            this.labelExamen.AutoSize = true;
            this.labelExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExamen.Location = new System.Drawing.Point(19, 20);
            this.labelExamen.Name = "labelExamen";
            this.labelExamen.Size = new System.Drawing.Size(279, 20);
            this.labelExamen.TabIndex = 16;
            this.labelExamen.Text = "Aquí dice el nombre del Examen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Enunciado:";
            // 
            // btnMarcar3
            // 
            this.btnMarcar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMarcar3.Enabled = false;
            this.btnMarcar3.Location = new System.Drawing.Point(436, 515);
            this.btnMarcar3.Name = "btnMarcar3";
            this.btnMarcar3.Size = new System.Drawing.Size(123, 24);
            this.btnMarcar3.TabIndex = 12;
            this.btnMarcar3.Text = "Marcar correcta";
            this.btnMarcar3.UseVisualStyleBackColor = true;
            this.btnMarcar3.Click += new System.EventHandler(this.btnMarcar3_Click);
            // 
            // btnMarcar2
            // 
            this.btnMarcar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMarcar2.Enabled = false;
            this.btnMarcar2.Location = new System.Drawing.Point(436, 447);
            this.btnMarcar2.Name = "btnMarcar2";
            this.btnMarcar2.Size = new System.Drawing.Size(123, 26);
            this.btnMarcar2.TabIndex = 11;
            this.btnMarcar2.Text = "Marcar correcta";
            this.btnMarcar2.UseVisualStyleBackColor = true;
            this.btnMarcar2.Click += new System.EventHandler(this.btnMarcar2_Click);
            // 
            // btnMarcar1
            // 
            this.btnMarcar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMarcar1.Enabled = false;
            this.btnMarcar1.Location = new System.Drawing.Point(436, 394);
            this.btnMarcar1.Name = "btnMarcar1";
            this.btnMarcar1.Size = new System.Drawing.Size(123, 23);
            this.btnMarcar1.TabIndex = 10;
            this.btnMarcar1.Text = "Marcar correcta";
            this.btnMarcar1.UseVisualStyleBackColor = true;
            this.btnMarcar1.Click += new System.EventHandler(this.btnMarcar1_Click);
            // 
            // txtCorrecta
            // 
            this.txtCorrecta.Enabled = false;
            this.txtCorrecta.Location = new System.Drawing.Point(19, 571);
            this.txtCorrecta.Name = "txtCorrecta";
            this.txtCorrecta.Size = new System.Drawing.Size(540, 22);
            this.txtCorrecta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Respuesta Correcta:";
            // 
            // txtR3
            // 
            this.txtR3.Enabled = false;
            this.txtR3.Location = new System.Drawing.Point(130, 516);
            this.txtR3.Name = "txtR3";
            this.txtR3.Size = new System.Drawing.Size(300, 22);
            this.txtR3.TabIndex = 6;
            this.txtR3.TextChanged += new System.EventHandler(this.txtR3_TextChanged);
            // 
            // txtR2
            // 
            this.txtR2.Enabled = false;
            this.txtR2.Location = new System.Drawing.Point(130, 451);
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(300, 22);
            this.txtR2.TabIndex = 5;
            this.txtR2.TextChanged += new System.EventHandler(this.txtR2_TextChanged);
            // 
            // txtR1
            // 
            this.txtR1.Enabled = false;
            this.txtR1.Location = new System.Drawing.Point(130, 395);
            this.txtR1.Name = "txtR1";
            this.txtR1.Size = new System.Drawing.Size(300, 22);
            this.txtR1.TabIndex = 4;
            this.txtR1.TextChanged += new System.EventHandler(this.txtR1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Respuesta 3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Respuesta 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Respuesta 1:";
            // 
            // cEnunciado
            // 
            this.cEnunciado.DataPropertyName = "Enunciado";
            this.cEnunciado.HeaderText = "Enunciado";
            this.cEnunciado.MinimumWidth = 6;
            this.cEnunciado.Name = "cEnunciado";
            this.cEnunciado.ReadOnly = true;
            this.cEnunciado.Width = 125;
            // 
            // cRespuesta1
            // 
            this.cRespuesta1.DataPropertyName = "Respuesta1";
            this.cRespuesta1.HeaderText = "Respuesta 1";
            this.cRespuesta1.MinimumWidth = 6;
            this.cRespuesta1.Name = "cRespuesta1";
            this.cRespuesta1.ReadOnly = true;
            this.cRespuesta1.Width = 125;
            // 
            // cRespuesta2
            // 
            this.cRespuesta2.DataPropertyName = "Respuesta2";
            this.cRespuesta2.HeaderText = "Respuesta 2";
            this.cRespuesta2.MinimumWidth = 6;
            this.cRespuesta2.Name = "cRespuesta2";
            this.cRespuesta2.ReadOnly = true;
            this.cRespuesta2.Width = 125;
            // 
            // cRespuesta3
            // 
            this.cRespuesta3.DataPropertyName = "Respuesta3";
            this.cRespuesta3.HeaderText = "Respuesta 3";
            this.cRespuesta3.MinimumWidth = 6;
            this.cRespuesta3.Name = "cRespuesta3";
            this.cRespuesta3.ReadOnly = true;
            this.cRespuesta3.Width = 125;
            // 
            // cCorrecta
            // 
            this.cCorrecta.DataPropertyName = "Correcta";
            this.cCorrecta.HeaderText = "Correcta";
            this.cCorrecta.MinimumWidth = 6;
            this.cCorrecta.Name = "cCorrecta";
            this.cCorrecta.ReadOnly = true;
            this.cCorrecta.Width = 125;
            // 
            // cImagen
            // 
            this.cImagen.DataPropertyName = "Imagen";
            this.cImagen.HeaderText = "Imagen";
            this.cImagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.cImagen.MinimumWidth = 6;
            this.cImagen.Name = "cImagen";
            this.cImagen.ReadOnly = true;
            this.cImagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cImagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cImagen.Width = 125;
            // 
            // MantenimientoPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 728);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tspPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenimientoPreguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Preguntas";
            this.Load += new System.EventHandler(this.MantenimientoPreguntas_Load);
            this.tspPrincipal.ResumeLayout(false);
            this.tspPrincipal.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripBtnNuevo;
        private System.Windows.Forms.ToolStripButton toolStripBtnEditar;
        private System.Windows.Forms.ToolStripButton toolStripBtnBorrar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label labelCerti;
        private System.Windows.Forms.Label labelExamen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMarcar3;
        private System.Windows.Forms.Button btnMarcar2;
        private System.Windows.Forms.Button btnMarcar1;
        private System.Windows.Forms.TextBox txtCorrecta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtR3;
        private System.Windows.Forms.TextBox txtR2;
        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCambiarImagen;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtEnunciado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEnunciado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRespuesta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRespuesta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRespuesta3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCorrecta;
        private System.Windows.Forms.DataGridViewImageColumn cImagen;
    }
}