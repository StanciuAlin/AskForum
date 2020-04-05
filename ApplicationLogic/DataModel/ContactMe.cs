using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DataModel
{
    class ContactMe
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string MessageContent { get; set; }
        public DateTime Date { get; set; }
        public long IdContactRequest { get; set; }
    }
}
