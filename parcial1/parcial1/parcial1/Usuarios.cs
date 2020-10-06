using System;
using System.Collections.Generic;
using System.Text;

namespace parcial1
{
   class Usuarios
    {
        public string User { get; set; }

        public string Clave { get; set; }


        public Usuarios(string User, string Clave)
        {
            this.Clave = Clave;
            this.User = User;

        }


    }
}
