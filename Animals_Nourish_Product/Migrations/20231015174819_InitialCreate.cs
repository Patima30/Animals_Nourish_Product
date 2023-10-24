using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Animals_Nourish_Product.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id_Product = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name_Product = table.Column<string>(type: "TEXT", nullable: false),
                    Description_Product = table.Column<string>(type: "TEXT", nullable: false),
                    Price_Product = table.Column<decimal>(type: "TEXT", nullable: false),
                    Animal_type = table.Column<string>(type: "TEXT", nullable: false),
                    Food_type = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id_Product);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
