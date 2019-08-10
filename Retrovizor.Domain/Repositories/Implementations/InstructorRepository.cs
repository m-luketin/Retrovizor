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
using Retrovizor.Domain.Helpers;

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
            return _context.Instructors.Where(i => i.User.DrivingSchoolId == id).ToList();
        }

        public bool AddInstructor(Instructor instructorToAdd)
        {
            if (_context.Users.Any(u => u.Username == instructorToAdd.User.Username)) return false;

            var vehicle = _context.Vehicles.FirstOrDefault(v => instructorToAdd.Vehicle.Model.Contains(v.Manufacturer)
                    && instructorToAdd.Vehicle.Model.Contains(v.Model) && instructorToAdd.Vehicle.Year == v.Year);

            if (vehicle == null) return false;

            instructorToAdd.User.Username = CredentialsHelper.GenerateUsername(instructorToAdd.FirstName, instructorToAdd.LastName);
            instructorToAdd.User.Password = HashHelper.Hash(CredentialsHelper.GenerateRandomPassword());
            instructorToAdd.User.Role = Role.Instructor;

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

        public Instructor GetInstructorById(int id)
        {
            return _context.Instructors.Include(i => i.Vehicle).Include(i => i.User).FirstOrDefault(i => i.Id == id);
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
            return _context.Instructors.Include("Vehicle").Where(i => i.User.DrivingSchoolId == id).ToList();
        }
    }
}
