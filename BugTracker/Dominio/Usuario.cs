using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker.Dominio
{
    class Usuario
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        public Usuario()
        {
        }

        public Usuario(string nombre, string contraseña)
        {
            this.Nombre = nombre;
            this.Contraseña = contraseña;
        }
    }
}
