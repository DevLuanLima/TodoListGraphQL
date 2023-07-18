using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListGraphQL.Migrations
{
    /// <inheritdoc />
    public partial class CorrectingfieldTitleinItemData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tittle",
                table: "Items",
                newName: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Items",
                newName: "Tittle");
        }
    }
}
