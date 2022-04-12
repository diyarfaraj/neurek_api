using Microsoft.EntityFrameworkCore.Migrations;

namespace neurek.Data.Migrations
{
    public partial class AddJobsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobAd_Companies_CompanyId",
                table: "JobAd");

            migrationBuilder.DropForeignKey(
                name: "FK_Language_JobAd_JobAdId",
                table: "Language");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_JobAd_JobAdId",
                table: "Likes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobAd",
                table: "JobAd");

            migrationBuilder.RenameTable(
                name: "JobAd",
                newName: "JobAds");

            migrationBuilder.RenameIndex(
                name: "IX_JobAd_CompanyId",
                table: "JobAds",
                newName: "IX_JobAds_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobAds",
                table: "JobAds",
                column: "JobAdId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobAds_Companies_CompanyId",
                table: "JobAds",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Language_JobAds_JobAdId",
                table: "Language",
                column: "JobAdId",
                principalTable: "JobAds",
                principalColumn: "JobAdId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_JobAds_JobAdId",
                table: "Likes",
                column: "JobAdId",
                principalTable: "JobAds",
                principalColumn: "JobAdId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobAds_Companies_CompanyId",
                table: "JobAds");

            migrationBuilder.DropForeignKey(
                name: "FK_Language_JobAds_JobAdId",
                table: "Language");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_JobAds_JobAdId",
                table: "Likes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobAds",
                table: "JobAds");

            migrationBuilder.RenameTable(
                name: "JobAds",
                newName: "JobAd");

            migrationBuilder.RenameIndex(
                name: "IX_JobAds_CompanyId",
                table: "JobAd",
                newName: "IX_JobAd_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobAd",
                table: "JobAd",
                column: "JobAdId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobAd_Companies_CompanyId",
                table: "JobAd",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Language_JobAd_JobAdId",
                table: "Language",
                column: "JobAdId",
                principalTable: "JobAd",
                principalColumn: "JobAdId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_JobAd_JobAdId",
                table: "Likes",
                column: "JobAdId",
                principalTable: "JobAd",
                principalColumn: "JobAdId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
