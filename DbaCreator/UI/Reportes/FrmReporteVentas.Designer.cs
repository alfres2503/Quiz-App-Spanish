
namespace UI.Reportes
{
    partial class FrmReporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteVentas));
            this.PA_ReporteVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReportes = new UI.Reportes.DataSetReportes();
            this.RVSplitContainer = new System.Windows.Forms.SplitContainer();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dateTimePickerh = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PA_ReporteVentasTableAdapter = new UI.Reportes.DataSetReportesTableAdapters.PA_ReporteVentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RVSplitContainer)).BeginInit();
            this.RVSplitContainer.Panel1.SuspendLayout();
            this.RVSplitContainer.Panel2.SuspendLayout();
            this.RVSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PA_ReporteVentasBindingSource
            // 
            this.PA_ReporteVentasBindingSource.DataMember = "PA_ReporteVentas";
            this.PA_ReporteVentasBindingSource.DataSource = this.DataSetReportes;
            // 
            // DataSetReportes
            // 
            this.DataSetReportes.DataSetName = "DataSetReportes";
            this.DataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RVSplitContainer
            // 
            this.RVSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RVSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.RVSplitContainer.Name = "RVSplitContainer";
            // 
            // RVSplitContainer.Panel1
            // 
            this.RVSplitContainer.Panel1.Controls.Add(this.reportViewer);
            // 
            // RVSplitContainer.Panel2
            // 
            this.RVSplitContainer.Panel2.Controls.Add(this.btnSalir);
            this.RVSplitContainer.Panel2.Controls.Add(this.btnBuscar);
            this.RVSplitContainer.Panel2.Controls.Add(this.dateTimePickerh);
            this.RVSplitContainer.Panel2.Controls.Add(this.dateTimePickerd);
            this.RVSplitContainer.Panel2.Controls.Add(this.label3);
            this.RVSplitContainer.Panel2.Controls.Add(this.label2);
            this.RVSplitContainer.Panel2.Controls.Add(this.label1);
            this.RVSplitContainer.Size = new System.Drawing.Size(1314, 510);
            this.RVSplitContainer.SplitterDistance = 914;
            this.RVSplitContainer.TabIndex = 0;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetVentas";
            reportDataSource1.Value = this.PA_ReporteVentasBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "UI.Reportes.ReporteDeVentas.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(914, 510);
            this.reportViewer.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(15, 416);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(146, 82);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(238, 416);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(146, 82);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dateTimePickerh
            // 
            this.dateTimePickerh.Location = new System.Drawing.Point(74, 110);
            this.dateTimePickerh.Name = "dateTimePickerh";
            this.dateTimePickerh.Size = new System.Drawing.Size(302, 22);
            this.dateTimePickerh.TabIndex = 4;
            // 
            // dateTimePickerd
            // 
            this.dateTimePickerd.Location = new System.Drawing.Point(74, 48);
            this.dateTimePickerd.Name = "dateTimePickerd";
            this.dateTimePickerd.Size = new System.Drawing.Size(301, 22);
            this.dateTimePickerd.TabIndex = 3;
            this.dateTimePickerd.Value = new System.DateTime(2022, 3, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por fecha:";
            // 
            // PA_ReporteVentasTableAdapter
            // 
            this.PA_ReporteVentasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 510);
            this.Controls.Add(this.RVSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.FrmReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).EndInit();
            this.RVSplitContainer.Panel1.ResumeLayout(false);
            this.RVSplitContainer.Panel2.ResumeLayout(false);
            this.RVSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RVSplitContainer)).EndInit();
            this.RVSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer RVSplitContainer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource PA_ReporteVentasBindingSource;
        private DataSetReportes DataSetReportes;
        private DataSetReportesTableAdapters.PA_ReporteVentasTableAdapter PA_ReporteVentasTableAdapter;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePickerh;
        private System.Windows.Forms.DateTimePicker dateTimePickerd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}