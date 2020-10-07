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
        public int idusuario { get; set; }

        [MaxLength(50)]  // maximo de longitud de caracteres 
        [MinLength(10)]  // minimo de longitud de caracteres 
        public String nombre { get; set; }
        [Required] //que no acepta nulos
                   //  [Column("Password", TypeName = "char(20)")]

        public String clave { get; set; }



        public Usuarios() { }  //constructor implicito 

        public Usuarios(int idusuario, string nombre, string clave)
        {
            this.idusuario = idusuario;
            this.nombre = nombre;
            this.clave = clave;
        }


    }
}
