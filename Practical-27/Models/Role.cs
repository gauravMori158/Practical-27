namespace Core_Practical_17.Models;

    public class Role
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public ICollection<User> Users { get; set; }
    }

