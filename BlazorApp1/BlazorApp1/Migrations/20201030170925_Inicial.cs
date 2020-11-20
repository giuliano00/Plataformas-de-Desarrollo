using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nUsuario = table.Column<string>(type: "varchar(50)", nullable: false),
                    pass = table.Column<string>(type: "varchar(12)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "Recurso",
                columns: table => new
                {
                    recId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nRecurso = table.Column<string>(type: "varchar(50)", nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.recId);
                    table.ForeignKey(
                        name: "FK_Recurso_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    taskId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    titulo = table.Column<string>(type: "varchar(50)", nullable: false),
                    vencimiento = table.Column<DateTime>(nullable: false),
                    estimacion = table.Column<int>(type: "int(2)", nullable: false),
                    RecursoId = table.Column<int>(nullable: false),
                    estado = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.taskId);
                    table.ForeignKey(
                        name: "FK_Tarea_Recurso_RecursoId",
                        column: x => x.RecursoId,
                        principalTable: "Recurso",
                        principalColumn: "recId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    detId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fecha = table.Column<DateTime>(nullable: false),
                    tiempo = table.Column<int>(type: "int(5)", nullable: false),
                    RecursoId = table.Column<int>(nullable: false),
                    TareaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.detId);
                    table.ForeignKey(
                        name: "FK_Detalle_Recurso_RecursoId",
                        column: x => x.RecursoId,
                        principalTable: "Recurso",
                        principalColumn: "recId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalle_Tarea_TareaId",
                        column: x => x.TareaId,
                        principalTable: "Tarea",
                        principalColumn: "taskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_RecursoId",
                table: "Detalle",
                column: "RecursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_TareaId",
                table: "Detalle",
                column: "TareaId");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_UsuarioId",
                table: "Recurso",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_RecursoId",
                table: "Tarea",
                column: "RecursoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Recurso");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
