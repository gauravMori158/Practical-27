using System.ComponentModel.DataAnnotations;

namespace Core_Practical_17.Models;

    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }

        [Required]
        public int StandardId { get; set; }
        public int Age { get; set; }


    }

