using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace e.moiroServer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalLiteratures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    AuthorIndex = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalLiteratures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CertificationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClassRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClassTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClassTimeStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ClassTimeEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassTimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TopicTitle = table.Column<string>(type: "text", nullable: true),
                    Annotation = table.Column<string>(type: "text", nullable: true),
                    AuthorIndex = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    DepartmentHeadName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormOfEducations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormOfEducations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstituteStructures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rector = table.Column<string>(type: "text", nullable: true),
                    Dean = table.Column<string>(type: "text", nullable: true),
                    EducationalDepartmentChief = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstituteStructures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainLiteratures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    AuthorIndex = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainLiteratures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OccupationForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    PluralName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationForms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regulations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    AuthorIndex = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regulations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleBlocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SubgroupNumber = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleBlocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    PatronymicName = table.Column<string>(type: "text", nullable: true),
                    Position = table.Column<string>(type: "text", nullable: true),
                    AcademicRank = table.Column<string>(type: "text", nullable: true),
                    IsCathedral = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    AuthorIndex = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinalExaminations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    CertificationTypeId = table.Column<int>(type: "integer", nullable: false),
                    AuthorIndex = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalExaminations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinalExaminations_CertificationTypes_CertificationTypeId",
                        column: x => x.CertificationTypeId,
                        principalTable: "CertificationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalLiteratureCurriculumTopic",
                columns: table => new
                {
                    AdditionalLiteraturesId = table.Column<int>(type: "integer", nullable: false),
                    CurriculumTopicsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalLiteratureCurriculumTopic", x => new { x.AdditionalLiteraturesId, x.CurriculumTopicsId });
                    table.ForeignKey(
                        name: "FK_AdditionalLiteratureCurriculumTopic_AdditionalLiteratures_A~",
                        column: x => x.AdditionalLiteraturesId,
                        principalTable: "AdditionalLiteratures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdditionalLiteratureCurriculumTopic_CurriculumTopics_Curric~",
                        column: x => x.CurriculumTopicsId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicDepartment",
                columns: table => new
                {
                    CurriculumTopicsId = table.Column<int>(type: "integer", nullable: false),
                    DepartmentsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicDepartment", x => new { x.CurriculumTopicsId, x.DepartmentsId });
                    table.ForeignKey(
                        name: "FK_CurriculumTopicDepartment_CurriculumTopics_CurriculumTopics~",
                        column: x => x.CurriculumTopicsId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicDepartment_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicMainLiterature",
                columns: table => new
                {
                    CurriculumTopicsId = table.Column<int>(type: "integer", nullable: false),
                    MainLiteraturesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicMainLiterature", x => new { x.CurriculumTopicsId, x.MainLiteraturesId });
                    table.ForeignKey(
                        name: "FK_CurriculumTopicMainLiterature_CurriculumTopics_CurriculumTo~",
                        column: x => x.CurriculumTopicsId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicMainLiterature_MainLiteratures_MainLiteratur~",
                        column: x => x.MainLiteraturesId,
                        principalTable: "MainLiteratures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicRegulation",
                columns: table => new
                {
                    CurriculumTopicsId = table.Column<int>(type: "integer", nullable: false),
                    RegulationsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicRegulation", x => new { x.CurriculumTopicsId, x.RegulationsId });
                    table.ForeignKey(
                        name: "FK_CurriculumTopicRegulation_CurriculumTopics_CurriculumTopics~",
                        column: x => x.CurriculumTopicsId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicRegulation_Regulations_RegulationsId",
                        column: x => x.RegulationsId,
                        principalTable: "Regulations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleBlockClassRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScheduleBlockId = table.Column<int>(type: "integer", nullable: false),
                    ClassRoomId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleBlockClassRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleBlockClassRooms_ClassRooms_ClassRoomId",
                        column: x => x.ClassRoomId,
                        principalTable: "ClassRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleBlockClassRooms_ScheduleBlocks_ScheduleBlockId",
                        column: x => x.ScheduleBlockId,
                        principalTable: "ScheduleBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleBlockClassTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScheduleId = table.Column<int>(type: "integer", nullable: false),
                    ClassTimeId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false),
                    ScheduleBlockId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleBlockClassTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleBlockClassTimes_ClassTimes_ClassTimeId",
                        column: x => x.ClassTimeId,
                        principalTable: "ClassTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleBlockClassTimes_ScheduleBlocks_ScheduleBlockId",
                        column: x => x.ScheduleBlockId,
                        principalTable: "ScheduleBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicStudentCategory",
                columns: table => new
                {
                    CurriculumTopicsId = table.Column<int>(type: "integer", nullable: false),
                    StudentCategoriesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicStudentCategory", x => new { x.CurriculumTopicsId, x.StudentCategoriesId });
                    table.ForeignKey(
                        name: "FK_CurriculumTopicStudentCategory_CurriculumTopics_CurriculumT~",
                        column: x => x.CurriculumTopicsId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicStudentCategory_StudentCategories_StudentCat~",
                        column: x => x.StudentCategoriesId,
                        principalTable: "StudentCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NumberOfHours = table.Column<int>(type: "integer", nullable: false),
                    IsDistanceLearning = table.Column<bool>(type: "boolean", nullable: false),
                    IsControlWork = table.Column<bool>(type: "boolean", nullable: false),
                    IsTestWork = table.Column<bool>(type: "boolean", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: false),
                    StudentCategoryId = table.Column<int>(type: "integer", nullable: false),
                    CertificationTypeId = table.Column<int>(type: "integer", nullable: false),
                    FormOfEducationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingPrograms_CertificationTypes_CertificationTypeId",
                        column: x => x.CertificationTypeId,
                        principalTable: "CertificationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingPrograms_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingPrograms_FormOfEducations_FormOfEducationId",
                        column: x => x.FormOfEducationId,
                        principalTable: "FormOfEducations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingPrograms_StudentCategories_StudentCategoryId",
                        column: x => x.StudentCategoryId,
                        principalTable: "StudentCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    TeacherId = table.Column<int>(type: "integer", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentTeacher",
                columns: table => new
                {
                    DepartmentsId = table.Column<int>(type: "integer", nullable: false),
                    TeachersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentTeacher", x => new { x.DepartmentsId, x.TeachersId });
                    table.ForeignKey(
                        name: "FK_DepartmentTeacher_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentTeacher_Teachers_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleBlockTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TeacherId = table.Column<int>(type: "integer", nullable: false),
                    ScheduleBlockId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleBlockTeachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleBlockTeachers_ScheduleBlocks_ScheduleBlockId",
                        column: x => x.ScheduleBlockId,
                        principalTable: "ScheduleBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleBlockTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicTestWork",
                columns: table => new
                {
                    CurriculumTopicsId = table.Column<int>(type: "integer", nullable: false),
                    TestWorksId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicTestWork", x => new { x.CurriculumTopicsId, x.TestWorksId });
                    table.ForeignKey(
                        name: "FK_CurriculumTopicTestWork_CurriculumTopics_CurriculumTopicsId",
                        column: x => x.CurriculumTopicsId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicTestWork_TestWorks_TestWorksId",
                        column: x => x.TestWorksId,
                        principalTable: "TestWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicFinalExamination",
                columns: table => new
                {
                    CurriculumTopicsId = table.Column<int>(type: "integer", nullable: false),
                    FinalExaminationsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicFinalExamination", x => new { x.CurriculumTopicsId, x.FinalExaminationsId });
                    table.ForeignKey(
                        name: "FK_CurriculumTopicFinalExamination_CurriculumTopics_Curriculum~",
                        column: x => x.CurriculumTopicsId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicFinalExamination_FinalExaminations_FinalExam~",
                        column: x => x.FinalExaminationsId,
                        principalTable: "FinalExaminations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicTrainingProgram",
                columns: table => new
                {
                    CurriculumTopicsId = table.Column<int>(type: "integer", nullable: false),
                    TrainingProgramsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicTrainingProgram", x => new { x.CurriculumTopicsId, x.TrainingProgramsId });
                    table.ForeignKey(
                        name: "FK_CurriculumTopicTrainingProgram_CurriculumTopics_CurriculumT~",
                        column: x => x.CurriculumTopicsId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicTrainingProgram_TrainingPrograms_TrainingPro~",
                        column: x => x.TrainingProgramsId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GroupNumber = table.Column<int>(type: "integer", nullable: false),
                    CalendarYear = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ClassStartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ClassEndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_TrainingPrograms_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgramAdditionalLiteratures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramAdditionalLiteratures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramAdditionalLiteratures_TrainingPrograms_Train~",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgramCurriculumSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    SectionNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramCurriculumSections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramCurriculumSections_TrainingPrograms_Training~",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgramFinalExaminations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramFinalExaminations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramFinalExaminations_TrainingPrograms_TrainingP~",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgramIndependentWorkQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ContentDocx = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramIndependentWorkQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramIndependentWorkQuestions_TrainingPrograms_Tr~",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgramIntroductions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: false),
                    IntroductionDocx = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramIntroductions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramIntroductions_TrainingPrograms_TrainingProgr~",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgramMainLiteratures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramMainLiteratures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramMainLiteratures_TrainingPrograms_TrainingPro~",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgramRegulations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramRegulations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramRegulations_TrainingPrograms_TrainingProgram~",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgramTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TeacherId = table.Column<int>(type: "integer", nullable: false),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: false),
                    ExpertId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramTeachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramTeachers_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingProgramTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingProgramTeachers_TrainingPrograms_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProgramTestWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: false),
                    ContentDocx = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramTestWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramTestWorks_TrainingPrograms_TrainingProgramId",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    GroupId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleDates_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicTrainingPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsVariable = table.Column<bool>(type: "boolean", nullable: false),
                    ClassHours = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false),
                    TopicTitle = table.Column<string>(type: "text", nullable: true),
                    Annotation = table.Column<string>(type: "text", nullable: true),
                    TrainingProgramCurriculumSectionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicTrainingPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicTrainingPrograms_TrainingProgramCurriculumSe~",
                        column: x => x.TrainingProgramCurriculumSectionId,
                        principalTable: "TrainingProgramCurriculumSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaxVariableTopicTimes",
                columns: table => new
                {
                    TrainingProgramCurriculumSectionId = table.Column<int>(type: "integer", nullable: false),
                    OccupationFormId = table.Column<int>(type: "integer", nullable: false),
                    MaxVariableTopicHours = table.Column<int>(type: "integer", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaxVariableTopicTimes", x => new { x.TrainingProgramCurriculumSectionId, x.OccupationFormId });
                    table.ForeignKey(
                        name: "FK_MaxVariableTopicTimes_OccupationForms_OccupationFormId",
                        column: x => x.OccupationFormId,
                        principalTable: "OccupationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaxVariableTopicTimes_TrainingProgramCurriculumSections_Tra~",
                        column: x => x.TrainingProgramCurriculumSectionId,
                        principalTable: "TrainingProgramCurriculumSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleDateScheduleBlocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScheduleDateId = table.Column<int>(type: "integer", nullable: false),
                    ScheduleBlockId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleDateScheduleBlocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleDateScheduleBlocks_ScheduleBlocks_ScheduleBlockId",
                        column: x => x.ScheduleBlockId,
                        principalTable: "ScheduleBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleDateScheduleBlocks_ScheduleDates_ScheduleDateId",
                        column: x => x.ScheduleDateId,
                        principalTable: "ScheduleDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OccupationFormClassHours",
                columns: table => new
                {
                    OccupationFormId = table.Column<int>(type: "integer", nullable: false),
                    CurriculumTopicTrainingProgramId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    ClassHours = table.Column<int>(type: "integer", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationFormClassHours", x => new { x.CurriculumTopicTrainingProgramId, x.OccupationFormId });
                    table.ForeignKey(
                        name: "FK_OccupationFormClassHours_CurriculumTopicTrainingPrograms_Cu~",
                        column: x => x.CurriculumTopicTrainingProgramId,
                        principalTable: "CurriculumTopicTrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OccupationFormClassHours_OccupationForms_OccupationFormId",
                        column: x => x.OccupationFormId,
                        principalTable: "OccupationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleBlockCurriculumTopicTrainingPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicTrainingProgramId = table.Column<int>(type: "integer", nullable: false),
                    ScheduleBlockId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleBlockCurriculumTopicTrainingPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleBlockCurriculumTopicTrainingPrograms_CurriculumTopi~",
                        column: x => x.CurriculumTopicTrainingProgramId,
                        principalTable: "CurriculumTopicTrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleBlockCurriculumTopicTrainingPrograms_ScheduleBlocks~",
                        column: x => x.ScheduleBlockId,
                        principalTable: "ScheduleBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalLiteratureCurriculumTopic_CurriculumTopicsId",
                table: "AdditionalLiteratureCurriculumTopic",
                column: "CurriculumTopicsId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TeacherId",
                table: "AspNetUsers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicDepartment_DepartmentsId",
                table: "CurriculumTopicDepartment",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicFinalExamination_FinalExaminationsId",
                table: "CurriculumTopicFinalExamination",
                column: "FinalExaminationsId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicMainLiterature_MainLiteraturesId",
                table: "CurriculumTopicMainLiterature",
                column: "MainLiteraturesId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicRegulation_RegulationsId",
                table: "CurriculumTopicRegulation",
                column: "RegulationsId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicStudentCategory_StudentCategoriesId",
                table: "CurriculumTopicStudentCategory",
                column: "StudentCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicTestWork_TestWorksId",
                table: "CurriculumTopicTestWork",
                column: "TestWorksId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicTrainingProgram_TrainingProgramsId",
                table: "CurriculumTopicTrainingProgram",
                column: "TrainingProgramsId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicTrainingPrograms_TrainingProgramCurriculumSe~",
                table: "CurriculumTopicTrainingPrograms",
                column: "TrainingProgramCurriculumSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentTeacher_TeachersId",
                table: "DepartmentTeacher",
                column: "TeachersId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalExaminations_CertificationTypeId",
                table: "FinalExaminations",
                column: "CertificationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TrainingProgramId",
                table: "Groups",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_MaxVariableTopicTimes_OccupationFormId",
                table: "MaxVariableTopicTimes",
                column: "OccupationFormId");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationFormClassHours_OccupationFormId",
                table: "OccupationFormClassHours",
                column: "OccupationFormId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBlockClassRooms_ClassRoomId",
                table: "ScheduleBlockClassRooms",
                column: "ClassRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBlockClassRooms_ScheduleBlockId",
                table: "ScheduleBlockClassRooms",
                column: "ScheduleBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBlockClassTimes_ClassTimeId",
                table: "ScheduleBlockClassTimes",
                column: "ClassTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBlockClassTimes_ScheduleBlockId",
                table: "ScheduleBlockClassTimes",
                column: "ScheduleBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBlockCurriculumTopicTrainingPrograms_CurriculumTopi~",
                table: "ScheduleBlockCurriculumTopicTrainingPrograms",
                column: "CurriculumTopicTrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBlockCurriculumTopicTrainingPrograms_ScheduleBlockId",
                table: "ScheduleBlockCurriculumTopicTrainingPrograms",
                column: "ScheduleBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBlockTeachers_ScheduleBlockId",
                table: "ScheduleBlockTeachers",
                column: "ScheduleBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBlockTeachers_TeacherId",
                table: "ScheduleBlockTeachers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleDates_GroupId",
                table: "ScheduleDates",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleDateScheduleBlocks_ScheduleBlockId",
                table: "ScheduleDateScheduleBlocks",
                column: "ScheduleBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleDateScheduleBlocks_ScheduleDateId",
                table: "ScheduleDateScheduleBlocks",
                column: "ScheduleDateId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramAdditionalLiteratures_TrainingProgramId",
                table: "TrainingProgramAdditionalLiteratures",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramCurriculumSections_TrainingProgramId",
                table: "TrainingProgramCurriculumSections",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramFinalExaminations_TrainingProgramId",
                table: "TrainingProgramFinalExaminations",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramIndependentWorkQuestions_TrainingProgramId",
                table: "TrainingProgramIndependentWorkQuestions",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramIntroductions_TrainingProgramId",
                table: "TrainingProgramIntroductions",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramMainLiteratures_TrainingProgramId",
                table: "TrainingProgramMainLiteratures",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramRegulations_TrainingProgramId",
                table: "TrainingProgramRegulations",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPrograms_CertificationTypeId",
                table: "TrainingPrograms",
                column: "CertificationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPrograms_DepartmentId",
                table: "TrainingPrograms",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPrograms_FormOfEducationId",
                table: "TrainingPrograms",
                column: "FormOfEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPrograms_StudentCategoryId",
                table: "TrainingPrograms",
                column: "StudentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramTeachers_ExpertId",
                table: "TrainingProgramTeachers",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramTeachers_TeacherId",
                table: "TrainingProgramTeachers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramTeachers_TrainingProgramId",
                table: "TrainingProgramTeachers",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramTestWorks_TrainingProgramId",
                table: "TrainingProgramTestWorks",
                column: "TrainingProgramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalLiteratureCurriculumTopic");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CurriculumTopicDepartment");

            migrationBuilder.DropTable(
                name: "CurriculumTopicFinalExamination");

            migrationBuilder.DropTable(
                name: "CurriculumTopicMainLiterature");

            migrationBuilder.DropTable(
                name: "CurriculumTopicRegulation");

            migrationBuilder.DropTable(
                name: "CurriculumTopicStudentCategory");

            migrationBuilder.DropTable(
                name: "CurriculumTopicTestWork");

            migrationBuilder.DropTable(
                name: "CurriculumTopicTrainingProgram");

            migrationBuilder.DropTable(
                name: "DepartmentTeacher");

            migrationBuilder.DropTable(
                name: "InstituteStructures");

            migrationBuilder.DropTable(
                name: "MaxVariableTopicTimes");

            migrationBuilder.DropTable(
                name: "OccupationFormClassHours");

            migrationBuilder.DropTable(
                name: "ScheduleBlockClassRooms");

            migrationBuilder.DropTable(
                name: "ScheduleBlockClassTimes");

            migrationBuilder.DropTable(
                name: "ScheduleBlockCurriculumTopicTrainingPrograms");

            migrationBuilder.DropTable(
                name: "ScheduleBlockTeachers");

            migrationBuilder.DropTable(
                name: "ScheduleDateScheduleBlocks");

            migrationBuilder.DropTable(
                name: "TrainingProgramAdditionalLiteratures");

            migrationBuilder.DropTable(
                name: "TrainingProgramFinalExaminations");

            migrationBuilder.DropTable(
                name: "TrainingProgramIndependentWorkQuestions");

            migrationBuilder.DropTable(
                name: "TrainingProgramIntroductions");

            migrationBuilder.DropTable(
                name: "TrainingProgramMainLiteratures");

            migrationBuilder.DropTable(
                name: "TrainingProgramRegulations");

            migrationBuilder.DropTable(
                name: "TrainingProgramTeachers");

            migrationBuilder.DropTable(
                name: "TrainingProgramTestWorks");

            migrationBuilder.DropTable(
                name: "AdditionalLiteratures");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "FinalExaminations");

            migrationBuilder.DropTable(
                name: "MainLiteratures");

            migrationBuilder.DropTable(
                name: "Regulations");

            migrationBuilder.DropTable(
                name: "TestWorks");

            migrationBuilder.DropTable(
                name: "CurriculumTopics");

            migrationBuilder.DropTable(
                name: "OccupationForms");

            migrationBuilder.DropTable(
                name: "ClassRooms");

            migrationBuilder.DropTable(
                name: "ClassTimes");

            migrationBuilder.DropTable(
                name: "CurriculumTopicTrainingPrograms");

            migrationBuilder.DropTable(
                name: "ScheduleBlocks");

            migrationBuilder.DropTable(
                name: "ScheduleDates");

            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "TrainingProgramCurriculumSections");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "TrainingPrograms");

            migrationBuilder.DropTable(
                name: "CertificationTypes");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "FormOfEducations");

            migrationBuilder.DropTable(
                name: "StudentCategories");
        }
    }
}
