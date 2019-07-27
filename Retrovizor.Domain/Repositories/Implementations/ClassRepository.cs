using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class ClassRepository : IClassRepository
    {
        public ClassRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public List<Class> GetAllClasses()
        {
            return _context.Classes.ToList();
        }
                
        public bool AddClass(Class classToAdd)
        {
            var doesClassExist = _context.Classes.Any(c =>
                string.Equals(c.Name, classToAdd.Name, StringComparison.CurrentCultureIgnoreCase));

            if(doesClassExist)
                return false;

            _context.Classes.Add(classToAdd);
            _context.SaveChanges();
            return true;
        }
        public bool EditClass(Class editedClass)
        {
            var classToEdit = _context.Classes.Find(editedClass.Id);

            if(classToEdit == null)
                return false;

            classToEdit.Name = editedClass.Name;
            classToEdit.TotalLessons = editedClass.TotalLessons;
            classToEdit.Type = editedClass.Type;

            _context.SaveChanges();
            return true;
        }
        public bool DeleteClass(int idOfClassToDelete)
        {
            var classToDelete = _context.Classes.Find(idOfClassToDelete);

            if(classToDelete == null)
                return false;

            _context.Remove(classToDelete);
            _context.SaveChanges();
            return true;
        }
        public Class GetClassById(int id)
        {
            return _context.Classes.Find(id);
        }
        public List<Class> GetClassesByStudentId(int id)
        {
            var studentClasses = _context.StudentClasses.Where(c => c.StudentId == id);

            if(studentClasses == null)
                return null;

            var classesToGet = new List<Class>();

            foreach(var studentClass in studentClasses)
            {
                var tmpClass = _context.Classes.Find(studentClass.ClassId);

                if(tmpClass != null)
                    classesToGet.Add(tmpClass);
            }

            return classesToGet;
        }
    }
}
