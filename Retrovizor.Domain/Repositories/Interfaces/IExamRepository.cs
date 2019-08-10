using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IExamRepository
    {
        List<Exam> GetAllExamsByDrivingSchoolId(int id);
        bool AddExam(Exam examToAdd);
        bool EditExam(Exam editedExam);
        bool DeleteExam(int idOfExamToDelete);
        Exam GetExamById(int id);
        List<StudentExam> GetExamsByStudentId(int id);
        double GetExamPassRateByExamId(int id);
    }
}
