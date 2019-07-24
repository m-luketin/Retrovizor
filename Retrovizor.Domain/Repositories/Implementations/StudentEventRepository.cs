using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class StudentEventRepository : IStudentEventRepository
    {
        public StudentEventRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public bool AddStudentEvent(StudentEvent studentEventToAdd)
        {
            var doesStudentEventExist = _context.StudentEvents.Any(studentEvent =>
                studentEvent.StudentId == studentEventToAdd.StudentId && studentEvent.EventId == studentEventToAdd.EventId);

            if(doesStudentEventExist)
                return false;

            var isStudentBusy = _context.StudentEvents.Any(studentEvent =>
                            studentEvent.StudentId == studentEventToAdd.StudentId && studentEvent.Event.Time == studentEventToAdd.Event.Time);

            if(isStudentBusy)
                return false;

            _context.StudentEvents.Add(studentEventToAdd);
            _context.SaveChanges();
            return true;
        }
        
        public bool DeleteStudentEvent(int idOfStudentEventToDelete)
        {
            var studentEventToDelete = _context.StudentEvents.Find(idOfStudentEventToDelete);

            if(studentEventToDelete == null)
                return false;

            _context.Remove(studentEventToDelete);
            _context.SaveChanges();
            return true;
        }
        public List<StudentEvent> GetStudentEventsByStudentId(int id)
        {
            return _context.StudentEvents.Where(sc => id == sc.StudentId).ToList();
        }
        public List<StudentEvent> GetStudentEventsByEventId(int id)
        {
            return _context.StudentEvents.Where(sc => id == sc.EventId).ToList();
        }
    }
}
