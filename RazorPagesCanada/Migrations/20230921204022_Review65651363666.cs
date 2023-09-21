using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesCanada.Migrations
{
    /// <inheritdoc />
    public partial class Review65651363666 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accommodations_Destinations_Destinationid",
                table: "Accommodations");

            migrationBuilder.RenameColumn(
                name: "Destinationid",
                table: "Accommodations",
                newName: "destinationid");

            migrationBuilder.RenameIndex(
                name: "IX_Accommodations_Destinationid",
                table: "Accommodations",
                newName: "IX_Accommodations_destinationid");

            migrationBuilder.AlterColumn<int>(
                name: "destinationid",
                table: "Accommodations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Accommodations_Destinations_destinationid",
                table: "Accommodations",
                column: "destinationid",
                principalTable: "Destinations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accommodations_Destinations_destinationid",
                table: "Accommodations");

            migrationBuilder.RenameColumn(
                name: "destinationid",
                table: "Accommodations",
                newName: "Destinationid");

            migrationBuilder.RenameIndex(
                name: "IX_Accommodations_destinationid",
                table: "Accommodations",
                newName: "IX_Accommodations_Destinationid");

            migrationBuilder.AlterColumn<int>(
                name: "Destinationid",
                table: "Accommodations",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Accommodations_Destinations_Destinationid",
                table: "Accommodations",
                column: "Destinationid",
                principalTable: "Destinations",
                principalColumn: "id");
        }
    }
}
