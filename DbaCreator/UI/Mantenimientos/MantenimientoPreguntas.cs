using Capa.BLL;
using Capa.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MantenimientoPreguntas : Form
    {
        Examen examen = null;
        IPreguntaLN logicaPreguntas = new PreguntaLN();
        Pregunta pregunta;
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public MantenimientoPreguntas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// habilita objetos gráficos
        /// </summary>
        private void habilitar()
        {
            this.txtEnunciado.Enabled = true;
            this.txtR1.Enabled = true;
            txtR2.Enabled = true;
            txtR3.Enabled = true;
            //btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnMarcar1.Enabled = true;
            btnMarcar2.Enabled = true;
            btnMarcar3.Enabled = true;
            btnCambiarImagen.Enabled = true;
            txtEnunciado.ReadOnly = false;
        }

        /// <summary>
        /// deshabilita y limpia objetos gráficos
        /// </summary>
        private void deshabilitar()
        {
            this.txtEnunciado.Enabled = false;
            this.txtR1.Enabled = false;
            txtR2.Enabled = false;
            txtR3.Enabled = false;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            btnMarcar1.Enabled = false;
            btnMarcar2.Enabled = false;
            btnMarcar3.Enabled = false;
            btnCambiarImagen.Enabled = false;
            txtEnunciado.ReadOnly = true;

            txtEnunciado.Text = "";
            txtR1.Text = "";
            txtR2.Text = "";
            txtR3.Text = "";
            txtCorrecta.Text = "";
            pictureBox.Image = pictureBox2.Image;
        }

        /// <summary>
        /// Asigna el examen a editar
        /// </summary>
        /// <param name="ex">Examen a editar enviado desde otra ventana</param>
        public void AsignarExamen(Examen ex)
        {
            this.examen = ex;
        }

        /// <summary>
        /// Carga los datos en el datagrid y ajusta este ultimo
        /// </summary>
        private void CargarDatos()
        {
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.RowTemplate.Height = 100;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            this.dgvDatos.DataSource = logicaPreguntas.SeleccionarPorExamen(examen.ID);
        }

        /// <summary>
        /// Cierra la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Carga los datos y ajusta los elementos gráficos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MantenimientoPreguntas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
                labelExamen.Text = "Examen: " + examen.Titulo;
                labelCerti.Text = "Certificación: " + examen.NombreCertificacion;
                pictureBox.Image = pictureBox2.Image;
                txtEnunciado.ReadOnly = true;
                _MyLogControlEventos.Info("Preguntas cargadas");
            } catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Preguntas: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Reinicia la interfaz para crear una nueva pregunta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            deshabilitar();
            habilitar();
            pregunta = new Pregunta();
            _MyLogControlEventos.Info($"Se crea pregunta en el examen: {examen.ID}");
        }

        /// <summary>
        /// Coloca los datos del objeto seleccionado en el panel derecho para su edición
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    habilitar();
                    pregunta = this.dgvDatos.SelectedRows[0].DataBoundItem as Pregunta;
                    txtEnunciado.Text = pregunta.Enunciado;
                    txtR1.Text = pregunta.Respuesta1;
                    txtR2.Text = pregunta.Respuesta2;
                    txtR3.Text = pregunta.Respuesta3;
                    txtCorrecta.Text = pregunta.Correcta;
                    if (pregunta.Imagen != null)
                        pictureBox.Image = (Bitmap)((new ImageConverter()).ConvertFrom(pregunta.Imagen));
                    else
                        pictureBox.Image = pictureBox2.Image;
                    _MyLogControlEventos.Info($"Se edita pregunta en el examen: {examen.ID}");
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Preguntas: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Pide confirmación y borra el registro seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    pregunta = this.dgvDatos.SelectedRows[0].DataBoundItem as Pregunta;
                    if (MessageBox.Show($"¿Seguro que desea borrar la pregunta {pregunta.ID} | {pregunta.Enunciado}| ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _MyLogControlEventos.Info($"Se borra pregunta en el examen: {examen.ID}");
                        logicaPreguntas.Borrar(pregunta.ID);
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
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Preguntas: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// deshabilita
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
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Preguntas: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Marca la respuesta 1 como correcta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarcar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtR1.Text))
                {
                    MessageBox.Show("La respuesta 1 está vacía");
                } else
                {
                    txtCorrecta.Text = txtR1.Text;
                    btnAceptar.Enabled = true;
                }
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Preguntas: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Marca la respuesta 2 como correcta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarcar2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtR2.Text))
                {
                    MessageBox.Show("La respuesta 2 está vacía");
                }
                else
                {
                    txtCorrecta.Text = txtR2.Text;
                    btnAceptar.Enabled = true;
                }
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Preguntas: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Marca la respuesta 3 como correcta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarcar3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtR3.Text))
                {
                    MessageBox.Show("La respuesta 3 está vacía");
                }
                else
                {
                    txtCorrecta.Text = txtR3.Text;
                    btnAceptar.Enabled = true;
                }
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Preguntas: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Si una respuesta es cambiada deshabilita el botón de guardar para evitar problemas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtR1_TextChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
        }

        /// <summary>
        /// Si una respuesta es cambiada deshabilita el botón de guardar para evitar problemas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtR2_TextChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
        }

        /// <summary>
        /// Si una respuesta es cambiada deshabilita el botón de guardar para evitar problemas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtR3_TextChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
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
                if (string.IsNullOrEmpty(txtEnunciado.Text))
                {
                    MessageBox.Show("Enunciado requerido");
                    txtEnunciado.Focus();
                    return;
                }

                pregunta.IDExamen = examen.ID;
                pregunta.IDCertificacion = examen.CertificacionA.Id;
                pregunta.Enunciado = txtEnunciado.Text;
                pregunta.Respuesta1 = txtR1.Text;
                pregunta.Respuesta2 = txtR2.Text;
                pregunta.Respuesta3 = txtR3.Text;
                pregunta.Correcta = txtCorrecta.Text;
                pregunta.Imagen = imagenBytes(pictureBox.Image);
                
                if (examen != null)
                {
                    _MyLogControlEventos.Info($"Se guarda pregunta en el examen: {examen.ID}");
                    logicaPreguntas.Guardar(pregunta);
                    CargarDatos();
                }
                deshabilitar();
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Preguntas: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sirve para buscar una imagen nueva para la pregunta 
        /// si esta no es cambiada, usa la imagen predeterminada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectImage = new OpenFileDialog();
            selectImage.Filter = " png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (selectImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(selectImage.FileName);
                
            }
        }

        /// <summary>
        /// Convierte la imagen a bytes
        /// </summary>
        /// <param name="imageIn">Imagen a convertir</param>
        /// <returns></returns>
        private byte[] imagenBytes(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
    }
}
