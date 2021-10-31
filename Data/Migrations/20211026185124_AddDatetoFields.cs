using Microsoft.EntityFrameworkCore.Migrations;

namespace neurek.Data.Migrations
{
    public partial class AddDatetoFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "CandidateEducation",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EducationDescription",
                table: "CandidateEducation",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SchoolName",
                table: "CandidateEducation",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "CandidateEducation");

            migrationBuilder.DropColumn(
                name: "EducationDescription",
                table: "CandidateEducation");

            migrationBuilder.DropColumn(
                name: "SchoolName",
                table: "CandidateEducation");
        }
    }
}
