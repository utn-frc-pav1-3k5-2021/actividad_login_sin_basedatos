using System;
using System.Collections.Generic;
using System.Text;

//namespace es un agrupador
namespace BugTracker.Entidades
{
    //public significa que puede ser accesida
    //por cualquier elemento fuera de namespace
    public class Usuario
    {
        private string NombreUsu;
        private string Pass;

        public Usuario(string nombreUsuario, string password) 
        {
            //con this. estoy haciendo referencia a la clase propiamente dicha
            //entonces a todos sus atributos y metodos de esa clase
            this.NombreUsu = nombreUsuario;
            this.Pass = password;
        }
       
        public string NombreDeUsuario 
        {
            get => NombreUsu;

        }

    }
}
