using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Tareas
    {

        public int Idtarea { get; set; }
        public string Titulo { get; set; }

        public DateTime Vencimiento { get; set; }

        public int Estimacion { get; set; }

        public int Idrecurso { get; set; }
        public Recurso Responsable { get; set; }

        public bool Estado { get; set; }

    }
}
