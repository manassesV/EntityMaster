using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityMaster.Migrations
{
    /// <inheritdoc />
    public partial class six : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Drivers");
        }
    }
}
