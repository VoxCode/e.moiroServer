using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace e.moiroServer.Migrations
{
    public partial class CurriculumTopicType_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurriculumTopicTypeId",
                table: "CurriculumTopicTrainingPrograms",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurriculumTopicTypeId",
                table: "CurriculumTopics",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CurriculumTopicType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicTrainingPrograms_CurriculumTopicTypeId",
                table: "CurriculumTopicTrainingPrograms",
                column: "CurriculumTopicTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopics_CurriculumTopicTypeId",
                table: "CurriculumTopics",
                column: "CurriculumTopicTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurriculumTopics_CurriculumTopicType_CurriculumTopicTypeId",
                table: "CurriculumTopics",
                column: "CurriculumTopicTypeId",
                principalTable: "CurriculumTopicType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CurriculumTopicTrainingPrograms_CurriculumTopicType_Curricu~",
                table: "CurriculumTopicTrainingPrograms",
                column: "CurriculumTopicTypeId",
                principalTable: "CurriculumTopicType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurriculumTopics_CurriculumTopicType_CurriculumTopicTypeId",
                table: "CurriculumTopics");

            migrationBuilder.DropForeignKey(
                name: "FK_CurriculumTopicTrainingPrograms_CurriculumTopicType_Curricu~",
                table: "CurriculumTopicTrainingPrograms");

            migrationBuilder.DropTable(
                name: "CurriculumTopicType");

            migrationBuilder.DropIndex(
                name: "IX_CurriculumTopicTrainingPrograms_CurriculumTopicTypeId",
                table: "CurriculumTopicTrainingPrograms");

            migrationBuilder.DropIndex(
                name: "IX_CurriculumTopics_CurriculumTopicTypeId",
                table: "CurriculumTopics");

            migrationBuilder.DropColumn(
                name: "CurriculumTopicTypeId",
                table: "CurriculumTopicTrainingPrograms");

            migrationBuilder.DropColumn(
                name: "CurriculumTopicTypeId",
                table: "CurriculumTopics");
        }
    }
}
