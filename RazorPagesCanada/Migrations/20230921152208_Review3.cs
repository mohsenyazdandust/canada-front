using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesCanada.Migrations
{
    /// <inheritdoc />
    public partial class Review3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Resturants_Resturantid",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "Resturantid",
                table: "Reviews",
                newName: "resturantid");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_Resturantid",
                table: "Reviews",
                newName: "IX_Reviews_resturantid");

            migrationBuilder.AlterColumn<int>(
                name: "resturantid",
                table: "Reviews",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Resturants_resturantid",
                table: "Reviews",
                column: "resturantid",
                principalTable: "Resturants",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Resturants_resturantid",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "resturantid",
                table: "Reviews",
                newName: "Resturantid");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_resturantid",
                table: "Reviews",
                newName: "IX_Reviews_Resturantid");

            migrationBuilder.AlterColumn<int>(
                name: "Resturantid",
                table: "Reviews",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Resturants_Resturantid",
                table: "Reviews",
                column: "Resturantid",
                principalTable: "Resturants",
                principalColumn: "id");
        }
    }
}
