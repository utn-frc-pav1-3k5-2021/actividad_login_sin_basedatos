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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validacion de ingreso de un usuario
            if (this.txtUsuario.Text == "")
            {
                MessageBox.Show("Se debe ingresar un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validacion de ingreso de una clave
            if (this.txtContraseña.Text == "")
            {
                MessageBox.Show("Se debe ingresar una Constraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Usted ha ingresado al sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
