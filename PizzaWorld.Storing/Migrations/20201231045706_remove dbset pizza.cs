using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class removedbsetpizza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModelTopping_Pizzas_PizzasEntityID",
                table: "APizzaModelTopping");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Order_OrderEntityID",
                table: "Pizzas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas");

            migrationBuilder.RenameTable(
                name: "Pizzas",
                newName: "APizzaModel");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_OrderEntityID",
                table: "APizzaModel",
                newName: "IX_APizzaModel_OrderEntityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_APizzaModel",
                table: "APizzaModel",
                column: "EntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModel_Order_OrderEntityID",
                table: "APizzaModel",
                column: "OrderEntityID",
                principalTable: "Order",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModelTopping_APizzaModel_PizzasEntityID",
                table: "APizzaModelTopping",
                column: "PizzasEntityID",
                principalTable: "APizzaModel",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModel_Order_OrderEntityID",
                table: "APizzaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModelTopping_APizzaModel_PizzasEntityID",
                table: "APizzaModelTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_APizzaModel",
                table: "APizzaModel");

            migrationBuilder.RenameTable(
                name: "APizzaModel",
                newName: "Pizzas");

            migrationBuilder.RenameIndex(
                name: "IX_APizzaModel_OrderEntityID",
                table: "Pizzas",
                newName: "IX_Pizzas_OrderEntityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas",
                column: "EntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModelTopping_Pizzas_PizzasEntityID",
                table: "APizzaModelTopping",
                column: "PizzasEntityID",
                principalTable: "Pizzas",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Order_OrderEntityID",
                table: "Pizzas",
                column: "OrderEntityID",
                principalTable: "Order",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
