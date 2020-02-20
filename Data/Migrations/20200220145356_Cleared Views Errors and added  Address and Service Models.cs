using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjTrashCollection.Data.Migrations
{
    public partial class ClearedViewsErrorsandaddedAddressandServiceModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9cb1197-383e-42ea-be92-7c9ebd2d6136");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "211101ba-fa0c-45ca-86a8-7b0f1de66257", "f657766d-4d8c-4217-8220-0e4ece7d9879", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Zipcode",
                table: "Employees",
                column: "Zipcode");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Address_Zipcode",
                table: "Employees",
                column: "Zipcode",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Address_Zipcode",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Zipcode",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "211101ba-fa0c-45ca-86a8-7b0f1de66257");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9cb1197-383e-42ea-be92-7c9ebd2d6136", "bf6471a0-c853-4af8-a6c1-bea1aad45360", "Admin", "ADMIN" });
        }
    }
}
