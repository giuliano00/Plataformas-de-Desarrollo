using System;
using System.Collections.Generic;
using System.Linq;

namespace parcial1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Consultar();
            Actualizar();
            Borrado();
            Insertar();
            static void Borrado()
            {
                var ctx = new TareasDbContext();
                var usuario = ctx.Usuarios.Where(i => i.Idusuario == 1).Single();
                ctx.Usuarios.Remove(usuario);
                ctx.SaveChanges();
            }

            static void Actualizar()
            {
                var ctx = new TareasDbContext();

                var lista = ctx.Usuarios.Where(i => i.Idusuario == 1).ToList();
                lista[0].Nombre = "rodo";
;
                ctx.SaveChanges();
            }

        

            static void Consultar()
            {
                var ctx = new TareasDbContext();
                var lista = ctx.Usuarios.ToList();
                foreach (var item in lista)
                {
                    Console.WriteLine($"nombre: {item.Clave}({ item.Clave})");
                }

            }

            static void Insertar()
            {
                var ctx = new TareasDbContext();

                ctx.Set<Usuarios>().Add(new Usuarios { Idusuario = 3, Nombre = "fer", Clave = "1234" });
                ctx.Set<Usuarios>().Add(new Usuarios { Idusuario = 2, Nombre = "fer", Clave = "1234" });
                ctx.Set<Usuarios>().Add(new Usuarios { Idusuario = 1, Nombre = "fer", Clave = "1234" });

                ctx.Set<Tareas>().Add(new Tareas("Ejercicio1", new DateTime(2020, 1, 20), 10, new Recursos(), false, 1));
                ctx.Set<Tareas>().Add(new Tareas("Ejercicio2", new DateTime(2020, 2, 21), 11, new Recursos(), false, 2));
                ctx.Set<Tareas>().Add(new Tareas("Ejercicio3", new DateTime(2020, 3, 22), 12, new Recursos(), false, 3));
                ctx.Set<Tareas>().Add(new Tareas("Ejercicio4", new DateTime(2020, 4, 23), 13, new Recursos(), false, 4));
                ctx.SaveChanges();

            }
            //add-Migration "Inicial"   Update-Database


           // Usuarios u = new Usuarios("giu", "123");
           // Recursos r = new Recursos("giuliano", u);

           

            
        }
         
    }
}
