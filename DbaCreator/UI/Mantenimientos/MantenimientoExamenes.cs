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
    public partial class MantenimientoExamenes : Form
    {
        ICertificacionLN logicaCertificaciones = new CertificacionLN();
        IExamenLN logicaExamenes = new ExamenLN();
        int cont = 0;
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public MantenimientoExamenes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Llena los objetos gráficos y los ajusta para su debido uso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MantenimientoExamenes_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvDatos.AutoGenerateColumns = false;
                cmbCerti.DataSource = logicaCertificaciones.ObtenerTodos();
                cmbCerti.DisplayMember = "Descripcion";
                CargarDatos();
                _MyLogControlEventos.Info("Datos cargados");
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Examenes: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        /// <summary>
        /// llena el datagrid  on los objetos de la bd
        /// </summary>
        private void CargarDatos()
        {
            this.dgvDatos.DataSource = logicaExamenes.ObtenerTodos();
        }

        /// <summary>
        /// Reinicia la interfaz para crear un nuevo examen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            deshabilitar();
            habilitar();
            //numID.Value = dgvDatos.RowCount+1;
        }

        /// <summary>
        /// Habilita objetos gráficos
        /// </summary>
        private void habilitar()
        {
            this.numID.Enabled = true;
            this.cmbCerti.Enabled = true;
            numMInutos.Enabled = true;
            numNota.Enabled = true;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            //btnPreguntas.Enabled = true;
            txtTitulo.Enabled = true;
        }

        /// <summary>
        /// deshabilita y limpia objetos gráficos
        /// </summary>
        private void deshabilitar()
        {
            this.numID.Enabled = false;
            this.cmbCerti.Enabled = false;
            numMInutos.Enabled = false;
            numPreguntas.Enabled = false;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPreguntas.Enabled = false;
            txtTitulo.Enabled = false;
            numNota.Enabled = false;

            numID.Value = 1;
            numMInutos.Value = 1;
            numPreguntas.Value = 0;
            cmbCerti.SelectedIndex = 0;
            txtTitulo.Text = "";
        }

        /// <summary>
        /// pide confirmación y borra el registro seleccionado de la bd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    Examen examen = this.dgvDatos.SelectedRows[0].DataBoundItem as Examen;
                    if (MessageBox.Show($"¿Seguro que desea borrar el registro {examen.ID} {examen.Titulo}? Las preguntas asociadas se borrarán", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _MyLogControlEventos.Info($"Se borrró el examen: {examen.ID}");
                        logicaExamenes.Borrar(examen.ID);
                        this.CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                deshabilitar();
                CargarDatos();
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Examenes: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Coloca los datos del objeto seleccionado en el panel derecho para su edición
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnEditar_Click(object sender, EventArgs e)
        {
            cont++;
            if(cont == 1)
                MessageBox.Show("Advertencia: si cambia el ID podría generar problemas, cambielo solo en caso de que sepa lo que está haciendo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {

                    this.btnPreguntas.Enabled = true;
                    habilitar();
                    Examen examen = this.dgvDatos.SelectedRows[0].DataBoundItem as Examen;
                    numID.Value = examen.ID;
                    cmbCerti.SelectedIndex = examen.CertificacionA.Id - 1;
                    txtTitulo.Text = examen.Titulo;
                    numMInutos.Value = examen.Minutos;
                    numPreguntas.Value = examen.CantPreguntas;
                    _MyLogControlEventos.Info($"Edición del examen: {examen.ID}");
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Examenes: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Guarda/actualiza los datos en la bd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Examen examen = new Examen();
                if (string.IsNullOrEmpty(txtTitulo.Text))
                {
                    MessageBox.Show("Titulo requerido");
                    txtTitulo.Focus();
                    return;
                }

                examen.ID = (int)numID.Value;
                examen.CertificacionA = (Certificacion)cmbCerti.SelectedItem;
                examen.Titulo = txtTitulo.Text;
                examen.Minutos = (int)numMInutos.Value;
                examen.CantPreguntas = (int)numPreguntas.Value;
                examen.NotaMinima = (double)numNota.Value;

                logicaExamenes.Guardar(examen);
                _MyLogControlEventos.Info($"Se guardó el examen: {examen.ID}");
                if (examen != null)
                    CargarDatos();

                deshabilitar();
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Examenes: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Llama a deshabilitar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            try
            {
                deshabilitar();
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Examenes: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Abre una ventana para editar las preguntas del examen seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreguntas_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    var frm = new MantenimientoPreguntas();
                    Examen examen = this.dgvDatos.SelectedRows[0].DataBoundItem as Examen;
                    frm.AsignarExamen(examen);
                    frm.Show();
                    frm.Closed += (s, args) => this.CargarDatos();
                    _MyLogControlEventos.Info($"Se editan las preguntas del examen: {examen.ID}");
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Examenes: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
