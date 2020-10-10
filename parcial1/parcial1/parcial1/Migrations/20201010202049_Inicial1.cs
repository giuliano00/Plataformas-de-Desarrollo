using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace parcial1.Migrations
{
    public partial class Inicial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Idusuario = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true),
                    Clave = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Idusuario);
                });

            migrationBuilder.CreateTable(
                name: "Recurso",
                columns: table => new
                {
                    Idrecurso = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true),
                    Idusuario = table.Column<int>(nullable: false),
                    UsuarioIdusuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.Idrecurso);
                    table.ForeignKey(
                        name: "FK_Recurso_Usuarios_UsuarioIdusuario",
                        column: x => x.UsuarioIdusuario,
                        principalTable: "Usuarios",
                        principalColumn: "Idusuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tareas",
                columns: table => new
                {
                    Idtarea = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(nullable: true),
                    Vencimiento = table.Column<DateTime>(nullable: false),
                    Estimacion = table.Column<int>(nullable: false),
                    Idrecurso = table.Column<int>(nullable: false),
                    ResponsableIdrecurso = table.Column<int>(nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tareas", x => x.Idtarea);
                    table.ForeignKey(
                        name: "FK_tareas_Recurso_ResponsableIdrecurso",
                        column: x => x.ResponsableIdrecurso,
                        principalTable: "Recurso",
                        principalColumn: "Idrecurso",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    Iddetalle = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Tiempo = table.Column<string>(nullable: true),
                    Idrecurso = table.Column<int>(nullable: false),
                    RecursoIdrecurso = table.Column<int>(nullable: true),
                    Idtarea = table.Column<int>(nullable: false),
                    TareaIdtarea = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.Iddetalle);
                    table.ForeignKey(
                        name: "FK_Detalle_Recurso_RecursoIdrecurso",
                        column: x => x.RecursoIdrecurso,
                        principalTable: "Recurso",
                        principalColumn: "Idrecurso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalle_tareas_TareaIdtarea",
                        column: x => x.TareaIdtarea,
                        principalTable: "tareas",
                        principalColumn: "Idtarea",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_RecursoIdrecurso",
                table: "Detalle",
                column: "RecursoIdrecurso");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_TareaIdtarea",
                table: "Detalle",
                column: "TareaIdtarea");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_UsuarioIdusuario",
                table: "Recurso",
                column: "UsuarioIdusuario");

            migrationBuilder.CreateIndex(
                name: "IX_tareas_ResponsableIdrecurso",
                table: "tareas",
                column: "ResponsableIdrecurso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "tareas");

            migrationBuilder.DropTable(
                name: "Recurso");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
