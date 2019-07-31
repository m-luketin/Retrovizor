using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System.Linq;

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

            var isStudentBusy = _context.StudentEvents.Any(se => se.StudentId == studentEventToAdd.StudentId && (
                                    (se.Event.StartsAt < studentEventToAdd.Event.StartsAt && se.Event.EndsAt > studentEventToAdd.Event.StartsAt) || 
                                    (se.Event.StartsAt < studentEventToAdd.Event.EndsAt && se.Event.EndsAt > studentEventToAdd.Event.EndsAt)));

            if(isStudentBusy)
                return false;

            _context.StudentEvents.Add(studentEventToAdd);
            _context.SaveChanges();
            return true;
        }
        
        public bool DeleteStudentEvent(int studentId, int eventId)
        {
            var studentEvent = _context.StudentEvents.Find(studentId, eventId);

            if(studentEvent == null)
                return false;

            _context.Remove(studentEvent);
            _context.SaveChanges();
            return true;
        }
    }
}
