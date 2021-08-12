using LoginSinBD.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSinBD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nom = txtUsuario.Text;
            string contra = txtContra.Text;

            if (nom.Equals("") || contra.Equals(""))
            {
                MessageBox.Show("¡Ingrese usuario y contraseña!");
                return;
            }

            if (nom.Equals("francisco") && contra.Equals("queso"))
            {
                MessageBox.Show("¡Ingreso exitoso!");
                new Usuario(nom, contra);
            }
            else
            {
                MessageBox.Show("Datos incorrectos...");
            }
        }

        private void chkContra_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
