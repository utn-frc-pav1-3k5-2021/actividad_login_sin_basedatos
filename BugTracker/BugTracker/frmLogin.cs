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
                MessageBox.Show("Ingrese nombre de usuario");
                return;
            }
            if (txtContrasena.Text == string.Empty)
            {
                MessageBox.Show("Ingrese la contraseña");
                return;
            }
            MessageBox.Show("Ingresó al sistema");
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
