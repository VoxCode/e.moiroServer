using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class addIntroduction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "429bba87-b3f7-486a-ac2d-8357bed0988c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a05db803-97a0-4a25-8f6a-c81db7f5a08e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "baace5a4-45b3-47ec-96ed-7afc2ae29c63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db9dfc3e-d14b-429a-b5a8-1ebfdcb32621");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebc30ccd-8067-49b6-b03a-c2d1fd61d1f9");

            migrationBuilder.AddColumn<string>(
                name: "Introduction",
                table: "TrainingPrograms",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a4a2e78-ce1d-497b-a8e7-c0c5c36e9f10", "ca74fc8b-395e-4dcc-a324-933974c1debc", "Administrator", "ADMINISTRATOR" },
                    { "3a788a25-2a65-42d3-a7c4-a2dc4e936e92", "6bdd8a08-960d-4037-b2d7-c29acf4baa89", "Viewer", "VIEWER" },
                    { "7aec44bf-46ef-41f3-ad5a-34bc34ab44ce", "8e891df5-27da-45c9-bb67-3c65cc0a13e3", "Dean", "DEAN" },
                    { "f25ac0be-d407-41d9-9253-318fecf31429", "38fa34c9-e225-4852-b81b-cf05f0a003e7", "Creator", "CREATOR" },
                    { "5faec6c0-e9b4-4fb5-9ab1-3fc30c93500d", "805fcc8b-ab85-4455-8591-6be9a98fa501", "Editor", "EDITOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a4a2e78-ce1d-497b-a8e7-c0c5c36e9f10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a788a25-2a65-42d3-a7c4-a2dc4e936e92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5faec6c0-e9b4-4fb5-9ab1-3fc30c93500d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7aec44bf-46ef-41f3-ad5a-34bc34ab44ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f25ac0be-d407-41d9-9253-318fecf31429");

            migrationBuilder.DropColumn(
                name: "Introduction",
                table: "TrainingPrograms");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a05db803-97a0-4a25-8f6a-c81db7f5a08e", "b4742aad-56b4-45f8-935e-3fd5a44d4217", "Administrator", "ADMINISTRATOR" },
                    { "db9dfc3e-d14b-429a-b5a8-1ebfdcb32621", "de808f56-2719-4c52-9761-abec55a29e72", "Viewer", "VIEWER" },
                    { "ebc30ccd-8067-49b6-b03a-c2d1fd61d1f9", "0760f1c7-92cc-4047-bf7c-2f0f29b40835", "Dean", "DEAN" },
                    { "baace5a4-45b3-47ec-96ed-7afc2ae29c63", "2c3b2bfd-8dac-4d69-abd0-70c65216a2aa", "Creator", "CREATOR" },
                    { "429bba87-b3f7-486a-ac2d-8357bed0988c", "d9b40712-be53-44da-a361-a0594b7d3c34", "Editor", "EDITOR" }
                });
        }
    }
}
