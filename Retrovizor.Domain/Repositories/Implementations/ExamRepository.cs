using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class ExamRepository : IExamRepository
    {
        ExamRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public List<Exam> GetAllExams()
        {
            return _context.Exams.ToList();
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
            var doesExamExist = _context.Exams.Any(e => string.Equals(e.Type, editedExam.Type, StringComparison.CurrentCultureIgnoreCase));
        
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
    }
}