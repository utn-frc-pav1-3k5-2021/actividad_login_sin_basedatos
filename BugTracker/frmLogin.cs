using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class frmIS : Form
    {
        public frmIS()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validamos que se haya ingresado un usuario
            if((txtUsuario.Text == ""))
            {
                MessageBox.Show("Se debe Ingresar un ususario.");
                return;
            }

            //Validamos que se haya ingresado una contraseña
            if((txtContraseña.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.");
                return;
            }

            MessageBox.Show("Usted a ingresalo al sistema.");
            this.Close();
        }
    }
}
