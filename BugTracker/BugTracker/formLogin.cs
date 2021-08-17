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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if ((txtPassword.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var usuario = new Usuario();
            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Password = txtPassword.Text;

            if (validarCredenciales(usuario))
            {
                MessageBox.Show("Usted a ingreasado al sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                txtUsuario.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Debe ingresar usuario y/o contraseña validos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool validarCredenciales(Usuario usuario)
        {
            if (usuario.NombreUsuario == "Serena" && usuario.Password == "1234")
                return true;
            return false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
