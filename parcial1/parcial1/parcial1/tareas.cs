using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace parcial1
{
   public class Tareas
    {
        [Key]
        public int Idtarea { get; set; }
        public string Titulo { get; set; }

        public DateTime Vencimiento { get; set; }

        public int Estimacion { get; set; }

        public int Idrecurso { get; set; }
        public Recursos Responsable { get; set; }

        public bool Estado { get; set; }

        public 
            Tareas(string Titulo, DateTime Vencimiento, int Estimacion, Recursos Responsable, bool Estado, int Idtarea )
        {
            this.Titulo = Titulo;
            this.Vencimiento = Vencimiento;
            this.Estimacion = Estimacion;
            this.Responsable = Responsable;
            this.Estado = Estado;
            this.Idtarea = Idtarea;
        }
        public Tareas() {}


    }
}
