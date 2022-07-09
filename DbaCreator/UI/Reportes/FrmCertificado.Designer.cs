
namespace UI.Reportes
{
    partial class FrmCertificado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCertificado));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PA_DatosCertificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReportes = new UI.Reportes.DataSetReportes();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnMail = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnExportarPDF = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PA_DatosCertificacionTableAdapter = new UI.Reportes.DataSetReportesTableAdapters.PA_DatosCertificacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_DatosCertificacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).BeginInit();
            this.tspBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PA_DatosCertificacionBindingSource
            // 
            this.PA_DatosCertificacionBindingSource.DataMember = "PA_DatosCertificacion";
            this.PA_DatosCertificacionBindingSource.DataSource = this.DataSetReportes;
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
            this.tspBarraSuperior.Size = new System.Drawing.Size(942, 55);
            this.tspBarraSuperior.TabIndex = 3;
            this.tspBarraSuperior.Text = "toolStrip1";
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCertificado";
            reportDataSource1.Value = this.PA_DatosCertificacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Reportes.ReporteCertificacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 55);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(942, 497);
            this.reportViewer1.TabIndex = 4;
            // 
            // PA_DatosCertificacionTableAdapter
            // 
            this.PA_DatosCertificacionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCertificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 552);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.tspBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmCertificado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificado";
            this.Load += new System.EventHandler(this.FrmCertificado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_DatosCertificacionBindingSource)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PA_DatosCertificacionBindingSource;
        private DataSetReportes DataSetReportes;
        private DataSetReportesTableAdapters.PA_DatosCertificacionTableAdapter PA_DatosCertificacionTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripBtnMail;
    }
}