using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BagTracker
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar(object sender, EventArgs e)
        {
            // Validacion de Usuario
            if((txtUsu.Text == ""))
            {
                MessageBox.Show("Por favor ingresar un Usuario...", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            // Validacion de Contraseña
            if((txtContra.Text == ""))
            {
                MessageBox.Show("Por favor ingrese su contraseña...", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Usuario usu = new Usuario();
            usu.NombreUsuario = txtUsu.Text;
            usu.Password = txtContra.Text;

            if (ValidarCredenciales(usu))
            {
                MessageBox.Show("Usted a ingresado al sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                txtUsu.Text = "";
                txtContra.Text = "";
                MessageBox.Show("Ingrese su usuario y contraseña por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool ValidarCredenciales(Usuario usuario)
        {
            if (usuario.NombreUsuario == "Rodrigo" && usuario.Password == "123")
                return true;
            return false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // NADA
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
