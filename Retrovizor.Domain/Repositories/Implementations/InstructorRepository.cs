using CashRegister.Data.Helpers;
using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Data.Enums;
using Retrovizor.Domain.Classes;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class InstructorRepository : IInstructorRepository
    {
        public InstructorRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public List<Instructor> GetAllInstructorsByDrivingSchoolId(int id)
        {
            return _context.Instructors
                .Include("Vehicle")
                .Include("Reviews")
                .Where(i => i.User.DrivingSchoolId == id).ToList();
        }

        public bool AddInstructor(Instructor instructorToAdd)
        {
            if (_context.Users.Any(u => u.Username == instructorToAdd.User.Username
            || u.OIB == instructorToAdd.User.OIB || u.PhoneNumber == instructorToAdd.User.PhoneNumber)) return false;

            instructorToAdd.User.DrivingSchool = _context.DrivingSchools.Find(instructorToAdd.User.DrivingSchoolId);

            _context.Instructors.Add(instructorToAdd);
            _context.SaveChanges();
            return true;
        }

        public bool EditInstructor(Instructor editedInstructor)
        {
            var instructorToEdit = _context.Instructors.Find(editedInstructor.Id);

            if(instructorToEdit == null)
                return false;

            instructorToEdit.FirstName = editedInstructor.FirstName;
            instructorToEdit.LastName = editedInstructor.LastName;
            instructorToEdit.User.Username = editedInstructor.User.Username;
            instructorToEdit.User.Password = editedInstructor.User.Password;
            instructorToEdit.User.OIB = editedInstructor.User.OIB;
            instructorToEdit.User.PhoneNumber = editedInstructor.User.PhoneNumber;

            _context.SaveChanges();
            return true;
        }

        public bool DeleteInstructor(int idOfInstructorToDelete)
        {
            var instructorToDelete = _context.Instructors.Find(idOfInstructorToDelete);

            if(instructorToDelete == null)
                return false;

            _context.Remove(instructorToDelete);
            _context.SaveChanges();
            return true;
        }

        public Instructor GetInstructorById(int userId)
        {
            var id = GetInstructorIdFromUserId(userId);

            return _context.Instructors
                .Include("User")
                .Include("User.DrivingSchool")
                .Include("VehicleSessions")
                .Include("Vehicle")
                .FirstOrDefault(instructor=>instructor.Id==id);
        }

        public Instructor GetCurrentInstructorByStudentId(int userId)
        {
            var id = GetStudentIdFromUserId(userId);

            var vehicleSessions = _context.VehicleSessions
                .Include("Instructor")
                .Include("Instructor.User")
                .Include("Instructor.User.DrivingSchool")
                .Include("Instructor.Vehicle")
                .Where(vs => vs.StudentId == id).ToList();

            if(vehicleSessions.Count == 0)
                return null;

            var currentVehicleSession = vehicleSessions.FirstOrDefault(vs => vs.IsActive);

            if(currentVehicleSession == null)
                return null;

            return currentVehicleSession.Instructor;
        }

        public List<Instructor> GetInstructorsByDrivingSchoolId(int id)
        {
            return _context.Instructors.Where(i => i.User.DrivingSchoolId == id).ToList();
        }

        //public List<Instructor> GetAvailableInstructorsByDrivingSchoolId(int id)
        //{
        //    return _context.Instructors.Where(i => i.User.DrivingSchoolId == id && i.isAvailable).ToList();
        //}

        private int GetInstructorIdFromUserId(int userId)
        {
            var user = _context.Users.Include("Instructor").FirstOrDefault(u => u.Id == userId);
            var id = user.Instructor.Id;

            return id;
        }

        private int GetStudentIdFromUserId(int userId)
        {
            var user = _context.Users.Include("Student").FirstOrDefault(u => u.Id == userId);
            var id = user.Student.Id;

            return id;
        }

    }
}
