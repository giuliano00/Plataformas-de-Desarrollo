using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace parcial1
{
     public class Recursos
    {
        public string Nombre { get; set; }
        [Key]
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
