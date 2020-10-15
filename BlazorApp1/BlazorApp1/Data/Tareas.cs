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
       

        public bool Estado { get; set; }

        public
            Tareas(string Titulo, DateTime Vencimiento, int Estimacion,  bool Estado, int Idtarea)
        {
            this.Titulo = Titulo;
            this.Vencimiento = Vencimiento;
            this.Estimacion = Estimacion;          
            this.Estado = Estado;
            this.Idtarea = Idtarea;
        }
        public Tareas() { }

    }
}
