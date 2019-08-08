using Microsoft.EntityFrameworkCore;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Data.Enums;
using System;
using System.Linq;

namespace Retrovizor.Data.Entities
{
    public class RetrovizorContext : DbContext
    {
        public RetrovizorContext(DbContextOptions options) : base(options)
        {}

        public DbSet<User> Users { get; set; }
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
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.Admin)
                .WithOne(a => a.User)
                .HasForeignKey<Admin>(a => a.UserId);
            modelBuilder.Entity<User>()
                .HasOne(u => u.Instructor)
                .WithOne(i => i.User)
                .HasForeignKey<Instructor>(i => i.UserId);
            modelBuilder.Entity<User>()
                .HasOne(u => u.Student)
                .WithOne(s => s.User)
                .HasForeignKey<Student>(s => s.UserId);

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

            foreach (var fk in cascadeFKs)
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

            modelBuilder.Entity<User>().HasData(
                new
                {
                    Id = 1,
                    Username = "Duje",
                    Password = "NqSs3eyOEG9CA8AbO6GgIXjZOgqjAX6tJ0nq1WOOWAt9YnwY", //onphdvwr
                    Role = Role.Admin,
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 2,
                    Username = "Kreso",
                    Password = "zaFUUQie8N96psne7PziMc24lTzDt+75t6MoUqCB83kwaSU6", //jxfqcnh
                    Role = Role.Admin,
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 3,
                    Username = "Drazen",
                    Password = "CZ/N7zgZL4faI4Cp4pgd0/L98ZlWS2M6K+VhQf360Ywv2Vkh", //xxjdkpdk
                    Role = Role.Admin,
                    DrivingSchoolId = 2
                },
                new
                {
                    Id = 4,
                    Username = "IDomazet",
                    Password = "yxq0Ed+O2iWi98Toqah+BS75nkM7Z7+SXaoi/SPwsXkbVWHA", //npfzcpvqu
                    OIB = "12345123451",
                    PhoneNumber = "00385976086801",
                    Role = Role.Instructor,
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 5,
                    Username = "MCeprnja",
                    Password = "wyWLW6MQdogtds5NSUP/NJhVcrUVFGDPk9zS58Nk3Xnykq/e", //tfetheb
                    OIB = "12345123452",
                    PhoneNumber = "00385976086801",
                    Role = Role.Instructor,
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 6,
                    Username = "ZDelas",
                    Password = "wnCehHvutg39CCPGSMSABgFA6dKxI1GS/TpYkgEArLBcv16O", //irmhlobp
                    OIB = "12345123453",
                    PhoneNumber = "00385976086801",
                    Role = Role.Instructor,
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 7,
                    Username = "JSvalina",
                    Password = "V+dugmSl5R+gGdUFn8fLVNMd3f67CAtoNaxYlCIi+aR4hn1b", //unqpza
                    OIB = "12345123454",
                    PhoneNumber = "00385976086801",
                    Role = Role.Instructor,
                    DrivingSchoolId = 2
                },
                new
                {
                    Id = 8,
                    Username = "MLuketin",
                    Password = "gIrZXsGJ1KwFWOkycqVaS1N7zAtxOwqVGYfJEkrOshKIPlwa", //fgabxer
                    OIB = "12345123461",
                    PhoneNumber = "00385976086801",
                    Role = Role.Student,
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 9,
                    Username = "LNola",
                    Password = "4otiXl9sR1IrN1Oxk7JXw5b8jn5kcQ2GSKVvBriy4F0Ct72H", //zkcuurig
                    OIB = "12345123462",
                    PhoneNumber = "00385976086801",
                    Role = Role.Student,
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 10,
                    Username = "NBorovic",
                    Password = "Q/2RZdW5Q3AwxcWIKlk4jGizvLawjC5kAU11YDL+1UKDQHFT", //tqznrrif
                    OIB = "12345123463",
                    PhoneNumber = "00385976086801",
                    Role = Role.Student,
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 11,
                    Username = "LBendic",
                    Password = "e+5Zz+VgZHqNuaK5p8c/OGHpwlnO6zNTI89ouMxxy5fEja/P", //kdwcjys
                    OIB = "12345123464",
                    PhoneNumber = "00385976086801",
                    Role = Role.Student,
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 12,
                    Username = "KTomic",
                    Password = "oINRmcaSWlLomk6pbdtw9m7tBVjHzvsQvgm1lbGDiB713H0R", //vzndlm
                    OIB = "12345123465",
                    PhoneNumber = "00385976086801",
                    Role = Role.Student,
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 13,
                    Username = "PCondic",
                    Password = "Ae5m6kB/XbEkj6vPzceoGLeguy7oVink9iK+smuifbgSQMlQ", //ktjokers
                    OIB = "12345123466",
                    PhoneNumber = "00385976086801",
                    Role = Role.Student,
                    DrivingSchoolId = 1
                },
                new
                {
                    Id = 14,
                    Username = "AAmanzi",
                    Password = "zEXK/8+DyNVCBICYavDmMnA4x7iT5AwMQkLVQBJSDeNwA1Ic", //wvvlziix
                    OIB = "12345123467",
                    PhoneNumber = "00385976086801",
                    Role = Role.Student,
                    DrivingSchoolId = 2
                },
                new
                {
                    Id = 15,
                    Username = "AVuletic",
                    Password = "hQFfPhep54nqhqGES06j18OyU79CeUPrDK/iSEZdt4BhFzq+", //fglrhth
                    OIB = "12345123468",
                    PhoneNumber = "00385976086801",
                    Role = Role.Student,
                    DrivingSchoolId = 2
                }
            );

