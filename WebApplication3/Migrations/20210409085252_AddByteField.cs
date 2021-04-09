using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class AddByteField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<byte[]>(
                name: "IntroductionData",
                table: "TrainingPrograms",
                type: "bytea",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IntroductionData",
                table: "TrainingPrograms");

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
    }
}
