using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        public StudentRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }
        public bool AddStudent(Student studentToAdd)
        {
            var doesStudentExist = _context.Students.Any(student =>
                string.Equals(student.OIB, studentToAdd.OIB, StringComparison.CurrentCultureIgnoreCase));

            if(doesStudentExist)
                return false;

            _context.Students.Add(studentToAdd);
            _context.SaveChanges();
            return true;
        }
        public bool EditStudent(Student editedStudent)
        {
            var studentToEdit = _context.Students.Find(editedStudent.Id);

            if(studentToEdit == null)
                return false;

            studentToEdit.FirstName = editedStudent.FirstName;
            studentToEdit.LastName = editedStudent.LastName;
            studentToEdit.Username = editedStudent.Username;
            studentToEdit.Password = editedStudent.Password;
            studentToEdit.OIB = editedStudent.OIB;
            studentToEdit.PhoneNumber = editedStudent.PhoneNumber;
            studentToEdit.Category = editedStudent.Category;

            _context.SaveChanges();
            return true;
        }
        public bool DeleteStudent(int idOfStudentToDelete)
        {
            var studentToDelete = _context.Students.Find(idOfStudentToDelete);

            if(studentToDelete == null)
                return false;

            _context.Remove(studentToDelete);
            _context.SaveChanges();
            return true;
        }
        public Student GetStudentById(int id)
        {
            return _context.Students.Find(id);
        }
    }
}
