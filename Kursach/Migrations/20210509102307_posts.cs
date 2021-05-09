using Microsoft.EntityFrameworkCore.Migrations;

namespace Kursach.Migrations
{
    public partial class posts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Campaigns_CampaignId",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "CampaignName",
                table: "Post");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Posts");

            migrationBuilder.RenameIndex(
                name: "IX_Post_CampaignId",
                table: "Posts",
                newName: "IX_Posts_CampaignId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Campaigns_CampaignId",
                table: "Posts",
                column: "CampaignId",
                principalTable: "Campaigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Campaigns_CampaignId",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Post");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_CampaignId",
                table: "Post",
                newName: "IX_Post_CampaignId");

            migrationBuilder.AddColumn<string>(
                name: "CampaignName",
                table: "Post",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Campaigns_CampaignId",
                table: "Post",
                column: "CampaignId",
                principalTable: "Campaigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
