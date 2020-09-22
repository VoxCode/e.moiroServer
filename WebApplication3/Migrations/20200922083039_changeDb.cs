using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace e.moiroServer.Migrations
{
    public partial class changeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurriculumTopics_CurriculumSections_CurriculumSectionId",
                table: "CurriculumTopics");

            migrationBuilder.DropForeignKey(
                name: "FK_CurriculumTopics_OccupationForms_OccupationFormId",
                table: "CurriculumTopics");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Departments_DepartmentId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_TeacherCategories_TeacherCategoryId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPrograms_Groups_GroupId",
                table: "TrainingPrograms");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "СurriculumTopicAdditionalLiterature");

            migrationBuilder.DropTable(
                name: "СurriculumTopicConsultationTopic");

            migrationBuilder.DropTable(
                name: "СurriculumTopicDepartment");

            migrationBuilder.DropTable(
                name: "СurriculumTopicMainLiterature");

            migrationBuilder.DropTable(
                name: "СurriculumTopicTeacher");

            migrationBuilder.DropTable(
                name: "СurriculumTopicTeacherCategory");

            migrationBuilder.DropTable(
                name: "СurriculumTopicTheQuestion");

            migrationBuilder.DropTable(
                name: "СurriculumTopicTrainingProgram");

            migrationBuilder.DropTable(
                name: "ConsultationTopics");

            migrationBuilder.DropTable(
                name: "TeacherCategories");

            migrationBuilder.DropTable(
                name: "TheQuestions");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPrograms_GroupId",
                table: "TrainingPrograms");

            migrationBuilder.DropIndex(
                name: "IX_Groups_DepartmentId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_TeacherCategoryId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_CurriculumTopics_CurriculumSectionId",
                table: "CurriculumTopics");

            migrationBuilder.DropIndex(
                name: "IX_CurriculumTopics_OccupationFormId",
                table: "CurriculumTopics");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "NumberOfHours",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "TeacherCategoryId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "ClassHours",
                table: "CurriculumTopics");

            migrationBuilder.DropColumn(
                name: "CurriculumSectionId",
                table: "CurriculumTopics");

            migrationBuilder.DropColumn(
                name: "IsDistanceLearning",
                table: "CurriculumTopics");

            migrationBuilder.DropColumn(
                name: "OccupationFormId",
                table: "CurriculumTopics");

            migrationBuilder.AddColumn<string>(
                name: "CertificationTypeId",
                table: "TrainingPrograms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentId",
                table: "TrainingPrograms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId1",
                table: "TrainingPrograms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndependentWork",
                table: "TrainingPrograms",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDistanceLearning",
                table: "TrainingPrograms",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsIndependentWork",
                table: "TrainingPrograms",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTestWork",
                table: "TrainingPrograms",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TrainingPrograms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfHours",
                table: "TrainingPrograms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentCategoryId",
                table: "TrainingPrograms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeacherCategoryId",
                table: "TrainingPrograms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestWork",
                table: "CurriculumTopics",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPrograms_DepartmentId1",
                table: "TrainingPrograms",
                column: "DepartmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPrograms_StudentCategoryId",
                table: "TrainingPrograms",
                column: "StudentCategoryId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPrograms_Departments_DepartmentId1",
                table: "TrainingPrograms",
                column: "DepartmentId1",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPrograms_StudentCategories_StudentCategoryId",
                table: "TrainingPrograms",
                column: "StudentCategoryId",
                principalTable: "StudentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPrograms_Departments_DepartmentId1",
                table: "TrainingPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPrograms_StudentCategories_StudentCategoryId",
                table: "TrainingPrograms");

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
                name: "StudentCategories");

            migrationBuilder.DropTable(
                name: "FinalExaminations");

            migrationBuilder.DropTable(
                name: "Regulations");

            migrationBuilder.DropTable(
                name: "TestWorks");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPrograms_DepartmentId1",
                table: "TrainingPrograms");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPrograms_StudentCategoryId",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "CertificationTypeId",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "IndependentWork",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "IsDistanceLearning",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "IsIndependentWork",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "IsTestWork",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "NumberOfHours",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "StudentCategoryId",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "TeacherCategoryId",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "TestWork",
                table: "CurriculumTopics");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "TrainingPrograms",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Groups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfHours",
                table: "Groups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherCategoryId",
                table: "Groups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassHours",
                table: "CurriculumTopics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurriculumSectionId",
                table: "CurriculumTopics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDistanceLearning",
                table: "CurriculumTopics",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "OccupationFormId",
                table: "CurriculumTopics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ConsultationTopics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultationTopics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Company = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TheQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicAdditionalLiterature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdditionalLiteratureId = table.Column<int>(type: "integer", nullable: false),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicAdditionalLiterature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicAdditionalLiterature_AdditionalLiteratures_A~",
                        column: x => x.AdditionalLiteratureId,
                        principalTable: "AdditionalLiteratures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicAdditionalLiterature_CurriculumTopics_Curric~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicDepartment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicDepartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicDepartment_CurriculumTopics_CurriculumTopicId",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicDepartment_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicMainLiterature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    MainLiteratureId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicMainLiterature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicMainLiterature_CurriculumTopics_CurriculumTo~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicMainLiterature_MainLiteratures_MainLiteratur~",
                        column: x => x.MainLiteratureId,
                        principalTable: "MainLiteratures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicTeacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    TeacherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicTeacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTeacher_CurriculumTopics_CurriculumTopicId",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTeacher_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicTrainingProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    TrainingProgramId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicTrainingProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTrainingProgram_CurriculumTopics_CurriculumT~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTrainingProgram_TrainingPrograms_TrainingPro~",
                        column: x => x.TrainingProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicConsultationTopic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConsultationTopicId = table.Column<int>(type: "integer", nullable: false),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicConsultationTopic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicConsultationTopic_ConsultationTopics_Consult~",
                        column: x => x.ConsultationTopicId,
                        principalTable: "ConsultationTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicConsultationTopic_CurriculumTopics_Curriculu~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicTeacherCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    TeacherCategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicTeacherCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTeacherCategory_CurriculumTopics_CurriculumT~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTeacherCategory_TeacherCategories_TeacherCat~",
                        column: x => x.TeacherCategoryId,
                        principalTable: "TeacherCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicTheQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    TheQuestionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicTheQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTheQuestion_CurriculumTopics_CurriculumTopic~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CurriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTheQuestion_TheQuestions_TheQuestionId",
                        column: x => x.TheQuestionId,
                        principalTable: "TheQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPrograms_GroupId",
                table: "TrainingPrograms",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_DepartmentId",
                table: "Groups",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TeacherCategoryId",
                table: "Groups",
                column: "TeacherCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopics_CurriculumSectionId",
                table: "CurriculumTopics",
                column: "CurriculumSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopics_OccupationFormId",
                table: "CurriculumTopics",
                column: "OccupationFormId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicAdditionalLiterature_AdditionalLiteratureId",
                table: "СurriculumTopicAdditionalLiterature",
                column: "AdditionalLiteratureId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicAdditionalLiterature_CurriculumTopicId",
                table: "СurriculumTopicAdditionalLiterature",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicConsultationTopic_ConsultationTopicId",
                table: "СurriculumTopicConsultationTopic",
                column: "ConsultationTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicConsultationTopic_CurriculumTopicId",
                table: "СurriculumTopicConsultationTopic",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicDepartment_CurriculumTopicId",
                table: "СurriculumTopicDepartment",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicDepartment_DepartmentId",
                table: "СurriculumTopicDepartment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicMainLiterature_CurriculumTopicId",
                table: "СurriculumTopicMainLiterature",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicMainLiterature_MainLiteratureId",
                table: "СurriculumTopicMainLiterature",
                column: "MainLiteratureId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTeacher_CurriculumTopicId",
                table: "СurriculumTopicTeacher",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTeacher_TeacherId",
                table: "СurriculumTopicTeacher",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTeacherCategory_CurriculumTopicId",
                table: "СurriculumTopicTeacherCategory",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTeacherCategory_TeacherCategoryId",
                table: "СurriculumTopicTeacherCategory",
                column: "TeacherCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTheQuestion_CurriculumTopicId",
                table: "СurriculumTopicTheQuestion",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTheQuestion_TheQuestionId",
                table: "СurriculumTopicTheQuestion",
                column: "TheQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTrainingProgram_CurriculumTopicId",
                table: "СurriculumTopicTrainingProgram",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTrainingProgram_TrainingProgramId",
                table: "СurriculumTopicTrainingProgram",
                column: "TrainingProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurriculumTopics_CurriculumSections_CurriculumSectionId",
                table: "CurriculumTopics",
                column: "CurriculumSectionId",
                principalTable: "CurriculumSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CurriculumTopics_OccupationForms_OccupationFormId",
                table: "CurriculumTopics",
                column: "OccupationFormId",
                principalTable: "OccupationForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Departments_DepartmentId",
                table: "Groups",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_TeacherCategories_TeacherCategoryId",
                table: "Groups",
                column: "TeacherCategoryId",
                principalTable: "TeacherCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPrograms_Groups_GroupId",
                table: "TrainingPrograms",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
