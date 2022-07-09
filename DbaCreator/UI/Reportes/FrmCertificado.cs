using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace UI.Reportes
{
    public partial class FrmCertificado : Form
    {
        int idIntento;
        string correo;
        string ruta;
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public FrmCertificado(int idIntento, string correoC)
        {
            InitializeComponent();
            this.idIntento = idIntento;
            this.correo = correoC;
        }

        /// <summary>
        /// Intenta cargar el reporte para que sea visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCertificado_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'DataSetReportes.PA_DatosCertificacion' table. You can move, or remove it, as needed.
                this.PA_DatosCertificacionTableAdapter.Fill(this.DataSetReportes.PA_DatosCertificacion, idIntento);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el certificado: " + er.Message);
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
        /// Exporta el pdf
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
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el certificado: " + er.Message);
            }
        }

        /// <summary>
        /// Envía el mail al correo del usuario
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

                mensaje.Subject = "Certificado";
                mensaje.Body = "¡Felicidades! Se adjunta su certificación.";
                mensaje.IsBodyHtml = true;
                
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("alfredosuarezaguilar@gmail.com", "Hjxc20d8910");
                smtp.EnableSsl = true;

                Attachment attachment = new Attachment($@"c:\temp\Certificado {idIntento}.pdf");
                mensaje.Attachments.Add(attachment);
                smtp.Send(mensaje);

                MessageBox.Show("Correo Enviado", "Evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _MyLogControlEventos.Info($"Mail enviado a {this.correo}");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el certificado: " + er.Message);
            }
        }

        /// <summary>
        /// Método que genera el pdf de la certificación
        /// </summary>
        private void GenerarPDF()
        {
            ruta = $@"c:\temp\Certificado {idIntento}.pdf";

            if (!Directory.Exists(@"c:\temp"))
                Directory.CreateDirectory(@"c:\temp");

            byte[] Bytes = this.reportViewer1.LocalReport.Render(format: "PDF", deviceInfo: @"<DeviceInfo> <EmbedFonts>None</EmbedFonts> </DeviceInfo>");

            using (FileStream stream = new FileStream(ruta, FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }

            Process.Start(ruta);
            _MyLogControlEventos.Info($"PDF Generado");
        }

    }
}
