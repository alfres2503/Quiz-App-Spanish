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

namespace UI
{
    public partial class Menu : Form
    {
        public Cliente cliente { get; set; }
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Revisa el tipo de usuario que entró y muestra las opciones disponibles según lo encontrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_Load(object sender, EventArgs e)
        {
            if (cliente.IdTipo == 2)
            {
                itemMantenimientos.Visible = false; 
                itemReportes.Visible = false;

            }
            else if (cliente.IdTipo == 3)
            {
                itemMantenimientos.Visible = false;
                itemExamen.Visible = false;
            }
            _MyLogControlEventos.Info($"Usuario: {cliente.Id} {cliente.Nombre} {cliente.Apellido}");
        }

        /// <summary>
        /// Pide confirmación para cerrar sesión y abre de nuevo el Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"Desea Cerrar Sesión?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.OK)
            {
                _MyLogControlEventos.Info("Sesión cerrada");
                this.Hide();
                var frm = new InicioSesion();
                frm.Closed += (s, args) => this.Close();
                frm.Show();
            } else
            {
                return;
            }

        }

        /// <summary>
        /// Crea una nueva ventana MDI del mantenimiento de Examenes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mantenimientoExamenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MyLogControlEventos.Info("Mantenimiento de examenes abierto");
            var frm = new MantenimientoExamenes();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Crea una nueva ventana MDI del mantenimiento de Clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mantenimientoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MyLogControlEventos.Info("Mantenimiento de clientes abierto");
            var frm = new MantenimientoClientes();
            frm.MdiParent = this;
            frm.Show();   
        }

        /// <summary>
        /// Crea una nueva ventana MDI del mantenimiento de certificaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mantenimientoDeCertificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MyLogControlEventos.Info("Mantenimiento de certificaciones abierto");
            var frm = new MantenimientoCertificaciones();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Crea una nueva ventana MDI de facturación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void facturarExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MyLogControlEventos.Info("Facturación abierto");
            var frm = new FacturacionExamenes();
            frm.AsignarCliente(cliente);
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Crea una nueva ventana MDI de realización de examen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void realizarExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MyLogControlEventos.Info("Realización de Examen abierto");
            var frm = new RealizarExamen(cliente);
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Crea una nueva ventana MDI del reporte de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MyLogControlEventos.Info("Reporte de Clientes consultado");
            var frm = new Reportes.FrmReporteClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Crea una nueva ventana MDI del reporte de ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MyLogControlEventos.Info("Reporte de Ventas consultado");
            var frm = new Reportes.FrmReporteVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Crea una nueva ventana MDI del reporte de examenes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reporteDeCertificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MyLogControlEventos.Info("Reporte de Examenes realizados por cliente consultado");
            var frm = new Reportes.FrmReporteExamenes();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Crea una nueva ventana MDI del reporte de clientes certificados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reporteDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MyLogControlEventos.Info("Reporte de clientes certificados consultado");
            var frm = new Reportes.FrmClientesCertificados();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Crea una nueva ventana MDI del reporte gráfico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reporteDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MyLogControlEventos.Info("Gráfico de clientes certificados consultado");
            var frm = new Reportes.FrmReporteGrafico();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Crea un log que informa del cierre de la app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MyLogControlEventos.Info("Aplicación cerrada");
        }
    }
}
