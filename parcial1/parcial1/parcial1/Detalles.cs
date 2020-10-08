using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace parcial1
{
    public class Detalles
    {
        [Key]
        public int Iddetalle { get; set; }
        public DateTime Fecha { get; set; }

        public string Tiempo { get; set; }

        public int Idrecurso { get; set; }
        public Recursos Recurso { get; set; }
        public int Idtarea { get; set; }
        public Tareas Tarea { get; set; }

        public Detalles(DateTime Fecha, string Tiempo, Recursos Recurso, Tareas Tarea)
        {
            this.Fecha = Fecha;
            this.Tiempo = Tiempo;
            this.Recurso = Recurso;
            this.Tarea = Tarea;
            

        }
        public Detalles()
        {

        }
    }
}
