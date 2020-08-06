﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using e.moiroServer.Models;

namespace e.moiroServer.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200806214513_manyToManyId")]
    partial class manyToManyId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.AdditionalLiterature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AdditionalLiteratures");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.ConsultationTopic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ConsultationTopics");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.CurriculumSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("SectionNumberId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SectionNumberId");

                    b.ToTable("CurriculumSections");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.CurriculumTopic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Annotation")
                        .HasColumnType("text");

                    b.Property<int>("ClassHours")
                        .HasColumnType("integer");

                    b.Property<int>("CurriculumSectionId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDistanceLearning")
                        .HasColumnType("boolean");

                    b.Property<int>("OccupationFormId")
                        .HasColumnType("integer");

                    b.Property<string>("TopicTitle")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CurriculumSectionId");

                    b.HasIndex("OccupationFormId");

                    b.ToTable("CurriculumTopics");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.FormOfEducation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FormOfEducations");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CalendarYear")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ClassEndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ClassStartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<int>("FormOfEducationId")
                        .HasColumnType("integer");

                    b.Property<int>("GroupNumber")
                        .HasColumnType("integer");

                    b.Property<int>("NumberOfHours")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherCategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("TheTopicOfContinuingEducation")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("FormOfEducationId");

                    b.HasIndex("TeacherCategoryId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.MainLiterature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MainLiteratures");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.OccupationForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<string>("ShortName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OccupationForms");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.SectionNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SectionNumbers");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsCathedral")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("TeachingPositionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TeachingPositionId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.TeacherCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TeacherCategories");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.TeachingPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TeachingPositions");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.TheQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TheQuestions");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.TrainingProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("TrainingPrograms");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicAdditionalLiterature", b =>
                {
                    b.Property<int>("CurriculumTopicId")
                        .HasColumnType("integer");

                    b.Property<int>("AdditionalLiteratureId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.HasKey("CurriculumTopicId", "AdditionalLiteratureId");

                    b.HasIndex("AdditionalLiteratureId");

                    b.ToTable("СurriculumTopicAdditionalLiterature");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicConsultationTopic", b =>
                {
                    b.Property<int>("CurriculumTopicId")
                        .HasColumnType("integer");

                    b.Property<int>("ConsultationTopicId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.HasKey("CurriculumTopicId", "ConsultationTopicId");

                    b.HasIndex("ConsultationTopicId");

                    b.ToTable("СurriculumTopicConsultationTopic");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicDepartment", b =>
                {
                    b.Property<int>("CurriculumTopicId")
                        .HasColumnType("integer");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.HasKey("CurriculumTopicId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("СurriculumTopicDepartment");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicMainLiterature", b =>
                {
                    b.Property<int>("CurriculumTopicId")
                        .HasColumnType("integer");

                    b.Property<int>("MainLiteratureId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.HasKey("CurriculumTopicId", "MainLiteratureId");

                    b.HasIndex("MainLiteratureId");

                    b.ToTable("СurriculumTopicMainLiterature");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicTeacher", b =>
                {
                    b.Property<int>("CurriculumTopicId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.HasKey("CurriculumTopicId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("СurriculumTopicTeacher");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicTeacherCategory", b =>
                {
                    b.Property<int>("CurriculumTopicId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherCategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.HasKey("CurriculumTopicId", "TeacherCategoryId");

                    b.HasIndex("TeacherCategoryId");

                    b.ToTable("СurriculumTopicTeacherCategory");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicTheQuestion", b =>
                {
                    b.Property<int>("CurriculumTopicId")
                        .HasColumnType("integer");

                    b.Property<int>("TheQuestionId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.HasKey("CurriculumTopicId", "TheQuestionId");

                    b.HasIndex("TheQuestionId");

                    b.ToTable("СurriculumTopicTheQuestion");
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicTrainingProgram", b =>
                {
                    b.Property<int>("CurriculumTopicId")
                        .HasColumnType("integer");

                    b.Property<int>("TrainingProgramId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.HasKey("CurriculumTopicId", "TrainingProgramId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("СurriculumTopicTrainingProgram");
                });

            modelBuilder.Entity("e.moiroServer.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Company")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("e.moiroServer.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("e.moiroServer.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("e.moiroServer.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e.moiroServer.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("e.moiroServer.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.CurriculumSection", b =>
                {
                    b.HasOne("e.moiroServer.Data.Models.SectionNumber", "SectionNumber")
                        .WithMany("CurriculumSections")
                        .HasForeignKey("SectionNumberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.CurriculumTopic", b =>
                {
                    b.HasOne("e.moiroServer.Data.Models.CurriculumSection", "CurriculumSection")
                        .WithMany("CurriculumTopics")
                        .HasForeignKey("CurriculumSectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e.moiroServer.Data.Models.OccupationForm", "OccupationForm")
                        .WithMany("CurriculumTopics")
                        .HasForeignKey("OccupationFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.Group", b =>
                {
                    b.HasOne("e.moiroServer.Data.Models.Department", "Department")
                        .WithMany("Groups")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e.moiroServer.Data.Models.FormOfEducation", "FormOfEducation")
                        .WithMany("Groups")
                        .HasForeignKey("FormOfEducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e.moiroServer.Data.Models.TeacherCategory", "TeacherCategory")
                        .WithMany("Groups")
                        .HasForeignKey("TeacherCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.Teacher", b =>
                {
                    b.HasOne("e.moiroServer.Data.Models.TeachingPosition", "TeachingPosition")
                        .WithMany("Teachers")
                        .HasForeignKey("TeachingPositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.TrainingProgram", b =>
                {
                    b.HasOne("e.moiroServer.Data.Models.Group", "Group")
                        .WithMany("TrainingPrograms")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicAdditionalLiterature", b =>
                {
                    b.HasOne("e.moiroServer.Data.Models.AdditionalLiterature", "AdditionalLiterature")
                        .WithMany("СurriculumTopicAdditionalLiteratures")
                        .HasForeignKey("AdditionalLiteratureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e.moiroServer.Data.Models.CurriculumTopic", "CurriculumTopic")
                        .WithMany("СurriculumTopicAdditionalLiteratures")
                        .HasForeignKey("CurriculumTopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicConsultationTopic", b =>
                {
                    b.HasOne("e.moiroServer.Data.Models.ConsultationTopic", "ConsultationTopics")
                        .WithMany("СurriculumTopicConsultationTopics")
                        .HasForeignKey("ConsultationTopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e.moiroServer.Data.Models.CurriculumTopic", "CurriculumTopic")
                        .WithMany("СurriculumTopicConsultationTopics")
                        .HasForeignKey("CurriculumTopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicDepartment", b =>
                {
                    b.HasOne("e.moiroServer.Data.Models.CurriculumTopic", "CurriculumTopic")
                        .WithMany("СurriculumTopicDepartments")
                        .HasForeignKey("CurriculumTopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e.moiroServer.Data.Models.Department", "Department")
                        .WithMany("СurriculumTopicDepartments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicMainLiterature", b =>
                {
                    b.HasOne("e.moiroServer.Data.Models.CurriculumTopic", "CurriculumTopic")
                        .WithMany("СurriculumTopicMainLiteratures")
                        .HasForeignKey("CurriculumTopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e.moiroServer.Data.Models.MainLiterature", "MainLiterature")
                        .WithMany("СurriculumTopicMainLiteratures")
                        .HasForeignKey("MainLiteratureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicTeacher", b =>
                {
                    b.HasOne("e.moiroServer.Data.Models.CurriculumTopic", "CurriculumTopic")
                        .WithMany("СurriculumTopicTeachers")
                        .HasForeignKey("CurriculumTopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e.moiroServer.Data.Models.Teacher", "Teacher")
                        .WithMany("СurriculumTopicTeachers")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicTeacherCategory", b =>
                {
                    b.HasOne("e.moiroServer.Data.Models.CurriculumTopic", "CurriculumTopic")
                        .WithMany("СurriculumTopicTeacherCategories")
                        .HasForeignKey("CurriculumTopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e.moiroServer.Data.Models.TeacherCategory", "TeacherCategory")
                        .WithMany("СurriculumTopicTeacherCategories")
                        .HasForeignKey("TeacherCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicTheQuestion", b =>
                {
                    b.HasOne("e.moiroServer.Data.Models.CurriculumTopic", "CurriculumTopic")
                        .WithMany("СurriculumTopicTheQuestions")
                        .HasForeignKey("CurriculumTopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e.moiroServer.Data.Models.TheQuestion", "TheQuestion")
                        .WithMany("СurriculumTopicTheQuestions")
                        .HasForeignKey("TheQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e.moiroServer.Data.Models.СurriculumTopicTrainingProgram", b =>
                {
                    b.HasOne("e.moiroServer.Data.Models.CurriculumTopic", "CurriculumTopic")
                        .WithMany("СurriculumTopicTrainingPrograms")
                        .HasForeignKey("CurriculumTopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e.moiroServer.Data.Models.TrainingProgram", "TrainingProgram")
                        .WithMany("СurriculumTopicTrainingPrograms")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
