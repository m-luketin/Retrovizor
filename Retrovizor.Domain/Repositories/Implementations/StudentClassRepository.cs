using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class StudentClassRepository : IStudentClassRepository
    {
        public StudentClassRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public List<StudentClass> GetAllStudentClasses()
        {
            return _context.StudentClasses.ToList();
        }
        public bool AddStudentClass(StudentClass studentClassToAdd)
        {
            var doesStudentClassExist = _context.StudentClasses.Any(studentClass =>
                studentClass.StudentId == studentClassToAdd.StudentId && studentClass.ClassId == studentClassToAdd.ClassId);

            if(doesStudentClassExist)
                return false;

            _context.StudentClasses.Add(studentClassToAdd);
            _context.SaveChanges();
            return true;
        }
        public bool EditStudentClass(StudentClass editedStudentClass)
        {
            var doesStudentClassExist = _context.StudentClasses.Any(studentClass =>
                studentClass.StudentId == editedStudentClass.StudentId && studentClass.ClassId == editedStudentClass.ClassId);

            if(doesStudentClassExist)
                return false;

            var studentClassToEdit = _context.StudentClasses.Find(editedStudentClass.StudentId, editedStudentClass.ClassId);

            if(studentClassToEdit == null)
                return false;

            studentClassToEdit.CurrentLesson = editedStudentClass.CurrentLesson;

            _context.SaveChanges();
            return true;
        }
        public bool DeleteStudentClass(int idOfStudentClassToDelete)
        {
            var studentClassToDelete = _context.StudentClasses.Find(idOfStudentClassToDelete);

            if(studentClassToDelete == null)
                return false;

            _context.Remove(studentClassToDelete);
            _context.SaveChanges();
            return true;
        }
        public List<StudentClass> GetStudentClassesByStudentId(int id)
        {
            return _context.StudentClasses.Where(sc => id == sc.StudentId).ToList();
        }
        public List<StudentClass> GetStudentClassesByClassId(int id)
        {
            return _context.StudentClasses.Where(sc => id == sc.ClassId).ToList();
        }
    }
}
