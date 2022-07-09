using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Reportes
{
    public partial class ReporteFactura : Form
    {
        int noFactura;
        string correo;
        string ruta;
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public ReporteFactura(int numeroFactura, string correoC)
        {
            InitializeComponent();
            this.noFactura = numeroFactura;
            this.correo = correoC;
        }

        /// <summary>
        /// Crea un reporte con la factura y el código QR correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReporteFactura_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaQR = @"file:///" + @"C:/TEMP/qrFactura.png";

                this.PA_SeleccionarDetallesPorFacturaTableAdapter.Fill(this.DataSetReportes.PA_SeleccionarDetallesPorFactura, noFactura);

                this.reportViewer.LocalReport.EnableExternalImages = true;
                ReportParameter param = new ReportParameter("quickresponse", rutaQR);
                this.reportViewer.LocalReport.SetParameters(param);

                this.reportViewer.RefreshReport();
                _MyLogControlEventos.Info($"Reporte de Factura {noFactura} generado");

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el reporte de la factura: " + er.Message);
            }
            
        }
        /// <summary>
        /// Cierra la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Llama al método generarPDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                GenerarPDF();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el reporte de la factura: " + er.Message);
            }
        }

        /// <summary>
        /// Genera el pdf
        /// </summary>
        public void GenerarPDF()
        {
            ruta = $@"c:\temp\factura{noFactura}.pdf";

            if (!Directory.Exists(@"c:\temp"))
                Directory.CreateDirectory(@"c:\temp");

            byte[] Bytes = this.reportViewer.LocalReport.Render(format: "PDF", deviceInfo: @"<DeviceInfo> <EmbedFonts>None</EmbedFonts> </DeviceInfo>");

            using (FileStream stream = new FileStream(ruta, FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }

            Process.Start(ruta);
            _MyLogControlEventos.Info($"PDF Generado");
        }

        /// <summary>
        /// Envía el pdf creado al correo del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnMail_Click(object sender, EventArgs e)
        {
            try
            {
                GenerarPDF();

                Thread.Sleep(50);

                MailMessage mensaje = new MailMessage();

                mensaje.From = new MailAddress("alfredosuarezaguilar@gmail.com", "DBACreator");
                mensaje.To.Add(this.correo);

                mensaje.Subject = "Factura";
                mensaje.Body = "¡Gracias! Se adjunta su factura.";
                mensaje.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("alfredosuarezaguilar@gmail.com", "Hjxc20d8910");
                smtp.EnableSsl = true;

                Attachment attachment = new Attachment($@"c:\temp\factura{noFactura}.pdf");
                mensaje.Attachments.Add(attachment);
                smtp.Send(mensaje);

                MessageBox.Show("Correo Enviado", "Evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _MyLogControlEventos.Info($"Mail enviado a {this.correo}");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el reporte de la factura: " + er.Message);
            }
        }
    }
}
