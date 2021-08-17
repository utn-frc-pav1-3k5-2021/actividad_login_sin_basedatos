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
            if ((textBox1.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario: ");
                return;
            }

            if ((textBox2.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña: ");
                return;
            }

            MessageBox.Show("Usted ha ingresado al sistema.");
            this.Close();
        }
    }
}
