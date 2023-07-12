using Core_Practical_17.Interface;
using Core_Practical_17.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_Practical_17.Repository;

    public class UserRepo : IUserRepo
    {
        private readonly DbContextClass _context;
        public UserRepo(DbContextClass context)
        {
            _context = context;
        }

        public List<User> GetAlluser()
        {
           return _context.Users.Include(d=>d.Roles).ToList();
        }
    }

