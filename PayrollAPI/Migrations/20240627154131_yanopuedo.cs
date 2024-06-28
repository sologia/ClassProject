using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrolAPI.Migrations
{
    /// <inheritdoc />
    public partial class yanopuedo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Periodo",
                table: "Payrolls");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Periodo",
                table: "Payrolls",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
