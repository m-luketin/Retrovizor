﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Retrovizor.Data.Entities;

namespace Retrovizor.Data.Migrations
{
    [DbContext(typeof(RetrovizorContext))]
    [Migration("20190804063117_ChangedPropNames")]
    partial class ChangedPropNames
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrivingSchoolId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DrivingSchoolId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("TotalLessons");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.DrivingSchool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("DrivingSchools");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndsAt");

                    b.Property<int>("LocationId");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartsAt");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PointsToPass");

                    b.Property<int>("TotalPoints");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrivingSchoolId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int?>("UserId");

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("DrivingSchoolId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.HasIndex("VehicleId");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InstructorId");

                    b.Property<string>("ReviewText");

                    b.Property<int>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.HasIndex("StudentId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<int>("DrivingSchoolId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DrivingSchoolId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.StudentClass", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("ClassId");

                    b.Property<int>("CurrentLesson");

                    b.HasKey("StudentId", "ClassId");

                    b.HasIndex("ClassId");

                    b.ToTable("StudentClasses");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.StudentEvent", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("EventId");

                    b.HasKey("StudentId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("StudentEvents");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.StudentExam", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("ExamId");

                    b.Property<DateTime>("DateTaken");

                    b.Property<int>("Points");

                    b.HasKey("StudentId", "ExamId", "DateTaken");

                    b.HasIndex("ExamId");

                    b.ToTable("StudentExams");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DrivingSchoolId");

                    b.Property<string>("OIB");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("Role");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("DrivingSchoolId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FuelType");

                    b.Property<string>("Image");

                    b.Property<string>("LicensePlate");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Model");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.VehicleSession", b =>
                {
                    b.Property<int>("VehicleId");

                    b.Property<int>("StudentId");

                    b.Property<int>("InstructorId");

                    b.Property<DateTime>("DateAssigned");

                    b.Property<bool>("IsActive");

                    b.HasKey("VehicleId", "StudentId", "InstructorId", "DateAssigned");

                    b.HasIndex("InstructorId");

                    b.HasIndex("StudentId");

                    b.ToTable("VehicleSessions");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Admin", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.DrivingSchool")
                        .WithMany("Admins")
                        .HasForeignKey("DrivingSchoolId");

                    b.HasOne("Retrovizor.Data.Entities.Models.User", "User")
                        .WithOne("Admin")
                        .HasForeignKey("Retrovizor.Data.Entities.Models.Admin", "UserId");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Event", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.Location", "Location")
                        .WithMany("Events")
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Instructor", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.DrivingSchool")
                        .WithMany("Instructors")
                        .HasForeignKey("DrivingSchoolId");

                    b.HasOne("Retrovizor.Data.Entities.Models.User", "User")
                        .WithOne("Instructor")
                        .HasForeignKey("Retrovizor.Data.Entities.Models.Instructor", "UserId");

                    b.HasOne("Retrovizor.Data.Entities.Models.Vehicle", "Vehicle")
                        .WithMany("Instructors")
                        .HasForeignKey("VehicleId");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.RefreshToken", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Review", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.Instructor", "Instructor")
                        .WithMany("Reviews")
                        .HasForeignKey("InstructorId");

                    b.HasOne("Retrovizor.Data.Entities.Models.Student", "Student")
                        .WithMany("Reviews")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Student", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.DrivingSchool")
                        .WithMany("Students")
                        .HasForeignKey("DrivingSchoolId");

                    b.HasOne("Retrovizor.Data.Entities.Models.User", "User")
                        .WithOne("Student")
                        .HasForeignKey("Retrovizor.Data.Entities.Models.Student", "UserId");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.StudentClass", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.Class", "Class")
                        .WithMany("StudentClasses")
                        .HasForeignKey("ClassId");

                    b.HasOne("Retrovizor.Data.Entities.Models.Student", "Student")
                        .WithMany("StudentClasses")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.StudentEvent", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.Event", "Event")
                        .WithMany("StudentEvents")
                        .HasForeignKey("EventId");

                    b.HasOne("Retrovizor.Data.Entities.Models.Student", "Student")
                        .WithMany("StudentEvents")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.StudentExam", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.Exam", "Exam")
                        .WithMany("StudentExams")
                        .HasForeignKey("ExamId");

                    b.HasOne("Retrovizor.Data.Entities.Models.Student", "Student")
                        .WithMany("StudentExams")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.User", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.DrivingSchool", "DrivingSchool")
                        .WithMany("Users")
                        .HasForeignKey("DrivingSchoolId");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.VehicleSession", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.Instructor", "Instructor")
                        .WithMany("VehicleSessions")
                        .HasForeignKey("InstructorId");

                    b.HasOne("Retrovizor.Data.Entities.Models.Student", "Student")
                        .WithMany("VehicleSessions")
                        .HasForeignKey("StudentId");

                    b.HasOne("Retrovizor.Data.Entities.Models.Vehicle", "Vehicle")
                        .WithMany("VehicleSessions")
                        .HasForeignKey("VehicleId");
                });
#pragma warning restore 612, 618
        }
    }
}
