using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validacion de ingreso de usuario
            if ((txtName.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.");
                return;
            }

            // Validacion de ingreso de contraseña
            if ((txtPassword.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.");
                return;
            }

            MessageBox.Show("Usted ha ingresado al sistema.");
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
    }
}
