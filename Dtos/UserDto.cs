using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dispatch_system.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateAdded { get; set; }
        public string Notes { get; set; }
        public string UserType { get; set; }
    }
}
