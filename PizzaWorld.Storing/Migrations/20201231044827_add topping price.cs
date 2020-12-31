using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class addtoppingprice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Topping",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas",
                column: "EntityID");

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 1L,
                column: "Price",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 2L,
                column: "Price",
                value: 1.0);

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "EntityID", "Name", "Price" },
                values: new object[,]
                {
                    { 3L, "Cheese", 3.0 },
                    { 4L, "Sausage", 2.0 },
                    { 5L, "Ham", 1.0 },
                    { 6L, "Onion", 1.0 },
                    { 7L, "Bacon", 3.0 },
                    { 8L, "Chicken", 3.0 },
                    { 9L, "Anchovi", 2.0 },
                    { 10L, "Cucumber", 1.0 },
                    { 11L, "Mushroom", 1.0 },
                    { 12L, "Spinach", 1.0 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 12L);

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Topping");

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
    }
}
