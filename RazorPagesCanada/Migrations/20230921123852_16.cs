using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesCanada.Migrations
{
    /// <inheritdoc />
    public partial class _16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuisineResturant_Cuisines_relatedCuisisnesid",
                table: "CuisineResturant");

            migrationBuilder.RenameColumn(
                name: "relatedCuisisnesid",
                table: "CuisineResturant",
                newName: "relatedCuisinesid");

            migrationBuilder.RenameIndex(
                name: "IX_CuisineResturant_relatedCuisisnesid",
                table: "CuisineResturant",
                newName: "IX_CuisineResturant_relatedCuisinesid");

            migrationBuilder.AddForeignKey(
                name: "FK_CuisineResturant_Cuisines_relatedCuisinesid",
                table: "CuisineResturant",
                column: "relatedCuisinesid",
                principalTable: "Cuisines",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuisineResturant_Cuisines_relatedCuisinesid",
                table: "CuisineResturant");

            migrationBuilder.RenameColumn(
                name: "relatedCuisinesid",
                table: "CuisineResturant",
                newName: "relatedCuisisnesid");

            migrationBuilder.RenameIndex(
                name: "IX_CuisineResturant_relatedCuisinesid",
                table: "CuisineResturant",
                newName: "IX_CuisineResturant_relatedCuisisnesid");

            migrationBuilder.AddForeignKey(
                name: "FK_CuisineResturant_Cuisines_relatedCuisisnesid",
                table: "CuisineResturant",
                column: "relatedCuisisnesid",
                principalTable: "Cuisines",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
