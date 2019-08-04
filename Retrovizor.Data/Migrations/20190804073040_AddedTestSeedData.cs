using Microsoft.EntityFrameworkCore.Migrations;

namespace Retrovizor.Data.Migrations
{
    public partial class AddedTestSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DrivingSchools",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 1, "Solinska 5", "Semafor" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "FuelType", "Image", "LicensePlate", "Manufacturer", "Model", "Type" },
                values: new object[] { 1, "Dizel", "vehicle.jpg", "ML4422", "Golf", "VII", "Type" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DrivingSchoolId", "OIB", "Password", "PhoneNumber", "Role", "Username" },
                values: new object[] { 1, 1, "123456789", "NqSs3eyOEG9CA8AbO6GgIXjZOgqjAX6tJ0nq1WOOWAt9YnwY", "0921112222", 2, "nborovic" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DrivingSchoolId", "OIB", "Password", "PhoneNumber", "Role", "Username" },
                values: new object[] { 2, 1, "987654321", "zaFUUQie8N96psne7PziMc24lTzDt+75t6MoUqCB83kwaSU6", "0915559999", 1, "mluketin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DrivingSchoolId", "OIB", "Password", "PhoneNumber", "Role", "Username" },
                values: new object[] { 3, 1, "543216789", "CZ/N7zgZL4faI4Cp4pgd0/L98ZlWS2M6K+VhQf360Ywv2Vkh", "0982221111", 0, "lnola" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "FirstName", "LastName", "UserId", "VehicleId" },
                values: new object[] { 1, "Matija", "Luketin", 2, 1 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Category", "FirstName", "LastName", "UserId" },
                values: new object[] { 1, "B", "Luka", "Nola", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DrivingSchools",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
