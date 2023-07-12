using Core_Practical_17.Interface;
using Core_Practical_17.Models;

namespace Core_Practical_17.Repository;

    public class StudentRepo : IStudentRepo
    {
        private readonly DbContextClass _context;

        public StudentRepo(DbContextClass context)
        {
            _context = context;
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

        }
        
         public  Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(x=>x.StudentId ==id);
        }

        public void Edit(Student student)
        {
            var std = _context.Students.FirstOrDefault(x => x.StudentId == student.StudentId);

            std.StudentName = student.StudentName;
            std.StandardId = student.StandardId;
            std.Age = student.Age;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var std = _context.Students.FirstOrDefault(x=>x.StudentId==id);
            _context.Students.Remove(std);
            _context.SaveChanges();
        }

    }

