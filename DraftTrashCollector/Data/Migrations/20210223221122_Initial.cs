using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftTrashCollector.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1cfd427-3f39-4c66-815f-129cb3213e45", "77aa1c60-a8b4-46fd-b135-b11ab5547f31", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1cfd427-3f39-4c66-815f-129cb3213e45");
        }
    }
}
