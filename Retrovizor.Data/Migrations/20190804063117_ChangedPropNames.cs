using Microsoft.EntityFrameworkCore.Migrations;

namespace Retrovizor.Data.Migrations
{
    public partial class ChangedPropNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Users_CredentialsId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Users_CredentialsId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_CredentialsId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CredentialsId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_CredentialsId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Admins_CredentialsId",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "CredentialsId",
                table: "Students",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CredentialsId",
                table: "Instructors",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CredentialsId",
                table: "Admins",
                newName: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_UserId",
                table: "Instructors",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Users_UserId",
                table: "Admins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Users_UserId",
                table: "Instructors",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_UserId",
                table: "Students",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Users_UserId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Users_UserId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_UserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_UserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_UserId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Admins_UserId",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Students",
                newName: "CredentialsId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Instructors",
                newName: "CredentialsId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Admins",
                newName: "CredentialsId");

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
                name: "FK_Students_Users_CredentialsId",
                table: "Students",
                column: "CredentialsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