            modelBuilder.Entity<Admin>().HasData(
                new
                {
                    Id = 1,
                    UserId = 1
                },
                new
                {
                    Id = 2,
                    UserId = 2
                },
                new
                {
                    Id = 3,
                    UserId = 3
                }
            );

            modelBuilder.Entity<Instructor>().HasData(
                new
                {
                    Id = 1,
                    FirstName = "Izabela",
                    LastName = "Domazet",
                    VehicleId = 1,
                    UserId = 4
                },
                new
                {
                    Id = 2,
                    FirstName = "Mario",
                    LastName = "Ceprnja",
                    VehicleId = 2,
                    UserId = 5
                },
                new
                {
                    Id = 3,
                    FirstName = "Zvonimir",
                    LastName = "Delas",
                    VehicleId = 3,
                    UserId = 6
                },
                new
                {
                    Id = 4,
                    FirstName = "Josip",
                    LastName = "Svalina",
                    VehicleId = 4,
                    UserId = 7
                }
            );

            modelBuilder.Entity<Student>().HasData(
                new
                {
                    Id = 1,
                    FirstName = "Matija",
                    LastName = "Luketin",
                    Category = "A1",
                    UserId = 8
                },
                new
                {
                    Id = 2,
                    FirstName = "Luka",
                    LastName = "Nola",
                    Category = "B",
                    UserId = 9
                },
                new
                {
                    Id = 3,
                    FirstName = "Nino",
                    LastName = "Borovic",
                    Category = "B",
                    UserId = 10
                },
                new
                {
                    Id = 4,
                    FirstName = "Luka",
                    LastName = "Bendic",
                    Category = "A2",
                    UserId = 11
                },
                new
                {
                    Id = 5,
                    FirstName = "Klara Bruna",
                    LastName = "Tomic",
                    Category = "B",
                    UserId = 12
                },
                new
                {
                    Id = 6,
                    FirstName = "Petra",
                    LastName = "Condic",
                    PhoneNumber = "00385976086801",
                    Category = "B",
                    UserId = 13
                },
                new
                {
                    Id = 7,
                    FirstName = "Alex",
                    LastName = "Amanzi",
                    Category = "B",
                    UserId = 14
                },
                new
                {
                    Id = 8,
                    FirstName = "Ante",
                    LastName = "Vuletic",
                    Category = "A",
                    UserId = 15
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
                    
                    Type = "Car",
                    LicensePlate = "ST-200-OK"
                },
                new
                {
                    Id = 2,
                    Manufacturer = "Mercedes",
                    Model = "A Class",
                    FuelType = "Gasoline",
                    
                    Type = "Car",
                    LicensePlate = "ST-404-NF"
                },
                new
                {
                    Id = 3,
                    Manufacturer = "Renault",
                    Model = "Megane III",
                    FuelType = "Diesel",
                    
                    Type = "Car",
                    LicensePlate = "ST-500-FB"
                },
                new
                {
                    Id = 4,
                    Manufacturer = "Kawasaki",
                    Model = "ZZR",
                    FuelType = "Gasoline",
                    
                    Type = "Motorcycle",
                    LicensePlate = "ST-408-TO"
                }
            );

