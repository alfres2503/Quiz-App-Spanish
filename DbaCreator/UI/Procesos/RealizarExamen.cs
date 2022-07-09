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
using UI.Reportes;

namespace UI
{
    public partial class RealizarExamen : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        Cliente cliente;
        Examen examen;
        Intento intento;
        int cont = 0, h, m, s;
        System.Timers.Timer t;

        List<Pregunta> ListaPreguntas;
        private int NoPregunta = -1;
        private int Total = 0;
        private int LimiteTiempo;

        IExamenLN logicaExamenes = new ExamenLN();
        IPreguntaLN logicaPreguntas = new PreguntaLN();
        public RealizarExamen(Cliente c)
        {
            InitializeComponent();
            this.cliente = c;
        }


        /// <summary>
        /// Carga los datos del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RealizarExamen_Load(object sender, EventArgs e)
        {
            lblNombre.Text = cliente.Nombre + " " + cliente.Apellido;
            lblID.Text = cliente.Id.ToString();
        }

        /// <summary>
        /// Metodo que da comienzo al examen
        /// </summary>
        /// <param name="cDetalle">Parámetro del que extrae los datos para la realización</param>
        private void comenzarExamen(ClienteDetalle cDetalle)
        {
            try
            {
                examen = logicaExamenes.ObtenerPorID(cDetalle.IDExamen);
                FacturaLN.MarcarRealizado(cDetalle.codigoUnico);

                intento = new Intento();
                intento.IDIntento = IntentoLN.ObtenerNumeroDeIntentoActual();
                intento.IDCliente = cliente.Id;
                intento.IDExamen = examen.ID;
                intento.Exitoso = false;

                ListaPreguntas = logicaPreguntas.SeleccionarPorExamen(examen.ID);
                lblTotalPreguntas.Text = ListaPreguntas.Count.ToString();

                IntentoLN.Insertar(intento);

                gbExamen.Text = examen.Titulo;
                gBValidacion.Visible = false;

                SiguientePregunta();

                habilitar();

                LimiteTiempo = examen.Minutos * 60;
                if (examen.Minutos == 1)
                    lbTotalTiempo.Text = examen.Minutos + " Minuto";
                else
                    lbTotalTiempo.Text = examen.Minutos + " Minutos";

                _MyLogControlEventos.Info($"El cliente {cliente.Nombre} {cliente.Apellido} realiza {examen.Titulo}");
                tmr.Start();

                t = new System.Timers.Timer();
                t.Interval = 1000;
                t.Elapsed += EventoTiempo;
                t.Start();

                cont++;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en realización: " + er.Message);
            }
        }

