using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory_Design.Migrations
{
    /// <inheritdoc />
    public partial class HouseAndMedicalAllowance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HouseAllowance",
                table: "Employees",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MwdicalAllowance",
                table: "Employees",
                type: "int",
                nullable: true,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HouseAllowance",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MwdicalAllowance",
                table: "Employees");
        }
    }
}
