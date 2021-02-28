using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftTrashCollector.Migrations
{
    public partial class AdjustedCustomerSuspendDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c1d29c9-6615-44a5-9c33-3968b30fd085");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4020d5c6-1812-4160-b846-db3ea2e0392f");

            migrationBuilder.AddColumn<string>(
                name: "SuspendEnd",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuspendStart",
                table: "Customer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0c81283-002c-40dd-bff4-a7bde37bbf29", "a61c2515-71bc-4e23-8dde-e33862bdd713", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43d5fc5a-ae6c-4314-b0a5-492444563b73", "dd2d6e14-e647-487b-8999-4e33a8fd586c", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43d5fc5a-ae6c-4314-b0a5-492444563b73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0c81283-002c-40dd-bff4-a7bde37bbf29");

            migrationBuilder.DropColumn(
                name: "SuspendEnd",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "SuspendStart",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c1d29c9-6615-44a5-9c33-3968b30fd085", "6609ba0c-f7bf-430f-9b28-b6bfba7a877f", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4020d5c6-1812-4160-b846-db3ea2e0392f", "a8d61418-24d3-4a8e-bdf8-3b17bf63e872", "Customer", "CUSTOMER" });
        }
    }
}