        /// <summary>
        /// Metodo para que se vea el tiempo avanzar en horas, minutos y segundos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventoTiempo(object sender, System.Timers.ElapsedEventArgs e)
        {

            Invoke(new Action(() =>
            {
                s += 1;
                if (s==60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                textBoxTiempo.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }
            ));
        }

        /// <summary>
        /// habilita elementos gráficos
        /// </summary>
        private void habilitar()
        {
            lblSlash.Visible = true;
            lbTotalTiempo.Visible = true;
            label2.Visible = true;
            textBoxTiempo.Visible = true;
            rtEnunciado.Visible = true;
            radioR1.Visible = true;
            radioR2.Visible = true;
            radioR3.Visible = true;
            btnSiguiente.Visible = true;
            label3.Visible = true;
            lblNo.Visible = true;
            label6.Visible = true;
            lblTotalPreguntas.Visible = true;
        }

        /// <summary>
        /// Avanza a la siguiente pregunta del examen
        /// </summary>
        private void SiguientePregunta()
        {
            NoPregunta++;
            Pregunta pregunta = ListaPreguntas[NoPregunta];

            this.rtEnunciado.Text = pregunta.Enunciado;
            this.radioR1.Text = pregunta.Respuesta1;
            this.radioR2.Text = pregunta.Respuesta2;
            this.radioR3.Text = pregunta.Respuesta3;
            this.pictureBox.Image = (Bitmap)((new ImageConverter()).ConvertFrom(pregunta.Imagen));
            this.radioR1.Checked = true;
        }

        /// <summary>
        /// Califica que la pregunta seleccionada sea la correcta
        /// </summary>
        private void Calificar()
        {
            Pregunta pregunta = ListaPreguntas[NoPregunta];
            if (radioR1.Checked && radioR1.Text == pregunta.Correcta)
                Total++;
            if (radioR2.Checked && radioR2.Text == pregunta.Correcta)
                Total++;
            if (radioR3.Checked && radioR3.Text == pregunta.Correcta)
                Total++;
        }

        /// <summary>
        /// Revisa el resultado final del examen, en caso de aprobado abre el reporte de certificado
        /// </summary>
        private void RevisarExamen()
        {
            _MyLogControlEventos.Info($"Prueba finalizada");

            MessageBox.Show($"La prueba a terminado, usted acertó {Total}/{ListaPreguntas.Count} preguntas!" +
                   $"\n Su calificación fue: " + (double)(((double)Total / (double)ListaPreguntas.Count)) * 100,
                   "Calificación",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Total >= ((ListaPreguntas.Count) * (examen.NotaMinima / 100)))
            {
                _MyLogControlEventos.Info($"Prueba aprobada");
                MessageBox.Show($"Usted aprobó el examen! Una vez de click en aceptar, espere a que se genere su certificado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IntentoLN.MarcarIntentoExitoso(intento.IDIntento);

                var frm = new FrmCertificado(intento.IDIntento, cliente.Email);
                frm.ShowDialog();
                return;
            }
            else
            {
                _MyLogControlEventos.Info($"Prueba reprobada");
                MessageBox.Show($"Usted no aprobó el examen", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Valida la compra y en caso de que todo sea correcto, pide confirmación y llama al método comenzarExamen 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRealizarExamen_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDetalle cDetalle = FacturaLN.ObtenerDetallePorCodigo(cliente.Id, txtCodigo.Text);
                if (cDetalle == null)
                {
                    MessageBox.Show("No se ha encontrado su compra", "Código no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cDetalle.ExamenRealizado == true)
                {
                    MessageBox.Show("Usted ya realizó este examen, para volver a realizarlo debe pagarlo de nuevo", "Examen ya realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Su compra se ha encontrado ¿Desea comenzar el examen?", "Código encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        comenzarExamen(cDetalle);
                        return;
                    }
                    else
                        return;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en la autenticación: " + er.Message);
            }
        }

        /// <summary>
        /// cierra la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Botón para que el cliente pueda avanzar de pregunta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                Calificar();
                if (NoPregunta == ListaPreguntas.Count - 1)
                {
                    tmr.Stop();
                    t.Stop();
                    RevisarExamen();
                    cont++;

                    btnSiguiente.Enabled = false;
                }
                else
                {
                    lblNo.Text = (NoPregunta + 2).ToString();
                    SiguientePregunta();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en realización: " + er.Message);
            }

            
        }

        /// <summary>
        /// Si ya se inició el examen y el usuario cierra la ventana, arroja la revisión del examen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RealizarExamen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cont==1)
            {
                RevisarExamen();
            }
        }

        /// <summary>
        /// Estos son los eventos que pasan cada que el reloj avanza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(this.lblTiempo.Text);

                if (value >= LimiteTiempo)
                {
                    t.Stop();
                    tmr.Stop();
                    btnSiguiente.Enabled = false;
                    MessageBox.Show($"Se acabó su tiempo", "Lo sentimos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _MyLogControlEventos.Info($"Tiempo de la prueba finalizado");
                    RevisarExamen();
                    cont++;
                    return;
                }

                value++;
                this.lblTiempo.Text = value.ToString();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en realización: " + er.Message);
            }
           
            
        }

        /// <summary>
        /// Antes de cerrar la aplicaión para los relojes para evitar posibles errores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RealizarExamen_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (cont == 1)
                {
                    tmr.Stop();
                    t.Stop();
                    Application.DoEvents();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _MyLogControlEventos.Error("Ocurrió el siguiente error en realización: " + er.Message);
            }
        }

    }
}
