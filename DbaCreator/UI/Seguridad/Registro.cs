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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Registro : Form
    {
        string rutaImagen = "";
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        IClienteLN logica = new ClienteLN();
        Cliente c;

        public Registro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Para ver contraseñas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkContrasenna_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkContrasenna.Checked)
            {
                txtContrasenna.UseSystemPasswordChar = false;
                textValidarC.UseSystemPasswordChar = false;
            }
            else
            {
                txtContrasenna.UseSystemPasswordChar = true;
                textValidarC.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Para seleccionar una imagen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectImage = new OpenFileDialog();
            selectImage.Filter = " png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (selectImage.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = selectImage.FileName.ToString();
                pictureBox.ImageLocation = rutaImagen;
            }
        }

        /// <summary>
        /// Valida los datos y si todo es correcto guarda el nuevo cliente en la bd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente clienteExistente = logica.ObtenerPorID(Convert.ToInt32(txtID.Text));
                if (clienteExistente != null)
                {
                    MessageBox.Show("Usuario ya registrado");
                    return;
                }
                clienteExistente = logica.ObtenerPorTelefono(mskTelefono.Text);
                if (clienteExistente != null)
                {
                    MessageBox.Show("Telefono ya registrado");
                    return;
                }
                clienteExistente = logica.ObtenerPorCorreo(txtmail.Text.ToLower());
                if (clienteExistente != null)
                {
                    MessageBox.Show("Correo ya registrado");
                    return;
                }
                if (Convert.ToInt32(txtID.Text) < 100000000)
                {
                    MessageBox.Show("Cédula no válida");
                    return;
                }
                if (!mskTelefono.MaskFull)
                {
                    MessageBox.Show("Debe digitar un telefono");
                    return;
                }
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Debe digitar un nombre");
                    return;
                }
                if (txtApellido.Text == "")
                {
                    MessageBox.Show("Debe digitar su apellido o apellidos");
                    return;
                }
                if (!Regex.IsMatch(txtmail.Text, "^[\\w-]+(\\.[\\w-]+)*@[A-Za-z0-9]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$"))
                {
                    MessageBox.Show("Correo no válido");
                    return;
                }
                if (cmbPais.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un país");
                    return;
                }
                if (txtContrasenna.Text == "")
                {
                    MessageBox.Show("Inserte una contraseña");
                    return;
                }
                if (textValidarC.Text == "")
                {
                    MessageBox.Show("Valide su contraseña");
                    return;
                }
                if (txtContrasenna.Text != textValidarC.Text)
                {
                    MessageBox.Show("Sus contraseñas no coinciden");
                    return;
                }
                if (this.pictureBox.Image == null)
                {
                    MessageBox.Show("Debe insertar una imagen");
                    return;
                }

                c = new Cliente()
                {
                    Id = Convert.ToInt32(txtID.Text.Trim()),
                    IdTipo = 2,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email = txtmail.Text.ToLower(),
                    Imagen = imagenBytes(),
                    FechaNacimiento = this.dateTimePicker.Value,
                    Telefono = mskTelefono.Text,
                    Pais = cmbPais.SelectedItem.ToString(),
                    Contrasenna = txtContrasenna.Text
                };

                logica.Guardar(c);
                _MyLogControlEventos.Info("Se creó un usuario nuevo satisfactoriamente");
                MessageBox.Show("Cliente satisfactoriamente registrado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error al tratar de registrarse: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Convierte la imagen a bytes
        /// </summary>
        /// <returns></returns>
        private byte[] imagenBytes()
        {

            byte[] imagen = null;
            FileStream stream = new FileStream(rutaImagen, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            imagen = br.ReadBytes((int)stream.Length);


            return imagen;
        }

        /// <summary>
        /// Limpia los objetos gráficos
        /// </summary>
        private void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtmail.Text = "";
            txtApellido.Text = "";
            txtContrasenna.Text = "";
            textValidarC.Text = "";
            mskTelefono.Clear();
            pictureBox.Image = null;
        }

        /// <summary>
        /// Llena el combo países
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Registro_Load(object sender, EventArgs e)
        {
            try
            {
                List<Pais> paises = PaisLN.ObtenerTodos();
                cmbPais.DisplayMember = "Nombre";
                cmbPais.DataSource = paises;
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error:" + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Cierra la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
