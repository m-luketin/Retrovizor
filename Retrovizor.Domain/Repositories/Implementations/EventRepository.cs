using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class EventRepository : IEventRepository
    {
        EventRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public List<Event> GetAllEvents()
        {
            return _context.Events.ToList();
        }
        public bool AddEvent(Event eventToAdd)
        {
            var doesEventExist = _context.Events.Any(e =>
                DateTime.Equals(e.Time, eventToAdd.Time) && e.LocationId == eventToAdd.LocationId);

            if(doesEventExist)
                return false;

            _context.Events.Add(eventToAdd);
            _context.SaveChanges();
            return true;
        }
        public bool EditEvent(Event editedEvent)
        {
            var doesEventExist = _context.Events.Any(e =>
                DateTime.Equals(e.Time, editedEvent.Time) && e.LocationId == editedEvent.LocationId);

            if(doesEventExist)
                return false;

            var eventToEdit = _context.Events.Find(editedEvent.Id);

            if(eventToEdit == null)
                return false;

            eventToEdit.Name = editedEvent.Name;
            eventToEdit.Type = editedEvent.Type;
            eventToEdit.Time = editedEvent.Time;

            _context.SaveChanges();
            return true;
        }
        public bool DeleteEvent(int idOfEventToDelete)
        {
            var eventToDelete = _context.Events.Find(idOfEventToDelete);

            if(eventToDelete == null)
                return false;

            _context.Remove(eventToDelete);
            _context.SaveChanges();
            return true;
        }
        public Event GetEventById(int id)
        {
            return _context.Events.Find(id);
        }
    }
}