using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Detalle
    {
        public int Iddetalle { get; set; }
        public DateTime Fecha { get; set; }

        public string Tiempo { get; set; }

        public int Idrecurso { get; set; }
        public Recurso Recurso { get; set; }
        public int Idtarea { get; set; }
        public Tareas Tarea { get; set; }
    }
}
