using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace parcial1
{
    [Table("Usuario")]
   public class Usuarios
    {
       

        [Key]
        public int UsuarioPK { get; set; }
        [MaxLength(15)]
        [MinLength(3)]
        public string User { get; set; }
        [Required]
        [Column("Password",TypeName ="char(20")]
        public string Clave { get; set; }


        public Usuarios(string User, string Clave,int UsuarioPK)
        {
            this.Clave = Clave;
            this.User = User;
            this.UsuarioPK = UsuarioPK;
        }
        public Usuarios()
        {
            
        }

       
    }
}
