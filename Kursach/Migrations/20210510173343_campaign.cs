using Microsoft.EntityFrameworkCore.Migrations;

namespace Kursach.Migrations
{
    public partial class campaign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CollectedMoney",
                table: "Campaigns",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Deskription",
                table: "Campaigns",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollectedMoney",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "Deskription",
                table: "Campaigns");
        }
    }
}
