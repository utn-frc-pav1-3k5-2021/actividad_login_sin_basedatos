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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Se debe ingresar un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtContra.Text=="")
            {
                MessageBox.Show("Se debe ingresar una contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Usuario usuario = new Usuario();
            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Password = txtContra.Text;

            if (ValidarUsuario(usuario))
            {
                MessageBox.Show("Ingreso Correcto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                txtContra.Text = "";
                txtUsuario.Text = "";
                MessageBox.Show("Usuario o Contraseña Incorrectos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }

        private bool ValidarUsuario(Usuario usuario)
        {
            if (usuario.NombreUsuario == "victor" && usuario.Password == "bazan") return true;

            else return false;
        }
    }
}
