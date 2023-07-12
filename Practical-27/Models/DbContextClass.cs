using Microsoft.EntityFrameworkCore;

namespace Core_Practical_17.Models;

    public class DbContextClass :DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> option): base(option)
        {
           
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<Role> Roles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student() { StudentName = "Mori", StudentId = 1, StandardId = 10, Age = 21 }
            );

            modelBuilder.Entity<User>().HasData(
               new User() {  Id=1,FirstName="Gaurav",LastName="Mori",EmailAddress="gaurav@gmail.com",Password="Mori@123",Mobile="9090909090",RoleId=1}
           );


            modelBuilder.Entity<Role>().HasData(
               new Role() { RoleId=1,RoleName="Admin"  }
           );
        }

    }

