using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Usted debe ingresar su nombre de usuario");
                return; 
            }

            if(txtPassword.Text == "")
            {
                MessageBox.Show("Usted debe ingresar una constraseña");
                return; 
            }

            MessageBox.Show("Usted a ingresado al sistema");
            this.Close(); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted a salido del sisemat");
            this.Close();
        }
    }
}
