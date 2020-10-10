using System;
using System.ComponentModel.DataAnnotations;

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

        public Detalles(DateTime Fecha, string Tiempo, int Iddetalle, int Idrecurso, int Idtarea)
        {
            this.Fecha = Fecha;
            this.Tiempo = Tiempo;
            
            
            this.Iddetalle = Iddetalle;
            this.Idrecurso = Idrecurso;
            this.Idtarea = Idtarea;


        }
        public Detalles()
        {

        }
    }
}
