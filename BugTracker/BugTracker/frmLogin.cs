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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if((txtUsuario.Text==""))
                {
                    MessageBox.Show("Se debe ingresar un usuario.");
                    return;
                }
            if ((txtContrasena.Text==""))
                {
                    MessageBox.Show("Se debe ingresar una contraseña.");
                    return;
                }
            MessageBox.Show("Usted ha ingresado al sistema.");
            this.Close();
        }

        
    }
}
