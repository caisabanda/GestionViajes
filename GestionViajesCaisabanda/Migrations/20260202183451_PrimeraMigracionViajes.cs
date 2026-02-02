using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace GestionViajesCaisabanda.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracionViajes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Destinos",
                columns: table => new
                {
                    destino_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "longtext", nullable: false),
                    pais = table.Column<string>(type: "longtext", nullable: false),
                    descripcion = table.Column<string>(type: "longtext", nullable: false),
                    costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinos", x => x.destino_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Turistas",
                columns: table => new
                {
                    turista_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "longtext", nullable: false),
                    apellido = table.Column<string>(type: "longtext", nullable: false),
                    email = table.Column<string>(type: "longtext", nullable: false),
                    telefono = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turistas", x => x.turista_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinos");

            migrationBuilder.DropTable(
                name: "Turistas");
        }
    }
}
