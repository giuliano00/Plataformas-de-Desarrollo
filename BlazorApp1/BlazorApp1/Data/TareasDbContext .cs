using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareasDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(user =>
            {
                user.ToTable("Usuario");

                user.HasKey(p => p.UsuarioPK);

                user.Property(p => p.UsuarioPK).ValueGeneratedOnAdd().HasColumnName("userId");

                user.Property(p => p.Nombre).HasColumnName("nUsuario").HasColumnType("varchar(50)").IsRequired();

                user.Property(p => p.Clave).HasColumnName("pass").HasColumnType("varchar(12)").IsRequired();

            });


            modelBuilder.Entity<Recurso>(rec =>
            {
                rec.ToTable("Recurso");

                rec.HasKey(p => p.Id);

                rec.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("recId");

                rec.Property(p => p.Nombre).HasColumnName("nRecurso").HasColumnType("varchar(50)").IsRequired();

            });

            modelBuilder.Entity<Tareas>(tar =>
            {
                tar.ToTable("Tarea");

                tar.HasKey(p => p.Id);

                tar.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("taskId");

                tar.Property(p => p.Titulo).HasColumnName("titulo").HasColumnType("varchar(50)").IsRequired();

                tar.Property(p => p.Vencimiento).HasColumnName("vencimiento").IsRequired();

                tar.Property(p => p.Estimacion).HasColumnName("estimacion").HasColumnType("int(2)").IsRequired();

                tar.Property(p => p.Estado).HasColumnName("estado").HasColumnType("varchar(10)");

            });

            modelBuilder.Entity<Detalle>(det =>
            {
                det.ToTable("Detalle");

                det.HasKey(p => p.Id);

                det.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("detId");

                det.Property(p => p.Fecha).HasColumnName("fecha").IsRequired();

                det.Property(p => p.Tiempo).HasColumnName("tiempo").HasColumnType("int(5)").IsRequired();

            });
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Recurso> Recursos { get; set; }

        public DbSet<Tareas> Tareas { get; set; }

        public DbSet<Detalle> Detalles { get; set; }

    }
}