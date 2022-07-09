using Capa.BLL;
using Capa.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Reportes
{
    public partial class FrmClientesCertificados : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public FrmClientesCertificados()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Llena el combobox com las certificaciones existentes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmClientesCertificados_Load(object sender, EventArgs e)
        {
            try
            {
                var logica = new CertificacionLN();
                this.toolStripComboBoxCertis.ComboBox.DataSource = logica.ObtenerTodos();
                this.toolStripComboBoxCertis.ComboBox.DisplayMember = "Descripcion";

            } catch(Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el reporte de clientes certificados: " + er.Message);
            }
            
        }

        /// <summary>
        /// Carga el reporte según la certificación seleccionada en el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnBuscar_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = (toolStripComboBoxCertis.ComboBox.SelectedItem as Certificacion).Id;
                this.PA_ReporteClientesCertificadosTableAdapter.Fill(this.DataSetReportes.PA_ReporteClientesCertificados, id);

                this.reportViewer1.RefreshReport();
                _MyLogControlEventos.Info("Datos encontrados");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el reporte de clientes certificados: " + er.Message);
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
    }
}
