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
            //validamos que haya ingresado un usuario
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Se debe ingresar usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //validamos que haya ingresado una contraseña
            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Se debe ingresar una contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Dominio.Usuario usuario = new Dominio.Usuario();
            usuario.Nombre = txtUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;


            if (validarCredenciales(usuario))
            {
                MessageBox.Show("Usted ingresó al sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
            else 
            {
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                MessageBox.Show("Acceso denegado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                       
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarCredenciales(Dominio.Usuario usuario)
        {
            if (usuario.Nombre == "Aldana" && usuario.Contraseña == "123")
            {
                return true;
            }
            return false;
        }
    }
}
