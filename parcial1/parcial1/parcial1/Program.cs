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

            static void Borrado()
            {
                var ctx = new tareasDbContext();
                var usuario = ctx.Usuarios.Where(i => i.idusuario == 1).Single();
                ctx.Usuarios.Remove(usuario);
                ctx.SaveChanges();
            }

            static void Actualizar()
            {
                var ctx = new tareasDbContext();

                var lista = ctx.Usuarios.Where(i => i.idusuario == 1).ToList();
                lista[0].nombre = "rodo";
;
                ctx.SaveChanges();
            }

        

            static void Consultar()
            {
                var ctx = new tareasDbContext();
                var lista = ctx.Usuarios.ToList();
                foreach (var item in lista)
                {
                    Console.WriteLine($"nombre: {item.clave}({ item.clave})");
                }

            }

            static void Insertar()
            {
                var ctx = new tareasDbContext();

                ctx.Set<Usuarios>().Add(new Usuarios { idusuario = 3, nombre = "fer", clave = "1234" });
                ctx.Set<Usuarios>().Add(new Usuarios { idusuario = 2, nombre = "fer", clave = "1234" });
                ctx.Set<Usuarios>().Add(new Usuarios { idusuario = 1, nombre = "fer", clave = "1234" });

                ctx.Set<tareas>().Add(new tareas("Ejercicio1", new DateTime(2020, 1, 20), 10, new Recursos(), false, 1));
                ctx.Set<tareas>().Add(new tareas("Ejercicio2", new DateTime(2020, 2, 21), 11, new Recursos(), false, 2));
                ctx.Set<tareas>().Add(new tareas("Ejercicio3", new DateTime(2020, 3, 22), 12, new Recursos(), false, 3));
                ctx.Set<tareas>().Add(new tareas("Ejercicio4", new DateTime(2020, 4, 23), 13, new Recursos(), false, 4));
                ctx.SaveChanges();

            }
            //add-Migration "Inicial"   Update-Database


           // Usuarios u = new Usuarios("giu", "123");
           // Recursos r = new Recursos("giuliano", u);

           

            
        }
         
    }
}
