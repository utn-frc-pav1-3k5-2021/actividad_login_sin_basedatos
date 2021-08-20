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
            //Validar que se haya ingresado un usuario

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Se debe ingresar un nombre de usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var usuario = new Usuario();
            usuario.NombreUsuario = txtUsuario.Text;
            usuario.ContraseñaUsuario = txtContraseña.Text;

            if (ValidarCredenciales(usuario))
            {
                MessageBox.Show("Usted ha ingresado al sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            else
            {   txtUsuario.Text = "";
                txtContraseña.Text = "";
                MessageBox.Show("Se debe ingresar un usuario y/o contraseña valida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidarCredenciales(Usuario pUsuario)
        {   if (pUsuario.NombreUsuario == "bruno" & pUsuario.ContraseñaUsuario == "1234")
                return true;
            return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
