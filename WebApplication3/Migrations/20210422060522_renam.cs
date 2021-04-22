using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class renam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurriculumTopicTrainingPrograms_TrainingProgramCurriculumSe~",
                table: "CurriculumTopicTrainingPrograms");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29900f1a-26d1-43a7-94e1-cda0faa6e230");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "335963f9-8d59-460c-91c3-6b58ce9be373");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e25138c-92a1-4027-82c8-c8960304a51a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70a6dfc7-26f6-4065-9443-22301f82dd42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4a3dbcc-204e-4a10-99c5-d04709beab69");

            migrationBuilder.DropColumn(
                name: "TrainingProgrmaCurriculumSectionId",
                table: "CurriculumTopicTrainingPrograms");

            migrationBuilder.AlterColumn<int>(
                name: "TrainingProgramCurriculumSectionId",
                table: "CurriculumTopicTrainingPrograms",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "156438c5-46bf-48e6-966a-0645e38d8bcd", "464947a1-3842-4931-8909-aac7a998f9b1", "Administrator", "ADMINISTRATOR" },
                    { "ef31f488-e986-4d8d-b7ab-ee03e11768f7", "ec26fc30-f3ad-4935-bf45-b087bfd1bbd6", "Viewer", "VIEWER" },
                    { "a8af41f5-3f9b-4b94-97b8-7f7a30c7551d", "59a4d858-89a9-4796-b68d-f53f4034fc05", "Dean", "DEAN" },
                    { "f6a17e3a-bb41-48e0-8b16-37db85cfb98c", "2a7f7de5-177c-40c2-abd9-d5b55975ef6e", "Creator", "CREATOR" },
                    { "23e016c3-c576-4528-b4a4-8ba24a468808", "1872871c-eca7-4f7a-af51-1a32f6e4f66b", "Editor", "EDITOR" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CurriculumTopicTrainingPrograms_TrainingProgramCurriculumSe~",
                table: "CurriculumTopicTrainingPrograms",
                column: "TrainingProgramCurriculumSectionId",
                principalTable: "TrainingProgramCurriculumSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurriculumTopicTrainingPrograms_TrainingProgramCurriculumSe~",
                table: "CurriculumTopicTrainingPrograms");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "156438c5-46bf-48e6-966a-0645e38d8bcd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23e016c3-c576-4528-b4a4-8ba24a468808");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8af41f5-3f9b-4b94-97b8-7f7a30c7551d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef31f488-e986-4d8d-b7ab-ee03e11768f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6a17e3a-bb41-48e0-8b16-37db85cfb98c");

            migrationBuilder.AlterColumn<int>(
                name: "TrainingProgramCurriculumSectionId",
                table: "CurriculumTopicTrainingPrograms",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "TrainingProgrmaCurriculumSectionId",
                table: "CurriculumTopicTrainingPrograms",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70a6dfc7-26f6-4065-9443-22301f82dd42", "6de10ea8-1b57-454d-b048-c6f7fc382101", "Administrator", "ADMINISTRATOR" },
                    { "29900f1a-26d1-43a7-94e1-cda0faa6e230", "59818fb1-519f-429e-b544-d3e9ceb52195", "Viewer", "VIEWER" },
                    { "c4a3dbcc-204e-4a10-99c5-d04709beab69", "1b023534-886b-464c-8620-677b37571591", "Dean", "DEAN" },
                    { "6e25138c-92a1-4027-82c8-c8960304a51a", "a57f5418-aaab-4256-8e99-653ce5e6fc05", "Creator", "CREATOR" },
                    { "335963f9-8d59-460c-91c3-6b58ce9be373", "1c8bda62-3a51-4ff5-956b-1a2e4b4b289a", "Editor", "EDITOR" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CurriculumTopicTrainingPrograms_TrainingProgramCurriculumSe~",
                table: "CurriculumTopicTrainingPrograms",
                column: "TrainingProgramCurriculumSectionId",
                principalTable: "TrainingProgramCurriculumSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
