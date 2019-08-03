using CashRegister.Data.Helpers;
using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Data.Enums;
using Retrovizor.Domain.Classes;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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
            return _context.Instructors.Where(i => i.DrivingSchoolId == id).ToList();
        }

        public bool AddInstructor(Instructor instructorToAdd)
        {
            var doesInstructorExist = _context.Instructors.Any(instructor =>
                string.Equals(instructor.OIB, instructorToAdd.OIB, StringComparison.CurrentCultureIgnoreCase));

            if(doesInstructorExist)
                return false;

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
            instructorToEdit.Username = editedInstructor.Username;
            instructorToEdit.Password = editedInstructor.Password;
            instructorToEdit.OIB = editedInstructor.OIB;
            instructorToEdit.PhoneNumber = editedInstructor.PhoneNumber;

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

        public Instructor GetInstructorById(int id)
        {
            return _context.Instructors.Find(id);
        }

        public Instructor GetCurrentInstructorByStudentId(int id)
        {
            var vehicleSessions = _context.VehicleSessions.Where(vs => vs.StudentId == id);

            if(vehicleSessions == null)
                return null;

            var currentVehicleSession = vehicleSessions.FirstOrDefault(vs => vs.IsActive);

            if(currentVehicleSession == null)
                return null;

            return currentVehicleSession.Instructor;
        }

        public List<Instructor> GetInstructorsByDrivingSchoolId(int id)
        {
            return _context.Instructors.Where(i => i.DrivingSchoolId == id).ToList();
        }

        public UserCredentials VerifyCredentials(UserCredentials credentials)
        {
            var instructorMatch = _context.Instructors.First(instructor => instructor.Username == credentials.Username
            && HashHelper.ValidatePassword(instructor.Password, credentials.Password));

            if (instructorMatch == null) return null;

            credentials.Id = instructorMatch.Id;
            credentials.Role = (Role)1;

            return credentials;
        }
    }
}
