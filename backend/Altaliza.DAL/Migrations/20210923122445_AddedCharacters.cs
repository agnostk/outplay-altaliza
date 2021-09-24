using Microsoft.EntityFrameworkCore.Migrations;

namespace Altaliza.DAL.Migrations
{
    public partial class AddedCharacters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Name", "Wallet" },
                values: new object[] { 1, "Fulano de Tal", 250000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
