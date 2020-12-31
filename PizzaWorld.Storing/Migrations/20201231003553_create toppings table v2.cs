using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class createtoppingstablev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 11L);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityID", "Name" },
                values: new object[,]
                {
                    { 1L, "one" },
                    { 2L, "two" }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "EntityID", "Name" },
                values: new object[,]
                {
                    { 1L, "Pepperoni" },
                    { 2L, "Pineapple" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 2L);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityID", "Name" },
                values: new object[,]
                {
                    { 10L, "Store1" },
                    { 11L, "Store2" }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "EntityID", "Name" },
                values: new object[,]
                {
                    { 10L, "Pepperoni" },
                    { 11L, "Pineapple" }
                });
        }
    }
}
