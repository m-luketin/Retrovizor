using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System.Linq;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class StudentClassRepository : IStudentClassRepository
    {
        public StudentClassRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public bool AddStudentClass(StudentClass studentClassToAdd)
        {
            var doesExist = _context.StudentClasses.Any(sc => sc.StudentId == studentClassToAdd.StudentId && sc.ClassId == studentClassToAdd.ClassId);

            if(doesExist)
                return false;

            var student = _context.Students.Find(studentClassToAdd.StudentId);

            if(student == null)
                return false;

            var classToAssign = _context.Classes.Find(studentClassToAdd.ClassId);

            if(classToAssign == null)
                return false;

            _context.StudentClasses.Add(new StudentClass()
            {
                StudentId = student.Id,
                Student = student,
                ClassId = classToAssign.Id,
                Class = classToAssign,
                CurrentLesson = 1
            });
            _context.SaveChanges();
            return true;
        }

        public bool EditStudentClass(StudentClass editedStudentClass)
        {
            var studentClassToEdit = _context.StudentClasses.Find(editedStudentClass.StudentId, editedStudentClass.ClassId);
            if(studentClassToEdit == null)
                return false;

            studentClassToEdit.CurrentLesson = editedStudentClass.CurrentLesson;

            _context.SaveChanges();
            return true;
        }

        public bool DeleteStudentClass(int studentId, int classId)
        {
            var studentClass = _context.StudentClasses.Find(studentId, classId);
            if(studentClass == null)
                return false;

            _context.Remove(studentClass);
            _context.SaveChanges();
            return true;
        }
        
        public StudentClass GetStudentClass(int studentId, int classId)
        {
            return _context.StudentClasses.Find(studentId, classId);
        }
    }
}