            modelBuilder.Entity<Review>().HasData(
                new
                {
                    Id = 1,
                    InstructorId = 1,
                    StudentId = 1,
                    Text = "Odlicna instruktorica! Dobri savjeti, vrlo smirena i iskustvo se vidi! Preporucam."
                },
                new
                {
                    Id = 2,
                    InstructorId = 2,
                    StudentId = 2,
                    Text = "Imali smo vrlo stresno druzenje, ali polozio sam isprve. Hvala instruktore!"
                },
                new
                {
                    Id = 3,
                    InstructorId = 3,
                    StudentId = 3,
                    Text = "Uvjerljivo najbolji instruktor ikad!!!"
                },
                new
                {
                    Id = 4,
                    InstructorId = 2,
                    StudentId = 4,
                    Text = "Reka mi je da mu ostavin neki komentar pa evo."
                },
                new
                {
                    Id = 5,
                    InstructorId = 4,
                    StudentId = 7,
                    Text = "Ne znan jel instruktor autoskole ili se samo ubacija u auto sa mnon?!?!"
                },
                new
                {
                    Id = 6,
                    InstructorId = 4,
                    StudentId = 8,
                    Text = "Nope. Nope. Nope."
                }
            );

            modelBuilder.Entity<VehicleSession>().HasData(
                new
                {
                    StudentId = 1,
                    InstructorId = 1,
                    VehicleId = 1,
                    DateAssigned = new DateTime(2019, 5, 1),
                    IsActive = true
                },
                new
                {
                    StudentId = 2,
                    InstructorId = 2,
                    VehicleId = 2,
                    DateAssigned = new DateTime(2019, 5, 1),
                    IsActive = true
                },
                new
                {
                    StudentId = 3,
                    InstructorId = 3,
                    VehicleId = 3,
                    DateAssigned = new DateTime(2019, 5, 1),
                    IsActive = true
                },
                new
                {
                    StudentId = 8,
                    InstructorId = 4,
                    VehicleId = 4,
                    DateAssigned = new DateTime(2019, 5, 1),
                    IsActive = true
                },
                new
                {
                    StudentId = 4,
                    InstructorId = 2,
                    VehicleId = 2,
                    DateAssigned = new DateTime(2019, 5, 1),
                    IsActive = true
                },
                new
                {
                    StudentId = 7,
                    InstructorId = 4,
                    VehicleId = 4,
                    DateAssigned = new DateTime(2019, 5, 1),
                    IsActive = true
                }
            );

