using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class AddSizes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SizeEntityID",
                table: "APizzaModel",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.EntityID);
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "EntityID", "Name", "Price" },
                values: new object[] { 1L, "Small", 0.0 });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "EntityID", "Name", "Price" },
                values: new object[] { 2L, "Medium", 2.0 });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "EntityID", "Name", "Price" },
                values: new object[] { 3L, "Large", 4.0 });

            migrationBuilder.CreateIndex(
                name: "IX_APizzaModel_SizeEntityID",
                table: "APizzaModel",
                column: "SizeEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModel_Sizes_SizeEntityID",
                table: "APizzaModel",
                column: "SizeEntityID",
                principalTable: "Sizes",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModel_Sizes_SizeEntityID",
                table: "APizzaModel");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropIndex(
                name: "IX_APizzaModel_SizeEntityID",
                table: "APizzaModel");

            migrationBuilder.DropColumn(
                name: "SizeEntityID",
                table: "APizzaModel");
        }
    }
}
