using Microsoft.EntityFrameworkCore.Migrations;

namespace chefs_dishes.Migrations
{
    public partial class NewDishViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Chefs_ChefId",
                table: "Dishes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dishes",
                table: "Dishes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chefs",
                table: "Chefs");

            migrationBuilder.RenameTable(
                name: "Dishes",
                newName: "dishes");

            migrationBuilder.RenameTable(
                name: "Chefs",
                newName: "chefs");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_ChefId",
                table: "dishes",
                newName: "IX_dishes_ChefId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dishes",
                table: "dishes",
                column: "DishId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_chefs",
                table: "chefs",
                column: "ChefId");

            migrationBuilder.AddForeignKey(
                name: "FK_dishes_chefs_ChefId",
                table: "dishes",
                column: "ChefId",
                principalTable: "chefs",
                principalColumn: "ChefId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dishes_chefs_ChefId",
                table: "dishes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dishes",
                table: "dishes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_chefs",
                table: "chefs");

            migrationBuilder.RenameTable(
                name: "dishes",
                newName: "Dishes");

            migrationBuilder.RenameTable(
                name: "chefs",
                newName: "Chefs");

            migrationBuilder.RenameIndex(
                name: "IX_dishes_ChefId",
                table: "Dishes",
                newName: "IX_Dishes_ChefId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dishes",
                table: "Dishes",
                column: "DishId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chefs",
                table: "Chefs",
                column: "ChefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Chefs_ChefId",
                table: "Dishes",
                column: "ChefId",
                principalTable: "Chefs",
                principalColumn: "ChefId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
