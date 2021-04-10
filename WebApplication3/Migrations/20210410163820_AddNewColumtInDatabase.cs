using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class AddNewColumtInDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "527d76ef-2369-4dd9-8329-bef0360830ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70b7f139-a58f-45cb-9605-c9d7cd57e128");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6d6f0f6-7a17-437c-b4fa-b87d44e4913e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e45e5e55-f980-49a1-8c02-5b8f99f1815c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e58b8633-e858-4f87-9efa-9df370e5a1c7");

            migrationBuilder.AddColumn<int>(
                name: "MaxVaiableTopicHours",
                table: "TrainingProgramCurriculumSections",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentHeadName",
                table: "Departments",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a1cca11c-c211-4076-bd45-77c1a2d2456b", "6924ea5e-f1e0-4d6e-8390-37cc10cd98d5", "Administrator", "ADMINISTRATOR" },
                    { "03c28a50-ed11-4cef-893c-dfe0d5ad4ff5", "6d1597f6-3cb4-41a9-a478-f8a483299e93", "Viewer", "VIEWER" },
                    { "dba9962f-07c1-4375-9f8c-90eadebd7578", "b2e78926-f6c5-415a-8739-9d22f0738b43", "Dean", "DEAN" },
                    { "7ac4b28d-8a5e-48fb-a4ae-380a099ccd8f", "b82d3ac1-8640-4861-9b14-0c23d560154f", "Creator", "CREATOR" },
                    { "fba73d5d-1a26-413d-888c-672d0659ca38", "6521e5ab-680a-4984-bea3-32f9c5b701ff", "Editor", "EDITOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03c28a50-ed11-4cef-893c-dfe0d5ad4ff5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ac4b28d-8a5e-48fb-a4ae-380a099ccd8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1cca11c-c211-4076-bd45-77c1a2d2456b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dba9962f-07c1-4375-9f8c-90eadebd7578");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fba73d5d-1a26-413d-888c-672d0659ca38");

            migrationBuilder.DropColumn(
                name: "MaxVaiableTopicHours",
                table: "TrainingProgramCurriculumSections");

            migrationBuilder.DropColumn(
                name: "DepartmentHeadName",
                table: "Departments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70b7f139-a58f-45cb-9605-c9d7cd57e128", "fd5e1bb9-1baa-4c61-9c41-4abcab51a6bc", "Administrator", "ADMINISTRATOR" },
                    { "527d76ef-2369-4dd9-8329-bef0360830ed", "a543440e-e149-4527-ae6c-f0e8916790f8", "Viewer", "VIEWER" },
                    { "e58b8633-e858-4f87-9efa-9df370e5a1c7", "39f7c581-addb-4c3b-aa00-58923d94817e", "Dean", "DEAN" },
                    { "c6d6f0f6-7a17-437c-b4fa-b87d44e4913e", "71893299-dc33-4de7-a50d-c59d793900a9", "Creator", "CREATOR" },
                    { "e45e5e55-f980-49a1-8c02-5b8f99f1815c", "0213eb55-5fda-4964-ba9c-85a9d0fd72f3", "Editor", "EDITOR" }
                });
        }
    }
}
