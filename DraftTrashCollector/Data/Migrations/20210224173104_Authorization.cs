using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftTrashCollector.Data.Migrations
{
    public partial class Authorization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f1f4489-2f31-426f-98c2-42d9323d9618");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e46a95fc-a931-4421-bc5c-bfb118e32719");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c3019aa-e59d-4a46-bedc-983aa9bed24b", "83dd835f-855a-4f9f-adde-e0c014b9b392", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7ef92fe5-8ce3-4181-9f65-87505e75691c", "c2b597ed-5062-4bb8-8a75-49fef24549ce", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c3019aa-e59d-4a46-bedc-983aa9bed24b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ef92fe5-8ce3-4181-9f65-87505e75691c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e46a95fc-a931-4421-bc5c-bfb118e32719", "3fff08c0-e96f-4505-935b-5024c425d98b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f1f4489-2f31-426f-98c2-42d9323d9618", "a093a487-e7c9-40a9-a0c7-123117b99f9f", "Customer", "CUSTOMER" });
        }
    }
}