            modelBuilder.Entity<StudentClass>().HasData(
                new
                {
                    StudentId = 1,
                    ClassId = 1,
                    CurrentLesson = 5
                },
                new
                {
                    StudentId = 1,
                    ClassId = 2,
                    CurrentLesson = 5
                },
                new
                {
                    StudentId = 2,
                    ClassId = 1,
                    CurrentLesson = 5
                },
                new
                {
                    StudentId = 2,
                    ClassId = 2,
                    CurrentLesson = 5
                },
                new
                {
                    StudentId = 3,
                    ClassId = 1,
                    CurrentLesson = 15
                },
                new
                {
                    StudentId = 3,
                    ClassId = 2,
                    CurrentLesson = 10
                },
                new
                {
                    StudentId = 4,
                    ClassId = 1,
                    CurrentLesson = 15
                },
                new
                {
                    StudentId = 4,
                    ClassId = 2,
                    CurrentLesson = 10
                },
                new
                {
                    StudentId = 5,
                    ClassId = 1,
                    CurrentLesson = 5
                },
                new
                {
                    StudentId = 5,
                    ClassId = 2,
                    CurrentLesson = 5
                },
                new
                {
                    StudentId = 6,
                    ClassId = 1,
                    CurrentLesson = 5
                },
                new
                {
                    StudentId = 6,
                    ClassId = 2,
                    CurrentLesson = 5
                },
                new
                {
                    StudentId = 7,
                    ClassId = 1,
                    CurrentLesson = 5
                },
                new
                {
                    StudentId = 7,
                    ClassId = 2,
                    CurrentLesson = 5
                },
                new
                {
                    StudentId = 8,
                    ClassId = 1,
                    CurrentLesson = 5
                },
                new
                {
                    StudentId = 8,
                    ClassId = 2,
                    CurrentLesson = 5
                }
            );

            modelBuilder.Entity<StudentEvent>().HasData(
                new
                {
                    StudentId = 1,
                    EventId = 1
                },
                new
                {
                    StudentId = 1,
                    EventId = 2
                },
                new
                {
                    StudentId = 1,
                    EventId = 3
                },
                new
                {
                    StudentId = 1,
                    EventId = 4
                },
                new
                {
                    StudentId = 1,
                    EventId = 5
                },
                new
                {
                    StudentId = 1,
                    EventId = 6
                },
                new
                {
                    StudentId = 2,
                    EventId = 1
                },
                new
                {
                    StudentId = 2,
                    EventId = 2
                },
                new
                {
                    StudentId = 2,
                    EventId = 3
                },
                new
                {
                    StudentId = 2,
                    EventId = 4
                },
                new
                {
                    StudentId = 2,
                    EventId = 5
                },
                new
                {
                    StudentId = 2,
                    EventId = 6
                },
                new
                {
                    StudentId = 5,
                    EventId = 1
                },
                new
                {
                    StudentId = 5,
                    EventId = 2
                },
                new
                {
                    StudentId = 5,
                    EventId = 3
                },
                new
                {
                    StudentId = 5,
                    EventId = 4
                },
                new
                {
                    StudentId = 5,
                    EventId = 5
                },
                new
                {
                    StudentId = 5,
                    EventId = 6
                },
                new
                {
                    StudentId = 6,
                    EventId = 1
                },
                new
                {
                    StudentId = 6,
                    EventId = 2
                },
                new
                {
                    StudentId = 6,
                    EventId = 3
                },
                new
                {
                    StudentId = 6,
                    EventId = 4
                },
                new
                {
                    StudentId = 6,
                    EventId = 5
                },
                new
                {
                    StudentId = 6,
                    EventId = 6
                },
                new
                {
                    StudentId = 7,
                    EventId = 1
                },
                new
                {
                    StudentId = 7,
                    EventId = 2
                },
                new
                {
                    StudentId = 7,
                    EventId = 3
                },
                new
                {
                    StudentId = 7,
                    EventId = 4
                },
                new
                {
                    StudentId = 7,
                    EventId = 5
                },
                new
                {
                    StudentId = 7,
                    EventId = 6
                },
                new
                {
                    StudentId = 8,
                    EventId = 1
                }, 
                new
                {
                    StudentId = 8,
                    EventId = 2
                },
                new
                {
                    StudentId = 8,
                    EventId = 3
                }, 
                new
                {
                    StudentId = 8,
                    EventId = 4
                }, 
                new
                {
                    StudentId = 8,
                    EventId = 5
                },
                new
                {
                    StudentId = 8,
                    EventId = 6
                }
            );

