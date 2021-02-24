using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftTrashCollector.Data.Migrations
{
    public partial class Authorizations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4af1461a-dff9-4f26-8d90-b477c50e638f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4d176fb-8c25-47e3-bca0-1f3b429eeaf8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e46a95fc-a931-4421-bc5c-bfb118e32719", "3fff08c0-e96f-4505-935b-5024c425d98b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f1f4489-2f31-426f-98c2-42d9323d9618", "a093a487-e7c9-40a9-a0c7-123117b99f9f", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4af1461a-dff9-4f26-8d90-b477c50e638f", "8819307f-e207-4812-8426-d7b2f689554f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4d176fb-8c25-47e3-bca0-1f3b429eeaf8", "4800338a-37c8-4ebd-87df-4162a8f9c263", "Customer", "CUSTOMER" });
        }
    }
}
