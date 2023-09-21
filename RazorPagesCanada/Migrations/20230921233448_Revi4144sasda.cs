using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesCanada.Migrations
{
    /// <inheritdoc />
    public partial class Revi4144sasda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date",
                table: "bookings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "date",
                table: "bookings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
