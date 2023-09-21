using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesCanada.Migrations
{
    /// <inheritdoc />
    public partial class third2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuisines",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(type: "TEXT", nullable: false),
                    descriprion = table.Column<string>(type: "TEXT", nullable: false),
                    preparation = table.Column<string>(type: "TEXT", nullable: false),
                    culturalSignificance = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuisines", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Resturant",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resturant", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CuisineResturant",
                columns: table => new
                {
                    recommandedResturantsid = table.Column<int>(type: "INTEGER", nullable: false),
                    relatedCuisisnesid = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuisineResturant", x => new { x.recommandedResturantsid, x.relatedCuisisnesid });
                    table.ForeignKey(
                        name: "FK_CuisineResturant_Cuisines_relatedCuisisnesid",
                        column: x => x.relatedCuisisnesid,
                        principalTable: "Cuisines",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CuisineResturant_Resturant_recommandedResturantsid",
                        column: x => x.recommandedResturantsid,
                        principalTable: "Resturant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CuisineResturant_relatedCuisisnesid",
                table: "CuisineResturant",
                column: "relatedCuisisnesid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuisineResturant");

            migrationBuilder.DropTable(
                name: "Cuisines");

            migrationBuilder.DropTable(
                name: "Resturant");
        }
    }
}
