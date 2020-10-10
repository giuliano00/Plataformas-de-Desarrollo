using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace parcial1
{
     public class Recursos
    {
        [Key]
        public int Idrecurso { get; set; }
        public string Nombre { get; set; }
       public int Idusuario { get; set; }
        public Usuarios Usuario { get; set; }
        public Recursos(string Nombre,int idrecurso,int Idusuario)
        {
            this.Nombre = Nombre;         
            this.Idrecurso = idrecurso;
            this.Idusuario = Idusuario;


        }

        public Recursos()
        {
        }
    }
}
