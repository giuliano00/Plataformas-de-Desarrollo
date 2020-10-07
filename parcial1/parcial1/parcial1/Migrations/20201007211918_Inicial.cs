using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace parcial1.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioPK = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    User = table.Column<string>(maxLength: 15, nullable: true),
                    Password = table.Column<string>(type: "char(20", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioPK);
                });

            migrationBuilder.CreateTable(
                name: "recursos",
                columns: table => new
                {
                    iduser = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true),
                    idusuario = table.Column<int>(nullable: false),
                    UsuarioPK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recursos", x => x.iduser);
                    table.ForeignKey(
                        name: "FK_recursos_Usuarios_UsuarioPK",
                        column: x => x.UsuarioPK,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioPK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tareas",
                columns: table => new
                {
                    idtarea = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(nullable: true),
                    Vencimiento = table.Column<DateTime>(nullable: false),
                    Estimacion = table.Column<int>(nullable: false),
                    idrecurso = table.Column<int>(nullable: false),
                    Responsableiduser = table.Column<int>(nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tareas", x => x.idtarea);
                    table.ForeignKey(
                        name: "FK_tareas_recursos_Responsableiduser",
                        column: x => x.Responsableiduser,
                        principalTable: "recursos",
                        principalColumn: "iduser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "detalles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Tiempo = table.Column<string>(nullable: true),
                    idrecurso = table.Column<int>(nullable: false),
                    Recursoiduser = table.Column<int>(nullable: true),
                    idtarea = table.Column<int>(nullable: false),
                    Tareaidtarea = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalles", x => x.id);
                    table.ForeignKey(
                        name: "FK_detalles_recursos_Recursoiduser",
                        column: x => x.Recursoiduser,
                        principalTable: "recursos",
                        principalColumn: "iduser",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_detalles_tareas_Tareaidtarea",
                        column: x => x.Tareaidtarea,
                        principalTable: "tareas",
                        principalColumn: "idtarea",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_detalles_Recursoiduser",
                table: "detalles",
                column: "Recursoiduser");

            migrationBuilder.CreateIndex(
                name: "IX_detalles_Tareaidtarea",
                table: "detalles",
                column: "Tareaidtarea");

            migrationBuilder.CreateIndex(
                name: "IX_recursos_UsuarioPK",
                table: "recursos",
                column: "UsuarioPK");

            migrationBuilder.CreateIndex(
                name: "IX_tareas_Responsableiduser",
                table: "tareas",
                column: "Responsableiduser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalles");

            migrationBuilder.DropTable(
                name: "tareas");

            migrationBuilder.DropTable(
                name: "recursos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
