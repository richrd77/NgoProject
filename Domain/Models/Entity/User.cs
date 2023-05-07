using System;

namespace Domain.Models.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
        
        public string Mobile { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        public char Gender { get; set; }

        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}
