﻿using System;
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
            //Validamos que se haya ingresado un usuario
            if ((txtUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario");
                return;
            }

            //Validamos que se haya ingresado una contraseña
            if ((txtContrasenia.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña");
                return;
            }

            MessageBox.Show("Usted a ingresado al sistema");
            this.Close();
        }
    }
}
