using System;
using System.Collections.Generic;
using System.Linq;

namespace parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Consultar();
            Actualizar();

            static void Borrado()
            {
                var ctx = new tareasDbContext();
                var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == 1).Single();
                ctx.Usuarios.Remove(usuario);
                ctx.SaveChanges();
            }

            static void Actualizar()
            {
                var ctx = new tareasDbContext();

                var lista = ctx.Usuarios.Where(i => i.UsuarioPK == 1).Single();
                lista[0].User= "rodo";

                ctx.SaveChanges();
            }

        

            static void Consultar()
            {
                var ctx = new tareasDbContext();
                var lista = ctx.Usuarios.ToList();
                foreach (var item in lista)
                {
                    Console.WriteLine($"nombre: {item.User}({ item.UsuarioPK})");
                }

            }

            static void Insertar()
            {
                var ctx = new tareasDbContext();

                ctx.Usuarios.Add(new Usuario{UsuarioPK = 4,User = "reberto", Clave = "1234" });

                ctx.SaveChanges();
            }
            //add-Migration "Inicial"   Update-Database

            var ctx = new tareasDbContext();
            ctx.Set<Usuarios>().Add(new Usuarios { User = "giu", Clave = "1234", UsuarioPK = 1 });
            ctx.Set<Usuarios>().Add(new Usuarios { UsuarioPK = 2, User = "fer", Clave = "1234" });
            ctx.Set<Usuarios>().Add(new Usuarios { UsuarioPK = 3, User = "gab", Clave = "1234" });
            ctx.Set<Usuarios>().Add(new Usuarios { UsuarioPK = 4, User = "gra", Clave = "1234" });
            ctx.Set<Usuarios>().Add(new Usuarios { UsuarioPK = 5, User = "rodo", Clave = "1234" });
            ctx.SaveChanges ();

            Usuarios u = new Usuarios("giu", "123");
            Recursos r = new Recursos("giuliano", u);

           List<tareas> tareas = new List<tareas>();

            tareas.Add(new tareas("Ejercicio1", new DateTime(2020, 1, 20), 10, new Recursos(), false));
            tareas.Add(new tareas("Ejercicio2", new DateTime(2020, 2, 21), 11, new Recursos(), false));
            tareas.Add(new tareas("Ejercicio3", new DateTime(2020, 3, 22), 12, new Recursos(), false));
            tareas.Add(new tareas("Ejercicio4", new DateTime(2020, 4, 23), 13, new Recursos(), false));

        }
         
    }
}
