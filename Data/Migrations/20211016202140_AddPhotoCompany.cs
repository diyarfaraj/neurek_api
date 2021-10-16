using Microsoft.EntityFrameworkCore.Migrations;

namespace neurek.Data.Migrations
{
    public partial class AddPhotoCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Photos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_CompanyId",
                table: "Photos",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Companies_CompanyId",
                table: "Photos",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Companies_CompanyId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_CompanyId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Photos");
        }
    }
}
