using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class ExamRepository : IExamRepository
    {
        public ExamRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public List<Exam> GetAllExamsByDrivingSchoolId(int id)
        {
            var students = _context.Students.Where(s => s.DrivingSchoolId == id).ToList();

            if(students == null)
                return null;

            var studentExams = new List<StudentExam>();

            foreach(var student in students)
                studentExams.AddRange(student.StudentExams);

            var exams = new List<Exam>();

            foreach(var studentExam in studentExams)
                exams.Add(studentExam.Exam);

            return exams.Distinct().ToList();

        }
        public bool AddExam(Exam examToAdd)
        {
            var doesExamExist = _context.Exams.Any(e => string.Equals(e.Type, examToAdd.Type, StringComparison.CurrentCultureIgnoreCase));

            if(doesExamExist)
                return false;

            _context.Exams.Add(examToAdd);
            _context.SaveChanges();
            return true;
        }

        public bool EditExam(Exam editedExam)
        {
            var doesExamExist = _context.Exams.Any(e => string.Equals(e.Type, editedExam.Type, StringComparison.CurrentCultureIgnoreCase) && editedExam.Id != e.Id);
        
            if(doesExamExist)
                return false;

            var examToEdit = _context.Exams.Find(editedExam.Id);

            if(examToEdit == null)
                return false;
            
            examToEdit.TotalPoints = editedExam.TotalPoints;
            examToEdit.Type = editedExam.Type;

            _context.SaveChanges();
            return true;
        }

        public bool DeleteExam(int idOfExamToDelete)
        {
            var examToDelete = _context.Exams.Find(idOfExamToDelete);

            if(examToDelete == null)
                return false;

            _context.Remove(examToDelete);
            _context.SaveChanges();
            return true;
        }

        public Exam GetExamById(int id)
        {
            return _context.Exams.Find(id);
        }

        public List<Exam> GetExamsByStudentId(int id)
        {
            var studentExams = _context.StudentExams.Where(se => se.StudentId == id).ToList();

            if(studentExams == null)
                return null;

            var exams = new List<Exam>();

            foreach(var studentExam in studentExams)
                if(studentExam.Exam != null)
                    exams.Add(studentExam.Exam);

            return exams;
        }
        
        public double GetExamPassRateByExamId(int id)
        {
            var exam = _context.Exams.Find(id);

            if(exam == null)
                return 0;

            var studentExams = _context.StudentExams.Where(se => se.ExamId == id).ToList();

            if(studentExams == null)
                return 0;

            var studentsPassed = 0.0;

            foreach(var studentExam in studentExams)
                if(studentExam.Points >= exam.PointsToPass)
                    studentsPassed++;

            return studentsPassed / studentExams.Count();
        }
    }
}