using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace neurek.Data.Migrations
{
    public partial class UpdateExperience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YearsOfWorking",
                table: "CandidateExperience",
                newName: "CurrentJob");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "CandidateExperience",
                newName: "JobTtitle");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "CandidateExperience",
                newName: "JobDescription");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "CandidateExperience",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FromDate",
                table: "CandidateExperience",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ToDate",
                table: "CandidateExperience",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "CandidateExperience");

            migrationBuilder.DropColumn(
                name: "FromDate",
                table: "CandidateExperience");

            migrationBuilder.DropColumn(
                name: "ToDate",
                table: "CandidateExperience");

            migrationBuilder.RenameColumn(
                name: "JobTtitle",
                table: "CandidateExperience",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "JobDescription",
                table: "CandidateExperience",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CurrentJob",
                table: "CandidateExperience",
                newName: "YearsOfWorking");
        }
    }
}
