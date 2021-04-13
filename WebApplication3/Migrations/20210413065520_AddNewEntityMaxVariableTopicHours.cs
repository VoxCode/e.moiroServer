using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace e.moiroServer.Migrations
{
    public partial class AddNewEntityMaxVariableTopicHours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxVariableTopicHours",
                table: "TrainingProgramCurriculumSections");

            migrationBuilder.CreateTable(
                name: "OccupationFormMaxVariableTopicHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaxVariableTopicHours = table.Column<int>(type: "integer", nullable: false),
                    OccupationFormId = table.Column<int>(type: "integer", nullable: false),
                    TrainingProgramCurriculumSectionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationFormMaxVariableTopicHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OccupationFormMaxVariableTopicHours_TrainingProgramCurricul~",
                        column: x => x.TrainingProgramCurriculumSectionId,
                        principalTable: "TrainingProgramCurriculumSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OccupationFormMaxVariableTopicHours_TrainingProgramCurricul~",
                table: "OccupationFormMaxVariableTopicHours",
                column: "TrainingProgramCurriculumSectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OccupationFormMaxVariableTopicHours");

            migrationBuilder.AddColumn<int>(
                name: "MaxVariableTopicHours",
                table: "TrainingProgramCurriculumSections",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
