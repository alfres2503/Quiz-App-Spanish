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
    public partial class MantenimientoClientes : Form
    {
        IClienteLN logica = new ClienteLN();
        int idViejo;
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Llama a la ventana de registro 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            _MyLogControlEventos.Info("Nuevo cliente");
            var frm = new Registro();
            frm.Show();
            frm.Closed += (s, args) => this.CargarDatos();
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
        /// Llena  y ajusta datagrid, también los comboboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDatos.ClearSelection();
                CargarDatos();
                cFoto.ImageLayout = DataGridViewImageCellLayout.Zoom;

                List<Pais> paises = PaisLN.ObtenerTodos();
                cmbPais.DisplayMember = "Nombre";
                cmbPais.DataSource = paises;
                _MyLogControlEventos.Info("Clientes cargados");
            }
            catch(Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Clientes: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga los datos de la bd al datagrid y ajusta este para que se vea bien
        /// </summary>
        private void CargarDatos()
        {
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.RowTemplate.Height = 100;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            this.dgvDatos.DataSource = logica.ObtenerTodos();

            this.cmbTipo.DataSource = Enum.GetValues(typeof(TipoCliente));

            this.cmbTipo.SelectedIndex = 0;
        }

        /// <summary>
        /// Pide confirmación al usuario y borra el registro seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnBorrar_Click(object sender, EventArgs e)
        {
            if (this.dgvDatos.SelectedRows.Count > 0)
            {
                Cliente oCliente = this.dgvDatos.SelectedRows[0].DataBoundItem as Cliente;
                if (MessageBox.Show($"¿Seguro que desea borrar el registro {oCliente.Id} {oCliente.Nombre}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _MyLogControlEventos.Info($"Se borrró el cliente: {oCliente.Id}");
                    logica.Borrar(oCliente.Id.ToString());
                    this.CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Coloca los datos del usuario seleccionado en el panel de la derecha para ser editado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnEditar_Click(object sender, EventArgs e)
        {
            Cliente oCliente = null;
            
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    habilitar();
                    oCliente = this.dgvDatos.SelectedRows[0].DataBoundItem as Cliente;
                    idViejo = oCliente.Id;
                    txtID.Text = oCliente.Id.ToString();
                    txtNombre.Text = oCliente.Nombre;
                    txtApellido.Text = oCliente.Apellido;
                    txtEmail.Text = oCliente.Email;
                    txtTelefono.Text = oCliente.Telefono;
                    txtContra.Text = oCliente.Contrasenna;
                    dtpFechaNacimiento.Value = oCliente.FechaNacimiento;

                    TipoCliente tipo = (TipoCliente)Enum.ToObject(typeof(TipoCliente), oCliente.IdTipo);
                   
                    cmbTipo.SelectedIndex = cmbTipo.FindString(tipo.ToString());
                    cmbPais.SelectedIndex = cmbPais.FindString(oCliente.Pais);
                    pictureBox.Image = (Bitmap)((new ImageConverter()).ConvertFrom(oCliente.Imagen));
                    _MyLogControlEventos.Info($"Se edita el cliente: {oCliente.Id}");
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Clientes: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// hablita elementos gráficos
        /// </summary>
        private void habilitar()
        {
            txtID.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefono.Enabled = true;
            txtContra.Enabled = true;
            cmbTipo.Enabled = true;
            cmbPais.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        /// <summary>
        /// deshabilita y limpia elementos gráficos
        /// </summary>
        private void deshabilitar()
        {
            txtID.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefono.Enabled = false;
            txtContra.Enabled = false;
            cmbTipo.Enabled = false;
            cmbPais.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;

            txtID.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtContra.Text = "";
            pictureBox.Image = null;
        }

        /// <summary>
        /// llama al método deshabilitar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitar();
        }

        /// <summary>
        /// Conversor de imagen a bytes
        /// </summary>
        /// <param name="imageIn">Imagen a convertir</param>
        /// <returns></returns>
        private byte[] imagenBytes(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        /// <summary>
        /// Actualiza los datos del cliente editado en la bd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Id Requerido");
                    txtID.Focus();
                    return;
                }

                Cliente c = new Cliente();
                
                c.Id = Convert.ToInt32(txtID.Text.Trim());
                c.IdTipo = (int)Enum.Parse(typeof(TipoCliente), cmbTipo.SelectedValue.ToString());
                c.Nombre = txtNombre.Text;
                c.Apellido = txtApellido.Text;
                c.Email = txtEmail.Text.ToLower();
                c.Imagen = imagenBytes(pictureBox.Image);
                c.FechaNacimiento = this.dtpFechaNacimiento.Value;
                c.Telefono = txtTelefono.Text;
                c.Pais = cmbPais.SelectedItem.ToString();
                c.Contrasenna = txtContra.Text;

                _MyLogControlEventos.Info($"Se actualiza el cliente: {c.Id}");
                logica.Actualizar(c, idViejo);

                if (c != null)
                    this.CargarDatos();

                deshabilitar();
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error en el mantenimiento de Clientes: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Este botón sirve para cambiar la imagen del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectImage = new OpenFileDialog();
            selectImage.Filter = " png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (selectImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(selectImage.FileName);
            }
        }
    }
}
