using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Usuario
    {
        public int UsuarioPK { get; set; }

        public string Nombre { get; set; }

        public string Clave { get; set; }


    }
}
