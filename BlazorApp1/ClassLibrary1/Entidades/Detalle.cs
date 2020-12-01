using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace ClassLibrary1.Entidades
{
    public class Detalle
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public int Tiempo { get; set; }

        public int RecursoId { get; set; }

        public Recurso Recurso { get; set; }

        public int TareaId { get; set; }

        public Tareas Tarea { get; set; }
    }
}