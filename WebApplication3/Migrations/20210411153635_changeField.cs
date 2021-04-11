using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class changeField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "CertificationTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CertificationTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CertificationTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CertificationTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CertificationTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FormOfEducations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FormOfEducations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OccupationForms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OccupationForms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OccupationForms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OccupationForms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OccupationForms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OccupationForms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OccupationForms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OccupationForms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.RenameColumn(
                name: "MaxVaiableTopicHours",
                table: "TrainingProgramCurriculumSections",
                newName: "MaxVariableTopicHours");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaxVariableTopicHours",
                table: "TrainingProgramCurriculumSections",
                newName: "MaxVaiableTopicHours");

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

            migrationBuilder.InsertData(
                table: "CertificationTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Выпускная работа" },
                    { 2, "Зачет" },
                    { 3, "Экзамен" },
                    { 4, "Собеседование в форме зачета" },
                    { 5, "Собеседование в форме деловой игры" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentHeadName", "Name" },
                values: new object[,]
                {
                    { 3, null, "Кафедра частных методик общего среднего образования" },
                    { 2, null, "Кафедра психологии и управления" },
                    { 1, null, "Кафедра дошкольного и начального образования" }
                });

            migrationBuilder.InsertData(
                table: "FormOfEducations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Очная" },
                    { 2, "Заочная" }
                });

            migrationBuilder.InsertData(
                table: "OccupationForms",
                columns: new[] { "Id", "FullName", "PluralName" },
                values: new object[,]
                {
                    { 1, "Лекция", "Лекции" },
                    { 2, "Практическое занятие", "Практические занятия" },
                    { 3, "Семинарское занятие", "Семинарские занятия" },
                    { 4, "Круглый стол, тематическая дискуссия", "Круглые столы, тематические дискуссии" },
                    { 5, "Лабораторное занятие", "Лабораторные занятия" },
                    { 6, "Деловая игра", "Деловые игры" },
                    { 7, "Тренинг", "Тренинги" },
                    { 8, "Конференция", "Конференции" }
                });
        }
    }
}
