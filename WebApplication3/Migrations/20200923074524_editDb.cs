using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace e.moiroServer.Migrations
{
    public partial class editDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CertificationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificationTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPrograms_CertificationTypeId",
                table: "TrainingPrograms",
                column: "CertificationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalExaminations_CertificationTypeId",
                table: "FinalExaminations",
                column: "CertificationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FinalExaminations_CertificationTypes_CertificationTypeId",
                table: "FinalExaminations",
                column: "CertificationTypeId",
                principalTable: "CertificationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPrograms_CertificationTypes_CertificationTypeId",
                table: "TrainingPrograms",
                column: "CertificationTypeId",
                principalTable: "CertificationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FinalExaminations_CertificationTypes_CertificationTypeId",
                table: "FinalExaminations");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPrograms_CertificationTypes_CertificationTypeId",
                table: "TrainingPrograms");

            migrationBuilder.DropTable(
                name: "CertificationTypes");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPrograms_CertificationTypeId",
                table: "TrainingPrograms");

            migrationBuilder.DropIndex(
                name: "IX_FinalExaminations_CertificationTypeId",
                table: "FinalExaminations");
        }
    }
}
