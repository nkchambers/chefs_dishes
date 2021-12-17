using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace chefs_dishes.Migrations
{
    public partial class ChangedDOBToDateTimeInModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Chefs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DateOfBirth",
                table: "Chefs",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
