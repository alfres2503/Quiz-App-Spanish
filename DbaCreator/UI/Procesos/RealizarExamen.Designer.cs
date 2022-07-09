
namespace UI
{
    partial class RealizarExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarExamen));
            this.label5 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnRealizarExamen = new System.Windows.Forms.Button();
            this.gBValidacion = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbExamen = new System.Windows.Forms.GroupBox();
            this.textBoxTiempo = new System.Windows.Forms.TextBox();
            this.lbTotalTiempo = new System.Windows.Forms.Label();
            this.lblSlash = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalPreguntas = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.radioR3 = new System.Windows.Forms.RadioButton();
            this.radioR2 = new System.Windows.Forms.RadioButton();
            this.radioR1 = new System.Windows.Forms.RadioButton();
            this.rtEnunciado = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.gBValidacion.SuspendLayout();
            this.gbExamen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Identificación:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(7, 60);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(157, 18);
            this.lbl1.TabIndex = 16;
            this.lbl1.Text = "Nombre del Cliente:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(803, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(152, 20);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre del Cliente";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(848, 146);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(107, 20);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "ID del cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Código de Realización:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(665, 236);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(290, 27);
            this.txtCodigo.TabIndex = 21;
            // 
            // btnRealizarExamen
            // 
            this.btnRealizarExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarExamen.Location = new System.Drawing.Point(755, 310);
            this.btnRealizarExamen.Name = "btnRealizarExamen";
            this.btnRealizarExamen.Size = new System.Drawing.Size(200, 52);
            this.btnRealizarExamen.TabIndex = 22;
            this.btnRealizarExamen.Text = "Comenzar Examen";
            this.btnRealizarExamen.UseVisualStyleBackColor = true;
            this.btnRealizarExamen.Click += new System.EventHandler(this.btnRealizarExamen_Click);
            // 
            // gBValidacion
            // 
            this.gBValidacion.Controls.Add(this.btnSalir);
            this.gBValidacion.Controls.Add(this.lbl1);
            this.gBValidacion.Controls.Add(this.btnRealizarExamen);
            this.gBValidacion.Controls.Add(this.lblNombre);
            this.gBValidacion.Controls.Add(this.txtCodigo);
            this.gBValidacion.Controls.Add(this.label5);
            this.gBValidacion.Controls.Add(this.label1);
            this.gBValidacion.Controls.Add(this.lblID);
            this.gBValidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBValidacion.Location = new System.Drawing.Point(17, 278);
            this.gBValidacion.Name = "gBValidacion";
            this.gBValidacion.Size = new System.Drawing.Size(968, 368);
            this.gBValidacion.TabIndex = 23;
            this.gBValidacion.TabStop = false;
            this.gBValidacion.Text = "Ingrese su Código";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(6, 310);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 52);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbExamen
            // 
            this.gbExamen.Controls.Add(this.textBoxTiempo);
            this.gbExamen.Controls.Add(this.lbTotalTiempo);
            this.gbExamen.Controls.Add(this.lblSlash);
            this.gbExamen.Controls.Add(this.label6);
            this.gbExamen.Controls.Add(this.lblTotalPreguntas);
            this.gbExamen.Controls.Add(this.lblNo);
            this.gbExamen.Controls.Add(this.label3);
            this.gbExamen.Controls.Add(this.lblTiempo);
            this.gbExamen.Controls.Add(this.gBValidacion);
            this.gbExamen.Controls.Add(this.label2);
            this.gbExamen.Controls.Add(this.btnSiguiente);
            this.gbExamen.Controls.Add(this.radioR3);
            this.gbExamen.Controls.Add(this.radioR2);
            this.gbExamen.Controls.Add(this.radioR1);
            this.gbExamen.Controls.Add(this.rtEnunciado);
            this.gbExamen.Controls.Add(this.pictureBox);
            this.gbExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbExamen.Location = new System.Drawing.Point(12, 3);
            this.gbExamen.Name = "gbExamen";
            this.gbExamen.Size = new System.Drawing.Size(991, 657);
            this.gbExamen.TabIndex = 24;
            this.gbExamen.TabStop = false;
            // 
            // textBoxTiempo
            // 
            this.textBoxTiempo.Location = new System.Drawing.Point(117, 206);
            this.textBoxTiempo.Name = "textBoxTiempo";
            this.textBoxTiempo.ReadOnly = true;
            this.textBoxTiempo.Size = new System.Drawing.Size(100, 27);
            this.textBoxTiempo.TabIndex = 40;
            this.textBoxTiempo.Text = "00:00:00";
            this.textBoxTiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTiempo.Visible = false;
            // 
            // lbTotalTiempo
            // 
            this.lbTotalTiempo.AutoSize = true;
            this.lbTotalTiempo.Location = new System.Drawing.Point(243, 209);
            this.lbTotalTiempo.Name = "lbTotalTiempo";
            this.lbTotalTiempo.Size = new System.Drawing.Size(18, 20);
            this.lbTotalTiempo.TabIndex = 39;
            this.lbTotalTiempo.Text = "0";
            this.lbTotalTiempo.Visible = false;
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.Location = new System.Drawing.Point(223, 208);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(14, 20);
            this.lblSlash.TabIndex = 38;
            this.lblSlash.Text = "/";
            this.lblSlash.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(908, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "de";
            this.label6.Visible = false;
            // 
            // lblTotalPreguntas
            // 
            this.lblTotalPreguntas.AutoSize = true;
            this.lblTotalPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPreguntas.Location = new System.Drawing.Point(956, 213);
            this.lblTotalPreguntas.Name = "lblTotalPreguntas";
            this.lblTotalPreguntas.Size = new System.Drawing.Size(16, 18);
            this.lblTotalPreguntas.TabIndex = 34;
            this.lblTotalPreguntas.Text = "1";
            this.lblTotalPreguntas.Visible = false;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(870, 213);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(16, 18);
            this.lblNo.TabIndex = 33;
            this.lblNo.Text = "1";
            this.lblNo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(769, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Pregunta No:";
            this.label3.Visible = false;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(114, 142);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(16, 18);
            this.lblTiempo.TabIndex = 31;
            this.lblTiempo.Text = "0";
            this.lblTiempo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tiempo:";
            this.label2.Visible = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(803, 596);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(171, 50);
            this.btnSiguiente.TabIndex = 29;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // radioR3
            // 
            this.radioR3.AutoSize = true;
            this.radioR3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioR3.Location = new System.Drawing.Point(28, 610);
            this.radioR3.Name = "radioR3";
            this.radioR3.Size = new System.Drawing.Size(81, 22);
            this.radioR3.TabIndex = 28;
            this.radioR3.TabStop = true;
            this.radioR3.Text = "radioR3";
            this.radioR3.UseVisualStyleBackColor = true;
            this.radioR3.Visible = false;
            // 
            // radioR2
            // 
            this.radioR2.AutoSize = true;
            this.radioR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioR2.Location = new System.Drawing.Point(28, 504);
            this.radioR2.Name = "radioR2";
            this.radioR2.Size = new System.Drawing.Size(81, 22);
            this.radioR2.TabIndex = 27;
            this.radioR2.TabStop = true;
            this.radioR2.Text = "radioR2";
            this.radioR2.UseVisualStyleBackColor = true;
            this.radioR2.Visible = false;
            // 
            // radioR1
            // 
            this.radioR1.AutoSize = true;
            this.radioR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioR1.Location = new System.Drawing.Point(28, 389);
            this.radioR1.Name = "radioR1";
            this.radioR1.Size = new System.Drawing.Size(81, 22);
            this.radioR1.TabIndex = 26;
            this.radioR1.TabStop = true;
            this.radioR1.Text = "radioR1";
            this.radioR1.UseVisualStyleBackColor = true;
            this.radioR1.Visible = false;
            // 
            // rtEnunciado
            // 
            this.rtEnunciado.Enabled = false;
            this.rtEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtEnunciado.Location = new System.Drawing.Point(28, 254);
            this.rtEnunciado.Name = "rtEnunciado";
            this.rtEnunciado.ReadOnly = true;
            this.rtEnunciado.Size = new System.Drawing.Size(946, 113);
            this.rtEnunciado.TabIndex = 25;
            this.rtEnunciado.Text = "";
            this.rtEnunciado.Visible = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(326, 37);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(331, 194);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 24;
            this.pictureBox.TabStop = false;
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // RealizarExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 672);
            this.Controls.Add(this.gbExamen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RealizarExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Examen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RealizarExamen_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RealizarExamen_FormClosed);
            this.Load += new System.EventHandler(this.RealizarExamen_Load);
            this.gBValidacion.ResumeLayout(false);
            this.gBValidacion.PerformLayout();
            this.gbExamen.ResumeLayout(false);
            this.gbExamen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnRealizarExamen;
        private System.Windows.Forms.GroupBox gBValidacion;
        private System.Windows.Forms.GroupBox gbExamen;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RichTextBox rtEnunciado;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.RadioButton radioR3;
        private System.Windows.Forms.RadioButton radioR2;
        private System.Windows.Forms.RadioButton radioR1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalPreguntas;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.Label lbTotalTiempo;
        private System.Windows.Forms.TextBox textBoxTiempo;
    }
}