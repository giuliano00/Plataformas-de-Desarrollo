using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareasService
    {
        public Tareas[] GetTareas()
        {
            Tareas[] resultado = new Tareas[5];

            resultado[0] = new Tareas("Tarea 1", new DateTime(2020, 10, 10), 5, false, 1);
            resultado[1] = new Tareas("Tarea 2", new DateTime(2020, 10, 10), 5, false, 2);
            resultado[2] = new Tareas("Tarea 3", new DateTime(2020, 10, 10), 5, false, 3);
            resultado[3] = new Tareas("Tarea 4", new DateTime(2020, 10, 10), 5, false, 4);
            resultado[4] = new Tareas("Tarea 5", new DateTime(2020, 10, 10), 5, false, 5);


            return resultado;
        }
    }
}
