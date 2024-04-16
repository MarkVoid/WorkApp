using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkApp.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Login",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 1, "admin123", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Login",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
