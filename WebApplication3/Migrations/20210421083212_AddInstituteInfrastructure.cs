using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace e.moiroServer.Migrations
{
    public partial class AddInstituteInfrastructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_ScheduleBlockClassRoom_ScheduleBlock_ScheduleBlockId",
            //    table: "ScheduleBlockClassRoom");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ScheduleBlockClassTime_ScheduleBlock_ScheduleBlockId",
            //    table: "ScheduleBlockClassTime");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ScheduleBlockCurriculumTopicTrainingProgram_CurriculumTopic~",
            //    table: "ScheduleBlockCurriculumTopicTrainingProgram");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ScheduleBlockCurriculumTopicTrainingProgram_ScheduleBlock_S~",
            //    table: "ScheduleBlockCurriculumTopicTrainingProgram");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ScheduleBlockTeacher_ScheduleBlock_ScheduleBlockId",
            //    table: "ScheduleBlockTeacher");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ScheduleBlockTeacher_Teachers_TeacherId",
            //    table: "ScheduleBlockTeacher");

            //migrationBuilder.DropTable(
            //    name: "ScheduleDateSheduleBlock");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_ScheduleBlockTeacher",
            //    table: "ScheduleBlockTeacher");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_ScheduleBlockCurriculumTopicTrainingProgram",
            //    table: "ScheduleBlockCurriculumTopicTrainingProgram");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_ScheduleBlockClassTime",
            //    table: "ScheduleBlockClassTime");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_ScheduleBlockClassRoom",
            //    table: "ScheduleBlockClassRoom");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_ScheduleBlock",
            //    table: "ScheduleBlock");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "1b26e9b7-5671-442b-9d1c-e3fd1685663f");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "2d2e13f2-527e-4c77-85ba-49712c40079c");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "7a040519-ce29-400d-9b43-8091226076f9");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "990f2e97-b30e-4d23-8bcd-a222bd66a3ac");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "a98f7457-a95f-4489-b3e0-56039a47e046");

            //migrationBuilder.RenameTable(
            //    name: "ScheduleBlockTeacher",
            //    newName: "ScheduleBlockTeachers");

            //migrationBuilder.RenameTable(
            //    name: "ScheduleBlockCurriculumTopicTrainingProgram",
            //    newName: "ScheduleBlockCurriculumTopicTrainingPrograms");

            //migrationBuilder.RenameTable(
            //    name: "ScheduleBlockClassTime",
            //    newName: "ScheduleBlockClassTimes");

            //migrationBuilder.RenameTable(
            //    name: "ScheduleBlockClassRoom",
            //    newName: "ScheduleBlockClassRooms");

            //migrationBuilder.RenameTable(
            //    name: "ScheduleBlock",
            //    newName: "ScheduleBlocks");

            //migrationBuilder.RenameIndex(
            //    name: "IX_ScheduleBlockTeacher_TeacherId",
            //    table: "ScheduleBlockTeachers",
            //    newName: "IX_ScheduleBlockTeachers_TeacherId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_ScheduleBlockTeacher_ScheduleBlockId",
            //    table: "ScheduleBlockTeachers",
            //    newName: "IX_ScheduleBlockTeachers_ScheduleBlockId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_ScheduleBlockCurriculumTopicTrainingProgram_ScheduleBlockId",
            //    table: "ScheduleBlockCurriculumTopicTrainingPrograms",
            //    newName: "IX_ScheduleBlockCurriculumTopicTrainingPrograms_ScheduleBlockId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_ScheduleBlockCurriculumTopicTrainingProgram_CurriculumTopic~",
            //    table: "ScheduleBlockCurriculumTopicTrainingPrograms",
            //    newName: "IX_ScheduleBlockCurriculumTopicTrainingPrograms_CurriculumTopi~");

            //migrationBuilder.RenameIndex(
            //    name: "IX_ScheduleBlockClassTime_ScheduleBlockId",
            //    table: "ScheduleBlockClassTimes",
            //    newName: "IX_ScheduleBlockClassTimes_ScheduleBlockId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_ScheduleBlockClassRoom_ScheduleBlockId",
            //    table: "ScheduleBlockClassRooms",
            //    newName: "IX_ScheduleBlockClassRooms_ScheduleBlockId");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_ScheduleBlockTeachers",
            //    table: "ScheduleBlockTeachers",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_ScheduleBlockCurriculumTopicTrainingPrograms",
            //    table: "ScheduleBlockCurriculumTopicTrainingPrograms",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_ScheduleBlockClassTimes",
            //    table: "ScheduleBlockClassTimes",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_ScheduleBlockClassRooms",
            //    table: "ScheduleBlockClassRooms",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_ScheduleBlocks",
            //    table: "ScheduleBlocks",
            //    column: "Id");

            //migrationBuilder.CreateTable(
            //    name: "ClassRooms",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        Name = table.Column<string>(type: "text", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ClassRooms", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ClassTimes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        ClassTimeStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
            //        ClassTimeEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ClassTimes", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "InstituteStructures",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        Rector = table.Column<string>(type: "text", nullable: true),
            //        Dean = table.Column<string>(type: "text", nullable: true),
            //        EducationalDepartmentChief = table.Column<string>(type: "text", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_InstituteStructures", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ScheduleDates",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
            //        GroupId = table.Column<int>(type: "integer", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ScheduleDates", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_ScheduleDates_Groups_GroupId",
            //            column: x => x.GroupId,
            //            principalTable: "Groups",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ScheduleDateScheduleBlocks",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        ScheduleDateId = table.Column<int>(type: "integer", nullable: false),
            //        ScheduleBlockId = table.Column<int>(type: "integer", nullable: false),
            //        SerialNumber = table.Column<int>(type: "integer", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ScheduleDateScheduleBlocks", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_ScheduleDateScheduleBlocks_ScheduleBlocks_ScheduleBlockId",
            //            column: x => x.ScheduleBlockId,
            //            principalTable: "ScheduleBlocks",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_ScheduleDateScheduleBlocks_ScheduleDates_ScheduleDateId",
            //            column: x => x.ScheduleDateId,
            //            principalTable: "ScheduleDates",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "70a6dfc7-26f6-4065-9443-22301f82dd42", "6de10ea8-1b57-454d-b048-c6f7fc382101", "Administrator", "ADMINISTRATOR" },
            //        { "29900f1a-26d1-43a7-94e1-cda0faa6e230", "59818fb1-519f-429e-b544-d3e9ceb52195", "Viewer", "VIEWER" },
            //        { "c4a3dbcc-204e-4a10-99c5-d04709beab69", "1b023534-886b-464c-8620-677b37571591", "Dean", "DEAN" },
            //        { "6e25138c-92a1-4027-82c8-c8960304a51a", "a57f5418-aaab-4256-8e99-653ce5e6fc05", "Creator", "CREATOR" },
            //        { "335963f9-8d59-460c-91c3-6b58ce9be373", "1c8bda62-3a51-4ff5-956b-1a2e4b4b289a", "Editor", "EDITOR" }
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_ScheduleBlockClassTimes_ClassTimeId",
            //    table: "ScheduleBlockClassTimes",
            //    column: "ClassTimeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ScheduleBlockClassRooms_ClassRoomId",
            //    table: "ScheduleBlockClassRooms",
            //    column: "ClassRoomId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ScheduleDates_GroupId",
            //    table: "ScheduleDates",
            //    column: "GroupId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ScheduleDateScheduleBlocks_ScheduleBlockId",
            //    table: "ScheduleDateScheduleBlocks",
            //    column: "ScheduleBlockId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ScheduleDateScheduleBlocks_ScheduleDateId",
            //    table: "ScheduleDateScheduleBlocks",
            //    column: "ScheduleDateId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ScheduleBlockClassRooms_ClassRooms_ClassRoomId",
            //    table: "ScheduleBlockClassRooms",
            //    column: "ClassRoomId",
            //    principalTable: "ClassRooms",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ScheduleBlockClassRooms_ScheduleBlocks_ScheduleBlockId",
            //    table: "ScheduleBlockClassRooms",
            //    column: "ScheduleBlockId",
            //    principalTable: "ScheduleBlocks",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ScheduleBlockClassTimes_ClassTimes_ClassTimeId",
            //    table: "ScheduleBlockClassTimes",
            //    column: "ClassTimeId",
            //    principalTable: "ClassTimes",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ScheduleBlockClassTimes_ScheduleBlocks_ScheduleBlockId",
            //    table: "ScheduleBlockClassTimes",
            //    column: "ScheduleBlockId",
            //    principalTable: "ScheduleBlocks",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ScheduleBlockCurriculumTopicTrainingPrograms_CurriculumTopi~",
            //    table: "ScheduleBlockCurriculumTopicTrainingPrograms",
            //    column: "CurriculumTopicTrainingProgramId",
            //    principalTable: "CurriculumTopicTrainingPrograms",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ScheduleBlockCurriculumTopicTrainingPrograms_ScheduleBlocks~",
            //    table: "ScheduleBlockCurriculumTopicTrainingPrograms",
            //    column: "ScheduleBlockId",
            //    principalTable: "ScheduleBlocks",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ScheduleBlockTeachers_ScheduleBlocks_ScheduleBlockId",
            //    table: "ScheduleBlockTeachers",
            //    column: "ScheduleBlockId",
            //    principalTable: "ScheduleBlocks",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ScheduleBlockTeachers_Teachers_TeacherId",
            //    table: "ScheduleBlockTeachers",
            //    column: "TeacherId",
            //    principalTable: "Teachers",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_ScheduleBlockClassRooms_ClassRooms_ClassRoomId",
            //    table: "ScheduleBlockClassRooms");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ScheduleBlockClassRooms_ScheduleBlocks_ScheduleBlockId",
            //    table: "ScheduleBlockClassRooms");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ScheduleBlockClassTimes_ClassTimes_ClassTimeId",
            //    table: "ScheduleBlockClassTimes");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ScheduleBlockClassTimes_ScheduleBlocks_ScheduleBlockId",
            //    table: "ScheduleBlockClassTimes");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ScheduleBlockCurriculumTopicTrainingPrograms_CurriculumTopi~",
            //    table: "ScheduleBlockCurriculumTopicTrainingPrograms");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ScheduleBlockCurriculumTopicTrainingPrograms_ScheduleBlocks~",
            //    table: "ScheduleBlockCurriculumTopicTrainingPrograms");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ScheduleBlockTeachers_ScheduleBlocks_ScheduleBlockId",
            //    table: "ScheduleBlockTeachers");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ScheduleBlockTeachers_Teachers_TeacherId",
            //    table: "ScheduleBlockTeachers");

            //migrationBuilder.DropTable(
            //    name: "ClassRooms");

            //migrationBuilder.DropTable(
            //    name: "ClassTimes");

            //migrationBuilder.DropTable(
            //    name: "InstituteStructures");

            //migrationBuilder.DropTable(
            //    name: "ScheduleDateScheduleBlocks");

            //migrationBuilder.DropTable(
            //    name: "ScheduleDates");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_ScheduleBlockTeachers",
            //    table: "ScheduleBlockTeachers");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_ScheduleBlocks",
            //    table: "ScheduleBlocks");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_ScheduleBlockCurriculumTopicTrainingPrograms",
            //    table: "ScheduleBlockCurriculumTopicTrainingPrograms");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_ScheduleBlockClassTimes",
            //    table: "ScheduleBlockClassTimes");

            //migrationBuilder.DropIndex(
            //    name: "IX_ScheduleBlockClassTimes_ClassTimeId",
            //    table: "ScheduleBlockClassTimes");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_ScheduleBlockClassRooms",
            //    table: "ScheduleBlockClassRooms");

            //migrationBuilder.DropIndex(
            //    name: "IX_ScheduleBlockClassRooms_ClassRoomId",
            //    table: "ScheduleBlockClassRooms");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "29900f1a-26d1-43a7-94e1-cda0faa6e230");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "335963f9-8d59-460c-91c3-6b58ce9be373");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "6e25138c-92a1-4027-82c8-c8960304a51a");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "70a6dfc7-26f6-4065-9443-22301f82dd42");

            //migrationBuilder.DeleteData(
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "c4a3dbcc-204e-4a10-99c5-d04709beab69");

            //migrationBuilder.RenameTable(
            //    name: "ScheduleBlockTeachers",
            //    newName: "ScheduleBlockTeacher");

            //migrationBuilder.RenameTable(
            //    name: "ScheduleBlocks",
            //    newName: "ScheduleBlock");

            //migrationBuilder.RenameTable(
            //    name: "ScheduleBlockCurriculumTopicTrainingPrograms",
            //    newName: "ScheduleBlockCurriculumTopicTrainingProgram");

            //migrationBuilder.RenameTable(
            //    name: "ScheduleBlockClassTimes",
            //    newName: "ScheduleBlockClassTime");

            //migrationBuilder.RenameTable(
            //    name: "ScheduleBlockClassRooms",
            //    newName: "ScheduleBlockClassRoom");

            //migrationBuilder.RenameIndex(
            //    name: "IX_ScheduleBlockTeachers_TeacherId",
            //    table: "ScheduleBlockTeacher",
            //    newName: "IX_ScheduleBlockTeacher_TeacherId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_ScheduleBlockTeachers_ScheduleBlockId",
            //    table: "ScheduleBlockTeacher",
            //    newName: "IX_ScheduleBlockTeacher_ScheduleBlockId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_ScheduleBlockCurriculumTopicTrainingPrograms_ScheduleBlockId",
            //    table: "ScheduleBlockCurriculumTopicTrainingProgram",
            //    newName: "IX_ScheduleBlockCurriculumTopicTrainingProgram_ScheduleBlockId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_ScheduleBlockCurriculumTopicTrainingPrograms_CurriculumTopi~",
            //    table: "ScheduleBlockCurriculumTopicTrainingProgram",
            //    newName: "IX_ScheduleBlockCurriculumTopicTrainingProgram_CurriculumTopic~");

            //migrationBuilder.RenameIndex(
            //    name: "IX_ScheduleBlockClassTimes_ScheduleBlockId",
            //    table: "ScheduleBlockClassTime",
            //    newName: "IX_ScheduleBlockClassTime_ScheduleBlockId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_ScheduleBlockClassRooms_ScheduleBlockId",
            //    table: "ScheduleBlockClassRoom",
            //    newName: "IX_ScheduleBlockClassRoom_ScheduleBlockId");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_ScheduleBlockTeacher",
            //    table: "ScheduleBlockTeacher",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_ScheduleBlock",
            //    table: "ScheduleBlock",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_ScheduleBlockCurriculumTopicTrainingProgram",
            //    table: "ScheduleBlockCurriculumTopicTrainingProgram",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_ScheduleBlockClassTime",
            //    table: "ScheduleBlockClassTime",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_ScheduleBlockClassRoom",
            //    table: "ScheduleBlockClassRoom",
            //    column: "Id");

            //migrationBuilder.CreateTable(
            //    name: "ScheduleDateSheduleBlock",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        ScheduleBlockId = table.Column<int>(type: "integer", nullable: false),
            //        ScheduleDateId = table.Column<int>(type: "integer", nullable: false),
            //        SerialNumber = table.Column<int>(type: "integer", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ScheduleDateSheduleBlock", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_ScheduleDateSheduleBlock_ScheduleBlock_ScheduleBlockId",
            //            column: x => x.ScheduleBlockId,
            //            principalTable: "ScheduleBlock",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "1b26e9b7-5671-442b-9d1c-e3fd1685663f", "46adbc49-7edb-472e-ba75-a8944ac284a7", "Administrator", "ADMINISTRATOR" },
            //        { "a98f7457-a95f-4489-b3e0-56039a47e046", "9c5b9147-008c-4ab5-be25-4039a054c1aa", "Viewer", "VIEWER" },
            //        { "2d2e13f2-527e-4c77-85ba-49712c40079c", "0bd078f1-b728-430c-a8ac-479ed83412ba", "Dean", "DEAN" },
            //        { "7a040519-ce29-400d-9b43-8091226076f9", "fdddc45e-3d06-4291-a694-6917241386a1", "Creator", "CREATOR" },
            //        { "990f2e97-b30e-4d23-8bcd-a222bd66a3ac", "b5486885-6708-4c2e-9eda-1b1a99e56c25", "Editor", "EDITOR" }
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_ScheduleDateSheduleBlock_ScheduleBlockId",
            //    table: "ScheduleDateSheduleBlock",
            //    column: "ScheduleBlockId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ScheduleBlockClassRoom_ScheduleBlock_ScheduleBlockId",
            //    table: "ScheduleBlockClassRoom",
            //    column: "ScheduleBlockId",
            //    principalTable: "ScheduleBlock",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ScheduleBlockClassTime_ScheduleBlock_ScheduleBlockId",
            //    table: "ScheduleBlockClassTime",
            //    column: "ScheduleBlockId",
            //    principalTable: "ScheduleBlock",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ScheduleBlockCurriculumTopicTrainingProgram_CurriculumTopic~",
            //    table: "ScheduleBlockCurriculumTopicTrainingProgram",
            //    column: "CurriculumTopicTrainingProgramId",
            //    principalTable: "CurriculumTopicTrainingPrograms",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ScheduleBlockCurriculumTopicTrainingProgram_ScheduleBlock_S~",
            //    table: "ScheduleBlockCurriculumTopicTrainingProgram",
            //    column: "ScheduleBlockId",
            //    principalTable: "ScheduleBlock",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ScheduleBlockTeacher_ScheduleBlock_ScheduleBlockId",
            //    table: "ScheduleBlockTeacher",
            //    column: "ScheduleBlockId",
            //    principalTable: "ScheduleBlock",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ScheduleBlockTeacher_Teachers_TeacherId",
            //    table: "ScheduleBlockTeacher",
            //    column: "TeacherId",
            //    principalTable: "Teachers",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
