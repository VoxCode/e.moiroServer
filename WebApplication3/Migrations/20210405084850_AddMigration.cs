using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using System;

namespace e.moiroServer.Migrations
{
    public partial class AddMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalLiteratures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true)
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
                name: "CurriculumSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumSections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TopicTitle = table.Column<string>(type: "text", nullable: true),
                    Annotation = table.Column<string>(type: "text", nullable: true)
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
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expert",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expert", x => x.Id);
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
                name: "MainLiteratures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true)
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
                    Content = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regulations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleBlock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SubgroupNumber = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleBlock", x => x.Id);
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
                    Name = table.Column<string>(type: "text", nullable: true),
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
                    Content = table.Column<string>(type: "text", nullable: true)
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
                    CertificationTypeId = table.Column<int>(type: "integer", nullable: false)
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
                name: "CurriculumTopicAdditionalLiteratures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdditionalLiteratureId = table.Column<int>(type: "integer", nullable: false),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicAdditionalLiteratures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicAdditionalLiteratures_AdditionalLiteratures_~",
                        column: x => x.AdditionalLiteratureId,
                        principalTable: "AdditionalLiteratures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicAdditionalLiteratures_CurriculumTopics_Curri~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicDepartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicDepartments_CurriculumTopics_CurriculumTopic~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicDepartments_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicMainLiteratures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainLiteratureId = table.Column<int>(type: "integer", nullable: false),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicMainLiteratures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicMainLiteratures_CurriculumTopics_CurriculumT~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicMainLiteratures_MainLiteratures_MainLiteratu~",
                        column: x => x.MainLiteratureId,
                        principalTable: "MainLiteratures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicRegulations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    RegulationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicRegulations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicRegulations_CurriculumTopics_CurriculumTopic~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicRegulations_Regulations_RegulationId",
                        column: x => x.RegulationId,
                        principalTable: "Regulations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleBlockClassRoom",
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
                    table.PrimaryKey("PK_ScheduleBlockClassRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleBlockClassRoom_ScheduleBlock_ScheduleBlockId",
                        column: x => x.ScheduleBlockId,
                        principalTable: "ScheduleBlock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleBlockClassTime",
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
                    table.PrimaryKey("PK_ScheduleBlockClassTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleBlockClassTime_ScheduleBlock_ScheduleBlockId",
                        column: x => x.ScheduleBlockId,
                        principalTable: "ScheduleBlock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleDateSheduleBlock",
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
                    table.PrimaryKey("PK_ScheduleDateSheduleBlock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleDateSheduleBlock_ScheduleBlock_ScheduleBlockId",
                        column: x => x.ScheduleBlockId,
                        principalTable: "ScheduleBlock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicStudentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    StudentCategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicStudentCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicStudentCategories_CurriculumTopics_Curriculu~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicStudentCategories_StudentCategories_StudentC~",
                        column: x => x.StudentCategoryId,
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
                    ControlWork = table.Column<string>(type: "text", nullable: true),
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
                name: "ScheduleBlockTeacher",
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
                    table.PrimaryKey("PK_ScheduleBlockTeacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleBlockTeacher_ScheduleBlock_ScheduleBlockId",
                        column: x => x.ScheduleBlockId,
                        principalTable: "ScheduleBlock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleBlockTeacher_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicTestWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    TestWorkId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicTestWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicTestWorks_CurriculumTopics_CurriculumTopicId",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicTestWorks_TestWorks_TestWorkId",
                        column: x => x.TestWorkId,
                        principalTable: "TestWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicFinalExaminations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    FinalExaminationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicFinalExaminations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicFinalExaminations_CurriculumTopics_Curriculu~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicFinalExaminations_FinalExaminations_FinalExa~",
                        column: x => x.FinalExaminationId,
                        principalTable: "FinalExaminations",
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
                    AdditionalLiteratureId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramAdditionalLiteratures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramAdditionalLiteratures_AdditionalLiteratures_~",
                        column: x => x.AdditionalLiteratureId,
                        principalTable: "AdditionalLiteratures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    CurriculumSectionId = table.Column<int>(type: "integer", nullable: true),
                    SectionNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramCurriculumSections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramCurriculumSections_CurriculumSections_Curric~",
                        column: x => x.CurriculumSectionId,
                        principalTable: "CurriculumSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    FinalExaminationId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramFinalExaminations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramFinalExaminations_FinalExaminations_FinalExa~",
                        column: x => x.FinalExaminationId,
                        principalTable: "FinalExaminations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingProgramFinalExaminations_TrainingPrograms_TrainingP~",
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
                    MainLiteratureId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramMainLiteratures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramMainLiteratures_MainLiteratures_MainLiteratu~",
                        column: x => x.MainLiteratureId,
                        principalTable: "MainLiteratures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    RegulationId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramRegulations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramRegulations_Regulations_RegulationId",
                        column: x => x.RegulationId,
                        principalTable: "Regulations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_TrainingProgramTeachers_Expert_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Expert",
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
                    TestWorkId = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramTestWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramTestWorks_TestWorks_TestWorkId",
                        column: x => x.TestWorkId,
                        principalTable: "TestWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "CurriculumTopicTrainingPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsVariable = table.Column<bool>(type: "boolean", nullable: false),
                    ClassHours = table.Column<int>(type: "integer", nullable: false),
                    SerialNumber = table.Column<int>(type: "integer", nullable: false),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: false),
                    OccupationFormId = table.Column<int>(type: "integer", nullable: true),
                    TrainingProgrmaCurriculumSectionId = table.Column<int>(type: "integer", nullable: false),
                    TrainingProgramCurriculumSectionId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopicTrainingPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicTrainingPrograms_CurriculumTopics_Curriculum~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicTrainingPrograms_OccupationForms_OccupationF~",
                        column: x => x.OccupationFormId,
                        principalTable: "OccupationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicTrainingPrograms_TrainingProgramCurriculumSe~",
                        column: x => x.TrainingProgramCurriculumSectionId,
                        principalTable: "TrainingProgramCurriculumSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CurriculumTopicTrainingPrograms_TrainingPrograms_TrainingPr~",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleBlockCurriculumTopicTrainingProgram",
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
                    table.PrimaryKey("PK_ScheduleBlockCurriculumTopicTrainingProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleBlockCurriculumTopicTrainingProgram_CurriculumTopic~",
                        column: x => x.CurriculumTopicTrainingProgramId,
                        principalTable: "CurriculumTopicTrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleBlockCurriculumTopicTrainingProgram_ScheduleBlock_S~",
                        column: x => x.ScheduleBlockId,
                        principalTable: "ScheduleBlock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Кафедра частных методик общего среднего образования" },
                    { 2, "Кафедра психологии и управления" },
                    { 1, "Кафедра дошкольного и начального образования" }
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
                name: "IX_CurriculumTopicAdditionalLiteratures_AdditionalLiteratureId",
                table: "CurriculumTopicAdditionalLiteratures",
                column: "AdditionalLiteratureId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicAdditionalLiteratures_CurriculumTopicId",
                table: "CurriculumTopicAdditionalLiteratures",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicDepartments_CurriculumTopicId",
                table: "CurriculumTopicDepartments",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicDepartments_DepartmentId",
                table: "CurriculumTopicDepartments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicFinalExaminations_CurriculumTopicId",
                table: "CurriculumTopicFinalExaminations",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicFinalExaminations_FinalExaminationId",
                table: "CurriculumTopicFinalExaminations",
                column: "FinalExaminationId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicMainLiteratures_CurriculumTopicId",
                table: "CurriculumTopicMainLiteratures",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicMainLiteratures_MainLiteratureId",
                table: "CurriculumTopicMainLiteratures",
                column: "MainLiteratureId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicRegulations_CurriculumTopicId",
                table: "CurriculumTopicRegulations",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicRegulations_RegulationId",
                table: "CurriculumTopicRegulations",
                column: "RegulationId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicStudentCategories_CurriculumTopicId",
                table: "CurriculumTopicStudentCategories",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicStudentCategories_StudentCategoryId",
                table: "CurriculumTopicStudentCategories",
                column: "StudentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicTestWorks_CurriculumTopicId",
                table: "CurriculumTopicTestWorks",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicTestWorks_TestWorkId",
                table: "CurriculumTopicTestWorks",
                column: "TestWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicTrainingPrograms_CurriculumTopicId",
                table: "CurriculumTopicTrainingPrograms",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicTrainingPrograms_OccupationFormId",
                table: "CurriculumTopicTrainingPrograms",
                column: "OccupationFormId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicTrainingPrograms_TrainingProgramCurriculumSe~",
                table: "CurriculumTopicTrainingPrograms",
                column: "TrainingProgramCurriculumSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicTrainingPrograms_TrainingProgramId",
                table: "CurriculumTopicTrainingPrograms",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalExaminations_CertificationTypeId",
                table: "FinalExaminations",
                column: "CertificationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TrainingProgramId",
                table: "Groups",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBlockClassRoom_ScheduleBlockId",
                table: "ScheduleBlockClassRoom",
                column: "ScheduleBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBlockClassTime_ScheduleBlockId",
                table: "ScheduleBlockClassTime",
                column: "ScheduleBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBlockCurriculumTopicTrainingProgram_CurriculumTopic~",
                table: "ScheduleBlockCurriculumTopicTrainingProgram",
                column: "CurriculumTopicTrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBlockCurriculumTopicTrainingProgram_ScheduleBlockId",
                table: "ScheduleBlockCurriculumTopicTrainingProgram",
                column: "ScheduleBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBlockTeacher_ScheduleBlockId",
                table: "ScheduleBlockTeacher",
                column: "ScheduleBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBlockTeacher_TeacherId",
                table: "ScheduleBlockTeacher",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleDateSheduleBlock_ScheduleBlockId",
                table: "ScheduleDateSheduleBlock",
                column: "ScheduleBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramAdditionalLiteratures_AdditionalLiteratureId",
                table: "TrainingProgramAdditionalLiteratures",
                column: "AdditionalLiteratureId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramAdditionalLiteratures_TrainingProgramId",
                table: "TrainingProgramAdditionalLiteratures",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramCurriculumSections_CurriculumSectionId",
                table: "TrainingProgramCurriculumSections",
                column: "CurriculumSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramCurriculumSections_TrainingProgramId",
                table: "TrainingProgramCurriculumSections",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramFinalExaminations_FinalExaminationId",
                table: "TrainingProgramFinalExaminations",
                column: "FinalExaminationId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramFinalExaminations_TrainingProgramId",
                table: "TrainingProgramFinalExaminations",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramMainLiteratures_MainLiteratureId",
                table: "TrainingProgramMainLiteratures",
                column: "MainLiteratureId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramMainLiteratures_TrainingProgramId",
                table: "TrainingProgramMainLiteratures",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramRegulations_RegulationId",
                table: "TrainingProgramRegulations",
                column: "RegulationId");

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
                name: "IX_TrainingProgramTestWorks_TestWorkId",
                table: "TrainingProgramTestWorks",
                column: "TestWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProgramTestWorks_TrainingProgramId",
                table: "TrainingProgramTestWorks",
                column: "TrainingProgramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "CurriculumTopicAdditionalLiteratures");

            migrationBuilder.DropTable(
                name: "CurriculumTopicDepartments");

            migrationBuilder.DropTable(
                name: "CurriculumTopicFinalExaminations");

            migrationBuilder.DropTable(
                name: "CurriculumTopicMainLiteratures");

            migrationBuilder.DropTable(
                name: "CurriculumTopicRegulations");

            migrationBuilder.DropTable(
                name: "CurriculumTopicStudentCategories");

            migrationBuilder.DropTable(
                name: "CurriculumTopicTestWorks");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "ScheduleBlockClassRoom");

            migrationBuilder.DropTable(
                name: "ScheduleBlockClassTime");

            migrationBuilder.DropTable(
                name: "ScheduleBlockCurriculumTopicTrainingProgram");

            migrationBuilder.DropTable(
                name: "ScheduleBlockTeacher");

            migrationBuilder.DropTable(
                name: "ScheduleDateSheduleBlock");

            migrationBuilder.DropTable(
                name: "TrainingProgramAdditionalLiteratures");

            migrationBuilder.DropTable(
                name: "TrainingProgramFinalExaminations");

            migrationBuilder.DropTable(
                name: "TrainingProgramMainLiteratures");

            migrationBuilder.DropTable(
                name: "TrainingProgramRegulations");

            migrationBuilder.DropTable(
                name: "TrainingProgramTeachers");

            migrationBuilder.DropTable(
                name: "TrainingProgramTestWorks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CurriculumTopicTrainingPrograms");

            migrationBuilder.DropTable(
                name: "ScheduleBlock");

            migrationBuilder.DropTable(
                name: "AdditionalLiteratures");

            migrationBuilder.DropTable(
                name: "FinalExaminations");

            migrationBuilder.DropTable(
                name: "MainLiteratures");

            migrationBuilder.DropTable(
                name: "Regulations");

            migrationBuilder.DropTable(
                name: "Expert");

            migrationBuilder.DropTable(
                name: "TestWorks");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "CurriculumTopics");

            migrationBuilder.DropTable(
                name: "OccupationForms");

            migrationBuilder.DropTable(
                name: "TrainingProgramCurriculumSections");

            migrationBuilder.DropTable(
                name: "CurriculumSections");

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
