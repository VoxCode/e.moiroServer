using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class AddAuthorIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "AuthorIndex",
                table: "TestWorks",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorIndex",
                table: "Regulations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorIndex",
                table: "MainLiteratures",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorIndex",
                table: "FinalExaminations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorIndex",
                table: "CurriculumTopics",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorIndex",
                table: "CurriculumSections",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorIndex",
                table: "AdditionalLiteratures",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7bc8f5a3-062b-40a7-84f6-c87695fb744c", "f80041c2-f667-46e9-a66e-2c2528cdda2f", "Administrator", "ADMINISTRATOR" },
                    { "e098202f-f5fd-489c-9e87-f280f3f119b9", "6cdb7b2c-a84f-4bfd-b36d-ea8929f7ba9a", "Viewer", "VIEWER" },
                    { "3b015bbb-b60e-4e7f-9f52-e1fce897f843", "395ca6d6-f2c2-4b94-9adc-80bf0d2280e6", "Dean", "DEAN" },
                    { "7d28290f-ef5a-4ee9-bd45-10d37bfd83ba", "91727227-8316-4190-855f-669652905776", "Creator", "CREATOR" },
                    { "eb095cf6-9ff0-46e2-bff3-6372cad335c8", "2f47fd96-de06-484b-a686-fc700d903ea5", "Editor", "EDITOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b015bbb-b60e-4e7f-9f52-e1fce897f843");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bc8f5a3-062b-40a7-84f6-c87695fb744c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d28290f-ef5a-4ee9-bd45-10d37bfd83ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e098202f-f5fd-489c-9e87-f280f3f119b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb095cf6-9ff0-46e2-bff3-6372cad335c8");

            migrationBuilder.DropColumn(
                name: "AuthorIndex",
                table: "TestWorks");

            migrationBuilder.DropColumn(
                name: "AuthorIndex",
                table: "Regulations");

            migrationBuilder.DropColumn(
                name: "AuthorIndex",
                table: "MainLiteratures");

            migrationBuilder.DropColumn(
                name: "AuthorIndex",
                table: "FinalExaminations");

            migrationBuilder.DropColumn(
                name: "AuthorIndex",
                table: "CurriculumTopics");

            migrationBuilder.DropColumn(
                name: "AuthorIndex",
                table: "CurriculumSections");

            migrationBuilder.DropColumn(
                name: "AuthorIndex",
                table: "AdditionalLiteratures");

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
        }
    }
}
