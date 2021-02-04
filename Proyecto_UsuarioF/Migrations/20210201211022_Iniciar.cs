using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoReguistroUsuario.Migrations
{
    public partial class Iniciar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roll",
                columns: table => new
                {
                    RolliD = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Fechacreacion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roll", x => x.RolliD);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdR = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Alias = table.Column<string>(type: "TEXT", nullable: true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Clave = table.Column<string>(type: "TEXT", nullable: true),
                    RolId = table.Column<string>(type: "TEXT", nullable: true),
                    Activo = table.Column<bool>(type: "INTEGER", nullable: false),
                    UsuarioNombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
<<<<<<< HEAD:Proyecto_UsuarioF/Migrations/20210204163327_Inicial.cs
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
=======
                    table.PrimaryKey("PK_Usuarios", x => x.IdR);
>>>>>>> 546a3d14b8670f013de56a2fcb0427db5a14f853:Proyecto_UsuarioF/Migrations/20210201211022_Iniciar.cs
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roll");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
