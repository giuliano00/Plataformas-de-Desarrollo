﻿using System;
using System.Collections.Generic;

namespace parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Usuarios u = new Usuarios("giu", "123");
            Recursos r = new Recursos("giuliano", u);

           List<tareas> tareas = new List<tareas>();

            tareas.Add(new tareas("Ejercicio1", new DateTime(2020, 9, 22), 10, new Recursos(), false));
            tareas.Add(new tareas("Ejercicio2", new DateTime(2020, 9, 23), 12, new Recursos(), false));
            tareas.Add(new tareas("Ejercicio3", new DateTime(2020, 9, 24), 12, new Recursos(), false));
            tareas.Add(new tareas("Ejercicio4", new DateTime(2020, 9, 24), 12, new Recursos(), false));

        }
         
    }
}