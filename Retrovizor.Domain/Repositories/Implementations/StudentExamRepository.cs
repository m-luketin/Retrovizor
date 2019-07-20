using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class StudentExamRepository : IStudentExamRepository
    {
        StudentExamRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public List<StudentExam> GetAllStudentExams()
        {
            return _context.StudentExams.ToList();
        }
        public bool AddStudentExam(StudentExam studentExamToAdd)
        {
            var doesStudentExamExist = _context.StudentExams.Any(studentExam =>
                studentExam.StudentId == studentExamToAdd.StudentId && studentExam.ExamId == studentExamToAdd.ExamId);

            if(doesStudentExamExist)
                return false;

            _context.StudentExams.Add(studentExamToAdd);
            _context.SaveChanges();
            return true;
        }
        public bool EditStudentExam(StudentExam editedStudentExam)
        {
            var doesStudentExamExist = _context.StudentExams.Any(studentExam =>
                studentExam.StudentId == editedStudentExam.StudentId && studentExam.ExamId == editedStudentExam.ExamId);

            if(doesStudentExamExist)
                return false;

            var studentExamToEdit = _context.StudentExams.Find(editedStudentExam.StudentId, editedStudentExam.ExamId);

            if(studentExamToEdit == null)
                return false;

            studentExamToEdit.Points = editedStudentExam.Points;

            _context.SaveChanges();
            return true;
        }
        public bool DeleteStudentExam(int idOfStudentExamToDelete)
        {
            var studentExamToDelete = _context.StudentExams.Find(idOfStudentExamToDelete);

            if(studentExamToDelete == null)
                return false;

            _context.Remove(studentExamToDelete);
            _context.SaveChanges();
            return true;
        }
        public List<StudentExam> GetStudentExamsByStudentId(int id)
        {
            return _context.StudentExams.Where(sc => id == sc.StudentId).ToList();
        }
        public List<StudentExam> GetStudentExamsByExamId(int id)
        {
            return _context.StudentExams.Where(sc => id == sc.ExamId).ToList();
        }
    }
}
