﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using parcial1;

namespace parcial1.Migrations
{
    [DbContext(typeof(TareasDbContext))]
    partial class TareasDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("parcial1.Detalles", b =>
                {
                    b.Property<int>("Iddetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("Idrecurso")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Idtarea")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RecursoIdrecurso")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TareaIdtarea")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tiempo")
                        .HasColumnType("TEXT");

                    b.HasKey("Iddetalle");

                    b.HasIndex("RecursoIdrecurso");

                    b.HasIndex("TareaIdtarea");

                    b.ToTable("Tetalles");
                });

            modelBuilder.Entity("parcial1.Recursos", b =>
                {
                    b.Property<int>("Idrecurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Idusuario")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UsuarioIdusuario")
                        .HasColumnType("INTEGER");

                    b.HasKey("Idrecurso");

                    b.HasIndex("UsuarioIdusuario");

                    b.ToTable("Tecursos");
                });

            modelBuilder.Entity("parcial1.Tareas", b =>
                {
                    b.Property<int>("Idtarea")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Estimacion")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Idrecurso")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ResponsableIdrecurso")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Vencimiento")
                        .HasColumnType("TEXT");

                    b.HasKey("Idtarea");

                    b.HasIndex("ResponsableIdrecurso");

                    b.ToTable("tareas");
                });

            modelBuilder.Entity("parcial1.Usuarios", b =>
                {
                    b.Property<int>("Idusuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Idusuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("parcial1.Detalles", b =>
                {
                    b.HasOne("parcial1.Recursos", "Recurso")
                        .WithMany()
                        .HasForeignKey("RecursoIdrecurso");

                    b.HasOne("parcial1.Tareas", "Tarea")
                        .WithMany()
                        .HasForeignKey("TareaIdtarea");
                });

            modelBuilder.Entity("parcial1.Recursos", b =>
                {
                    b.HasOne("parcial1.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdusuario");
                });

            modelBuilder.Entity("parcial1.Tareas", b =>
                {
                    b.HasOne("parcial1.Recursos", "Responsable")
                        .WithMany()
                        .HasForeignKey("ResponsableIdrecurso");
                });
#pragma warning restore 612, 618
        }
    }
}
