﻿// <auto-generated />
using System;
using EsafyCapcitacion.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EsafyCapcitacion.Migrations
{
    [DbContext(typeof(EsafyCapcitacionContext))]
    [Migration("20190525161255_2019052502")]
    partial class _2019052502
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EsafyCapcitacion.Models.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<int>("CourseTestId");

                    b.Property<DateTime>("Created");

                    b.Property<int?>("ExaminationId");

                    b.Property<DateTime>("Modified");

                    b.Property<int>("QuestionOptionId");

                    b.Property<int>("StudentId");

                    b.Property<int>("TestQuestionId");

                    b.HasKey("AnswerId");

                    b.HasIndex("ExaminationId");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.CapacitationClass", b =>
                {
                    b.Property<int>("CapacitationClassId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Modified");

                    b.HasKey("CapacitationClassId");

                    b.ToTable("CapacitationClass");
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.CapacitationPlan", b =>
                {
                    b.Property<int>("CapacitationPlanId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("Created");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("PlanName");

                    b.HasKey("CapacitationPlanId");

                    b.ToTable("CapacitationPlan");
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Modified");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CapacitationPlanId");

                    b.Property<string>("CourseName");

                    b.Property<string>("CourseShortName");

                    b.Property<DateTime>("Created");

                    b.Property<bool>("IsAvailable");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("SenceCode");

                    b.Property<string>("SenceTitle");

                    b.Property<int>("VerticalId");

                    b.HasKey("CourseId");

                    b.HasIndex("CapacitationPlanId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.CourseTest", b =>
                {
                    b.Property<int>("CourseTestId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<string>("CourseTestName");

                    b.Property<DateTime>("Created");

                    b.Property<bool>("IsAvailable");

                    b.Property<DateTime>("Modified");

                    b.HasKey("CourseTestId");

                    b.ToTable("CourseTest");
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.Examination", b =>
                {
                    b.Property<int>("ExaminationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<int>("CourseTestId");

                    b.Property<DateTime>("Created");

                    b.Property<int>("ExamState");

                    b.Property<DateTime>("Modified");

                    b.Property<int>("StudentId");

                    b.HasKey("ExaminationId");

                    b.ToTable("Examination");
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyId1");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ShortName");

                    b.HasKey("PersonId");

                    b.HasIndex("CompanyId1");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.QuestionOption", b =>
                {
                    b.Property<int>("QuestionOptionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<bool>("IsCorrectAns");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("QuestionText");

                    b.Property<int>("TestQuestionId");

                    b.HasKey("QuestionOptionId");

                    b.HasIndex("TestQuestionId");

                    b.ToTable("QuestionOption");
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.TestQuestion", b =>
                {
                    b.Property<int>("TestQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseTestId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("HeadingText");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("QuestionTitle");

                    b.Property<string>("SubHeadingText");

                    b.HasKey("TestQuestionId");

                    b.HasIndex("CourseTestId");

                    b.ToTable("TestQuestion");
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.Vertical", b =>
                {
                    b.Property<int>("VerticalId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("VerticalName");

                    b.HasKey("VerticalId");

                    b.ToTable("Vertical");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.Student", b =>
                {
                    b.HasBaseType("EsafyCapcitacion.Models.Person");

                    b.Property<int>("CompanyId");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.Answer", b =>
                {
                    b.HasOne("EsafyCapcitacion.Models.Examination")
                        .WithMany("AnswerList")
                        .HasForeignKey("ExaminationId");
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.Course", b =>
                {
                    b.HasOne("EsafyCapcitacion.Models.CapacitationPlan")
                        .WithMany("CourseList")
                        .HasForeignKey("CapacitationPlanId");
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.Person", b =>
                {
                    b.HasOne("EsafyCapcitacion.Models.Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId1");
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.QuestionOption", b =>
                {
                    b.HasOne("EsafyCapcitacion.Models.TestQuestion")
                        .WithMany("OptionList")
                        .HasForeignKey("TestQuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EsafyCapcitacion.Models.TestQuestion", b =>
                {
                    b.HasOne("EsafyCapcitacion.Models.CourseTest")
                        .WithMany("QuestionList")
                        .HasForeignKey("CourseTestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}