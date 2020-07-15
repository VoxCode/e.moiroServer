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
                name: "ConsultationTopics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultationTopics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departmens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmens", x => x.Id);
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
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
                name: "TeacherCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherCategories", x => x.Id);
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
                name: "TheQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheQuestions", x => x.Id);
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
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GroupNumber = table.Column<int>(nullable: false),
                    CalendarYear = table.Column<DateTime>(nullable: false),
                    TheTopicOfContinuingEducation = table.Column<string>(nullable: true),
                    ClassStartDate = table.Column<DateTime>(nullable: false),
                    ClassEndDate = table.Column<DateTime>(nullable: false),
                    NumberOfHours = table.Column<int>(nullable: false),
                    FormOfEducationId = table.Column<int>(nullable: false),
                    TeacherCategoryId = table.Column<int>(nullable: false),
                    DepartmensId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Departmens_DepartmensId",
                        column: x => x.DepartmensId,
                        principalTable: "Departmens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Groups_FormOfEducations_FormOfEducationId",
                        column: x => x.FormOfEducationId,
                        principalTable: "FormOfEducations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Groups_TeacherCategories_TeacherCategoryId",
                        column: x => x.TeacherCategoryId,
                        principalTable: "TeacherCategories",
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
                    Cathedra = table.Column<bool>(nullable: false),
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
                name: "CuriculumTopics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TopicTitle = table.Column<string>(nullable: true),
                    ClassHours = table.Column<int>(nullable: false),
                    Annotation = table.Column<string>(nullable: true),
                    DistanceLearning = table.Column<bool>(nullable: false),
                    CurriculumSectionId = table.Column<int>(nullable: false),
                    OccupationFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuriculumTopics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CuriculumTopics_CurriculumSections_CurriculumSectionId",
                        column: x => x.CurriculumSectionId,
                        principalTable: "CurriculumSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CuriculumTopics_OccupationForms_OccupationFormId",
                        column: x => x.OccupationFormId,
                        principalTable: "OccupationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingPrograms_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicAdditionalLiteratures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdditionalLiteratureId = table.Column<int>(nullable: false),
                    CuriculumTopicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicAdditionalLiteratures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicAdditionalLiteratures_AdditionalLiteratures_~",
                        column: x => x.AdditionalLiteratureId,
                        principalTable: "AdditionalLiteratures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicAdditionalLiteratures_CuriculumTopics_Curicu~",
                        column: x => x.CuriculumTopicId,
                        principalTable: "CuriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicConsultationTopics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConsultationTopicsId = table.Column<int>(nullable: false),
                    CuriculumTopicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicConsultationTopics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicConsultationTopics_ConsultationTopics_Consul~",
                        column: x => x.ConsultationTopicsId,
                        principalTable: "ConsultationTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicConsultationTopics_CuriculumTopics_Curiculum~",
                        column: x => x.CuriculumTopicId,
                        principalTable: "CuriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicDepartmens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CuriculumTopicId = table.Column<int>(nullable: false),
                    DepartmensId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicDepartmens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicDepartmens_CuriculumTopics_CuriculumTopicId",
                        column: x => x.CuriculumTopicId,
                        principalTable: "CuriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicDepartmens_Departmens_DepartmensId",
                        column: x => x.DepartmensId,
                        principalTable: "Departmens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicMainLiteratures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MainLiteratureId = table.Column<int>(nullable: false),
                    CuriculumTopicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicMainLiteratures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicMainLiteratures_CuriculumTopics_CuriculumTop~",
                        column: x => x.CuriculumTopicId,
                        principalTable: "CuriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicMainLiteratures_MainLiteratures_MainLiteratu~",
                        column: x => x.MainLiteratureId,
                        principalTable: "MainLiteratures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicTeacherCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TeacherCategoryId = table.Column<int>(nullable: false),
                    CuriculumTopicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicTeacherCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTeacherCategories_CuriculumTopics_CuriculumT~",
                        column: x => x.CuriculumTopicId,
                        principalTable: "CuriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTeacherCategories_TeacherCategories_TeacherC~",
                        column: x => x.TeacherCategoryId,
                        principalTable: "TeacherCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TeacherId = table.Column<int>(nullable: false),
                    CuriculumTopicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicTeachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTeachers_CuriculumTopics_CuriculumTopicId",
                        column: x => x.CuriculumTopicId,
                        principalTable: "CuriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicTheQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TheQuestionsId = table.Column<int>(nullable: false),
                    CuriculumTopicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicTheQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTheQuestions_CuriculumTopics_CuriculumTopicId",
                        column: x => x.CuriculumTopicId,
                        principalTable: "CuriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTheQuestions_TheQuestions_TheQuestionsId",
                        column: x => x.TheQuestionsId,
                        principalTable: "TheQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicTranningPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CuriculumTopicId = table.Column<int>(nullable: false),
                    TrainingProgramId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicTranningPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTranningPrograms_CuriculumTopics_CuriculumTo~",
                        column: x => x.CuriculumTopicId,
                        principalTable: "CuriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTranningPrograms_TrainingPrograms_TrainingPr~",
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
                name: "IX_CuriculumTopics_CurriculumSectionId",
                table: "CuriculumTopics",
                column: "CurriculumSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_CuriculumTopics_OccupationFormId",
                table: "CuriculumTopics",
                column: "OccupationFormId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumSections_SectionNumberId",
                table: "CurriculumSections",
                column: "SectionNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_DepartmensId",
                table: "Groups",
                column: "DepartmensId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_FormOfEducationId",
                table: "Groups",
                column: "FormOfEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TeacherCategoryId",
                table: "Groups",
                column: "TeacherCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeachingPositionId",
                table: "Teachers",
                column: "TeachingPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPrograms_GroupId",
                table: "TrainingPrograms",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicAdditionalLiteratures_AdditionalLiteratureId",
                table: "СurriculumTopicAdditionalLiteratures",
                column: "AdditionalLiteratureId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicAdditionalLiteratures_CuriculumTopicId",
                table: "СurriculumTopicAdditionalLiteratures",
                column: "CuriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicConsultationTopics_ConsultationTopicsId",
                table: "СurriculumTopicConsultationTopics",
                column: "ConsultationTopicsId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicConsultationTopics_CuriculumTopicId",
                table: "СurriculumTopicConsultationTopics",
                column: "CuriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicDepartmens_CuriculumTopicId",
                table: "СurriculumTopicDepartmens",
                column: "CuriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicDepartmens_DepartmensId",
                table: "СurriculumTopicDepartmens",
                column: "DepartmensId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicMainLiteratures_CuriculumTopicId",
                table: "СurriculumTopicMainLiteratures",
                column: "CuriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicMainLiteratures_MainLiteratureId",
                table: "СurriculumTopicMainLiteratures",
                column: "MainLiteratureId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTeacherCategories_CuriculumTopicId",
                table: "СurriculumTopicTeacherCategories",
                column: "CuriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTeacherCategories_TeacherCategoryId",
                table: "СurriculumTopicTeacherCategories",
                column: "TeacherCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTeachers_CuriculumTopicId",
                table: "СurriculumTopicTeachers",
                column: "CuriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTeachers_TeacherId",
                table: "СurriculumTopicTeachers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTheQuestions_CuriculumTopicId",
                table: "СurriculumTopicTheQuestions",
                column: "CuriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTheQuestions_TheQuestionsId",
                table: "СurriculumTopicTheQuestions",
                column: "TheQuestionsId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTranningPrograms_CuriculumTopicId",
                table: "СurriculumTopicTranningPrograms",
                column: "CuriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTranningPrograms_TrainingProgramId",
                table: "СurriculumTopicTranningPrograms",
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
                name: "Products");

            migrationBuilder.DropTable(
                name: "СurriculumTopicAdditionalLiteratures");

            migrationBuilder.DropTable(
                name: "СurriculumTopicConsultationTopics");

            migrationBuilder.DropTable(
                name: "СurriculumTopicDepartmens");

            migrationBuilder.DropTable(
                name: "СurriculumTopicMainLiteratures");

            migrationBuilder.DropTable(
                name: "СurriculumTopicTeacherCategories");

            migrationBuilder.DropTable(
                name: "СurriculumTopicTeachers");

            migrationBuilder.DropTable(
                name: "СurriculumTopicTheQuestions");

            migrationBuilder.DropTable(
                name: "СurriculumTopicTranningPrograms");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AdditionalLiteratures");

            migrationBuilder.DropTable(
                name: "ConsultationTopics");

            migrationBuilder.DropTable(
                name: "MainLiteratures");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "TheQuestions");

            migrationBuilder.DropTable(
                name: "CuriculumTopics");

            migrationBuilder.DropTable(
                name: "TrainingPrograms");

            migrationBuilder.DropTable(
                name: "TeachingPositions");

            migrationBuilder.DropTable(
                name: "CurriculumSections");

            migrationBuilder.DropTable(
                name: "OccupationForms");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "SectionNumbers");

            migrationBuilder.DropTable(
                name: "Departmens");

            migrationBuilder.DropTable(
                name: "FormOfEducations");

            migrationBuilder.DropTable(
                name: "TeacherCategories");
        }
    }
}
