using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace parcial1
{
    
   public class Usuarios
    {


        [Key]
        public int Idusuario { get; set; }

        [MaxLength(50)]  // maximo de longitud de caracteres 
        [MinLength(10)]  // minimo de longitud de caracteres 
        public String Nombre { get; set; }
        [Required] //que no acepta nulos
                   //  [Column("Password", TypeName = "char(20)")]

        public String Clave { get; set; }



        public Usuarios() { }  //constructor implicito 

        public Usuarios(int Idusuario, string Nombre, string Clave)
        {
            this.Idusuario = Idusuario;
            this.Nombre = Nombre;
            this.Clave = Clave;
        }


    }
}
