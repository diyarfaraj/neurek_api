using Microsoft.EntityFrameworkCore.Migrations;

namespace neurek.Data.Migrations
{
    public partial class AddSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "CandidateSkill");

            migrationBuilder.AddColumn<int>(
                name: "SkillsId",
                table: "CandidateSkill",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    DevIconName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateSkill_SkillsId",
                table: "CandidateSkill",
                column: "SkillsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateSkill_Skills_SkillsId",
                table: "CandidateSkill",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateSkill_Skills_SkillsId",
                table: "CandidateSkill");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_CandidateSkill_SkillsId",
                table: "CandidateSkill");

            migrationBuilder.DropColumn(
                name: "SkillsId",
                table: "CandidateSkill");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CandidateSkill",
                type: "TEXT",
                nullable: true);
        }
    }
}
