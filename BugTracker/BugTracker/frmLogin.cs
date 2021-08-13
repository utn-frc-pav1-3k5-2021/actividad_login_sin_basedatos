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

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "") {
                MessageBox.Show("Ingrese un usuario");
                return;
            }

            if (txt_contraseña.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña");
                return;
            }

            MessageBox.Show("Ha ingresado exitosamente al sistema!!");
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
