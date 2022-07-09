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
    public partial class FrmReporteVentas : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public FrmReporteVentas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// carga todos los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReporteVentas_Load(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();
        }

        /// <summary>
        /// Llena el reporte con los datos que esten entre la fecha Desde y hasta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime desde;
            DateTime hasta;
            try
            {
                desde = this.dateTimePickerd.Value;
                hasta = this.dateTimePickerh.Value;

                this.PA_ReporteVentasTableAdapter.Fill(this.DataSetReportes.PA_ReporteVentas, desde, hasta);

                this.reportViewer.RefreshReport();
                _MyLogControlEventos.Info("Datos encontrados");
            } 
            catch(Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el reporte de ventas: " + er.Message);
            }
        }

        /// <summary>
        /// Cierra la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
