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
    public partial class FrmReporteClientes : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public FrmReporteClientes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga todos los clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReporteClientes_Load(object sender, EventArgs e)
        {
            toolStripBtnBuscar.PerformClick();
        }

        /// <summary>
        /// Usa un stored procedure para buscar según lo escrito en el textbox y carga el reporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = "";

            try
            {
                filtro = "%" + this.toolStripTxtFiltro.Text + "%";
                this.PA_ReporteClientesTableAdapter.Fill(this.DataSetReportes.PA_ReporteClientes, filtro);

                this.reportViewer1.RefreshReport();
                _MyLogControlEventos.Info("Datos encontrados");

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el reporte de clientes: " + er.Message);
            }
        }

        /// <summary>
        /// cierra la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
