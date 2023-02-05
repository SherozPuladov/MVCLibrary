using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddedBookAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CallNumber",
                table: "Book",
                newName: "CallNumber");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "CallNumber",
                table: "Book",
                newName: "Number");
        }
    }
}
