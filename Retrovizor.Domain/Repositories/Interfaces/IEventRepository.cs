﻿using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IEventRepository
    {
        bool AddEvent(Event eventToAdd);
        bool EditEvent(Event editedEvent);
        bool DeleteEvent(int idOfEventToDelete);
        Event GetEventById(int id);
        List<StudentEvent> GetEventsByStudentId(int id);
        List<Event> GetInstructorDrivingLessonsByInstructorId(int id);
        List<Event> GetEventsByDrivingSchoolId(int id);
    }
}
