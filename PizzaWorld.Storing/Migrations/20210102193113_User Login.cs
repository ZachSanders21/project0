using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class UserLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 12L);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "EntityID", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, "Small", 0.0 },
                    { 2L, "Medium", 2.0 },
                    { 3L, "Large", 4.0 }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "EntityID", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, "Pepperoni", 2.0 },
                    { 2L, "Pineapple", 1.0 },
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
        }
    }
}
