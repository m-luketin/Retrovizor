using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Retrovizor.Data.Migrations
{
    public partial class SeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Classes");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Questions",
                nullable: true);

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
                columns: new[] { "Id", "Image", "Text", "Type" },
                values: new object[,]
                {
                    { 20, "", "Za sto se upotrebljava kompresivni zavoj?", "Prva pomoc" },
                    { 19, "", "Koja je uloga imobilizacije?", "Prva pomoc" },
                    { 18, "", "Sto je macje oko?", "Prva pomoc" },
                    { 17, "", "Koje su karakteristike venskog krvarenja?", "Prva pomoc" },
                    { 16, "", "Koji je normalan ljudski ritam otkucaja srca?", "Prva pomoc" },
                    { 15, "", "Koji je prvi postupak s ozlijedenim kod udara struje?", "Prva pomoc" },
                    { 14, "", "Sto alkohol izaziva?", "Prva pomoc" },
                    { 13, "", "Koji je ljudski ritam normalnog disanja?", "Prva pomoc" },
                    { 12, "", "Ozlijedenu osobu koja je dozivjela epilepticki napadaj stavljamo u koju poziciju?", "Prva pomoc" },
                    { 11, "", "Koji plin se oslobađa pri izgaranju benzina, a koji u zatvorenom prostoru može izazvati smrt?", "Prva pomoc" },
                    { 6, "", "Sto se podrazumijeva pod svjetlosnim znakovima upozorenja u prometu?", "Propisi" },
                    { 9, "", "Kako se na semaforu moze pojaviti zuto svjetlo?", "Propisi" },
                    { 8, "", "Koja je uloga parkirne kocnice na motornom vozilu?", "Propisi" },
                    { 7, "", "Sto vozac mora stalno pratiti za vrijeme voznje?", "Propisi" },
                    { 5, "", "Kako vozac daje svjetlosni znak upozorenja ostalim sudionicima u prometu?", "Propisi" },
                    { 4, "", "Sto je najveca dopustena masa vozila?", "Propisi" },
                    { 3, "", "Sto je motorno vozilo?", "Propisi" },
                    { 2, "", "Kad vozac reagira brze?", "Propisi" },
                    { 1, "", "U kojim ce uvjetima prijanjanje guma na cesti biti smanjeno?", "Propisi" },
                    { 10, "", "Sto je prestrojavanje?", "Propisi" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "FuelType", "Image", "LicensePlate", "Manufacturer", "Model", "Type" },
                values: new object[,]
                {
                    { 3, "Diesel", "", "ST-500-FB", "Renault", "Megane III", "Car" },
                    { 1, "Gasoline", "", "ST-200-OK", "Volkswagen", "Golf 7", "Car" },
                    { 2, "Gasoline", "", "ST-404-NF", "Mercedes", "A Class", "Car" },
                    { 4, "Gasoline", "", "ST-408-TO", "Kawasaki", "ZZR", "Motorcycle" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "DrivingSchoolId", "Password", "Username" },
                values: new object[,]
                {
                    { 1, 1, "", "Duje" },
                    { 2, 1, "", "Kreso" },
                    { 3, 2, "", "Drazen" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 38, false, 14, "Ubrzavanje refleksa" },
                    { 37, false, 13, "12 do 20 puta na dan" },
                    { 36, true, 13, "12-20 puta u jednoj minuti" },
                    { 35, false, 13, "14-16 puta na sat" },
                    { 34, false, 12, "Polulezeci polozaj" },
                    { 33, false, 12, "Polusjedeci polozaj" },
                    { 32, true, 12, "Bocni polozaj" },
                    { 30, false, 11, "Duhanski dim" },
                    { 39, false, 14, "Povecanje koncentracije i moci pamcenja" },
                    { 29, true, 11, "Ugljikov monoksid" },
                    { 28, false, 10, "Prolazenje vozilom pokraj drugog vozila koje se krece u istom smjeru" },
                    { 27, true, 10, "Zauzimanje takvog polozaja vozilom na prometnoj traci iz kojeg se moze na siguran nacin izvesti naredna radnja s vozilom" },
                    { 26, false, 10, "Prelazenje vozilom iz jedne u drugu prometnu traku radi brzega kretanja" },
                    { 25, true, 9, "Kao samostalno svjetlo" },
                    { 24, false, 9, "Zajedno sa crvenim svjetlom prije pojave zelenog svjetla" },
                    { 31, false, 11, "Natrijev klorid" },
                    { 40, true, 14, "Pospanost i jako usporavanje refleksa" },
                    { 42, true, 15, "Ukloniti izvor struje ili isključiti osigurač" },
                    { 23, true, 9, "Zajedno sa zelenim svjetlom prije pojave crvenog svjetla" },
                    { 58, true, 20, "Kad zelimo zaustaviti krvarenje" },
                    { 57, false, 20, "Za imobilizaciju prijeloma" },
                    { 56, false, 20, "Za teske opekotine" },
                    { 55, false, 19, "Sprjecavanje dodatnih povreda kod ozlijedjenog" },
                    { 54, false, 19, "Sprjecavanje povrijedenog od izvodenja sportskih aktivnosti" },
                    { 53, false, 19, "Pojacavanje boli kod povrijedenog" },
                    { 52, false, 18, "Mačka na cesti" },
                    { 41, false, 15, "Povrijeđenog zakopati u zemlju da bi zemlja izvukla struju" },
                    { 51, false, 18, "Vrsta raskrizja" },
                    { 49, false, 17, "Izlazi u mlazevima i tamno-crne je boje" },
                    { 48, false, 17, "Veoma teško se zaustavlja" },
                    { 47, true, 17, "Krv je tamno-crvene boje i ravnomjerno curi preko ruba rane" },
                    { 46, false, 16, "60-80 otkucaja u jednoj sekundi" },
                    { 45, true, 16, "60-80 otkucaja u jednoj minuti" },
                    { 44, false, 16, "60-80 otkucaja u jednom satu" },
                    { 43, false, 15, "Odmah započeti sa oživljavanjem ili reanimacijom" },
                    { 50, true, 18, "Jedan od sigurnih znakova smrti" },
                    { 22, false, 8, "Osigurati bolje kocenje na mokrom kolniku" },
                    { 21, false, 8, "Sprijeciti zanosenje vozila prilikom nagloga kocenja" },
                    { 20, true, 8, "Osigurati vozilo u zakocenom polozaju" },
                    { 1, true, 1, "Ako je cesta mokra" },
                    { 2, false, 1, "Ako je cesta s nepreglednim dionicama" },
                    { 3, true, 1, "Ako je cesta prekrivena snijegom" },
                    { 4, true, 2, "Kad posjeduje potrebne vjestine" },
                    { 5, false, 2, "Kad je umoran" },
                    { 6, false, 2, "Kad je pod utjecajem alkohola ili droga" },
                    { 7, true, 3, "Svako vozilo koje se pokrece snagom vlastitog motora, osim vozila koja se krecu po tracnicama" },
                    { 8, false, 3, "Svako prijevozno sredstvo namijenjeno za kretanje po cesti" },
                    { 10, false, 4, "Masa vozila s teretom u vozilu ili na vozilu" },
                    { 9, true, 4, "Masa vozila zajedno s njegovom nosivoscu" },
                    { 12, true, 5, "Kratkim uzastopnim paljenjem dugih svjetala" },
                    { 13, true, 5, "Naizmjenicnim paljenjem dugih i kratkih svjetala" },
                    { 14, false, 6, "Svjetla za maglu" },
                    { 15, true, 6, "Pokazivaci smjera" },
                    { 16, true, 6, "Stop-svjetla" },
                    { 17, true, 7, "Prometne uvjete na cesti kojom vozi" },
                    { 18, false, 7, "Jambo plakate" },
                    { 19, true, 7, "Kretanje ostalih sudionika u prometu" },
                    { 11, false, 5, "Paljenjem svih pokazivaca smjera" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "EndsAt", "LocationId", "Name", "StartsAt", "Type" },
                values: new object[,]
                {
                    { 3, new DateTime(2019, 8, 13, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Predavanje Propisi 3", new DateTime(2019, 8, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), "Propisi" },
                    { 1, new DateTime(2019, 8, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Predavanje Propisi 1", new DateTime(2019, 8, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "Propisi" },
                    { 2, new DateTime(2019, 8, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Predavanje Propisi 2", new DateTime(2019, 8, 12, 8, 0, 0, 0, DateTimeKind.Unspecified), "Propisi" },
                    { 4, new DateTime(2019, 8, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, "Predavanje Prva Pomoc 1", new DateTime(2019, 8, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), "Prva pomoc" },
                    { 9, new DateTime(2019, 8, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), 3, "Voznja", new DateTime(2019, 8, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), "Voznja" },
                    { 6, new DateTime(2019, 8, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, "Predavanje Prva Pomoc 3", new DateTime(2019, 8, 13, 9, 30, 0, 0, DateTimeKind.Unspecified), "Prva pomoc" },
                    { 7, new DateTime(2019, 8, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), 3, "Voznja", new DateTime(2019, 8, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), "Voznja" },
                    { 8, new DateTime(2019, 8, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, "Voznja", new DateTime(2019, 8, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "Voznja" },
                    { 5, new DateTime(2019, 8, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, "Predavanje Prva Pomoc 2", new DateTime(2019, 8, 12, 9, 30, 0, 0, DateTimeKind.Unspecified), "Prva pomoc" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "DrivingSchoolId", "FirstName", "LastName", "OIB", "Password", "PhoneNumber", "Username", "VehicleId" },
                values: new object[,]
                {
                    { 3, 1, "Zvonimir", "Delas", "12345123453", "", "00385976086801", "ZDelas", 3 },
                    { 1, 1, "Izabela", "Domazet", "12345123451", "", "00385976086801", "IDomazet", 1 },
                    { 2, 1, "Mario", "Ceprnja", "12345123452", "", "00385976086801", "MCeprnja", 2 },
                    { 4, 2, "Josip", "Svalina", "12345123454", "", "00385976086801", "JSvalina", 4 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Category", "DrivingSchoolId", "FirstName", "LastName", "OIB", "Password", "PhoneNumber", "Username" },
                values: new object[,]
                {
                    { 8, "A", 2, "Ante", "Vuletic", "12345123468", "", "00385976086801", "AVuletic" },
                    { 7, "B", 2, "Alex", "Amanzi", "12345123467", "", "00385976086801", "AAmanzi" },
                    { 6, "", 1, "Petra", "Condic", "12345123466", "B", "00385976086801", "PCondic" },
                    { 5, "B", 1, "Klara Bruna", "Tomic", "12345123465", "", "00385976086801", "KTomic" },
                    { 4, "A2", 1, "Luka", "Bendic", "12345123464", "", "00385976086801", "LBendic" },
                    { 3, "B", 1, "Nino", "Borovic", "12345123463", "", "00385976086801", "NBorovic" },
                    { 2, "B", 1, "Luka", "Nola", "12345123462", "", "00385976086801", "LNola" },
                    { 1, "A1", 1, "Matija", "Luketin", "12345123461", "", "00385976086801", "MLuketin" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "InstructorId", "ReviewText", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, null, 1 },
                    { 2, 2, null, 2 },
                    { 6, 4, null, 8 },
                    { 5, 4, null, 7 },
                    { 3, 3, null, 3 },
                    { 4, 2, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "StudentId", "ClassId", "CurrentLesson" },
                values: new object[,]
                {
                    { 1, 1, 5 },
                    { 8, 1, 5 },
                    { 7, 2, 5 },
                    { 7, 1, 5 },
                    { 6, 2, 5 },
                    { 6, 1, 5 },
                    { 5, 2, 5 },
                    { 8, 2, 5 },
                    { 4, 2, 10 },
                    { 4, 1, 15 },
                    { 3, 2, 10 },
                    { 3, 1, 15 },
                    { 2, 2, 5 },
                    { 2, 1, 5 },
                    { 1, 2, 5 },
                    { 5, 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "StudentEvents",
                columns: new[] { "StudentId", "EventId" },
                values: new object[,]
                {
                    { 6, 4 },
                    { 7, 4 },
                    { 8, 4 },
                    { 1, 5 },
                    { 2, 5 },
                    { 5, 5 },
                    { 6, 5 },
                    { 2, 6 },
                    { 8, 5 },
                    { 1, 6 },
                    { 5, 6 },
                    { 6, 6 },
                    { 7, 6 },
                    { 8, 6 },
                    { 5, 4 },
                    { 7, 5 },
                    { 2, 4 },
                    { 2, 3 },
                    { 8, 3 },
                    { 1, 1 },
                    { 2, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 1, 4 },
                    { 8, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 7, 1 },
                    { 6, 2 },
                    { 5, 2 },
                    { 6, 3 },
                    { 5, 3 },
                    { 7, 3 },
                    { 1, 3 },
                    { 8, 2 },
                    { 7, 2 }
                });

            migrationBuilder.InsertData(
                table: "StudentExams",
                columns: new[] { "StudentId", "ExamId", "DateTaken", "Points" },
                values: new object[,]
                {
                    { 4, 2, new DateTime(2019, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 4, 1, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 3, 2, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 55 },
                    { 3, 1, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 115 }
                });

            migrationBuilder.InsertData(
                table: "VehicleSessions",
                columns: new[] { "VehicleId", "StudentId", "InstructorId", "DateAssigned", "IsActive" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, 2, 2, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, 4, 2, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 3, 3, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 4, 8, 4, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 4, 7, 4, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });
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
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "StudentClasses",
                keyColumns: new[] { "StudentId", "ClassId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "StudentEvents",
                keyColumns: new[] { "StudentId", "EventId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "StudentExams",
                keyColumns: new[] { "StudentId", "ExamId", "DateTaken" },
                keyValues: new object[] { 3, 1, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "StudentExams",
                keyColumns: new[] { "StudentId", "ExamId", "DateTaken" },
                keyValues: new object[] { 3, 2, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "StudentExams",
                keyColumns: new[] { "StudentId", "ExamId", "DateTaken" },
                keyValues: new object[] { 4, 1, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "StudentExams",
                keyColumns: new[] { "StudentId", "ExamId", "DateTaken" },
                keyValues: new object[] { 4, 2, new DateTime(2019, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "VehicleSessions",
                keyColumns: new[] { "VehicleId", "StudentId", "InstructorId", "DateAssigned" },
                keyValues: new object[] { 1, 1, 1, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "VehicleSessions",
                keyColumns: new[] { "VehicleId", "StudentId", "InstructorId", "DateAssigned" },
                keyValues: new object[] { 2, 2, 2, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "VehicleSessions",
                keyColumns: new[] { "VehicleId", "StudentId", "InstructorId", "DateAssigned" },
                keyValues: new object[] { 2, 4, 2, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "VehicleSessions",
                keyColumns: new[] { "VehicleId", "StudentId", "InstructorId", "DateAssigned" },
                keyValues: new object[] { 3, 3, 3, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "VehicleSessions",
                keyColumns: new[] { "VehicleId", "StudentId", "InstructorId", "DateAssigned" },
                keyValues: new object[] { 4, 7, 4, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "VehicleSessions",
                keyColumns: new[] { "VehicleId", "StudentId", "InstructorId", "DateAssigned" },
                keyValues: new object[] { 4, 8, 4, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DrivingSchools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DrivingSchools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Classes",
                nullable: true);
        }
    }
}
