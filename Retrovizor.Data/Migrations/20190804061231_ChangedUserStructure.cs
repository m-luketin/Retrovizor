using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Retrovizor.Data.Migrations
{
    public partial class ChangedUserStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_Admins_AdminId",
                table: "RefreshTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_Instructors_InstructorId",
                table: "RefreshTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_Students_StudentId",
                table: "RefreshTokens");

            migrationBuilder.DropIndex(
                name: "IX_RefreshTokens_AdminId",
                table: "RefreshTokens");

            migrationBuilder.DropIndex(
                name: "IX_RefreshTokens_InstructorId",
                table: "RefreshTokens");

            migrationBuilder.DropColumn(
                name: "OIB",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "RefreshTokens");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "RefreshTokens");

            migrationBuilder.DropColumn(
                name: "OIB",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "RefreshTokens",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RefreshTokens_StudentId",
                table: "RefreshTokens",
                newName: "IX_RefreshTokens_UserId");

            migrationBuilder.AddColumn<int>(
                name: "CredentialsId",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CredentialsId",
                table: "Instructors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CredentialsId",
                table: "Admins",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    OIB = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false),
                    DrivingSchoolId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_DrivingSchools_DrivingSchoolId",
                        column: x => x.DrivingSchoolId,
                        principalTable: "DrivingSchools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_CredentialsId",
                table: "Students",
                column: "CredentialsId",
                unique: true,
                filter: "[CredentialsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_CredentialsId",
                table: "Instructors",
                column: "CredentialsId",
                unique: true,
                filter: "[CredentialsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_CredentialsId",
                table: "Admins",
                column: "CredentialsId",
                unique: true,
                filter: "[CredentialsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DrivingSchoolId",
                table: "Users",
                column: "DrivingSchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Users_CredentialsId",
                table: "Admins",
                column: "CredentialsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Users_CredentialsId",
                table: "Instructors",
                column: "CredentialsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_Users_UserId",
                table: "RefreshTokens",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_CredentialsId",
                table: "Students",
                column: "CredentialsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Users_CredentialsId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Users_CredentialsId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_Users_UserId",
                table: "RefreshTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_CredentialsId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Students_CredentialsId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_CredentialsId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Admins_CredentialsId",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "CredentialsId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CredentialsId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "CredentialsId",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "RefreshTokens",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                newName: "IX_RefreshTokens_StudentId");

            migrationBuilder.AddColumn<string>(
                name: "OIB",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "RefreshTokens",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "RefreshTokens",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OIB",
                table: "Instructors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Instructors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Instructors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Instructors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Admins",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Admins",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_AdminId",
                table: "RefreshTokens",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_InstructorId",
                table: "RefreshTokens",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_Admins_AdminId",
                table: "RefreshTokens",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_Instructors_InstructorId",
                table: "RefreshTokens",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_Students_StudentId",
                table: "RefreshTokens",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
