using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class InstructorRepository : IInstructorRepository
    {
        public InstructorRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;
        public List<Instructor> GetAllInstructors()
        {
            return _context.Instructors.ToList();
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
    }
}
