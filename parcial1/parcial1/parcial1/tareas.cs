using System;
using System.Collections.Generic;
using System.Text;

namespace parcial1
{
   class tareas
    {
        public string Titulo { get; set; }

        public DateTime Vencimiento { get; set; }

        public int Estimacion { get; set; }

        public Recursos Responsable { get; set; }

        public bool Estado { get; set; }

        public tareas(string Titulo, DateTime Vencimiento, int Estimacion, Recursos Responsable, bool Estado)
        {
            this.Titulo = Titulo;
            this.Vencimiento = Vencimiento;
            this.Estimacion = Estimacion;
            this.Responsable = Responsable;
            this.Estado = Estado;

        }



    }
}
