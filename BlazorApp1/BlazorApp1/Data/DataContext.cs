using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class DataContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//error en OnConfiguring
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//error en OnConfiguring
        {
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuario")
                .Property(p => p.Clave);
            modelBuilder.Entity<Tareas>()
                .ToTable("Tarea");
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
