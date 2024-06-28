using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrolAPI.Migrations
{
    /// <inheritdoc />
    public partial class someDtos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CntdAñosAntiguedad",
                table: "Incomes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CntdAñosAntiguedad",
                table: "Incomes");
        }
    }
}
