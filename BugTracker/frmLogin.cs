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
            Environment.Exit(0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Valida que se haya puesto un usuario
            if(txtUsuario.Text == "")
            {
                MessageBox.Show("Se debe ingresar un usuario");
                return;
            }

            //Valida que se haya puesto una Contraseña
            if(txtContra.Text == "")
            {
                MessageBox.Show("Se debe ingresar una contraseña");
                return;
            }

            MessageBox.Show("Usted ha ingresado al sistema");
            this.Close();
        }
    }
}
