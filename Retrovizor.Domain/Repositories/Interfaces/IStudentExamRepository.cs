using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IStudentExamRepository
    {
        bool AddStudentExam(StudentExam studentExamToAdd);
        bool EditStudentExam(StudentExam editedStudentExam);
        bool DeleteStudentExam(int studentId, int examId);
        StudentExam GetStudentExam(int studentId, int examId);
    }
}