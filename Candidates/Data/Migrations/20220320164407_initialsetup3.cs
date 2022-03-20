using Microsoft.EntityFrameworkCore.Migrations;

namespace Candidates.Data.Migrations
{
    public partial class initialsetup3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_skill",
                table: "Candidate");

            migrationBuilder.CreateTable(
                name: "CandidateSkills",
                columns: table => new
                {
                    Ids = table.Column<int>(nullable: false),
                    Idc = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateSkills", x => new { x.Idc, x.Ids });
                    table.ForeignKey(
                        name: "FK_CandidateSkills_Candidate_Idc",
                        column: x => x.Idc,
                        principalTable: "Candidate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateSkills_Skill_Ids",
                        column: x => x.Ids,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateSkills_Ids",
                table: "CandidateSkills",
                column: "Ids");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateSkills");

            migrationBuilder.AddColumn<int>(
                name: "Id_skill",
                table: "Candidate",
                nullable: false,
                defaultValue: 0);
        }
    }
}
