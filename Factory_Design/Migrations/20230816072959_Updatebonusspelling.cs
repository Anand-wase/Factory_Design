using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory_Design.Migrations
{
    /// <inheritdoc />
    public partial class Updatebonusspelling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Bonous",
                table: "Employees",
                newName: "Bonus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Bonus",
                table: "Employees",
                newName: "Bonous");
        }
    }
}
