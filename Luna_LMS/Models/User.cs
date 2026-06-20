using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luna_LMS.Models
{
    internal class User
    {
    }
        public class Users
        {
            public int UserID { get; set; }

            public string Username { get; set; }

            public string Email { get; set; }

            public string PasswordHash { get; set; }

            public int RoleID { get; set; }

            public bool IsActive { get; set; }

            public DateTime CreatedAt { get; set; }
        }
    
}
