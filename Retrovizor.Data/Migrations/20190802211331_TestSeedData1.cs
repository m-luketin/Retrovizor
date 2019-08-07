using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Retrovizor.Data.Migrations
{
    public partial class TestSeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Events",
                newName: "StartsAt");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "VehicleSessions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndsAt",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "DrivingSchools",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 1, "Novakova 69", "Semafor" });

            migrationBuilder.InsertData(
                table: "DrivingSchools",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 2, "Solinska 420", "Spojka" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "FuelType", "Image", "LicensePlate", "Manufacturer", "Model", "Type" },
                values: new object[] { 1, "Dizel", "path/do/slike", "IB69420", "Golf", "VII", "Nez" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "DrivingSchoolId", "Password", "Username" },
                values: new object[,]
                {
                    { 1, 1, "lozinka", "mluketin" },
                    { 2, 2, "sifra", "lbendic" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "DrivingSchoolId", "FirstName", "LastName", "OIB", "Password", "PhoneNumber", "Username", "VehicleId" },
                values: new object[] { 1, 2, "Ivan", "Bartučević", "5135135135", "password", "987654321", "ibartucevic", 1 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Category", "DrivingSchoolId", "FirstName", "LastName", "OIB", "Password", "PhoneNumber", "Username" },
                values: new object[] { 1, "B", 1, "Klara Bruna", "Tomić", "35135135315", "kod", "123456789", "kbtomic" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DrivingSchools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DrivingSchools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "VehicleSessions");

            migrationBuilder.DropColumn(
                name: "EndsAt",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "StartsAt",
                table: "Events",
                newName: "Time");
        }
    }
}
