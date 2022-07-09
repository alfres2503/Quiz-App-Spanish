
namespace UI.Reportes
{
    partial class ReporteFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteFactura));
            this.PA_SeleccionarDetallesPorFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReportes = new UI.Reportes.DataSetReportes();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnExportarPDF = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PA_SeleccionarDetallesPorFacturaTableAdapter = new UI.Reportes.DataSetReportesTableAdapters.PA_SeleccionarDetallesPorFacturaTableAdapter();
            this.toolStripBtnMail = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.PA_SeleccionarDetallesPorFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).BeginInit();
            this.tspBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PA_SeleccionarDetallesPorFacturaBindingSource
            // 
            this.PA_SeleccionarDetallesPorFacturaBindingSource.DataMember = "PA_SeleccionarDetallesPorFactura";
            this.PA_SeleccionarDetallesPorFacturaBindingSource.DataSource = this.DataSetReportes;
            // 
            // DataSetReportes
            // 
            this.DataSetReportes.DataSetName = "DataSetReportes";
            this.DataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnMail,
            this.toolStripBtnExportarPDF,
            this.toolStripBtnSalir});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.Size = new System.Drawing.Size(885, 55);
            this.tspBarraSuperior.TabIndex = 2;
            this.tspBarraSuperior.Text = "toolStrip1";
            // 
            // toolStripBtnExportarPDF
            // 
            this.toolStripBtnExportarPDF.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnExportarPDF.Image")));
            this.toolStripBtnExportarPDF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnExportarPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnExportarPDF.Name = "toolStripBtnExportarPDF";
            this.toolStripBtnExportarPDF.Size = new System.Drawing.Size(147, 52);
            this.toolStripBtnExportarPDF.Text = "Exportar PDF";
            this.toolStripBtnExportarPDF.Click += new System.EventHandler(this.toolStripBtnExportarPDF_Click);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSalir.Image")));
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(90, 52);
            this.toolStripBtnSalir.Text = "Salir";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFactura";
            reportDataSource1.Value = this.PA_SeleccionarDetallesPorFacturaBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "UI.Reportes.ReporteFactura.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 55);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(885, 509);
            this.reportViewer.TabIndex = 3;
            // 
            // PA_SeleccionarDetallesPorFacturaTableAdapter
            // 
            this.PA_SeleccionarDetallesPorFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripBtnMail
            // 
            this.toolStripBtnMail.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnMail.Image")));
            this.toolStripBtnMail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnMail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMail.Name = "toolStripBtnMail";
            this.toolStripBtnMail.Size = new System.Drawing.Size(239, 52);
            this.toolStripBtnMail.Text = "Enviar al Correo Registrado";
            this.toolStripBtnMail.Click += new System.EventHandler(this.toolStripBtnMail_Click);
            // 
            // ReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 564);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.tspBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ReporteFactura";
            this.Text = "Reporte de Factura";
            this.Load += new System.EventHandler(this.ReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_SeleccionarDetallesPorFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).EndInit();
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnExportarPDF;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource PA_SeleccionarDetallesPorFacturaBindingSource;
        private DataSetReportes DataSetReportes;
        private DataSetReportesTableAdapters.PA_SeleccionarDetallesPorFacturaTableAdapter PA_SeleccionarDetallesPorFacturaTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripBtnMail;
    }
}