            modelBuilder.Entity<StudentExam>().HasData(
                new
                {
                    StudentId = 3,
                    ExamId = 1,
                    DateTaken = new DateTime(2019, 6, 30),
                    Points = 115
                },
                new
                {
                    StudentId = 3,
                    ExamId = 2,
                    DateTaken = new DateTime(2019, 8, 1),
                    Points = 55
                },
                new
                {
                    StudentId = 4,
                    ExamId = 1,
                    DateTaken = new DateTime(2019, 7, 1),
                    Points = 100
                },
                new
                {
                    StudentId = 4,
                    ExamId = 2,
                    DateTaken = new DateTime(2019, 7, 31),
                    Points = 35
                }
            );

            modelBuilder.Entity<Question>().HasData(
                new
                {
                    Id = 1,
                    Text = "U kojim ce uvjetima prijanjanje guma na cesti biti smanjeno?",
                    Type = "Propisi"
                },
                new
                {
                    Id = 2,
                    Text = "Kad vozac reagira brze?",
                    Type = "Propisi"
                },
                new
                {
                    Id = 3,
                    Text = "Sto je motorno vozilo?",
                    Type = "Propisi"
                },
                new
                {
                    Id = 4,
                    Text = "Sto je najveca dopustena masa vozila?",
                    Type = "Propisi"
                },
                new
                {
                    Id = 5,
                    Text = "Kako vozac daje svjetlosni znak upozorenja ostalim sudionicima u prometu?",
                    Type = "Propisi"
                },
                new
                {
                    Id = 6,
                    Text = "Sto se podrazumijeva pod svjetlosnim znakovima upozorenja u prometu?",
                    Type = "Propisi"
                },
                new
                {
                    Id = 7,
                    Text = "Sto vozac mora stalno pratiti za vrijeme voznje?",
                    Type = "Propisi"
                },
                new
                {
                    Id = 8,
                    Text = "Koja je uloga parkirne kocnice na motornom vozilu?",
                    Type = "Propisi"
                },
                new
                {
                    Id = 9,
                    Text = "Kako se na semaforu moze pojaviti zuto svjetlo?",
                    Type = "Propisi"
                },
                new
                {
                    Id = 10,
                    Text = "Sto je prestrojavanje?",
                    Type = "Propisi"
                },
                new
                {
                    Id = 11,
                    Text = "Koji plin se oslobađa pri izgaranju benzina, a koji u zatvorenom prostoru može izazvati smrt?",
                    Type = "Prva pomoc"
                }, 
                new
                {
                    Id = 12,
                    Text = "Ozlijedenu osobu koja je dozivjela epilepticki napadaj stavljamo u koju poziciju?",
                    Type = "Prva pomoc"
                }, 
                new
                {
                    Id = 13,
                    Text = "Koji je ljudski ritam normalnog disanja?",
                    Type = "Prva pomoc"
                },
                new
                {
                    Id = 14,
                    Text = "Sto alkohol izaziva?",
                    Type = "Prva pomoc"
                }, 
                new
                {
                    Id = 15,
                    Text = "Koji je prvi postupak s ozlijedenim kod udara struje?",
                    Type = "Prva pomoc"
                }, 
                new
                {
                    Id = 16,
                    Text = "Koji je normalan ljudski ritam otkucaja srca?",
                    Type = "Prva pomoc"
                }, 
                new
                {
                    Id = 17,
                    Text = "Koje su karakteristike venskog krvarenja?",
                    Type = "Prva pomoc"
                },
                new
                {
                    Id = 18,
                    Text = "Sto je macje oko?",
                    Type = "Prva pomoc"
                },
                new
                {
                    Id = 19,
                    Text = "Koja je uloga imobilizacije?",
                    Type = "Prva pomoc"
                }, 
                new
                {
                    Id = 20,
                    Text = "Za sto se upotrebljava kompresivni zavoj?",
                    Type = "Prva pomoc"
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
