
namespace UI
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.itemExamen = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeCertificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoExamenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeCertificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemExamen,
            this.itemMantenimientos,
            this.itemReportes,
            this.btnSalir});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1222, 56);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // itemExamen
            // 
            this.itemExamen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarExamenToolStripMenuItem,
            this.facturarExamenToolStripMenuItem});
            this.itemExamen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemExamen.Image = ((System.Drawing.Image)(resources.GetObject("itemExamen.Image")));
            this.itemExamen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemExamen.Name = "itemExamen";
            this.itemExamen.Size = new System.Drawing.Size(132, 52);
            this.itemExamen.Text = "Examen";
            // 
            // realizarExamenToolStripMenuItem
            // 
            this.realizarExamenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("realizarExamenToolStripMenuItem.Image")));
            this.realizarExamenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.realizarExamenToolStripMenuItem.Name = "realizarExamenToolStripMenuItem";
            this.realizarExamenToolStripMenuItem.Size = new System.Drawing.Size(265, 72);
            this.realizarExamenToolStripMenuItem.Text = "Realizar Examen";
            this.realizarExamenToolStripMenuItem.Click += new System.EventHandler(this.realizarExamenToolStripMenuItem_Click);
            // 
            // facturarExamenToolStripMenuItem
            // 
            this.facturarExamenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facturarExamenToolStripMenuItem.Image")));
            this.facturarExamenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.facturarExamenToolStripMenuItem.Name = "facturarExamenToolStripMenuItem";
            this.facturarExamenToolStripMenuItem.Size = new System.Drawing.Size(265, 72);
            this.facturarExamenToolStripMenuItem.Text = "Facturar Examen";
            this.facturarExamenToolStripMenuItem.Click += new System.EventHandler(this.facturarExamenToolStripMenuItem_Click);
            // 
            // itemMantenimientos
            // 
            this.itemMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoClientesToolStripMenuItem,
            this.mantenimientoDeCertificacionToolStripMenuItem,
            this.mantenimientoExamenesToolStripMenuItem});
            this.itemMantenimientos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemMantenimientos.Image = ((System.Drawing.Image)(resources.GetObject("itemMantenimientos.Image")));
            this.itemMantenimientos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemMantenimientos.Name = "itemMantenimientos";
            this.itemMantenimientos.Size = new System.Drawing.Size(196, 52);
            this.itemMantenimientos.Text = "Mantenimientos";
            // 
            // mantenimientoClientesToolStripMenuItem
            // 
            this.mantenimientoClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoClientesToolStripMenuItem.Image")));
            this.mantenimientoClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mantenimientoClientesToolStripMenuItem.Name = "mantenimientoClientesToolStripMenuItem";
            this.mantenimientoClientesToolStripMenuItem.Size = new System.Drawing.Size(378, 54);
            this.mantenimientoClientesToolStripMenuItem.Text = "Mantenimiento Clientes";
            this.mantenimientoClientesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoClienteToolStripMenuItem_Click);
            // 
            // mantenimientoDeCertificacionToolStripMenuItem
            // 
            this.mantenimientoDeCertificacionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoDeCertificacionToolStripMenuItem.Image")));
            this.mantenimientoDeCertificacionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mantenimientoDeCertificacionToolStripMenuItem.Name = "mantenimientoDeCertificacionToolStripMenuItem";
            this.mantenimientoDeCertificacionToolStripMenuItem.Size = new System.Drawing.Size(378, 54);
            this.mantenimientoDeCertificacionToolStripMenuItem.Text = "Mantenimiento de Certificaciones";
            this.mantenimientoDeCertificacionToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeCertificacionToolStripMenuItem_Click);
            // 
            // mantenimientoExamenesToolStripMenuItem
            // 
            this.mantenimientoExamenesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoExamenesToolStripMenuItem.Image")));
            this.mantenimientoExamenesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mantenimientoExamenesToolStripMenuItem.Name = "mantenimientoExamenesToolStripMenuItem";
            this.mantenimientoExamenesToolStripMenuItem.Size = new System.Drawing.Size(378, 54);
            this.mantenimientoExamenesToolStripMenuItem.Text = "Mantenimiento Examenes";
            this.mantenimientoExamenesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoExamenesToolStripMenuItem_Click);
            // 
            // itemReportes
            // 
            this.itemReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeClientesToolStripMenuItem,
            this.reporteDeVentasToolStripMenuItem,
            this.reporteDeCertificacionesToolStripMenuItem,
            this.reporteDeFacturasToolStripMenuItem,
            this.reporteDeToolStripMenuItem});
            this.itemReportes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemReportes.Image = ((System.Drawing.Image)(resources.GetObject("itemReportes.Image")));
            this.itemReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemReportes.Name = "itemReportes";
            this.itemReportes.Size = new System.Drawing.Size(139, 52);
            this.itemReportes.Text = "Reportes";
            // 
            // reporteDeClientesToolStripMenuItem
            // 
            this.reporteDeClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteDeClientesToolStripMenuItem.Image")));
            this.reporteDeClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reporteDeClientesToolStripMenuItem.Name = "reporteDeClientesToolStripMenuItem";
            this.reporteDeClientesToolStripMenuItem.Size = new System.Drawing.Size(372, 54);
            this.reporteDeClientesToolStripMenuItem.Text = "Reporte de Clientes";
            this.reporteDeClientesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeClientesToolStripMenuItem_Click);
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteDeVentasToolStripMenuItem.Image")));
            this.reporteDeVentasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(372, 54);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas";
            this.reporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // reporteDeCertificacionesToolStripMenuItem
            // 
            this.reporteDeCertificacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteDeCertificacionesToolStripMenuItem.Image")));
            this.reporteDeCertificacionesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reporteDeCertificacionesToolStripMenuItem.Name = "reporteDeCertificacionesToolStripMenuItem";
            this.reporteDeCertificacionesToolStripMenuItem.Size = new System.Drawing.Size(372, 54);
            this.reporteDeCertificacionesToolStripMenuItem.Text = "Examenes Realizados por Cliente";
            this.reporteDeCertificacionesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeCertificacionesToolStripMenuItem_Click);
            // 
            // reporteDeFacturasToolStripMenuItem
            // 
            this.reporteDeFacturasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteDeFacturasToolStripMenuItem.Image")));
            this.reporteDeFacturasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reporteDeFacturasToolStripMenuItem.Name = "reporteDeFacturasToolStripMenuItem";
            this.reporteDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(372, 54);
            this.reporteDeFacturasToolStripMenuItem.Text = "Clientes Certificados";
            this.reporteDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeFacturasToolStripMenuItem_Click);
            // 
            // reporteDeToolStripMenuItem
            // 
            this.reporteDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteDeToolStripMenuItem.Image")));
            this.reporteDeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reporteDeToolStripMenuItem.Name = "reporteDeToolStripMenuItem";
            this.reporteDeToolStripMenuItem.Size = new System.Drawing.Size(372, 54);
            this.reporteDeToolStripMenuItem.Text = "Gráfico";
            this.reporteDeToolStripMenuItem.Click += new System.EventHandler(this.reporteDeToolStripMenuItem_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(173, 52);
            this.btnSalir.Text = "Cerrar Sesión";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1222, 748);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem itemExamen;
        private System.Windows.Forms.ToolStripMenuItem itemMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem itemReportes;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.ToolStripMenuItem realizarExamenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarExamenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoExamenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeCertificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeCertificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeToolStripMenuItem;
    }
}