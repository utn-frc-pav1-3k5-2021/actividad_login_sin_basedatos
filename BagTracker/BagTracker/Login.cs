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
                MessageBox.Show("Por favor ingresar un Usuario...");
                return;
            }


            // Validacion de Contraseña
            if((txtContra.Text == ""))
            {
                MessageBox.Show("Por favor ingrese su contraseña...");
                return;
            }

            MessageBox.Show("Se ha ingresado al sistema...");
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // NADA
        }
    }
}
