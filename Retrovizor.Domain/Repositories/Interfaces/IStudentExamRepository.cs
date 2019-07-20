using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IStudentExamRepository
    {
        List<StudentExam> GetAllStudentExams();
        bool AddStudentExam(StudentExam studentExamToAdd);
        bool EditStudentExam(StudentExam editedStudentExam);
        bool DeleteStudentExam(int idOfStudentExamToDelete);
        List<StudentExam> GetStudentExamsByStudentId(int id);
        List<StudentExam> GetStudentExamsByExamId(int id);
    }
}