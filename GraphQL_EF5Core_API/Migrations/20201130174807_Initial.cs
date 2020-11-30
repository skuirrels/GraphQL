using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphQL_EF5Core_API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skuirrel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skuirrel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Skuirrel",
                columns: new[] { "Id", "Age", "Location", "Name" },
                values: new object[,]
                {
                    { new Guid("9f5ccccf-ec37-4e5e-8763-fd42088bd6b2"), 10, "The Trees", "Alan Korn" },
                    { new Guid("860a7e27-8b5f-4b04-9a67-008000b6bfe1"), 5, "The Oak", "Savannah Korn" },
                    { new Guid("48569a5a-d01f-456b-9a64-f608714ca491"), 9, "The Pine", "Sienna Korn" },
                    { new Guid("f1aa9f34-609d-485b-9777-b5dd99343a13"), 11, "The Tree House", "Mamma Korn" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skuirrel");
        }
    }
}
