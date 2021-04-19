using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class NewFieldTeachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Teachers",
                newName: "PatronymicName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Teachers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Teachers",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OccupationFormMaxVariableTopicHours_OccupationFormId",
                table: "OccupationFormMaxVariableTopicHours",
                column: "OccupationFormId");

            migrationBuilder.AddForeignKey(
                name: "FK_OccupationFormMaxVariableTopicHours_OccupationForms_Occupat~",
                table: "OccupationFormMaxVariableTopicHours",
                column: "OccupationFormId",
                principalTable: "OccupationForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OccupationFormMaxVariableTopicHours_OccupationForms_Occupat~",
                table: "OccupationFormMaxVariableTopicHours");

            migrationBuilder.DropIndex(
                name: "IX_OccupationFormMaxVariableTopicHours_OccupationFormId",
                table: "OccupationFormMaxVariableTopicHours");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Teachers");

            migrationBuilder.RenameColumn(
                name: "PatronymicName",
                table: "Teachers",
                newName: "Name");
        }
    }
}
