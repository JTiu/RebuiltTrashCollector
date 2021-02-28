using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftTrashCollector.Migrations
{
    public partial class Changes_Customers_Start_Employees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53314869-0b59-4c09-8714-c10f687591d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5c865b9-21c2-403d-bcbb-2e2a7b9198d1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c1d29c9-6615-44a5-9c33-3968b30fd085", "6609ba0c-f7bf-430f-9b28-b6bfba7a877f", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4020d5c6-1812-4160-b846-db3ea2e0392f", "a8d61418-24d3-4a8e-bdf8-3b17bf63e872", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c1d29c9-6615-44a5-9c33-3968b30fd085");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4020d5c6-1812-4160-b846-db3ea2e0392f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5c865b9-21c2-403d-bcbb-2e2a7b9198d1", "940c4a45-88f0-4cbf-b98a-0d2fd3e32d54", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "53314869-0b59-4c09-8714-c10f687591d7", "ea310613-77f7-4e53-a408-50d6b93e8e82", "Customer", "CUSTOMER" });
        }
    }
}
