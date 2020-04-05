using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DataModel
{
    class Admin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int IdAdmin { get; set; }
        public ICollection<User> IdUsers { get; set; }
        public ICollection<ContactMe> IdContactRequests { get; set; }
    }
}
