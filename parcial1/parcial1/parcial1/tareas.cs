using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace parcial1
{
   public class tareas
    {
        [Key]
        public int idtarea { get; set; }
        public string Titulo { get; set; }

        public DateTime Vencimiento { get; set; }

        public int Estimacion { get; set; }

        public int idrecurso { get; set; }
        public Recursos Responsable { get; set; }

        public bool Estado { get; set; }

        public tareas(string Titulo, DateTime Vencimiento, int Estimacion, Recursos Responsable, bool Estado, int idtarea)
        {
            this.Titulo = Titulo;
            this.Vencimiento = Vencimiento;
            this.Estimacion = Estimacion;
            this.Responsable = Responsable;
            this.Estado = Estado;
            this.idtarea = idtarea;
        }
        public tareas() {}


    }
}
