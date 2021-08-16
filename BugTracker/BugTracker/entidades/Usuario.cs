using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker.entidades
{
    public class Usuario
    {
        private string NombreUsu;
        private string Pass;

        public Usuario(string nombreUsu, string password)
        {
            NombreUsu = nombreUsu;
            Pass = password;
        }

        public string NombreDeUsuario
        {
            get => NombreUsu;
            set => NombreUsu = value;
        }

        public string Password
        {
            get => Pass;
            set => Pass = value;
        }
    }
}
