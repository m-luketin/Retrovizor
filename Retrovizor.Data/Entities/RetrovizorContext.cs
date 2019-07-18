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
        {
        }

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
        public DbSet<StudentInstructor> StudentInstructors { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleSession> VehicleSessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentInstructor>()
                .HasKey(si => new { si.StudentId, si.InstructorId, si.DateAssigned });
            modelBuilder.Entity<StudentExam>()
                .HasKey(se => new { se.StudentId, se.ExamId, se.Points });
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

            modelBuilder.Entity<StudentInstructor>()
                .HasOne(si => si.Student)
                .WithMany(si => si.StudentInstructors)
                .HasForeignKey(si => si.StudentId);
            modelBuilder.Entity<StudentInstructor>()
                .HasOne(si => si.Instructor)
                .WithMany(si => si.StudentInstructors)
                .HasForeignKey(si => si.InstructorId);

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

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach(var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
