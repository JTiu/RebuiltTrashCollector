using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftTrashCollector.Migrations
{
    public partial class CustomerChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "cf87a8cd-31c1-47bc-9b61-cdffd4935dbb", "f76fb937-7435-4d25-9b3b-1175e6f12880", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d613c173-f8d4-4558-991f-b311d7aadd1d", "c42ac75e-6b51-46c3-ad77-939feab153d8", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf87a8cd-31c1-47bc-9b61-cdffd4935dbb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d613c173-f8d4-4558-991f-b311d7aadd1d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bcd8631-dc3d-4218-961c-5f49598f8e26", "5301accc-c0c4-4466-ab95-aa38e6b96c3c", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f2d2240-7e3d-4c3a-bf66-cb831daf702b", "bc212844-8b7d-418c-8dbd-88c980152284", "Customer", "CUSTOMER" });
        }
    }
}
