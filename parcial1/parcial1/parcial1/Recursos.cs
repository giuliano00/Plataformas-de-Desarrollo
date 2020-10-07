using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace parcial1
{
     public class Recursos
    {
        [Key]
        public int idrecurso { get; set; }
        public string Nombre { get; set; }
       public int idusuario { get; set; }
        public Usuarios Usuario { get; set; }
        public Recursos(string Nombre, Usuarios Usuario,int idrecurso)
        {
            this.Nombre = Nombre;
            this.Usuario = Usuario;
            this.idrecurso = idrecurso;

        }

        public Recursos()
        {
        }
    }
}
