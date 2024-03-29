﻿using Retrovizor.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retrovizor.Domain.Repositories.Interfaces
{
    public interface IStudentEventRepository
    {
        bool AddStudentEvent(StudentEvent studentEventToAdd);
        bool DeleteStudentEvent(int studentId, int eventId);
    }
}