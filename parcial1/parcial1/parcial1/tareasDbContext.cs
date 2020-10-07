using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace parcial1
{
    public class tareasDbContext : DbContext
    {
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");
            modelBuilder.Entity<tareas>().ToTable("tareas");
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<tareas> tareas { get; set; }
        public DbSet<Recursos> recursos { get; set; }
        public DbSet<Detalles> detalles { get; set; }
    }
}
