using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eskitech.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produkter",
                columns: table => new
                {
                    ProduktID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Storlek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LagerSaldo = table.Column<int>(type: "int", nullable: false),
                    Pris = table.Column<int>(type: "int", nullable: false),
                    Kategori = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkter", x => x.ProduktID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produkter");
        }
    }
}
