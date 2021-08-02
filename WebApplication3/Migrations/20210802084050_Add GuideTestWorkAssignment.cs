using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace e.moiroServer.Migrations
{
    public partial class AddGuideTestWorkAssignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleBlockClassTimes_ScheduleBlocks_ScheduleBlockId",
                table: "ScheduleBlockClassTimes");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "ScheduleBlockClassTimes");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCreation",
                table: "TrainingPrograms",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "ScheduleBlockId",
                table: "ScheduleBlockClassTimes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "GuidedTestWorkAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false),
                    CurriculumTopicTrainingProgramId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuidedTestWorkAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuidedTestWorkAssignments_CurriculumTopicTrainingPrograms_C~",
                        column: x => x.CurriculumTopicTrainingProgramId,
                        principalTable: "CurriculumTopicTrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GuidedTestWorkAssignments_CurriculumTopicTrainingProgramId",
                table: "GuidedTestWorkAssignments",
                column: "CurriculumTopicTrainingProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleBlockClassTimes_ScheduleBlocks_ScheduleBlockId",
                table: "ScheduleBlockClassTimes",
                column: "ScheduleBlockId",
                principalTable: "ScheduleBlocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleBlockClassTimes_ScheduleBlocks_ScheduleBlockId",
                table: "ScheduleBlockClassTimes");

            migrationBuilder.DropTable(
                name: "GuidedTestWorkAssignments");

            migrationBuilder.DropColumn(
                name: "DateOfCreation",
                table: "TrainingPrograms");

            migrationBuilder.AlterColumn<int>(
                name: "ScheduleBlockId",
                table: "ScheduleBlockClassTimes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "ScheduleBlockClassTimes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleBlockClassTimes_ScheduleBlocks_ScheduleBlockId",
                table: "ScheduleBlockClassTimes",
                column: "ScheduleBlockId",
                principalTable: "ScheduleBlocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
