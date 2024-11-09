using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComaBackend.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "Varchar(30)", nullable: false),
                    apellido = table.Column<string>(type: "Varchar(30)", nullable: false),
                    edad = table.Column<string>(type: "Varchar(2)", nullable: false),
                    correo = table.Column<string>(type: "Varchar(30)", nullable: false),
                    tipo_usuario = table.Column<string>(type: "Varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
