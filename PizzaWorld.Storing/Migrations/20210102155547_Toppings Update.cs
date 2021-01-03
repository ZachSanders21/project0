using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class ToppingsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModelTopping_Topping_ToppingsEntityID",
                table: "APizzaModelTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topping",
                table: "Topping");

            migrationBuilder.RenameTable(
                name: "Topping",
                newName: "Toppings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings",
                column: "EntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModelTopping_Toppings_ToppingsEntityID",
                table: "APizzaModelTopping",
                column: "ToppingsEntityID",
                principalTable: "Toppings",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModelTopping_Toppings_ToppingsEntityID",
                table: "APizzaModelTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings");

            migrationBuilder.RenameTable(
                name: "Toppings",
                newName: "Topping");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topping",
                table: "Topping",
                column: "EntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModelTopping_Topping_ToppingsEntityID",
                table: "APizzaModelTopping",
                column: "ToppingsEntityID",
                principalTable: "Topping",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
