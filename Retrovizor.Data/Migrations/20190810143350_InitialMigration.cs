using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Retrovizor.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TotalLessons = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DrivingSchools",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrivingSchools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TotalPoints = table.Column<int>(nullable: false),
                    PointsToPass = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Manufacturer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    FuelType = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    LicensePlate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

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
                    DrivingSchoolId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    LocationId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    StartsAt = table.Column<DateTime>(nullable: false),
                    EndsAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true),
                    QuestionId = table.Column<int>(nullable: false),
                    IsCorrect = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    VehicleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Instructors_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstructorId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    ReviewText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentClasses",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    ClassId = table.Column<int>(nullable: false),
                    CurrentLesson = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClasses", x => new { x.StudentId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_StudentClasses_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentClasses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentEvents",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEvents", x => new { x.StudentId, x.EventId });
                    table.ForeignKey(
                        name: "FK_StudentEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentEvents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentExams",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    ExamId = table.Column<int>(nullable: false),
                    DateTaken = table.Column<DateTime>(nullable: false),
                    Points = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentExams", x => new { x.StudentId, x.ExamId, x.DateTaken });
                    table.ForeignKey(
                        name: "FK_StudentExams_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentExams_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VehicleSessions",
                columns: table => new
                {
                    InstructorId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    VehicleId = table.Column<int>(nullable: false),
                    DateAssigned = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleSessions", x => new { x.VehicleId, x.StudentId, x.InstructorId, x.DateAssigned });
                    table.ForeignKey(
                        name: "FK_VehicleSessions_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VehicleSessions_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VehicleSessions_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name", "TotalLessons" },
                values: new object[,]
                {
                    { 1, "Propisi", 15 },
                    { 2, "Prva pomoc", 10 },
                    { 3, "Voznja B", 35 },
                    { 4, "Voznja A1", 20 },
                    { 5, "Voznja A2", 25 }
                });

            migrationBuilder.InsertData(
                table: "DrivingSchools",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "Dubrovacka 34", "Sprint" },
                    { 2, "Vukovarska 59", "Golf" }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "PointsToPass", "TotalPoints", "Type" },
                values: new object[,]
                {
                    { 1, 108, 120, "Propisi" },
                    { 2, 40, 60, "Prva pomoc" },
                    { 3, 50, 100, "Voznja" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { 3, "Solinska ulica", 43.523219900000001, 16.462575600000001 },
                    { 2, "Vukovarska 59", 43.511376300000002, 16.447716799999998 },
                    { 1, "Dubrovacka 34", 43.519500000000001, 16.449399999999969 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Picture", "Text", "Type" },
                values: new object[,]
                {
                    { 20, null, "Za sto se upotrebljava kompresivni zavoj?", "Prva pomoc" },
                    { 19, null, "Koja je uloga imobilizacije?", "Prva pomoc" },
                    { 18, null, "Sto je macje oko?", "Prva pomoc" },
                    { 17, null, "Koje su karakteristike venskog krvarenja?", "Prva pomoc" },
                    { 16, null, "Koji je normalan ljudski ritam otkucaja srca?", "Prva pomoc" },
                    { 15, null, "Koji je prvi postupak s ozlijedenim kod udara struje?", "Prva pomoc" },
                    { 14, null, "Sto alkohol izaziva?", "Prva pomoc" },
                    { 13, null, "Koji je ljudski ritam normalnog disanja?", "Prva pomoc" },
                    { 12, null, "Ozlijedenu osobu koja je dozivjela epilepticki napadaj stavljamo u koju poziciju?", "Prva pomoc" },
                    { 11, null, "Koji plin se oslobađa pri izgaranju benzina, a koji u zatvorenom prostoru može izazvati smrt?", "Prva pomoc" },
                    { 6, null, "Sto se podrazumijeva pod svjetlosnim znakovima upozorenja u prometu?", "Propisi" },
                    { 9, null, "Kako se na semaforu moze pojaviti zuto svjetlo?", "Propisi" },
                    { 8, null, "Koja je uloga parkirne kocnice na motornom vozilu?", "Propisi" },
                    { 7, null, "Sto vozac mora stalno pratiti za vrijeme voznje?", "Propisi" },
                    { 5, null, "Kako vozac daje svjetlosni znak upozorenja ostalim sudionicima u prometu?", "Propisi" },
                    { 4, null, "Sto je najveca dopustena masa vozila?", "Propisi" },
                    { 3, null, "Sto je motorno vozilo?", "Propisi" },
                    { 2, null, "Kad vozac reagira brze?", "Propisi" },
                    { 1, null, "U kojim ce uvjetima prijanjanje guma na cesti biti smanjeno?", "Propisi" },
                    { 10, null, "Sto je prestrojavanje?", "Propisi" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "FuelType", "LicensePlate", "Manufacturer", "Model", "Picture", "Type", "Year" },
                values: new object[,]
                {
                    { 3, "Diesel", "ST-500-FB", "Renault", "Megane III", null, "Car", 2018 },
                    { 1, "Gasoline", "ST-200-OK", "Volkswagen", "Golf 7", null, "Car", 2015 },
                    { 2, "Gasoline", "ST-404-NF", "Mercedes", "A Class", null, "Car", 2017 },
                    { 4, "Gasoline", "ST-408-TO", "Kawasaki", "ZZR", null, "Motorcycle", 2016 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 17, true, 7, "Prometne uvjete na cesti kojom vozi" },
                    { 35, false, 13, "14-16 puta na sat" },
                    { 34, false, 12, "Polulezeci polozaj" },
                    { 33, false, 12, "Polusjedeci polozaj" },
                    { 32, true, 12, "Bocni polozaj" },
                    { 31, false, 11, "Natrijev klorid" },
                    { 30, false, 11, "Duhanski dim" },
                    { 29, true, 11, "Ugljikov monoksid" },
                    { 36, true, 13, "12-20 puta u jednoj minuti" },
                    { 28, false, 10, "Prolazenje vozilom pokraj drugog vozila koje se krece u istom smjeru" },
                    { 26, false, 10, "Prelazenje vozilom iz jedne u drugu prometnu traku radi brzega kretanja" },
                    { 25, true, 9, "Kao samostalno svjetlo" },
                    { 24, false, 9, "Zajedno sa crvenim svjetlom prije pojave zelenog svjetla" },
                    { 23, true, 9, "Zajedno sa zelenim svjetlom prije pojave crvenog svjetla" },
                    { 22, false, 8, "Osigurati bolje kocenje na mokrom kolniku" },
                    { 21, false, 8, "Sprijeciti zanosenje vozila prilikom nagloga kocenja" },
                    { 20, true, 8, "Osigurati vozilo u zakocenom polozaju" },
                    { 27, true, 10, "Zauzimanje takvog polozaja vozilom na prometnoj traci iz kojeg se moze na siguran nacin izvesti naredna radnja s vozilom" },
                    { 37, false, 13, "12 do 20 puta na dan" },
                    { 38, false, 14, "Ubrzavanje refleksa" },
                    { 39, false, 14, "Povecanje koncentracije i moci pamcenja" },
                    { 56, false, 20, "Za teske opekotine" },
                    { 55, false, 19, "Sprjecavanje dodatnih povreda kod ozlijedjenog" },
                    { 54, false, 19, "Sprjecavanje povrijedenog od izvodenja sportskih aktivnosti" },
                    { 53, false, 19, "Pojacavanje boli kod povrijedenog" },
                    { 52, false, 18, "Mačka na cesti" },
                    { 51, false, 18, "Vrsta raskrizja" },
                    { 50, true, 18, "Jedan od sigurnih znakova smrti" },
                    { 49, false, 17, "Izlazi u mlazevima i tamno-crne je boje" },
                    { 48, false, 17, "Veoma teško se zaustavlja" },
                    { 47, true, 17, "Krv je tamno-crvene boje i ravnomjerno curi preko ruba rane" },
                    { 46, false, 16, "60-80 otkucaja u jednoj sekundi" },
                    { 45, true, 16, "60-80 otkucaja u jednoj minuti" },
                    { 44, false, 16, "60-80 otkucaja u jednom satu" },
                    { 43, false, 15, "Odmah započeti sa oživljavanjem ili reanimacijom" },
                    { 42, true, 15, "Ukloniti izvor struje ili isključiti osigurač" },
                    { 41, false, 15, "Povrijeđenog zakopati u zemlju da bi zemlja izvukla struju" },
                    { 40, true, 14, "Pospanost i jako usporavanje refleksa" },
                    { 19, true, 7, "Kretanje ostalih sudionika u prometu" },
                    { 18, false, 7, "Jambo plakate" },
                    { 58, true, 20, "Kad zelimo zaustaviti krvarenje" },
                    { 16, true, 6, "Stop-svjetla" },
                    { 1, true, 1, "Ako je cesta mokra" },
                    { 2, false, 1, "Ako je cesta s nepreglednim dionicama" },
                    { 3, true, 1, "Ako je cesta prekrivena snijegom" },
                    { 4, true, 2, "Kad posjeduje potrebne vjestine" },
                    { 5, false, 2, "Kad je umoran" },
                    { 7, true, 3, "Svako vozilo koje se pokrece snagom vlastitog motora, osim vozila koja se krecu po tracnicama" },
                    { 8, false, 3, "Svako prijevozno sredstvo namijenjeno za kretanje po cesti" },
                    { 6, false, 2, "Kad je pod utjecajem alkohola ili droga" },
                    { 10, false, 4, "Masa vozila s teretom u vozilu ili na vozilu" },
                    { 11, false, 5, "Paljenjem svih pokazivaca smjera" },
                    { 12, true, 5, "Kratkim uzastopnim paljenjem dugih svjetala" },
                    { 13, true, 5, "Naizmjenicnim paljenjem dugih i kratkih svjetala" },
                    { 14, false, 6, "Svjetla za maglu" },
                    { 15, true, 6, "Pokazivaci smjera" },
                    { 9, true, 4, "Masa vozila zajedno s njegovom nosivoscu" },
                    { 57, false, 20, "Za imobilizaciju prijeloma" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "EndsAt", "LocationId", "Name", "StartsAt", "Type" },
                values: new object[,]
                {
                    { 4, new DateTime(2019, 8, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, "Predavanje Prva Pomoc 1", new DateTime(2019, 8, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), "Prva pomoc" },
                    { 1, new DateTime(2019, 8, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Predavanje Propisi 1", new DateTime(2019, 8, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "Propisi" },
                    { 2, new DateTime(2019, 8, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Predavanje Propisi 2", new DateTime(2019, 8, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), "Propisi" },
                    { 3, new DateTime(2019, 8, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Predavanje Propisi 3", new DateTime(2019, 8, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), "Propisi" },
                    { 5, new DateTime(2019, 8, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, "Predavanje Prva Pomoc 2", new DateTime(2019, 8, 12, 9, 30, 0, 0, DateTimeKind.Unspecified), "Prva pomoc" },
                    { 7, new DateTime(2019, 8, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), 3, "Voznja", new DateTime(2019, 8, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), "Voznja" },
                    { 8, new DateTime(2019, 8, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, "Voznja", new DateTime(2019, 8, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "Voznja" },
                    { 9, new DateTime(2019, 8, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), 3, "Voznja", new DateTime(2019, 8, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), "Voznja" },
                    { 6, new DateTime(2019, 8, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, "Predavanje Prva Pomoc 3", new DateTime(2019, 8, 13, 9, 30, 0, 0, DateTimeKind.Unspecified), "Prva pomoc" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DrivingSchoolId", "OIB", "Password", "PhoneNumber", "Role", "Username" },
                values: new object[,]
                {
                    { 2, 1, null, "zaFUUQie8N96psne7PziMc24lTzDt+75t6MoUqCB83kwaSU6", null, 2, "Kreso" },
                    { 4, 1, "12345123451", "yxq0Ed+O2iWi98Toqah+BS75nkM7Z7+SXaoi/SPwsXkbVWHA", "00385976086801", 1, "IDomazet" },
                    { 5, 1, "12345123452", "wyWLW6MQdogtds5NSUP/NJhVcrUVFGDPk9zS58Nk3Xnykq/e", "00385976086801", 1, "MCeprnja" },
                    { 6, 1, "12345123453", "wnCehHvutg39CCPGSMSABgFA6dKxI1GS/TpYkgEArLBcv16O", "00385976086801", 1, "ZDelas" },
                    { 8, 1, "12345123461", "gIrZXsGJ1KwFWOkycqVaS1N7zAtxOwqVGYfJEkrOshKIPlwa", "00385976086801", 0, "MLuketin" },
                    { 9, 1, "12345123462", "4otiXl9sR1IrN1Oxk7JXw5b8jn5kcQ2GSKVvBriy4F0Ct72H", "00385976086801", 0, "LNola" },
                    { 11, 1, "12345123464", "e+5Zz+VgZHqNuaK5p8c/OGHpwlnO6zNTI89ouMxxy5fEja/P", "00385976086801", 0, "LBendic" },
                    { 12, 1, "12345123465", "oINRmcaSWlLomk6pbdtw9m7tBVjHzvsQvgm1lbGDiB713H0R", "00385976086801", 0, "KTomic" },
                    { 13, 1, "12345123466", "Ae5m6kB/XbEkj6vPzceoGLeguy7oVink9iK+smuifbgSQMlQ", "00385976086801", 0, "PCondic" },
                    { 3, 2, null, "CZ/N7zgZL4faI4Cp4pgd0/L98ZlWS2M6K+VhQf360Ywv2Vkh", null, 2, "Drazen" },
                    { 7, 2, "12345123454", "V+dugmSl5R+gGdUFn8fLVNMd3f67CAtoNaxYlCIi+aR4hn1b", "00385976086801", 1, "JSvalina" },
                    { 14, 2, "12345123467", "zEXK/8+DyNVCBICYavDmMnA4x7iT5AwMQkLVQBJSDeNwA1Ic", "00385976086801", 0, "AAmanzi" },
                    { 15, 2, "12345123468", "hQFfPhep54nqhqGES06j18OyU79CeUPrDK/iSEZdt4BhFzq+", "00385976086801", 0, "AVuletic" },
                    { 10, 1, "12345123463", "Q/2RZdW5Q3AwxcWIKlk4jGizvLawjC5kAU11YDL+1UKDQHFT", "00385976086801", 0, "NBorovic" },
                    { 1, 1, null, "NqSs3eyOEG9CA8AbO6GgIXjZOgqjAX6tJ0nq1WOOWAt9YnwY", null, 2, "Duje" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "FirstName", "LastName", "UserId", "VehicleId" },
                values: new object[,]
                {
                    { 1, "Izabela", "Domazet", 4, 1 },
                    { 2, "Mario", "Ceprnja", 5, 2 },
                    { 3, "Zvonimir", "Delas", 6, 3 },
                    { 4, "Josip", "Svalina", 7, 4 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Category", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 1, "A1", "Matija", "Luketin", 8 },
                    { 2, "B", "Luka", "Nola", 9 },
                    { 3, "B", "Nino", "Borovic", 10 },
                    { 4, "A2", "Luka", "Bendic", 11 },
                    { 5, "B", "Klara Bruna", "Tomic", 12 },
                    { 6, "B", "Petra", "Condic", 13 },
                    { 7, "B", "Alex", "Amanzi", 14 },
                    { 8, "A", "Ante", "Vuletic", 15 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "InstructorId", "ReviewText", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, null, 1 },
                    { 4, 2, null, 4 },
                    { 2, 2, null, 2 },
                    { 5, 4, null, 7 },
                    { 3, 3, null, 3 },
                    { 6, 4, null, 8 }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentId", "ClassId", "CurrentLesson" },
                values: new object[,]
                {
                    { 7, 1, 5 },
                    { 6, 2, 5 },
                    { 3, 1, 15 },
                    { 5, 1, 5 },
                    { 8, 1, 5 },
                    { 4, 2, 10 },
                    { 4, 1, 15 },
                    { 8, 2, 5 },
                    { 3, 2, 10 },
                    { 7, 2, 5 },
                    { 6, 1, 5 },
                    { 5, 2, 5 },
                    { 1, 1, 5 },
                    { 1, 2, 5 },
                    { 2, 2, 5 },
                    { 2, 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "StudentEvents",
                columns: new[] { "StudentId", "EventId" },
                values: new object[,]
                {
                    { 2, 6 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 1, 4 },
                    { 1, 3 },
                    { 1, 2 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 7, 5 },
                    { 6, 3 },
                    { 7, 6 },
                    { 1, 1 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 3 },
                    { 8, 4 },
                    { 8, 5 },
                    { 7, 4 },
                    { 6, 2 },
                    { 6, 1 },
                    { 1, 5 },
                    { 1, 6 },
                    { 5, 6 },
                    { 5, 5 },
                    { 5, 4 },
                    { 5, 3 },
                    { 5, 2 },
                    { 5, 1 },
                    { 8, 6 },
                    { 2, 4 },
                    { 2, 3 },
                    { 2, 5 },
                    { 2, 2 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "StudentExams",
                columns: new[] { "StudentId", "ExamId", "DateTaken", "Points" },
                values: new object[,]
                {
                    { 3, 1, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 115 },
                    { 3, 2, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 55 },
                    { 4, 2, new DateTime(2019, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 4, 1, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 }
                });

            migrationBuilder.InsertData(
                table: "VehicleSessions",
                columns: new[] { "VehicleId", "StudentId", "InstructorId", "DateAssigned", "IsActive" },
                values: new object[,]
                {
                    { 4, 7, 4, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, 4, 2, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 1, 1, 1, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, 2, 2, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 3, 3, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 4, 8, 4, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_LocationId",
                table: "Events",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_UserId",
                table: "Instructors",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_VehicleId",
                table: "Instructors",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_InstructorId",
                table: "Reviews",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_StudentId",
                table: "Reviews",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClasses_ClassId",
                table: "StudentClasses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentEvents_EventId",
                table: "StudentEvents",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentExams_ExamId",
                table: "StudentExams",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_DrivingSchoolId",
                table: "Users",
                column: "DrivingSchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleSessions_InstructorId",
                table: "VehicleSessions",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleSessions_StudentId",
                table: "VehicleSessions",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "StudentClasses");

            migrationBuilder.DropTable(
                name: "StudentEvents");

            migrationBuilder.DropTable(
                name: "StudentExams");

            migrationBuilder.DropTable(
                name: "VehicleSessions");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DrivingSchools");
        }
    }
}
