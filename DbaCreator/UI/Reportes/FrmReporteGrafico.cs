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
    public partial class FrmReporteGrafico : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public FrmReporteGrafico()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Llena el gráfico con los datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReporteGrafico_Load(object sender, EventArgs e)
        {
            try
            {
                this.PA_ReporteGraficoTableAdapter.Fill(this.DataSetReportes.PA_ReporteGrafico);

                this.reportViewer1.RefreshReport();
                _MyLogControlEventos.Info("Datos encontrados");
            } 
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el reporte gráfico: " + er.Message);
            }
            
            
        }
    }
}
