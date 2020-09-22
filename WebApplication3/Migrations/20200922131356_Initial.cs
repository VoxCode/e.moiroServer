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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalLiteratures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TopicTitle = table.Column<string>(nullable: true),
                    Annotation = table.Column<string>(nullable: true),
                    TestWork = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumTopics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinalExaminations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(nullable: true),
                    CertificationTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalExaminations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormOfEducations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormOfEducations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainLiteratures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainLiteratures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OccupationForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationForms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regulations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regulations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeachingPositions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachingPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestWorks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "CurriculumTopicAdditionalLiteratures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdditionalLiteratureId = table.Column<int>(nullable: false),
                    CurriculumTopicId = table.Column<int>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
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
                name: "CurriculumTopicFinalExaminations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(nullable: false),
                    FinalExaminationId = table.Column<int>(nullable: false)
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
                name: "CurriculumTopicMainLiteratures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainLiteratureId = table.Column<int>(nullable: false),
                    CurriculumTopicId = table.Column<int>(nullable: false)
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
                name: "CurriculumTopicTrainingPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsVariable = table.Column<bool>(nullable: false),
                    ClassHours = table.Column<int>(nullable: false),
                    SerialNumber = table.Column<int>(nullable: false),
                    CurriculumTopicId = table.Column<int>(nullable: false),
                    TrainingProgramId = table.Column<int>(nullable: false),
                    OccupationFormId = table.Column<int>(nullable: false)
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicRegulations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(nullable: false),
                    RegulationId = table.Column<int>(nullable: false)
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
                name: "CurriculumSections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    SectionNumberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumSections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurriculumSections_SectionNumbers_SectionNumberId",
                        column: x => x.SectionNumberId,
                        principalTable: "SectionNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicStudentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(nullable: false),
                    StudentCategoryId = table.Column<int>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    NumberOfHours = table.Column<int>(nullable: false),
                    IsDistanceLearning = table.Column<bool>(nullable: false),
                    IsIndependentWork = table.Column<bool>(nullable: false),
                    IsTestWork = table.Column<bool>(nullable: false),
                    IndependentWork = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: false),
                    StudentCategoryId = table.Column<int>(nullable: false),
                    CertificationTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingPrograms_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
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
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    IsCathedral = table.Column<bool>(nullable: false),
                    TeachingPositionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_TeachingPositions_TeachingPositionId",
                        column: x => x.TeachingPositionId,
                        principalTable: "TeachingPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumTopicTestWorks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(nullable: false),
                    TestWorkId = table.Column<int>(nullable: false)
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
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GroupNumber = table.Column<int>(nullable: false),
                    TheTopicOfContinuingEducation = table.Column<string>(nullable: true),
                    CalendarYear = table.Column<DateTime>(nullable: false),
                    ClassStartDate = table.Column<DateTime>(nullable: false),
                    ClassEndDate = table.Column<DateTime>(nullable: false),
                    FormOfEducationId = table.Column<int>(nullable: false),
                    TrainingProgramId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_FormOfEducations_FormOfEducationId",
                        column: x => x.FormOfEducationId,
                        principalTable: "FormOfEducations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingProgramId = table.Column<int>(nullable: false),
                    AdditionalLiteratureId = table.Column<int>(nullable: false),
                    SerialNumber = table.Column<int>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingProgramId = table.Column<int>(nullable: false),
                    CurriculumSectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramCurriculumSections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingProgramCurriculumSections_CurriculumSections_Curric~",
                        column: x => x.CurriculumSectionId,
                        principalTable: "CurriculumSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingProgramId = table.Column<int>(nullable: false),
                    FinalExaminationId = table.Column<int>(nullable: false),
                    SerialNumber = table.Column<int>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingProgramId = table.Column<int>(nullable: false),
                    MainLiteratureId = table.Column<int>(nullable: false),
                    SerialNumber = table.Column<int>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingProgramId = table.Column<int>(nullable: false),
                    RegulationId = table.Column<int>(nullable: false),
                    SerialNumber = table.Column<int>(nullable: false)
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
                name: "TrainingProgramTestWorks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingProgramId = table.Column<int>(nullable: false),
                    TestWorkId = table.Column<int>(nullable: false),
                    SerialNumber = table.Column<int>(nullable: false)
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
                name: "TrainingProgramTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TeacherId = table.Column<int>(nullable: false),
                    TrainingProgramId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProgramTeachers", x => x.Id);
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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumSections_SectionNumberId",
                table: "CurriculumSections",
                column: "SectionNumberId");

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
                name: "IX_Groups_FormOfEducationId",
                table: "Groups",
                column: "FormOfEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TrainingProgramId",
                table: "Groups",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeachingPositionId",
                table: "Teachers",
                column: "TeachingPositionId");

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
                name: "IX_TrainingPrograms_DepartmentId",
                table: "TrainingPrograms",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPrograms_StudentCategoryId",
                table: "TrainingPrograms",
                column: "StudentCategoryId");

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
                name: "CurriculumTopicTrainingPrograms");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "TrainingProgramAdditionalLiteratures");

            migrationBuilder.DropTable(
                name: "TrainingProgramCurriculumSections");

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
                name: "CurriculumTopics");

            migrationBuilder.DropTable(
                name: "OccupationForms");

            migrationBuilder.DropTable(
                name: "FormOfEducations");

            migrationBuilder.DropTable(
                name: "AdditionalLiteratures");

            migrationBuilder.DropTable(
                name: "CurriculumSections");

            migrationBuilder.DropTable(
                name: "FinalExaminations");

            migrationBuilder.DropTable(
                name: "MainLiteratures");

            migrationBuilder.DropTable(
                name: "Regulations");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "TestWorks");

            migrationBuilder.DropTable(
                name: "TrainingPrograms");

            migrationBuilder.DropTable(
                name: "SectionNumbers");

            migrationBuilder.DropTable(
                name: "TeachingPositions");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "StudentCategories");
        }
    }
}
