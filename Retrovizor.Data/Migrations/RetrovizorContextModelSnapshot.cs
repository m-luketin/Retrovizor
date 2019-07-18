﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Retrovizor.Data.Entities;

namespace Retrovizor.Data.Migrations
{
    [DbContext(typeof(RetrovizorContext))]
    partial class RetrovizorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("DrivingSchoolId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<int>("LocationId");

                    b.Property<DateTime>("Time");

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

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Username");

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("DrivingSchoolId");

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

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InstructorId");

                    b.Property<string>("ReviewText");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

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

                    b.Property<string>("OIB");

                    b.Property<string>("Param");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("DrivingSchoolId");

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

                    b.Property<int>("Points");

                    b.HasKey("StudentId", "ExamId", "Points");

                    b.HasIndex("ExamId");

                    b.ToTable("StudentExams");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.StudentInstructor", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<int>("InstructorId");

                    b.Property<DateTime>("DateAssigned");

                    b.HasKey("StudentId", "InstructorId", "DateAssigned");

                    b.HasIndex("InstructorId");

                    b.ToTable("StudentInstructors");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FuelType");

                    b.Property<string>("Image");

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

                    b.HasKey("VehicleId", "StudentId", "InstructorId", "DateAssigned");

                    b.HasIndex("InstructorId");

                    b.HasIndex("StudentId");

                    b.ToTable("VehicleSessions");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Admin", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.DrivingSchool", "DrivingSchool")
                        .WithMany("Administrators")
                        .HasForeignKey("DrivingSchoolId");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Event", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Instructor", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.DrivingSchool", "DrivingSchool")
                        .WithMany("Instructors")
                        .HasForeignKey("DrivingSchoolId");

                    b.HasOne("Retrovizor.Data.Entities.Models.Vehicle", "Vehicle")
                        .WithMany("Instructors")
                        .HasForeignKey("VehicleId");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Review", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.Instructor", "Instructor")
                        .WithMany("Reviews")
                        .HasForeignKey("InstructorId");
                });

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.Student", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.DrivingSchool", "DrivingSchool")
                        .WithMany("Students")
                        .HasForeignKey("DrivingSchoolId");
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

            modelBuilder.Entity("Retrovizor.Data.Entities.Models.StudentInstructor", b =>
                {
                    b.HasOne("Retrovizor.Data.Entities.Models.Instructor", "Instructor")
                        .WithMany("StudentInstructors")
                        .HasForeignKey("InstructorId");

                    b.HasOne("Retrovizor.Data.Entities.Models.Student", "Student")
                        .WithMany("StudentInstructors")
                        .HasForeignKey("StudentId");
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
