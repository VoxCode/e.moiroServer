using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class AccessDateFieldsAndFEtoDepConnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AccessDate",
                table: "Regulations",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AccessDate",
                table: "MainLiteratures",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AccessDate",
                table: "AdditionalLiteratures",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "DepartmentFinalExamination",
                columns: table => new
                {
                    DepartmentsId = table.Column<int>(type: "integer", nullable: false),
                    FinalExaminationsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentFinalExamination", x => new { x.DepartmentsId, x.FinalExaminationsId });
                    table.ForeignKey(
                        name: "FK_DepartmentFinalExamination_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentFinalExamination_FinalExaminations_FinalExaminati~",
                        column: x => x.FinalExaminationsId,
                        principalTable: "FinalExaminations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentFinalExamination_FinalExaminationsId",
                table: "DepartmentFinalExamination",
                column: "FinalExaminationsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentFinalExamination");

            migrationBuilder.DropColumn(
                name: "AccessDate",
                table: "Regulations");

            migrationBuilder.DropColumn(
                name: "AccessDate",
                table: "MainLiteratures");

            migrationBuilder.DropColumn(
                name: "AccessDate",
                table: "AdditionalLiteratures");
        }
    }
}
