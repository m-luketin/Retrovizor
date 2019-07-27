using Retrovizor.Data.Entities;
using Retrovizor.Data.Entities.Models;
using Retrovizor.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            var doesStudentExist = _context.Students.Any(student =>
                string.Equals(student.OIB, studentToAdd.OIB, StringComparison.CurrentCultureIgnoreCase));

            if(doesStudentExist)
                return false;

            _context.Students.Add(studentToAdd);
            _context.SaveChanges();
            return true;
        }
        public bool EditStudent(Student editedStudent)
        {
            var studentToEdit = _context.Students.Find(editedStudent.Id);

            if(studentToEdit == null)
                return false;

            studentToEdit.FirstName = editedStudent.FirstName;
            studentToEdit.LastName = editedStudent.LastName;
            studentToEdit.Username = editedStudent.Username;
            studentToEdit.Password = editedStudent.Password;
            studentToEdit.OIB = editedStudent.OIB;
            studentToEdit.PhoneNumber = editedStudent.PhoneNumber;
            studentToEdit.Category = editedStudent.Category;

            _context.SaveChanges();
            return true;
        }
        public bool DeleteStudent(int idOfStudentToDelete)
        {
            var studentToDelete = _context.Students.Find(idOfStudentToDelete);

            if(studentToDelete == null)
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
            return _context.Students.Where(s => s.DrivingSchoolId == id).ToList();
        }
        public List<Student> GetStudentsByInstructorId(int id)
        {
            var vehicleSessions = _context.VehicleSessions.Where(vs => vs.InstructorId == id);

            var students = new List<Student>();

            foreach(var vehicleSession in vehicleSessions)
                students.Add(vehicleSession.Student);

            return students.Distinct().ToList();
        }
        public List<Student> GetCurrentStudentsByInstructorId(int id)
        {
            var instructorVehicleSessions = _context.VehicleSessions.Where(vs => vs.InstructorId == id);
            var students = new List<Student>();

            foreach(var instructorVehicleSession in instructorVehicleSessions)
                students.Add(instructorVehicleSession.Student);

            students =  students.Distinct().ToList();
            var instructorsStudents = new List<Student>();

            foreach(var student in students)
            {
                var studentVehicleSessions = _context.VehicleSessions.Where(vs => vs.StudentId == student.Id);
                if(studentVehicleSessions == null)
                   continue;

                var currentVehicleSession = studentVehicleSessions.First();

                foreach(var vehicleSession in studentVehicleSessions)
                    if(vehicleSession.DateAssigned - currentVehicleSession.DateAssigned < new TimeSpan(0))
                        currentVehicleSession = vehicleSession;
                
                if(currentVehicleSession.InstructorId == id)
                    instructorsStudents.Add(student);
            }

            return instructorsStudents;
        }
        public bool EditExamPoints(int studentId, int examId, int newPoints)
        {
            var studentExam = _context.StudentExams.Find(studentId, examId);

            studentExam.Points = newPoints;

            _context.SaveChanges();
            return true;
        }
        public bool EditCurrentLesson(int studentId, int classId, int newCurrentLesson)
        {
            var studentClass = _context.StudentClasses.Find(studentId, classId);

            studentClass.CurrentLesson = newCurrentLesson;

            _context.SaveChanges();
            return true;
        }

        public bool HasStudentPassedExam(int studentId, int examId)
        {
            var studentExams = _context.StudentExams.Where(se => se.StudentId == studentId && se.ExamId == examId);
            var examToPass = _context.Exams.Find(examId);

            foreach(var studentExam in studentExams)
                if(studentExam.Points >= examToPass.PointsToPass)
                    return true;

            return false;
        }
    }
}
