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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "" | TxtPassword.Text == "")
            {
                MessageBox.Show("Se debe ingresar un usuario y contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Usuario usuario = new Usuario(TxtUsuario.Text, TxtPassword.Text);

            /* Otra opción válida a lo anterior es:
            
            Usuario usuario = new Usuario
            {
                Username = TxtUsuario.Text,
                Password = TxtPassword.Text
            };

            */

            if (ValidarCredenciales(usuario))
            {
                MessageBox.Show("Usted ha ingresado al sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                TxtUsuario.Text = "";
                TxtPassword.Text = "";
                MessageBox.Show("Usuario o contraseña inválidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public bool ValidarCredenciales(Usuario usuario)
        {
            if (usuario.Username == "Franco" && usuario.Password == "123")
                return true;
            return false;
        }
    }
}
