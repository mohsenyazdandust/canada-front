using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesCanada.Migrations
{
    /// <inheritdoc />
    public partial class Review656513636 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Destinationid",
                table: "Accommodations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accommodations_Destinationid",
                table: "Accommodations",
                column: "Destinationid");

            migrationBuilder.AddForeignKey(
                name: "FK_Accommodations_Destinations_Destinationid",
                table: "Accommodations",
                column: "Destinationid",
                principalTable: "Destinations",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accommodations_Destinations_Destinationid",
                table: "Accommodations");

            migrationBuilder.DropIndex(
                name: "IX_Accommodations_Destinationid",
                table: "Accommodations");

            migrationBuilder.DropColumn(
                name: "Destinationid",
                table: "Accommodations");
        }
    }
}
