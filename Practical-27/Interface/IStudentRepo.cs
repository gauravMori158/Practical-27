using Core_Practical_17.Models;

namespace Core_Practical_17.Interface;

    public interface IStudentRepo
    {
        List<Student> GetAll();

        void AddStudent(Student student);
        Student GetStudentById(int id);

        void Edit(Student student);
        void Delete(int id);


    }

