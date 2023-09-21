using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesCanada.Migrations
{
    /// <inheritdoc />
    public partial class _11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuisineResturant_Resturant_recommandedResturantsid",
                table: "CuisineResturant");

            migrationBuilder.DropTable(
                name: "Destination");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resturant",
                table: "Resturant");

            migrationBuilder.RenameTable(
                name: "Resturant",
                newName: "Resturants");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resturants",
                table: "Resturants",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: false),
                    moreDetails = table.Column<string>(type: "TEXT", nullable: false),
                    pictureAddress = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CuisineResturant_Resturants_recommandedResturantsid",
                table: "CuisineResturant",
                column: "recommandedResturantsid",
                principalTable: "Resturants",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuisineResturant_Resturants_recommandedResturantsid",
                table: "CuisineResturant");

            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resturants",
                table: "Resturants");

            migrationBuilder.RenameTable(
                name: "Resturants",
                newName: "Resturant");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resturant",
                table: "Resturant",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Destination",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    description = table.Column<string>(type: "TEXT", nullable: false),
                    moreDetails = table.Column<string>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    pictureAddress = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CuisineResturant_Resturant_recommandedResturantsid",
                table: "CuisineResturant",
                column: "recommandedResturantsid",
                principalTable: "Resturant",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
