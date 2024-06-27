﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrolAPI.Migrations
{
    /// <inheritdoc />
    public partial class problems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CntdAñosAntiguedad",
                table: "Incomes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CntdAñosAntiguedad",
                table: "Incomes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
