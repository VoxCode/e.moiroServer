using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace e.moiroServer.Migrations
{
    public partial class removeSectionNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurriculumSections_SectionNumbers_SectionNumberId",
                table: "CurriculumSections");

            migrationBuilder.DropTable(
                name: "SectionNumbers");

            migrationBuilder.DropIndex(
                name: "IX_CurriculumSections_SectionNumberId",
                table: "CurriculumSections");

            migrationBuilder.DropColumn(
                name: "SectionNumberId",
                table: "CurriculumSections");

            migrationBuilder.AddColumn<int>(
                name: "SectionNumber",
                table: "TrainingProgramCurriculumSections",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SectionNumber",
                table: "TrainingProgramCurriculumSections");

            migrationBuilder.AddColumn<int>(
                name: "SectionNumberId",
                table: "CurriculumSections",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SectionNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionNumbers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumSections_SectionNumberId",
                table: "CurriculumSections",
                column: "SectionNumberId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurriculumSections_SectionNumbers_SectionNumberId",
                table: "CurriculumSections",
                column: "SectionNumberId",
                principalTable: "SectionNumbers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
