
namespace UI
{
    partial class MantenimientoExamenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoExamenes));
            this.tspPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCertificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMinutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numNota = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPreguntas = new System.Windows.Forms.Button();
            this.cmbCerti = new System.Windows.Forms.ComboBox();
            this.numMInutos = new System.Windows.Forms.NumericUpDown();
            this.numPreguntas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tspPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMInutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreguntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
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
            this.tspPrincipal.Size = new System.Drawing.Size(1304, 55);
            this.tspPrincipal.TabIndex = 4;
            // 
            // toolStripBtnNuevo
            // 
            this.toolStripBtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnNuevo.Image")));
            this.toolStripBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNuevo.Name = "toolStripBtnNuevo";
            this.toolStripBtnNuevo.Size = new System.Drawing.Size(104, 52);
            this.toolStripBtnNuevo.Text = "&Nuevo";
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
            this.splitContainer1.Panel2.Controls.Add(this.numNota);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txtTitulo);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.btnAceptar);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnPreguntas);
            this.splitContainer1.Panel2.Controls.Add(this.cmbCerti);
            this.splitContainer1.Panel2.Controls.Add(this.numMInutos);
            this.splitContainer1.Panel2.Controls.Add(this.numPreguntas);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.numID);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(1304, 511);
            this.splitContainer1.SplitterDistance = 858;
            this.splitContainer1.TabIndex = 5;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cCertificacion,
            this.cTitulo,
            this.cMinutos,
            this.cCantp,
            this.cNota});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(858, 511);
            this.dgvDatos.TabIndex = 1;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "ID";
            this.cID.HeaderText = "ID";
            this.cID.MinimumWidth = 6;
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Width = 125;
            // 
            // cCertificacion
            // 
            this.cCertificacion.DataPropertyName = "NombreCertificacion";
            this.cCertificacion.HeaderText = "Certificación";
            this.cCertificacion.MinimumWidth = 6;
            this.cCertificacion.Name = "cCertificacion";
            this.cCertificacion.ReadOnly = true;
            this.cCertificacion.Width = 125;
            // 
            // cTitulo
            // 
            this.cTitulo.DataPropertyName = "Titulo";
            this.cTitulo.HeaderText = "Título";
            this.cTitulo.MinimumWidth = 6;
            this.cTitulo.Name = "cTitulo";
            this.cTitulo.ReadOnly = true;
            this.cTitulo.Width = 125;
            // 
            // cMinutos
            // 
            this.cMinutos.DataPropertyName = "Minutos";
            this.cMinutos.HeaderText = "Minutos";
            this.cMinutos.MinimumWidth = 6;
            this.cMinutos.Name = "cMinutos";
            this.cMinutos.ReadOnly = true;
            this.cMinutos.Width = 125;
            // 
            // cCantp
            // 
            this.cCantp.DataPropertyName = "CantPreguntas";
            this.cCantp.HeaderText = "Cantidad De Preguntas";
            this.cCantp.MinimumWidth = 6;
            this.cCantp.Name = "cCantp";
            this.cCantp.ReadOnly = true;
            this.cCantp.Width = 125;
            // 
            // cNota
            // 
            this.cNota.DataPropertyName = "NotaMinima";
            this.cNota.HeaderText = "Nota Mínima";
            this.cNota.MinimumWidth = 6;
            this.cNota.Name = "cNota";
            this.cNota.ReadOnly = true;
            this.cNota.Width = 125;
            // 
            // numNota
            // 
            this.numNota.Enabled = false;
            this.numNota.Location = new System.Drawing.Point(199, 322);
            this.numNota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNota.Name = "numNota";
            this.numNota.Size = new System.Drawing.Size(231, 22);
            this.numNota.TabIndex = 46;
            this.numNota.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Nota Mínima Para Pasar";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(112, 139);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(318, 22);
            this.txtTitulo.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Título";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(233, 444);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(197, 53);
            this.btnAceptar.TabIndex = 41;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(14, 444);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(211, 53);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPreguntas
            // 
            this.btnPreguntas.Enabled = false;
            this.btnPreguntas.Location = new System.Drawing.Point(14, 382);
            this.btnPreguntas.Name = "btnPreguntas";
            this.btnPreguntas.Size = new System.Drawing.Size(416, 55);
            this.btnPreguntas.TabIndex = 40;
            this.btnPreguntas.Text = "Editar preguntas";
            this.btnPreguntas.UseVisualStyleBackColor = true;
            this.btnPreguntas.Click += new System.EventHandler(this.btnPreguntas_Click);
            // 
            // cmbCerti
            // 
            this.cmbCerti.Enabled = false;
            this.cmbCerti.FormattingEnabled = true;
            this.cmbCerti.Location = new System.Drawing.Point(112, 72);
            this.cmbCerti.Name = "cmbCerti";
            this.cmbCerti.Size = new System.Drawing.Size(318, 24);
            this.cmbCerti.TabIndex = 39;
            // 
            // numMInutos
            // 
            this.numMInutos.Enabled = false;
            this.numMInutos.Location = new System.Drawing.Point(112, 202);
            this.numMInutos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMInutos.Name = "numMInutos";
            this.numMInutos.Size = new System.Drawing.Size(318, 22);
            this.numMInutos.TabIndex = 38;
            this.numMInutos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPreguntas
            // 
            this.numPreguntas.Enabled = false;
            this.numPreguntas.Location = new System.Drawing.Point(199, 259);
            this.numPreguntas.Name = "numPreguntas";
            this.numPreguntas.Size = new System.Drawing.Size(231, 22);
            this.numPreguntas.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Cantidad de Preguntas";
            // 
            // numID
            // 
            this.numID.Enabled = false;
            this.numID.Location = new System.Drawing.Point(112, 19);
            this.numID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(318, 22);
            this.numID.TabIndex = 35;
            this.numID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Minutos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Certificación";
            // 
            // MantenimientoExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 566);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tspPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MantenimientoExamenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Examenes";
            this.Load += new System.EventHandler(this.MantenimientoExamenes_Load);
            this.tspPrincipal.ResumeLayout(false);
            this.tspPrincipal.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMInutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreguntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPreguntas;
        private System.Windows.Forms.ComboBox cmbCerti;
        private System.Windows.Forms.NumericUpDown numMInutos;
        private System.Windows.Forms.NumericUpDown numPreguntas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numNota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCertificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMinutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNota;
    }
}