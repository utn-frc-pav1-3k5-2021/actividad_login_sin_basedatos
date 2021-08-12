using System;
using System.Collections.Generic;
using System.Text;

namespace LoginSinBD.dominio
{
    public class Usuario
    {
        private string nombre;
        private string contrasena;

        public Usuario()
        {

        }

        public Usuario(string nom, string contra)
        {
            this.nombre = nom;
            this.contrasena = contra;
        }

        public string Nombre { get; set; }
        public string Contrasena { get; set; }
    }

}
