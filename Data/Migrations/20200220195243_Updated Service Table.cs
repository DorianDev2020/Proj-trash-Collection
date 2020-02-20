using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjTrashCollection.Data.Migrations
{
    public partial class UpdatedServiceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "211101ba-fa0c-45ca-86a8-7b0f1de66257");

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PickupDay = table.Column<string>(nullable: true),
                    IsSuspended = table.Column<bool>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    OneTimePickup = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d84d3e82-f455-420d-ae00-fde1877b634d", "c15b4b06-e17f-4550-a0eb-a0c895b1fdff", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d84d3e82-f455-420d-ae00-fde1877b634d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "211101ba-fa0c-45ca-86a8-7b0f1de66257", "f657766d-4d8c-4217-8220-0e4ece7d9879", "Admin", "ADMIN" });
        }
    }
}
