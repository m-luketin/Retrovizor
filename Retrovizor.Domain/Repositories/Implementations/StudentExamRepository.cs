using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System.Linq;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class StudentExamRepository : IStudentExamRepository
    {
        public StudentExamRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

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

        public bool DeleteStudentExam(int studentId, int examId)
        {
            var studentExam = _context.StudentExams.Find(studentId, examId);

            if(studentExam == null)
                return false;

            _context.Remove(studentExam);
            _context.SaveChanges();
            return true;
        }

        public bool EditStudentExam(StudentExam editedStudentExam)
        {
            var studentExamToEdit = _context.StudentExams.Find(editedStudentExam.StudentId, editedStudentExam.ExamId);
            if(studentExamToEdit == null)
                return false;

            studentExamToEdit.Points = editedStudentExam.Points;
            _context.SaveChanges();
            return true;
        }
        
        public StudentExam GetStudentExam(int studentId, int examId)
        {
            return _context.StudentExams.Find(studentId, examId);
        }
    }
}
