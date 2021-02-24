using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftTrashCollector.Data.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "262033b5-72ed-4922-b4ac-cdbed36ea197");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c78d839a-9416-4d8d-a80c-8c216db3d011", "e5913787-d20b-483f-bb73-22265fabff82", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c78d839a-9416-4d8d-a80c-8c216db3d011");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "262033b5-72ed-4922-b4ac-cdbed36ea197", "5ee07edc-6cf4-4664-9664-390e80e67862", "Admin", "ADMIN" });
        }
    }
}
