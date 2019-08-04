using Microsoft.EntityFrameworkCore;
using Retrovizor.Data.Entities.Models;
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

            base.OnModelCreating(modelBuilder);

            // test seed data

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id=1,
                    Username="nborovic",
                    Password= "NqSs3eyOEG9CA8AbO6GgIXjZOgqjAX6tJ0nq1WOOWAt9YnwY",
                    OIB="123456789",
                    PhoneNumber="0921112222",
                    Role=Enums.Role.Admin,
                    DrivingSchoolId=1
                },
                new User
                {
                    Id=2,
                    Username="mluketin",
                    Password= "zaFUUQie8N96psne7PziMc24lTzDt+75t6MoUqCB83kwaSU6",
                    OIB="987654321",
                    PhoneNumber="0915559999",
                    Role=Enums.Role.Instructor,
                    DrivingSchoolId=1
                },
                new User
                {
                    Id=3,
                    Username="lnola",
                    Password= "CZ/N7zgZL4faI4Cp4pgd0/L98ZlWS2M6K+VhQf360Ywv2Vkh",
                    OIB="543216789",
                    PhoneNumber="0982221111",
                    Role=Enums.Role.Student,
                    DrivingSchoolId=1
                }
            );

            modelBuilder.Entity<DrivingSchool>().HasData(
                new DrivingSchool
                {
                    Id = 1,
                    Name = "Semafor",
                    Address = "Solinska 5"
                }
            );

            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    Id = 1,
                    UserId = 1
                }
            );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor
                {
                    Id = 1,
                    FirstName = "Matija",
                    LastName = "Luketin",
                    UserId = 2,
                    VehicleId=1
                }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Luka",
                    LastName = "Nola",
                    UserId = 3,
                    Category = "B",
                }
            );

            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle
                {
                    Id = 1,
                    FuelType = "Dizel",
                    Image = "vehicle.jpg",
                    LicensePlate = "ML4422",
                    Manufacturer = "Golf",
                    Model = "VII",
                    Type = "Type"
                }
            );
        }
    }
}
