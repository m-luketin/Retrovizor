using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        bool AddStudent(Student studentToAdd);
        bool EditStudent(Student editedStudent);
        bool DeleteStudent(int idOfStudentToDelete);
        Student GetStudentById(int id);
        List<Student> GetStudentsByDrivingSchoolId(int id);
        List<Student> GetStudentsByInstructorId(int id);
        List<Student> GetCurrentStudentsByInstructorId(int id);
        bool EditCurrentLesson(int studentId, int classId, int newCurrentLesson);
        bool EditExamPoints(int studentId, int examId, int newPoints);
        bool HasStudentPassedExam(int studentId, int examId);
    }
}
