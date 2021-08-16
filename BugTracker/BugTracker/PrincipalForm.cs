using BugTracker.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm(Usuario usu)
        {
            InitializeComponent();
            lblBienvenido.Text = "¡¡Bienvenida " + usu.NombreDeUsuario + "!!";
            lblBienvenido.Visible = true;
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
