using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Retrovizor.Data.Migrations
{
    public partial class RemovedStudentInstructors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentInstructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentExams",
                table: "StudentExams");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTaken",
                table: "StudentExams",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PointsToPass",
                table: "Exams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentExams",
                table: "StudentExams",
                columns: new[] { "StudentId", "ExamId", "DateTaken" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentExams",
                table: "StudentExams");

            migrationBuilder.DropColumn(
                name: "DateTaken",
                table: "StudentExams");

            migrationBuilder.DropColumn(
                name: "PointsToPass",
                table: "Exams");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentExams",
                table: "StudentExams",
                columns: new[] { "StudentId", "ExamId", "Points" });

            migrationBuilder.CreateTable(
                name: "StudentInstructors",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    InstructorId = table.Column<int>(nullable: false),
                    DateAssigned = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInstructors", x => new { x.StudentId, x.InstructorId, x.DateAssigned });
                    table.ForeignKey(
                        name: "FK_StudentInstructors_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentInstructors_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentInstructors_InstructorId",
                table: "StudentInstructors",
                column: "InstructorId");
        }
    }
}
