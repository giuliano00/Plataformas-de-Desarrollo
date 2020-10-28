using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Recurso
    {
        public int Idrecurso { get; set; }
        public string Nombre { get; set; }
        public int Idusuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}
