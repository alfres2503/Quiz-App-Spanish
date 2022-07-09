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

namespace UI
{
    public partial class MantenimientoCertificaciones : Form
    {
        ICertificacionLN logica = new CertificacionLN();
        int cont = 0;
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public MantenimientoCertificaciones()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los datos y captura excepciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MantenimientoCertificaciones_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
                _MyLogControlEventos.Info("Certificaciones cargadas");
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Certificaciones: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Llena el datagridview con las certificaciones en la base de datos
        /// </summary>
        private void CargarDatos()
        {
            dataGridView1.DataSource = logica.ObtenerTodos();
        }

        /// <summary>
        /// habilita botones y elementos gráficos
        /// </summary>
        private void habilitar()
        {
            this.txtDescripcion.Enabled = true;
            this.txtPrecio.Enabled = true;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            numID.Enabled = true;
        }

        /// <summary>
        /// deshabilita y resetea o limpia botones y elementos gráficos
        /// </summary>
        private void deshabilitar()
        {
            this.txtDescripcion.Enabled = false;
            this.txtPrecio.Enabled = false;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            numID.Enabled = false;

            numID.Value = 1;
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
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

        /// <summary>
        /// Se resetea la ventana para poder crear una nueva certificación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            deshabilitar();
            habilitar();
            _MyLogControlEventos.Info("Nueva certificación");
            //numID.Value = dataGridView1.RowCount + 1;
        }

        /// <summary>
        /// Coloca los datos del objeto seleccionado para poder ser editados en el panel derecho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnEditar_Click(object sender, EventArgs e)
        {
            cont++;
            if (cont == 1)
            {
                _MyLogControlEventos.Warn("si cambia el ID podría generar problemas");
                MessageBox.Show("Advertencia: si cambia el ID podría generar problemas, cambielo solo en caso de que sepa lo que está haciendo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Certificacion certificacion = null;

            try
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    habilitar();
                    certificacion = this.dataGridView1.SelectedRows[0].DataBoundItem as Certificacion;
                    txtDescripcion.Text = certificacion.Descripcion;
                    txtPrecio.Text = certificacion.Precio.ToString();
                    numID.Value = certificacion.Id;
                    _MyLogControlEventos.Info("Edición de la certificación "+ certificacion.Id);
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de certificaciones: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Llama al método deshabilitar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitar();
        }

        /// <summary>
        /// Pregunta al usuario si está seguro de querer borrar y mediante la capa BLL borra dcho registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    Certificacion certificacion = this.dataGridView1.SelectedRows[0].DataBoundItem as Certificacion;
                    if (MessageBox.Show($"¿Seguro que desea borrar el registro {certificacion.Id} {certificacion.Descripcion}? Los examenes de dicha certificación tambíen se borrarán", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _MyLogControlEventos.Info("Se borró la certificación " + certificacion.Id);
                        logica.Borrar(certificacion.Id);
                        this.CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                deshabilitar();
                CargarDatos();
            } catch(Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de certificaciones: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Valida los datos y los guarda/actualiza en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Certificacion certificacion = new Certificacion();

                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Descripcion requerida");
                    txtDescripcion.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Precio requerido");
                    txtPrecio.Focus();
                    return;
                }

                certificacion.Id = (int)numID.Value;
                certificacion.Descripcion = txtDescripcion.Text;
                certificacion.Precio = Convert.ToDouble(txtPrecio.Text);

                _MyLogControlEventos.Info("Se guardó la certificación " + certificacion.Id);
                logica.Guardar(certificacion);

                if (certificacion != null)
                    CargarDatos();

                deshabilitar();
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de certificaciones: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
