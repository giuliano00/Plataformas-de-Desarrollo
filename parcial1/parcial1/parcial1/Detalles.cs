using System;
using System.Collections.Generic;
using System.Text;

namespace parcial1
{
    class Detalles
    {
        public DateTime Fecha { get; set; }

        public string Tiempo { get; set; }

        public Recursos Recurso { get; set; }

        public tareas Tarea { get; set; }

        public Detalles(DateTime Fecha, string Tiempo, Recursos Recurso, tareas Tarea)
        {
            this.Fecha = Fecha;
            this.Tiempo = Tiempo;
            this.Recurso = Recurso;
            this.Tarea = Tarea;
            

        }

    }
}
