using BugTracker.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class frmLoguin : Form
    {
        public frmLoguin()
        {
            InitializeComponent();
        }

        private void frmLoguin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Usuario usu = new Usuario(txtUsuario.Text, txtContraseña.Text);
            string usuCorrecto = "Santiago";
            string passwordCorrecto = "123456";

            if (txtUsuario.Text.Equals(usuCorrecto) && txtContraseña.Text.Equals(passwordCorrecto))
            {
                Principal ventana = new Principal(usu);
                ventana.Show();
            }
            else 
            {
                MessageBox.Show("Ingrese valores correctos", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
