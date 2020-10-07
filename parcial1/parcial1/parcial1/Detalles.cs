using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace parcial1
{
    public class Detalles
    {
        [Key]
        public int iddetalle { get; set; }
        public DateTime Fecha { get; set; }

        public string Tiempo { get; set; }

        public int idrecurso { get; set; }
        public Recursos Recurso { get; set; }
        public int idtarea { get; set; }
        public tareas Tarea { get; set; }

        public Detalles(DateTime Fecha, string Tiempo, Recursos Recurso, tareas Tarea)
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
