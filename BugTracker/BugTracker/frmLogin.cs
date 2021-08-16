using BugTracker.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Usuario usu = new Usuario(txtUsuario.Text, txtContraseña.Text);
            //MessageBox.Show("Hola " + usu.NombreDeUsuario + " !");
            string usuPorDefecto = "Ayelen";
            string passwordPorDefecto = "123";

            if (txtUsuario.Text.Equals(usuPorDefecto) && txtContraseña.Text.Equals(passwordPorDefecto))
            {
                //Nombre y contraseña de usuario correctos
                //MessageBox.Show("Datos Correctos!");
                PrincipalForm ventana = new PrincipalForm(usu);
                ventana.Show();
                this.Hide();
            }
            else
            {
                //Nombre o contraseña de usuario incorrectos
                MessageBox.Show("Usuario ó contraseña incorrecta.¡Vuelva a ingresar datos correctos!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
