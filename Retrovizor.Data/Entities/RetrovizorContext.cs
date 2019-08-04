using Microsoft.EntityFrameworkCore;
using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Retrovizor.Data.Entities
{
    public class RetrovizorContext : DbContext
    {
        public RetrovizorContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<DrivingSchool> DrivingSchools { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<StudentEvent> StudentEvents { get; set; }
        public DbSet<StudentExam> StudentExams { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleSession> VehicleSessions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentExam>()
                .HasKey(se => new { se.StudentId, se.ExamId, se.DateTaken });
            modelBuilder.Entity<StudentClass>()
                .HasKey(sc => new { sc.StudentId, sc.ClassId });
            modelBuilder.Entity<StudentEvent>()
                .HasKey(se => new { se.StudentId, se.EventId });
            modelBuilder.Entity<VehicleSession>()
                .HasKey(vs => new { vs.VehicleId, vs.StudentId, vs.InstructorId, vs.DateAssigned });

            modelBuilder.Entity<StudentExam>()
                .HasOne(se => se.Student)
                .WithMany(se => se.StudentExams)
                .HasForeignKey(se => se.StudentId);
            modelBuilder.Entity<StudentExam>()
                .HasOne(se => se.Exam)
                .WithMany(se => se.StudentExams)
                .HasForeignKey(se => se.ExamId);
            
            modelBuilder.Entity<StudentClass>()
                .HasOne(sc => sc.Student)
                .WithMany(sc => sc.StudentClasses)
                .HasForeignKey(sc => sc.StudentId);
            modelBuilder.Entity<StudentClass>()
                .HasOne(sc => sc.Class)
                .WithMany(sc => sc.StudentClasses)
                .HasForeignKey(sc => sc.ClassId);

            modelBuilder.Entity<StudentEvent>()
                .HasOne(sc => sc.Student)
                .WithMany(sc => sc.StudentEvents)
                .HasForeignKey(sc => sc.StudentId);
            modelBuilder.Entity<StudentEvent>()
                .HasOne(sc => sc.Event)
                .WithMany(sc => sc.StudentEvents)
                .HasForeignKey(sc => sc.EventId);

            modelBuilder.Entity<VehicleSession>()
                .HasOne(sc => sc.Vehicle)
                .WithMany(sc => sc.VehicleSessions)
                .HasForeignKey(sc => sc.VehicleId);
            modelBuilder.Entity<VehicleSession>()
                .HasOne(sc => sc.Instructor)
                .WithMany(sc => sc.VehicleSessions)
                .HasForeignKey(sc => sc.InstructorId);
            modelBuilder.Entity<VehicleSession>()
                .HasOne(sc => sc.Student)
                .WithMany(sc => sc.VehicleSessions)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Instructor)
                .WithMany(r => r.Reviews)
                .HasForeignKey(r => r.InstructorId);
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Student)
                .WithMany(r => r.Reviews)
                .HasForeignKey(r => r.StudentId);
            
            // overriding default delete behaviour
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach(var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.ClientSetNull;

            modelBuilder.Entity<DrivingSchool>().HasData(
                new
                {
                    Id = 1,
                    Name = "Sprint",
                    Address = "Dubrovacka 34"
                },
                new
                {
                    Id = 2,
                    Name = "Golf",
                    Address = "Vukovarska 59"
                }
            );

            modelBuilder.Entity<Admin>().HasData(
                new
                {
                    Id = 1,
                    Username = "Duje",
                    Password = "",
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 2,
                    Username = "Kreso",
                    Password = "",
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 3,
                    Username = "Drazen",
                    Password = "",
                    DrivingSchoolId = 2
                }
            );

            modelBuilder.Entity<Instructor>().HasData(
                new
                {
                    Id = 1,
                    FirstName = "Izabela",
                    LastName = "Domazet",
                    Username = "IDomazet",
                    Password = "",
                    OIB = "12345123451",
                    PhoneNumber = "00385976086801",
                    VehicleId = 1,
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 2,
                    FirstName = "Mario",
                    LastName = "Ceprnja",
                    Username = "MCeprnja",
                    Password = "",
                    OIB = "12345123452",
                    PhoneNumber = "00385976086801",
                    VehicleId = 2,
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 3,
                    FirstName = "Zvonimir",
                    LastName = "Delas",
                    Username = "ZDelas",
                    Password = "",
                    OIB = "12345123453",
                    PhoneNumber = "00385976086801",
                    VehicleId = 3,
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 4,
                    FirstName = "Josip",
                    LastName = "Svalina",
                    Username = "JSvalina",
                    Password = "",
                    OIB = "12345123454",
                    PhoneNumber = "00385976086801",
                    VehicleId = 4,
                    DrivingSchoolId = 2
                }
            );

            modelBuilder.Entity<Student>().HasData(
                new
                {
                    Id = 1,
                    FirstName = "Matija",
                    LastName = "Luketin",
                    Username = "MLuketin",
                    Password = "",
                    OIB = "12345123461",
                    PhoneNumber = "00385976086801",
                    Category = "A1",
                    DrivingSchoolId = 0
                },
                new
                {
                    Id = 2,
                    FirstName = "Luka",
                    LastName = "Nola",
                    Username = "LNola",
                    Password = "",
                    OIB = "12345123462",
                    PhoneNumber = "00385976086801",
                    Category = "B",
                    DrivingSchoolId = 0
                },
                new
                {
                    Id = 3,
                    FirstName = "Nino",
                    LastName = "Borovic",
                    Username = "NBorovic",
                    Password = "",
                    OIB = "12345123463",
                    PhoneNumber = "00385976086801",
                    Category = "B",
                    DrivingSchoolId = 0
                },
                new
                {
                    Id = 4,
                    FirstName = "Luka",
                    LastName = "Bendic",
                    Username = "LBendic",
                    Password = "",
                    OIB = "12345123464",
                    PhoneNumber = "00385976086801",
                    Category = "A2",
                    DrivingSchoolId = 0
                },
                new
                {
                    Id = 5,
                    FirstName = "Klara Bruna",
                    LastName = "Tomic",
                    Username = "KTomic",
                    Password = "",
                    OIB = "12345123465",
                    PhoneNumber = "00385976086801",
                    Category = "",
                    DrivingSchoolId = 0
                },
                new
                {
                    Id = 6,
                    FirstName = "Petra",
                    LastName = "Condic",
                    Username = "PCondic",
                    Password = "",
                    OIB = "12345123466",
                    PhoneNumber = "00385976086801",
                    Category = "",
                    DrivingSchoolId = 0
                },
                new
                {
                    Id = 7,
                    FirstName = "Alex",
                    LastName = "Amanzi",
                    Username = "AAmanzi",
                    Password = "",
                    OIB = "12345123467",
                    PhoneNumber = "00385976086801",
                    Category = "",
                    DrivingSchoolId = 0
                },
                new
                {
                    Id = 8,
                    FirstName = "Ante",
                    LastName = "Vuletic",
                    Username = "AVuletic",
                    Password = "",
                    OIB = "12345123468",
                    PhoneNumber = "00385976086801",
                    Category = "",
                    DrivingSchoolId = 0
                }
            );

            modelBuilder.Entity<Class>().HasData(
                new
                {
                    Id = 1,
                    Name = "Propisi",
                    TotalLessons = 15
                },
                new
                {
                    Id = 2,
                    Name = "Prva pomoc",
                    TotalLessons = 10
                },
                new
                {
                    Id = 3,
                    Name = "Voznja B",
                    TotalLessons = 35
                },
                new
                {
                    Id = 4,
                    Name = "Voznja A1",
                    TotalLessons = 20
                },
                new
                {
                    Id = 5,
                    Name = "Voznja A2",
                    TotalLessons = 25
                }
            );

            modelBuilder.Entity<Location>().HasData(
                new
                {
                    Id = 1,
                    Address = "Dubrovacka 34",
                    Latitude = 43.5195,
                    Longitude = 16.44939999999997
                },
                new
                {
                    Id = 2,
                    Address = "Vukovarska 59",
                    Latitude = 43.5113763,
                    Longitude = 16.4477168
                },
                new
                {
                    Id = 3, 
                    Address = "Solinska ulica",
                    Latitude = 43.5232199,
                    Longitude = 16.4625756
                }
            );

            modelBuilder.Entity<Event>().HasData(
                new
                {
                    Id = 1,
                    Name = "Predavanje Propisi 1",
                    LocationId = 1,
                    Type = "Propisi",
                    StartsAt = new DateTime(2019, 8, 11, 8, 0, 0),
                    EndsAt = new DateTime(2019, 8, 11, 10, 0, 0)
                },
                new
                {
                    Id = 2,
                    Name = "Predavanje Propisi 2",
                    LocationId = 1,
                    Type = "Propisi",
                    StartsAt = new DateTime(2019, 8, 12, 8, 0, 0),
                    EndsAt = new DateTime(2019, 8, 12, 10, 0, 0)
                },
                new
                {
                    Id = 3,
                    Name = "Predavanje Propisi 3",
                    LocationId = 1,
                    Type = "Propisi",
                    StartsAt = new DateTime(2019, 8, 13, 8, 0, 0),
                    EndsAt = new DateTime(2019, 8, 13, 10, 0, 0)
                },
                new
                {
                    Id = 4,
                    Name = "Predavanje Prva Pomoc 1",
                    LocationId = 2,
                    Type = "Prva pomoc",
                    StartsAt = new DateTime(2019, 8, 11, 9, 30, 0),
                    EndsAt = new DateTime(2019, 8, 11, 11, 0, 0)
                },
                new
                {
                    Id = 5,
                    Name = "Predavanje Prva Pomoc 2",
                    LocationId = 2,
                    Type = "Prva pomoc",
                    StartsAt = new DateTime(2019, 8, 12, 9, 30, 0),
                    EndsAt = new DateTime(2019, 8, 12, 11, 0, 0)
                },
                new
                {
                    Id = 6,
                    Name = "Predavanje Prva Pomoc 3",
                    LocationId = 2,
                    Type = "Prva pomoc",
                    StartsAt = new DateTime(2019, 8, 13, 9, 30, 0),
                    EndsAt = new DateTime(2019, 8, 13, 11, 0, 0)
                },
                new
                {
                    Id = 7,
                    Name = "Voznja",
                    LocationId = 3,
                    Type = "Voznja",
                    StartsAt = new DateTime(2019, 8, 11, 9, 30, 0),
                    EndsAt = new DateTime(2019, 8, 11, 10, 30, 0)
                },
                new
                {
                    Id = 8,
                    Name = "Voznja",
                    LocationId = 3,
                    Type = "Voznja",
                    StartsAt = new DateTime(2019, 8, 12, 12, 0, 0),
                    EndsAt = new DateTime(2019, 8, 12, 13, 0, 0)
                },
                new
                {
                    Id = 9,
                    Name = "Voznja",
                    LocationId = 3,
                    Type = "Voznja",
                    StartsAt = new DateTime(2019, 8, 15, 8, 0, 0),
                    EndsAt = new DateTime(2019, 8, 15, 9, 0, 0)
                }
            );

            modelBuilder.Entity<Exam>().HasData(
                new
                {
                    Id = 1,
                    TotalPoints = 120,
                    PointsToPass = 108,
                    Type = "Propisi"
                },
                new
                {
                    Id = 2,
                    TotalPoints = 60,
                    PointsToPass = 40,
                    Type = "Prva pomoc"
                },
                new
                {
                    Id = 3,
                    TotalPoints = 100,
                    PointsToPass = 50,
                    Type = "Voznja"
                }
            );

            modelBuilder.Entity<Vehicle>().HasData(
                new
                {
                    Id = 1,
                    Manufacturer = "Volkswagen",
                    Model = "Golf 7",
                    FuelType = "Gasoline",
                    Image = "",
                    Type = "Car",
                    LicensePlate = "ST-200-OK"
                },
                new
                {
                    Id = 2,
                    Manufacturer = "Mercedes",
                    Model = "A Class",
                    FuelType = "Gasoline",
                    Image = "",
                    Type = "Car",
                    LicensePlate = "ST-404-NF"
                },
                new
                {
                    Id = 3,
                    Manufacturer = "Renault",
                    Model = "Megane III",
                    FuelType = "Diesel",
                    Image = "",
                    Type = "Car",
                    LicensePlate = "ST-500-FB"
                },
                new
                {
                    Id = 4,
                    Manufacturer = "Kawasaki",
                    Model = "ZZR",
                    FuelType = "Gasoline",
                    Image = "",
                    Type = "Motorcycle",
                    LicensePlate = "ST-408-TO"
                }
            );

            modelBuilder.Entity<Question>().HasData(
                new
                {
                    Id = 1,
                    Text = "U kojim ce uvjetima prijanjanje guma na cesti biti smanjeno?",
                    Type = "Propisi",
                    Image = ""
                },
                new
                {
                    Id = 2,
                    Text = "Kad vozac reagira brze?",
                    Type = "Propisi",
                    Image = ""
                },
                new
                {
                    Id = 3,
                    Text = "Sto je motorno vozilo?",
                    Type = "Propisi",
                    Image = ""
                },
                new
                {
                    Id = 4,
                    Text = "Sto je najveca dopustena masa vozila?",
                    Type = "Propisi",
                    Image = ""
                },
                new
                {
                    Id = 5,
                    Text = "Kako vozac daje svjetlosni znak upozorenja ostalim sudionicima u prometu?",
                    Type = "Propisi",
                    Image = ""
                },
                new
                {
                    Id = 6,
                    Text = "Sto se podrazumijeva pod svjetlosnim znakovima upozorenja u prometu?",
                    Type = "Propisi",
                    Image = ""
                },
                new
                {
                    Id = 7,
                    Text = "Sto vozac mora stalno pratiti za vrijeme voznje?",
                    Type = "Propisi",
                    Image = ""
                },
                new
                {
                    Id = 8,
                    Text = "Koja je uloga parkirne kocnice na motornom vozilu?",
                    Type = "Propisi",
                    Image = ""
                },
                new
                {
                    Id = 9,
                    Text = "Kako se na semaforu moze pojaviti zuto svjetlo?",
                    Type = "Propisi",
                    Image = ""
                },
                new
                {
                    Id = 10,
                    Text = "Sto je prestrojavanje?",
                    Type = "Propisi",
                    Image = ""
                },
                new
                {
                    Id = 11,
                    Text = "Koji plin se oslobađa pri izgaranju benzina, a koji u zatvorenom prostoru može izazvati smrt?",
                    Type = "Prva pomoc",
                    Image = ""
                }, 
                new
                {
                    Id = 12,
                    Text = "Ozlijedenu osobu koja je dozivjela epilepticki napadaj stavljamo u koju poziciju?",
                    Type = "Prva pomoc",
                    Image = ""
                }, 
                new
                {
                    Id = 13,
                    Text = "Koji je ljudski ritam normalnog disanja?",
                    Type = "Prva pomoc",
                    Image = ""
                },
                new
                {
                    Id = 14,
                    Text = "Sto alkohol izaziva?",
                    Type = "Prva pomoc",
                    Image = ""
                }, 
                new
                {
                    Id = 15,
                    Text = "Koji je prvi postupak s ozlijedenim kod udara struje?",
                    Type = "Prva pomoc",
                    Image = ""
                }, 
                new
                {
                    Id = 16,
                    Text = "Koji je normalan ljudski ritam otkucaja srca?",
                    Type = "Prva pomoc",
                    Image = ""
                }, 
                new
                {
                    Id = 17,
                    Text = "Koje su karakteristike venskog krvarenja?",
                    Type = "Prva pomoc",
                    Image = ""
                },
                new
                {
                    Id = 18,
                    Text = "Sto je macje oko?",
                    Type = "Prva pomoc",
                    Image = ""
                },
                new
                {
                    Id = 19,
                    Text = "Koja je uloga imobilizacije?",
                    Type = "Prva pomoc",
                    Image = ""
                }, 
                new
                {
                    Id = 20,
                    Text = "Za sto se upotrebljava kompresivni zavoj?",
                    Type = "Prva pomoc",
                    Image = ""
                }
            );

            modelBuilder.Entity<Answer>().HasData(
                new
                {
                    Id = 1,
                    Text = "Ako je cesta mokra",
                    QuestionId = 1,
                    IsCorrect = true
                },
                new
                {
                    Id = 2,
                    Text = "Ako je cesta s nepreglednim dionicama",
                    QuestionId = 1,
                    IsCorrect = false
                },
                new
                {
                    Id = 3,
                    Text = "Ako je cesta prekrivena snijegom",
                    QuestionId = 1,
                    IsCorrect = true
                },
                new
                {
                    Id = 4,
                    Text = "Kad posjeduje potrebne vjestine",
                    QuestionId = 2,
                    IsCorrect = true
                },
                new
                {
                    Id = 5,
                    Text = "Kad je umoran",
                    QuestionId = 2,
                    IsCorrect = false
                },
                new
                {
                    Id = 6,
                    Text = "Kad je pod utjecajem alkohola ili droga",
                    QuestionId = 2,
                    IsCorrect = false
                },
                new
                {
                    Id = 7,
                    Text = "Svako vozilo koje se pokrece snagom vlastitog motora, osim vozila koja se krecu po tracnicama",
                    QuestionId = 3,
                    IsCorrect = true
                },
                new
                {
                    Id = 8,
                    Text = "Svako prijevozno sredstvo namijenjeno za kretanje po cesti",
                    QuestionId = 3,
                    IsCorrect = false
                },
                new
                {
                    Id = 9,
                    Text = "Masa vozila zajedno s njegovom nosivoscu",
                    QuestionId = 4,
                    IsCorrect = true
                },
                new
                {
                    Id = 10,
                    Text = "Masa vozila s teretom u vozilu ili na vozilu",
                    QuestionId = 4,
                    IsCorrect = false
                },
                new
                {
                    Id = 11,
                    Text = "Paljenjem svih pokazivaca smjera",
                    QuestionId = 5,
                    IsCorrect = false
                },
                new
                {
                    Id = 12,
                    Text = "Kratkim uzastopnim paljenjem dugih svjetala",
                    QuestionId = 5,
                    IsCorrect = true
                },
                new
                {
                    Id = 13,
                    Text = "Naizmjenicnim paljenjem dugih i kratkih svjetala",
                    QuestionId = 5,
                    IsCorrect = true
                },
                new
                {
                    Id = 14,
                    Text = "Svjetla za maglu",
                    QuestionId = 6,
                    IsCorrect = false
                },
                new
                {
                    Id = 15,
                    Text = "Pokazivaci smjera",
                    QuestionId = 6,
                    IsCorrect = true
                },
                new
                {
                    Id = 16,
                    Text = "Stop-svjetla",
                    QuestionId = 6,
                    IsCorrect = true
                },
                new
                {
                    Id = 17,
                    Text = "Prometne uvjete na cesti kojom vozi",
                    QuestionId = 7,
                    IsCorrect = true
                },
                new
                {
                    Id = 18,
                    Text = "Jambo plakate",
                    QuestionId = 7,
                    IsCorrect = false
                },
                new
                {
                    Id = 19,
                    Text = "Kretanje ostalih sudionika u prometu",
                    QuestionId = 7,
                    IsCorrect = true
                },
                new
                {
                    Id = 20,
                    Text = "Osigurati vozilo u zakocenom polozaju",
                    QuestionId = 8,
                    IsCorrect = true
                },
                new
                {
                    Id = 21,
                    Text = "Sprijeciti zanosenje vozila prilikom nagloga kocenja",
                    QuestionId = 8,
                    IsCorrect = false
                },
                new
                {
                    Id = 22,
                    Text = "Osigurati bolje kocenje na mokrom kolniku",
                    QuestionId = 8,
                    IsCorrect = false
                },
                new
                {
                    Id = 23,
                    Text = "Zajedno sa zelenim svjetlom prije pojave crvenog svjetla",
                    QuestionId = 9,
                    IsCorrect = true
                },
                new
                {
                    Id = 24,
                    Text = "Zajedno sa crvenim svjetlom prije pojave zelenog svjetla",
                    QuestionId = 9,
                    IsCorrect = false
                },
                new
                {
                    Id = 25,
                    Text = "Kao samostalno svjetlo",
                    QuestionId = 9,
                    IsCorrect = true
                },
                new
                {
                    Id = 26,
                    Text = "Prelazenje vozilom iz jedne u drugu prometnu traku radi brzega kretanja",
                    QuestionId = 10,
                    IsCorrect = false
                },
                new
                {
                    Id = 27,
                    Text = "Zauzimanje takvog polozaja vozilom na prometnoj traci iz kojeg se moze na siguran nacin izvesti naredna radnja s vozilom",
                    QuestionId = 10,
                    IsCorrect = true
                },
                new
                {
                    Id = 28,
                    Text = "Prolazenje vozilom pokraj drugog vozila koje se krece u istom smjeru",
                    QuestionId = 10,
                    IsCorrect = false
                },
                new
                {
                    Id = 29,
                    Text = "Ugljikov monoksid",
                    QuestionId = 11,
                    IsCorrect = true
                },
                new
                {
                    Id = 30,
                    Text = "Duhanski dim",
                    QuestionId = 11,
                    IsCorrect = false
                },
                new
                {
                    Id = 31,
                    Text = "Natrijev klorid",
                    QuestionId = 11,
                    IsCorrect = false
                },
                new
                {
                    Id = 32,
                    Text = "Bocni polozaj",
                    QuestionId = 12,
                    IsCorrect = true
                },
                new
                {
                    Id = 33,
                    Text = "Polusjedeci polozaj",
                    QuestionId = 12,
                    IsCorrect = false
                },
                new
                {
                    Id = 34,
                    Text = "Polulezeci polozaj",
                    QuestionId = 12,
                    IsCorrect = false
                },
                new
                {
                    Id = 35,
                    Text = "14-16 puta na sat",
                    QuestionId = 13,
                    IsCorrect = false
                },
                new
                {
                    Id = 36,
                    Text = "12-20 puta u jednoj minuti",
                    QuestionId = 13,
                    IsCorrect = true
                },
                new
                {
                    Id = 37,
                    Text = "12 do 20 puta na dan",
                    QuestionId = 13,
                    IsCorrect = false
                },
                new
                {
                    Id = 38,
                    Text = "Ubrzavanje refleksa",
                    QuestionId = 14,
                    IsCorrect = false
                },
                new
                {
                    Id = 39,
                    Text = "Povecanje koncentracije i moci pamcenja",
                    QuestionId = 14,
                    IsCorrect = false
                },
                new
                {
                    Id = 40,
                    Text = "Pospanost i jako usporavanje refleksa",
                    QuestionId = 14,
                    IsCorrect = true
                },
                new
                {
                    Id = 41,
                    Text = "Povrijeđenog zakopati u zemlju da bi zemlja izvukla struju",
                    QuestionId = 15,
                    IsCorrect = false
                },
                new
                {
                    Id = 42,
                    Text = "Ukloniti izvor struje ili isključiti osigurač",
                    QuestionId = 15,
                    IsCorrect = true
                },
                new
                {
                    Id = 43,
                    Text = "Odmah započeti sa oživljavanjem ili reanimacijom",
                    QuestionId = 15,
                    IsCorrect = false
                },
                new
                {
                    Id = 44,
                    Text = "60-80 otkucaja u jednom satu",
                    QuestionId = 16,
                    IsCorrect = false
                },
                new
                {
                    Id = 45,
                    Text = "60-80 otkucaja u jednoj minuti",
                    QuestionId = 16,
                    IsCorrect = true
                },
                new
                {
                    Id = 46,
                    Text = "60-80 otkucaja u jednoj sekundi",
                    QuestionId = 16,
                    IsCorrect = false
                },
                new
                {
                    Id = 47,
                    Text = "Krv je tamno-crvene boje i ravnomjerno curi preko ruba rane",
                    QuestionId = 17,
                    IsCorrect = true
                },
                new
                {
                    Id = 48,
                    Text = "Veoma teško se zaustavlja",
                    QuestionId = 17,
                    IsCorrect = false
                },
                new
                {
                    Id = 49,
                    Text = "Izlazi u mlazevima i tamno-crne je boje",
                    QuestionId = 17,
                    IsCorrect = false
                },
                new
                {
                    Id = 50,
                    Text = "Jedan od sigurnih znakova smrti",
                    QuestionId = 18,
                    IsCorrect = true
                },
                new
                {
                    Id = 51,
                    Text = "Vrsta raskrizja",
                    QuestionId = 18,
                    IsCorrect = false
                },
                new
                {
                    Id = 52,
                    Text = "Mačka na cesti",
                    QuestionId = 18,
                    IsCorrect = false
                },
                new
                {
                    Id = 53,
                    Text = "Pojacavanje boli kod povrijedenog",
                    QuestionId = 19,
                    IsCorrect = false
                },
                new
                {
                    Id = 54,
                    Text = "Sprjecavanje povrijedenog od izvodenja sportskih aktivnosti",
                    QuestionId = 19,
                    IsCorrect = false
                },
                new
                {
                    Id = 55,
                    Text = "Sprjecavanje dodatnih povreda kod ozlijedjenog",
                    QuestionId = 19,
                    IsCorrect = false
                },
                new
                {
                    Id = 56,
                    Text = "Za teske opekotine",
                    QuestionId = 20,
                    IsCorrect = false
                },
                new
                {
                    Id = 57,
                    Text = "Za imobilizaciju prijeloma",
                    QuestionId = 20,
                    IsCorrect = false
                },
                new
                {
                    Id = 58,
                    Text = "Kad zelimo zaustaviti krvarenje",
                    QuestionId = 20,
                    IsCorrect = true
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
