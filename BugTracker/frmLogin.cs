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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text == ""))
            {
                MessageBox.Show("Se debe Ingresar un Usuario");
                return;

            }

            if ((txtPass.Text == ""))
            {
                MessageBox.Show("Se debe Ingresar una Contraseña");
                return;

            }

            MessageBox.Show("Usted a Ingresado al Sistema");
            this.Close();


        }
    }
}
