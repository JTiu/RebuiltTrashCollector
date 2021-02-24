using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftTrashCollector.Data.Migrations
{
    public partial class AdditionalRoleCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1cfd427-3f39-4c66-815f-129cb3213e45");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "262033b5-72ed-4922-b4ac-cdbed36ea197", "5ee07edc-6cf4-4664-9664-390e80e67862", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "262033b5-72ed-4922-b4ac-cdbed36ea197");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1cfd427-3f39-4c66-815f-129cb3213e45", "77aa1c60-a8b4-46fd-b135-b11ab5547f31", "Admin", "ADMIN" });
        }
    }
}
