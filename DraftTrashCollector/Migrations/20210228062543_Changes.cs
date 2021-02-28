using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftTrashCollector.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43d5fc5a-ae6c-4314-b0a5-492444563b73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0c81283-002c-40dd-bff4-a7bde37bbf29");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bcd8631-dc3d-4218-961c-5f49598f8e26", "5301accc-c0c4-4466-ab95-aa38e6b96c3c", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f2d2240-7e3d-4c3a-bf66-cb831daf702b", "bc212844-8b7d-418c-8dbd-88c980152284", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bcd8631-dc3d-4218-961c-5f49598f8e26");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f2d2240-7e3d-4c3a-bf66-cb831daf702b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0c81283-002c-40dd-bff4-a7bde37bbf29", "a61c2515-71bc-4e23-8dde-e33862bdd713", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43d5fc5a-ae6c-4314-b0a5-492444563b73", "dd2d6e14-e647-487b-8999-4e33a8fd586c", "Customer", "CUSTOMER" });
        }
    }
}
