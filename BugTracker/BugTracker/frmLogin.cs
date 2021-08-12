using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                MessageBox.Show("Se debe ingresar una contraseña.");
                return;
            }
            if(this.txtContraseña.Text == "")
            {
                MessageBox.Show("Se debe ingresar una contraseña.");
                return;
            }

            MessageBox.Show("Usted a ingresado al sistema.");
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
