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
            if((txtUsuario.Text == ""))
            {
                MessageBox.Show("Debe ingresar un Usuario:"):
            }
            if((txtContraseña.Text == ""))
            {
                MessageBox.Show("Debe ingresar una contraseña");
            }
            MessageBox.Show("Usted ingreso al sistema");
            this.Close();
        }
    }
}
