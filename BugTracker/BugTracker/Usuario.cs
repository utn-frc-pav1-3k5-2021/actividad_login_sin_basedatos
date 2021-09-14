using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker
{
    public class Usuario
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nombreUsuario, string unaContra)
        {
            Username = nombreUsuario;
            Password = unaContra;
        }
    }
}
