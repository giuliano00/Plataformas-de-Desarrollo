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

        [MaxLength(50)]  
        [MinLength(10)]  
        public String Nombre { get; set; }
        [Required]
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
