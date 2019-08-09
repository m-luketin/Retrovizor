﻿using CashRegister.Data.Helpers;
using Microsoft.EntityFrameworkCore;
using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Data.Enums;
using Retrovizor.Domain.Classes;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Retrovizor.Domain.Repositories.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        public StudentRepository(RetrovizorContext context)
        {
            _context = context;
        }
        private readonly RetrovizorContext _context;

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public bool AddStudent(Student studentToAdd)
        {
            if (_context.Users.Any(u => u.Username == studentToAdd.User.Username
                || u.OIB == studentToAdd.User.OIB || u.PhoneNumber == studentToAdd.User.PhoneNumber)) return false;

            studentToAdd.User.DrivingSchool = _context.DrivingSchools.Find(studentToAdd.User.DrivingSchoolId);

            _context.Students.Add(studentToAdd);
            _context.SaveChanges();
            return true;
        }

        public bool EditStudent(Student editedStudent)
        {
            var studentToEdit = _context.Students.Find(editedStudent.Id);

            if (studentToEdit == null)
                return false;

            studentToEdit.FirstName = editedStudent.FirstName;
            studentToEdit.LastName = editedStudent.LastName;
            studentToEdit.User.Username = editedStudent.User.Username;
            studentToEdit.User.Password = editedStudent.User.Password;
            studentToEdit.User.OIB = editedStudent.User.OIB;
            studentToEdit.User.PhoneNumber = editedStudent.User.PhoneNumber;
            studentToEdit.Category = editedStudent.Category;

            _context.SaveChanges();
            return true;
        }

        public bool DeleteStudent(int idOfStudentToDelete)
        {
            var studentToDelete = _context.Students.Find(idOfStudentToDelete);

            if (studentToDelete == null)
                return false;

            _context.Remove(studentToDelete);
            _context.SaveChanges();
            return true;
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.Find(id);
        }

        public List<Student> GetStudentsByDrivingSchoolId(int id)
        {
            return _context.Students.Where(s => s.User.DrivingSchoolId == id).ToList();
        }

        public List<Student> GetStudentsByInstructorId(int id)
        {
            var vehicleSessions = _context.VehicleSessions.Where(vs => vs.InstructorId == id).ToList();

            if (vehicleSessions.Count == 0)
                return null;

            var students = new List<Student>();

            foreach (var vehicleSession in vehicleSessions)
                students.Add(vehicleSession.Student);

            return students.Distinct().ToList();
        }

        public List<Student> GetCurrentStudentsByInstructorId(int id)
        {
            var instructorVehicleSessions = _context.VehicleSessions
                .Include("Student")
                .Include("Student.StudentClasses")
                .Include("Student.User")
                .Include("Student.VehicleSessions.Vehicle")
                .Include("Student.StudentEvents")
                .Include("Student.StudentEvents.Event")
                .Include("Student.StudentExams")
                .Include("Student.StudentExams.Exam")
                .Where(vs => vs.InstructorId == id).ToList();

            if (instructorVehicleSessions.Count == 0)
                return null;

            var students = new List<Student>();

            foreach (var instructorVehicleSession in instructorVehicleSessions)
                students.Add(instructorVehicleSession.Student);

            students = students.Distinct().ToList();
            var instructorsStudents = new List<Student>();

            foreach (var student in students)
            {
                var studentVehicleSessions = _context.VehicleSessions.Where(vs => vs.StudentId == student.Id).ToList();
                if (studentVehicleSessions.Count == 0)
                    continue;

                var currentVehicleSession = studentVehicleSessions.First();

                foreach (var vehicleSession in studentVehicleSessions)
                    if (vehicleSession.DateAssigned - currentVehicleSession.DateAssigned < new TimeSpan(0))
                        currentVehicleSession = vehicleSession;

                if (currentVehicleSession.InstructorId == id)
                    instructorsStudents.Add(student);
            }
            return instructorsStudents;
        }
    }
}
