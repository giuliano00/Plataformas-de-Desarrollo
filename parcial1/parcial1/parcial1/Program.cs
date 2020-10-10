using System;
using System.Collections.Generic;
using System.Linq;

namespace parcial1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agregando registros..");
            Insertar();
            Console.WriteLine("Consultando usuarios..");
            Consultar();
            Console.WriteLine("Actualizando usuario..");
            Actualizar();
            Console.WriteLine("Consultando usuarios..");
            Consultar(); //Consultar datos con el actualizado
            Console.WriteLine("Eliminando registros..");
            Borrado();

            static void Borrado()
            {
                var ctx = new TareasDbContext();
                //USUARIOS
                //var usuario = ctx.Usuarios.Where(i => i.Idusuario == 1).Single();
                var usuarios = ctx.Usuarios.ToList(); //Listar todos los usuarios

                foreach (var usuario in usuarios) //Recorrerlos y eliminarlos
                {
                    ctx.Usuarios.Remove(usuario);
                }

                //RECURSO
                var recursos = ctx.Recursos.ToList(); //Listar todos los recursos

                foreach (var recurso in recursos) //Recorrerlos y eliminarlos
                {
                    ctx.Recursos.Remove(recurso);
                }

                //TAREAS
                var tareas = ctx.Tareas.ToList(); //Listar todas las tareas

                foreach (var tarea in tareas) //Recorrerlas y eliminarlos
                {
                    ctx.Tareas.Remove(tarea);
                }

                ctx.SaveChanges();
            }

            static void Actualizar()
            {
                var ctx = new TareasDbContext();
                //var lista = ctx.Usuarios.Where(i => i.Idusuario == 1).ToList();
                var lista = ctx.Usuarios.FirstOrDefault(); //Obtener el primer registro
                lista.Nombre = "rodo"; ;
                ctx.SaveChanges();
            }

            static void Consultar()
            {
                var ctx = new TareasDbContext();
                var lista = ctx.Usuarios.ToList();
                foreach (var item in lista)
                {
                    Console.WriteLine($"nombre: {item.Nombre}({ item.Clave})");
                }

            }

            static void Insertar()
            {
                //USUARIOS
                var ctxUsuarios = new TareasDbContext();
                ctxUsuarios.Add(new Usuarios { Nombre = "Pepito1", Clave = "123" });
                ctxUsuarios.Add(new Usuarios { Nombre = "Pepito2", Clave = "1234" });
                ctxUsuarios.SaveChanges(); //Agregar usuarios a la BD

                //Obtener usuarios agregados
                var ctxConsulta = new TareasDbContext();
                var listaUsuarios = ctxConsulta.Usuarios.ToList();

                //RECURSO
                var ctxRecurso = new TareasDbContext();
                var nroRecurso = 0;

                //Va agregar un recurso por usuario
                foreach (var usuario in listaUsuarios)
                {
                    nroRecurso++; //Incrementa el nro del recurso
                    ctxRecurso.Add(new Recursos { Idusuario = usuario.Idusuario, Nombre = String.Format("recurso {0}", nroRecurso) });
                }
                ctxRecurso.SaveChanges(); //Agregar recursos a la BD

                //Obtener recursos agregados
                ctxConsulta = new TareasDbContext();
                var listaRecurso = ctxConsulta.Recursos.ToList();

                //TAREAS
                var ctxTareas = new TareasDbContext();
                var nroTarea = 0;

                //Va agregar una tarea por recurso
                foreach (var recurso in listaRecurso)
                {
                    nroTarea++; //Incrementa el nro de la tarea
                    ctxTareas.Add(new Tareas { Titulo = String.Format("Tarea {0}", nroTarea), Vencimiento = new DateTime(2020, 10, 10), Estimacion = 1, Idrecurso = recurso.Idrecurso, Estado = true });
                }

                ctxTareas.SaveChanges(); //Agregar tareas a la BD

            }
            //add-Migration "Inicial"   Update-Database


        }

    }
}
