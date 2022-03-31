using Microsoft.EntityFrameworkCore.Migrations;

namespace neurek.Data.Migrations
{
    public partial class LikeEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobAdId",
                table: "Language",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "JobAd",
                columns: table => new
                {
                    JobAdId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CompanyId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobAd", x => x.JobAdId);
                    table.ForeignKey(
                        name: "FK_JobAd_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    SourceUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    JobAdId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => new { x.SourceUserId, x.JobAdId });
                    table.ForeignKey(
                        name: "FK_Likes_JobAd_JobAdId",
                        column: x => x.JobAdId,
                        principalTable: "JobAd",
                        principalColumn: "JobAdId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Users_SourceUserId",
                        column: x => x.SourceUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Language_JobAdId",
                table: "Language",
                column: "JobAdId");

            migrationBuilder.CreateIndex(
                name: "IX_JobAd_CompanyId",
                table: "JobAd",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_JobAdId",
                table: "Likes",
                column: "JobAdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Language_JobAd_JobAdId",
                table: "Language",
                column: "JobAdId",
                principalTable: "JobAd",
                principalColumn: "JobAdId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Language_JobAd_JobAdId",
                table: "Language");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "JobAd");

            migrationBuilder.DropIndex(
                name: "IX_Language_JobAdId",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "JobAdId",
                table: "Language");
        }
    }
}
