using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesCanada.Migrations
{
    /// <inheritdoc />
    public partial class Review65651363666555 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GalletyAddress",
                table: "Destinations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GalletyAddress",
                table: "Destinations");
        }
    }
}
