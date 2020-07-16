using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace e.moiroServer.Migrations
{
    public partial class editModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Departmens_DepartmensId",
                table: "Groups");

            migrationBuilder.DropTable(
                name: "СurriculumTopicConsultationTopics");

            migrationBuilder.DropTable(
                name: "СurriculumTopicDepartmens");

            migrationBuilder.DropTable(
                name: "СurriculumTopicTheQuestions");

            migrationBuilder.DropTable(
                name: "СurriculumTopicTranningProgram");

            migrationBuilder.DropTable(
                name: "Departmens");

            migrationBuilder.DropIndex(
                name: "IX_Groups_DepartmensId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Cathedra",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "DepartmensId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "DistanceLearning",
                table: "CuriculumTopics");

            migrationBuilder.AddColumn<bool>(
                name: "IsCathedral",
                table: "Teachers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Groups",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDistanceLearning",
                table: "CuriculumTopics",
                nullable: false,
                defaultValue: false);

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
                name: "СurriculumTopicConsultationTopic",
                columns: table => new
                {
                    ConsultationTopicId = table.Column<int>(nullable: false),
                    CurriculumTopicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicConsultationTopic", x => new { x.CurriculumTopicId, x.ConsultationTopicId });
                    table.ForeignKey(
                        name: "FK_СurriculumTopicConsultationTopic_ConsultationTopics_Consult~",
                        column: x => x.ConsultationTopicId,
                        principalTable: "ConsultationTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicConsultationTopic_CuriculumTopics_Curriculum~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CuriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicTheQuestion",
                columns: table => new
                {
                    TheQuestionId = table.Column<int>(nullable: false),
                    CurriculumTopicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicTheQuestion", x => new { x.CurriculumTopicId, x.TheQuestionId });
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTheQuestion_CuriculumTopics_CurriculumTopicId",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CuriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTheQuestion_TheQuestions_TheQuestionId",
                        column: x => x.TheQuestionId,
                        principalTable: "TheQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicTrainingProgram",
                columns: table => new
                {
                    CurriculumTopicId = table.Column<int>(nullable: false),
                    TrainingProgramId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicTrainingProgram", x => new { x.CurriculumTopicId, x.TrainingProgramId });
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTrainingProgram_CuriculumTopics_CurriculumTo~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CuriculumTopics",
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
                name: "СurriculumTopicDepartment",
                columns: table => new
                {
                    CurriculumTopicId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicDepartment", x => new { x.CurriculumTopicId, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_СurriculumTopicDepartment_CuriculumTopics_CurriculumTopicId",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CuriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicDepartment_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_DepartmentId",
                table: "Groups",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicConsultationTopic_ConsultationTopicId",
                table: "СurriculumTopicConsultationTopic",
                column: "ConsultationTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicDepartment_DepartmentId",
                table: "СurriculumTopicDepartment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTheQuestion_TheQuestionId",
                table: "СurriculumTopicTheQuestion",
                column: "TheQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTrainingProgram_TrainingProgramId",
                table: "СurriculumTopicTrainingProgram",
                column: "TrainingProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Departments_DepartmentId",
                table: "Groups",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Departments_DepartmentId",
                table: "Groups");

            migrationBuilder.DropTable(
                name: "СurriculumTopicConsultationTopic");

            migrationBuilder.DropTable(
                name: "СurriculumTopicDepartment");

            migrationBuilder.DropTable(
                name: "СurriculumTopicTheQuestion");

            migrationBuilder.DropTable(
                name: "СurriculumTopicTrainingProgram");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Groups_DepartmentId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "IsCathedral",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "IsDistanceLearning",
                table: "CuriculumTopics");

            migrationBuilder.AddColumn<bool>(
                name: "Cathedra",
                table: "Teachers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DepartmensId",
                table: "Groups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "DistanceLearning",
                table: "CuriculumTopics",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Departmens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicConsultationTopics",
                columns: table => new
                {
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    ConsultationTopicsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicConsultationTopics", x => new { x.CurriculumTopicId, x.ConsultationTopicsId });
                    table.ForeignKey(
                        name: "FK_СurriculumTopicConsultationTopics_ConsultationTopics_Consul~",
                        column: x => x.ConsultationTopicsId,
                        principalTable: "ConsultationTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicConsultationTopics_CuriculumTopics_Curriculu~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CuriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicTheQuestions",
                columns: table => new
                {
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    TheQuestionsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicTheQuestions", x => new { x.CurriculumTopicId, x.TheQuestionsId });
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTheQuestions_CuriculumTopics_CurriculumTopic~",
                        column: x => x.CurriculumTopicId,
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
                name: "СurriculumTopicTranningProgram",
                columns: table => new
                {
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    TranningProgramId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicTranningProgram", x => new { x.CurriculumTopicId, x.TranningProgramId });
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTranningProgram_CuriculumTopics_CurriculumTo~",
                        column: x => x.CurriculumTopicId,
                        principalTable: "CuriculumTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_СurriculumTopicTranningProgram_TrainingPrograms_TranningPro~",
                        column: x => x.TranningProgramId,
                        principalTable: "TrainingPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "СurriculumTopicDepartmens",
                columns: table => new
                {
                    CurriculumTopicId = table.Column<int>(type: "integer", nullable: false),
                    DepartmensId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СurriculumTopicDepartmens", x => new { x.CurriculumTopicId, x.DepartmensId });
                    table.ForeignKey(
                        name: "FK_СurriculumTopicDepartmens_CuriculumTopics_CurriculumTopicId",
                        column: x => x.CurriculumTopicId,
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

            migrationBuilder.CreateIndex(
                name: "IX_Groups_DepartmensId",
                table: "Groups",
                column: "DepartmensId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicConsultationTopics_ConsultationTopicsId",
                table: "СurriculumTopicConsultationTopics",
                column: "ConsultationTopicsId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicDepartmens_DepartmensId",
                table: "СurriculumTopicDepartmens",
                column: "DepartmensId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTheQuestions_TheQuestionsId",
                table: "СurriculumTopicTheQuestions",
                column: "TheQuestionsId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTranningProgram_TranningProgramId",
                table: "СurriculumTopicTranningProgram",
                column: "TranningProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Departmens_DepartmensId",
                table: "Groups",
                column: "DepartmensId",
                principalTable: "Departmens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
