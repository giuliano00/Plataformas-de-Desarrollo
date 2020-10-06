using System;
using System.Collections.Generic;
using System.Text;

namespace parcial1
{
     class Recursos
    {
        public string Nombre { get; set; }

        public Usuarios Usuario { get; set; }
        public Recursos(string Nombre, Usuarios Usuario)
        {
            this.Nombre = Nombre;
            this.Usuario = Usuario;

        }

        public Recursos()
        {
        }
    }
}
