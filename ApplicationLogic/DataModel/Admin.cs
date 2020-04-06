using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.DataModel
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<User> IdUsers { get; set; }
        public ICollection<ContactMe> IdContactRequests { get; set; }
    }
}
