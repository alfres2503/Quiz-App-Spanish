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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class InicioSesion : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public InicioSesion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sirve para ver la contraseña digitada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkContrasenna_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkContrasenna.Checked)
                txtContrasenna.UseSystemPasswordChar = false;
            else
                txtContrasenna.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Abre la ventana de registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            var frm = new Registro();
            frm.ShowDialog();
        }

        
        /// <summary>
        /// Verifica los datos y si todo es correcto inicia la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            IClienteLN ln = new ClienteLN();

            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Debe ingresar su cédula", "Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtID.Text);
                string contrasenna = txtContrasenna.Text;
                Cliente cLogin = ln.ObtenerPorID(id);
                if (cLogin == null)
                {
                    MessageBox.Show("Usuario no encontrado :(", "Error", MessageBoxButtons.OK);
                    return;
                }

                if (cLogin.Id==id)
                {

                    if (cLogin.Contrasenna==contrasenna)
                    {
                        _MyLogControlEventos.Info("Se inició sesión");
                        this.Hide();
                        var frm = new Menu();
                        frm.cliente = cLogin;
                        frm.Closed += (s, args) => this.Close();
                        frm.Show();
                    } else
                    {
                        MessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK);
                        return;
                    }
                }
                
            }
            catch (Exception er)
            {
                _MyLogControlEventos.Error("Ocurrió el siguiente error al tratar de iniciar sesión: " + er.Message);
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Cierra la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Para hacer login con enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtContrasenna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            _MyLogControlEventos.InfoFormat("Abierta la aplicación");
        }

        /// <summary>
        /// Para escribir la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContrasenna.Focus();
            }
        }
    }
}
