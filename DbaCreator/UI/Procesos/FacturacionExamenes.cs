using Capa.BLL;
using Capa.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Reportes;
using Utilitarios;

namespace UI
{
    public partial class FacturacionExamenes : Form
    {
        Cliente cliente;
        Certificacion certificacion;
        EncFactura encabezadoFactura;
        // DetFactura detalleFactura;
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        ICertificacionLN logicaCertificaciones = new CertificacionLN();
        IFacturaLN logicaFacturas;
        IExamenLN logicaExamenes = new ExamenLN();

        public FacturacionExamenes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Asigna el cliente que factura
        /// </summary>
        /// <param name="cliente">Cliente del que extrae los datos</param>
        public void AsignarCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        /// <summary>
        /// Configura los combobox, los label y asigna el número de factura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FacturacionExamenes_Load(object sender, EventArgs e)
        {
            try
            {
                toolStripBtnNuevo.PerformClick();

                lblNombre.Text = cliente.Nombre + " " + cliente.Apellido;
                lblID.Text = cliente.Id.ToString();

                cmbCertis.DataSource = logicaCertificaciones.ObtenerTodos();
                cmbCertis.DisplayMember = "Descripcion";

                certificacion = (Certificacion)cmbCertis.SelectedItem;

                cmbExamenes.DataSource = logicaExamenes.ObtenerPorCertificacion(certificacion.Id);
                cmbExamenes.DisplayMember = "Titulo";

                cmbTarjeta.DataSource = TarjetaLN.ObtenerTodos();
                cmbTarjeta.DisplayMember = "Nombre";

                txtNFactura.Text = logicaFacturas.ObtenerNumeroDeFacturaActual().ToString();

            } 
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en facturación: " + er.Message);
            }
        }

        /// <summary>
        /// Cambia el examen por uno de la certificación seleccionada al cambiar la certificación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCertis_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                certificacion = (Certificacion)cmbCertis.SelectedItem;
                cmbExamenes.DataSource = logicaExamenes.ObtenerPorCertificacion(certificacion.Id);
                cmbExamenes.DisplayMember = "Titulo";
                cmbExamenes.SelectedIndex = 0;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en facturación: " + er.Message);
            }
        }

        /// <summary>
        /// Ciera la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Agrega las compras a la tabla de detalles de la factura y evita posibles errores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (encabezadoFactura == null)
                {
                    MessageBox.Show("Debe agregar los datos del encabezado de la factura para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que el Producto ya no se haya agregado
                if (encabezadoFactura._ListaFacturaDetalle.Count > 0)
                {
                    foreach(var item in encabezadoFactura._ListaFacturaDetalle)
                    {
                        if (item.IDExamen == (cmbExamenes.SelectedItem as Examen).ID)
                        {
                            MessageBox.Show("El producto ya fue agregado previamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                DetFactura detalleFactura = new DetFactura();

                detalleFactura.IDFactura = encabezadoFactura.IDFactura;

                detalleFactura.Secuencia = encabezadoFactura._ListaFacturaDetalle.Count == 0 ?
                                                 1 : encabezadoFactura._ListaFacturaDetalle.Max(p => p.Secuencia) + 1;

                detalleFactura.IDExamen = (cmbExamenes.SelectedItem as Examen).ID;
                detalleFactura.Monto = (cmbCertis.SelectedItem as Certificacion).Precio;
                detalleFactura.ExamenRealizado = false;

                encabezadoFactura.AgregarDetalle(detalleFactura);

                string[] lineaFactura = {detalleFactura.Secuencia.ToString(),
                                         detalleFactura.IDExamen.ToString(),
                                         detalleFactura.Monto.ToString(),
                                         (cmbExamenes.SelectedItem as Examen).CantPreguntas.ToString(),
                                         (cmbExamenes.SelectedItem as Examen).Minutos.ToString() + " Minutos",
                                         (cmbExamenes.SelectedItem as Examen).NotaMinima.ToString()};

                dgvDetalle.Rows.Add(lineaFactura);
                _MyLogControlEventos.Info($"Se añade: {lineaFactura}");
                txtTotal.Text = encabezadoFactura.ObtenerTotal().ToString();
                textBoxColones.Text = (encabezadoFactura.ObtenerTotal()*BancoC.valorDolar()).ToString();

                this.cmbCertis.SelectedIndex = 0;
                this.cmbExamenes.SelectedIndex = 0;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en facturación: " + er.Message);
            }
        }

        /// <summary>
        /// Resetea la interfaz para empezar la compra de nuevo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            _MyLogControlEventos.Info($"Se crea una nueva factura");
            logicaFacturas = new FacturaLN();
            encabezadoFactura = new EncFactura();

            txtTotal.Text = "";
            this.textBoxColones.Text = "";

            encabezadoFactura.IDFactura = logicaFacturas.ObtenerNumeroDeFacturaActual();
            encabezadoFactura.IDCliente = cliente.Id;

            dgvDetalle.Rows.Clear();
            
        }

        /// <summary>
        /// Genera el qr, valida que los datos sean correctos y genera el reporte de la factura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnFacturar_Click(object sender, EventArgs e)
        {
            string rutaQR = @"c:\temp\qrFactura.png";
            int numeroFactura = 0;
            try
            {
                if (!mskNoTarjeta.MaskFull)
                {
                    mskNoTarjeta.Focus();
                    MessageBox.Show("Debe ingresar su número de tarjeta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (encabezadoFactura._ListaFacturaDetalle.Count == 0)
                {
                    MessageBox.Show("No hay items en la factura ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                encabezadoFactura.IDTarjeta = (cmbTarjeta.SelectedItem as Tarjeta).ID;
                encabezadoFactura.NumeroTarjeta = mskNoTarjeta.Text;
                encabezadoFactura.FechaFacturacion = DateTime.Now;

                logicaFacturas.Guardar(encabezadoFactura);

                numeroFactura = encabezadoFactura.IDFactura;

                if (File.Exists(rutaQR))
                    File.Delete(rutaQR);

                Image quickResponseImage = QuickResponse.QuickResponseGenerador(numeroFactura.ToString(), 53);
                quickResponseImage.Save(rutaQR, ImageFormat.Png);
                _MyLogControlEventos.Info($"Se factura por un total de: {txtTotal.Text}");
                toolStripBtnNuevo.PerformClick();

                ReporteFactura reporte = new ReporteFactura(numeroFactura, this.cliente.Email);
                reporte.ShowDialog();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en facturación: " + er.Message);
            }
        }


    }
}
