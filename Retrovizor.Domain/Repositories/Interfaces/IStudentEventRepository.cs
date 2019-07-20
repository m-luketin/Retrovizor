using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IStudentEventRepository
    {
        List<StudentEvent> GetAllStudentEvents();
        bool AddStudentEvent(StudentEvent studentEventToAdd);
        bool DeleteStudentEvent(int idOfStudentEventToDelete);
        List<StudentEvent> GetStudentEventsByStudentId(int id);
        List<StudentEvent> GetStudentEventsByEventId(int id);
    }
}